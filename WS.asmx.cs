using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Collections;
using System.Data;

namespace HLBBWS
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    [Serializable()]
    public class WS : System.Web.Services.WebService
    {
        public class ResponseData
        {
            public String Status;
            public String ErrorCode;
            public String ErrorMessage;
            public List<Results> DataList;
        }

        public class Results
        {
            public String RecNo;
            public String CIF;
            public String CustName;
        }

        [WebMethod]
        public ResponseData CifInquiry(string strCustomerID)
        {
            ResponseData response = new ResponseData();
            response.Status = "-1";
            response.ErrorCode = "";
            response.ErrorMessage = "";

            DateTime dateBiz = DateTime.Now;
            //string strTranUserID = "";      //MCIMBASE
            string strTellerID = "MKLM01";
            string strBranchCode = "001";
            string strCtrlUnit = "61";

            string strXml = clsGetXml.GET_EAI_100000_XML(DateTime.Now, strTellerID, strBranchCode, strCtrlUnit, strCustomerID);

            EAIWebService.XmlHolder objXmlHolder = new EAIWebService.XmlHolder();
            objXmlHolder.content = strXml;
            objXmlHolder.securedContent = false;
            objXmlHolder.user = "user_eiws";
            //objXmlHolder.OID = null;
            objXmlHolder.password = "19e6492df3a767815d5eeddf5327004d7e8b5a9bfd0a996f7f60c9e5dc7e16dd";
            objXmlHolder.securedPassword = false;

            //Specify the binding to be used for the client.
            System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding();
            EAIWebService.EAIDelegateBeanClient client = new EAIWebService.EAIDelegateBeanClient("EAIDelegateBean", "http://10.3.14.188:9083/HLBWS/services/EAIDelegateBean");        //UAT
            client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, 10);
            EAIWebService.XmlHolder result = client.serviceRequest("mq_rbs", objXmlHolder);

            if (!String.IsNullOrEmpty(result.content))
            {
                XmlNodeList xmlList;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(result.content);

                //Display all the book titles.
                xmlList = xmlDoc.GetElementsByTagName("ErrorCode");
                if (xmlList.Count > 0)
                {
                    response.ErrorCode = xmlList.Item(0).InnerText;
                    response.ErrorMessage = xmlDoc.GetElementsByTagName("ErrorMsg").Item(0).InnerText;
                    response.Status = "0";
                    return response;
                }
                else
                {
                    xmlList = xmlDoc.GetElementsByTagName("CustomerNumber");   //CIF No.
                    List<Results> results = new List<Results>();

                    if (xmlList.Count > 1)
                    {
                        for (int i = 0; i < xmlList.Count; i++)
                        {
                            results.Add(new Results() { RecNo = i.ToString(), CIF = xmlList[i].InnerXml, CustName = "" });
                        }
                        response.DataList = results;

                        response.Status = "1";
                        return response;
                    }
                    else if (xmlList.Count == 1)
                    {
                        return CifDetailsInquiry(xmlList[0].InnerXml);      //direct get the cif details
                    }
                    else
                    {
                        response.Status = "0";
                        response.ErrorCode = "999";
                        response.ErrorMessage = "No record found";
                        return response;
                    }
                }
            }
            else
            {
                response.Status = "0";
                return response;
            }
        }

        [WebMethod]
        public ResponseData CifDetailsInquiry(string CifNum)
        {
            ResponseData response = new ResponseData();
            response.Status = "-1";
            response.ErrorCode = "";
            response.ErrorMessage = "";

            DateTime dateBiz = DateTime.Now;
            //string strTranUserID = "";  //MCIMBASE
            string strTellerID = "42115";
            string strBranchCode = "401";
            string strCtrlUnit = "6H";

            string strXml = clsGetXml.GET_EAI_100001_XML(DateTime.Now, strTellerID, strBranchCode, strCtrlUnit, CifNum);

            /*
                <Msg>
                  <Header>
                    <SC_TransType>100001</SC_TransType>
                    <SC_ApplName>MCI</SC_ApplName>
                    <SC_ApplID>MCI</SC_ApplID>
                    <SC_ApplTransID>7</SC_ApplTransID>
                    <SC_TransDate>161117</SC_TransDate>
                    <SC_TransTime>112122</SC_TransTime>
                    <SC_TransUserID>CSSTPMBASE</SC_TransUserID>
                    <SC_TransUserInfo></SC_TransUserInfo>
                    <SC_ApplUserID>B48743</SC_ApplUserID>
                    <SC_TellerID>MKLM02</SC_TellerID>
                    <SC_BranchCode>001</SC_BranchCode>
                    <SC_CtrlUnit>61</SC_CtrlUnit>
                  </Header>
                  <Body>
                    <CIFDetail>
                      <Request>
                        <CIFNum>31877145</CIFNum>
                      </Request>
                    </CIFDetail>
                  </Body>
                </Msg>
            */

            EAIWebService.XmlHolder objXmlHolder = new EAIWebService.XmlHolder();
            objXmlHolder.content = strXml;
            objXmlHolder.securedContent = false;
            objXmlHolder.user = "user_eiws";
            //objXmlHolder.OID = null;
            objXmlHolder.password = "19e6492df3a767815d5eeddf5327004d7e8b5a9bfd0a996f7f60c9e5dc7e16dd";
            objXmlHolder.securedPassword = false;

            //Specify the binding to be used for the client.
            System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding();
            EAIWebService.EAIDelegateBeanClient client = new EAIWebService.EAIDelegateBeanClient("EAIDelegateBean", "http://10.3.14.188:9083/HLBWS/services/EAIDelegateBean");        //UAT
            client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, 10);
            EAIWebService.XmlHolder result = client.serviceRequest("mq_rbs", objXmlHolder);

            if (!String.IsNullOrEmpty(result.content))
            {
                XmlNodeList xmlList;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(result.content);

                //Display all the book titles.
                xmlList = xmlDoc.GetElementsByTagName("ErrorCode");
                if (xmlList.Count > 0)
                {
                    response.ErrorCode = xmlList.Item(0).InnerText;
                    response.ErrorMessage = xmlDoc.GetElementsByTagName("ErrorMsg").Item(0).InnerText;
                    response.Status = "0";
                    return response;
                }
                else
                {
                    xmlList = xmlDoc.GetElementsByTagName("CustomerName1");   //Customer Name / Company Name
                    List<Results> results = new List<Results>();

                    for (int i = 0; i < xmlList.Count; i++)
                    {
                        results.Add(new Results() { RecNo = i.ToString(), CIF = CifNum, CustName = xmlList[i].InnerXml });
                    }
                    response.DataList = results;

                    response.Status = "1";
                    return response;
                }
            }
            else
            {
                response.Status = "0";
                return response;
            }
        }

        [WebMethod]
        public string DocInquiry(string strBranchCode)
        {
            DateTime dateStart = DateTime.Now;
            DateTime dateEnd = DateTime.Now;

            //int intFound = 0;
            string strErrCode = "";
            string strErrMsg = "";

            //Specify the binding to be used for the client.
            System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding();

            //Specify the address to be used for the client.
            //System.ServiceModel.EndpointAddress address = new System.ServiceModel.EndpointAddress(txtNewEndPoint.Text);
            //EDMS_WSSDK.WSSDKSoapClient client = new EDMS_WSSDK.WSSDKSoapClient(binding, address);

            List<string> listFields = new List<string>();
            List<string> listValues = new List<string>();

            //if (this.txtBranchCode.Text.Trim() != "")
            //{
                listFields.Add("Branch Code");
                listValues.Add(strBranchCode);
            //}
            //if (this.txtAccNo.Text.Trim() != "")
            //{
            //    listFields.Add("Account No");
            //    listValues.Add(this.txtAccNo.Text);
            //}
            //if (this.txtDocType.Text.Trim() != "")
            //{
            //    listFields.Add("Doc Type");
            //    listValues.Add(this.txtDocType.Text);
            //}


            EDMS_WSSDK.WSSDKSoapClient client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", "https://edms-sit1.hlbank.my:8081/LOAD_WSSDK/WSSDK.asmx?wsdl");        //SIT
            EDMS_WSSDK.DataProfileResult1[] result = client.ProfileSearch("DITB-InBranch", listFields.ToArray(), listValues.ToArray(), "INBRANCH", ref strErrCode, ref strErrMsg);

            //EDMS_WSSDK.WSSDKSoapClient client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", "https://edms-uat1.hlbank.my:8081/LOAD_WSSDK/WSSDK.asmx?wsdl");        //UAT
            //EDMS_WSSDK.DataProfileResult1[] result = client.ProfileSearch("DITB-InBranch", listFields.ToArray(), listValues.ToArray(), "INBRANCH", ref strErrCode, ref strErrMsg);

            return result.Count().ToString();

        }
    }
}