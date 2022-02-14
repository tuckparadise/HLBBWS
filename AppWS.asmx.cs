using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.DirectoryServices;
//using SourceCode.Hosting.Client;
//using SourceCode.Workflow.Client;
//using LOADS_API;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using Aspose.Pdf;
using System.Xml.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Diagnostics;
using System.Web.Script.Serialization;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net.Security;
using System.Collections;

namespace HLBBWS
{
    /// <summary>
    /// Summary description for AppWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class AppWS : System.Web.Services.WebService
    {
        [System.Runtime.Serialization.DataContract]
        public class Workflows
        {
            [DataMember(Name = "itemCount")]
            public long ItemCount
            {
                get;
                set;
            }

            [DataMember(Name = "workflows")]
            public List<Workflow> K2Workflows
            {
                get;
                set;
            }
        }

        [System.Runtime.Serialization.DataContract]
        public partial class Workflow
        {
            [DataMember(Name = "id")]
            public int Id
            {
                get;
                set;
            }

            [DataMember(Name = "defaultVersionId")]
            public int DefaultVersionId
            {
                get;
                set;
            }

            [DataMember(Name = "name")]
            public string Name
            {
                get;
                set;
            }

            [DataMember(Name = "folder")]
            public string Folder
            {
                get;
                set;
            }

            [DataMember(Name = "systemName")]
            public string SystemName
            {
                get;
                set;
            }

        }

        [DataContract]
        public class WorkflowInstanceXmlField
        {
            [DataMember(Name = "name")]
            public string Name
            {
                get;
                set;
            }

            [DataMember(Name = "value")]
            public string Value
            {
                get;
                set;
            }
        }

        [DataContract]
        public class ActivityDataFields { }

        [System.Runtime.Serialization.DataContract]
        public class Tasks
        {
            [DataMember(Name = "itemCount")]
            public long ItemCount
            {
                get;
                set;
            }

            [DataMember(Name = "tasks")]
            public List<K2Task> K2Tasks
            {
                get;
                set;
            }
        }

        [DataContract]
        public class K2Task
        {
            [DataMember(Name = "actions")]
            public Actions Actions
            {
                get;
                set;
            }

            [DataMember(Name = "activityDataFields")]
            public ActivityDataFields ActivityDataFields
            {
                get;
                set;
            }

            [DataMember(Name = "activityInstanceDestinationID")]
            public long ActivityInstanceDestinationID
            {
                get;
                set;
            }

            [DataMember(Name = "activityInstanceID")]
            public long ActivityInstanceID
            {
                get;
                set;
            }

            [DataMember(Name = "activityName")]
            public string ActivityName
            {
                get;
                set;
            }

            [DataMember(Name = "eventDescription")]
            public string EventDescription
            {
                get;
                set;
            }

            [DataMember(Name = "eventName")]
            public string EventName
            {
                get;
                set;
            }

            [DataMember(Name = "formURL")]
            public string FormURL
            {
                get;
                set;
            }

            [DataMember(Name = "instruction")]
            public string Instruction
            {
                get;
                set;
            }

            [DataMember(Name = "itemReferences")]
            public ActivityDataFields ItemReferences
            {
                get;
                set;
            }

            [DataMember(Name = "itemReferencesString")]
            public string ItemReferencesString
            {
                get;
                set;
            }

            [DataMember(Name = "originator")]
            public Originator Originator
            {
                get;
                set;
            }

            [DataMember(Name = "priority")]
            public long Priority
            {
                get;
                set;
            }

            [DataMember(Name = "serialNumber")]
            public string SerialNumber
            {
                get;
                set;
            }

            [DataMember(Name = "sleepUntil")]
            public string SleepUntil
            {
                get;
                set;
            }

            [DataMember(Name = "status")]
            public string Status
            {
                get;
                set;
            }

            [DataMember(Name = "taskStartDate")]
            public string TaskStartDate
            {
                get;
                set;
            }

            [DataMember(Name = "viewFlowURL")]
            public string ViewFlowURL
            {
                get;
                set;
            }

            [DataMember(Name = "workflowCategory")]
            public string WorkflowCategory
            {
                get;
                set;
            }

            [DataMember(Name = "workflowDisplayName")]
            public string WorkflowDisplayName
            {
                get;
                set;
            }

            [DataMember(Name = "workflowID")]
            public long WorkflowID
            {
                get;
                set;
            }

            [DataMember(Name = "workflowInstanceDataFields")]
            public ActivityDataFields WorkflowInstanceDataFields
            {
                get;
                set;
            }

            [DataMember(Name = "workflowInstanceDataFieldsString")]
            public string WorkflowInstanceDataFieldsString
            {
                get;
                set;
            }

            [DataMember(Name = "workflowInstanceFolio")]
            public string WorkflowInstanceFolio
            {
                get;
                set;
            }

            [DataMember(Name = "workflowInstanceID")]
            public long WorkflowInstanceID
            {
                get;
                set;
            }

            [DataMember(Name = "workflowInstanceXmlFields")]
            public WorkflowInstanceXmlField[] WorkflowInstanceXmlFields
            {
                get;
                set;
            }

            [DataMember(Name = "workflowName")]
            public string WorkflowName
            {
                get;
                set;
            }
        }

        public class Actions
        {
            [DataMember(Name = "nonBatchableActions")]
            public List<object> NonBatchableActions
            {
                get;
                set;
            }

            [DataMember(Name = "batchableActions")]
            public List<string> BatchableActions
            {
                get;
                set;
            }

            [DataMember(Name = "systemActions")]
            public List<string> SystemActions
            {
                get;
                set;
            }
        }

        [DataContract]
        public class Originator
        {
            [DataMember(Name = "email")]
            public string Email
            {
                get;
                set;
            }

            [DataMember(Name = "manager")]
            public string Manager
            {
                get;
                set;
            }

            [DataMember(Name = "displayName")]
            public string DisplayName
            {
                get;
                set;
            }

            [DataMember(Name = "fqn")]
            public string Fqn
            {
                get;
                set;
            }

            [DataMember(Name = "username")]
            public string Username
            {
                get;
                set;
            }


        }
        public enum EnumResponseType
        {
            ExportFile,
            SearchFile,
            DownloadFile,
            DeleteFile,
            CifDetailsInquiryByIDNo,
            CifDetailsInquiryByCIFNum,
            TradeTxnInquiry,
            LdapAuthentication,
            LdapSearchUser
        }

        public class LdapAuthenticationResponseData
        {
            public String Status;
            public String ErrorCode;
            public String ErrorMessage;

            public String AccountName;
            public String DisplayName;
            public String Department;
            public String Mail;
        }

        public class LdapSearchUserResponseData
        {
            public String Status;
            public String ErrorCode;
            public String ErrorMessage;

            public String AccountName;
            public String DisplayName;
            public String Department;
            public String Mail;
        }

        public class ExportFileResponseData
        {
            public String Status { get; set; }
            public String ErrorCode { get; set; }
            public String ErrorMessage { get; set; }

            public ExportFileResponseData() { Status = "-1"; ErrorCode = ""; ErrorMessage = ""; }
            public ExportFileResponseData(String strStatus, String strErrorCode, String strErrorMessage) { Status = strStatus; ErrorCode = strErrorCode; ErrorMessage = strErrorCode; }
        }

        public class DownloadFileResponseData
        {
            public String Status { get; set; }
            public String ErrorCode { get; set; }
            public String ErrorMessage { get; set; }
            public String FileUrl { get; set; }

            public DownloadFileResponseData() { Status = "-1"; ErrorCode = ""; ErrorMessage = ""; FileUrl = ""; }
            public DownloadFileResponseData(String strStatus, String strErrorCode, String strErrorMessage, String strFileUrl) { Status = strStatus; ErrorCode = strErrorCode; ErrorMessage = strErrorCode; FileUrl = strFileUrl; }
        }

        public class SearchFileResponseData
        {
            public String Status { get; set; }
            public String ErrorCode { get; set; }
            public String ErrorMessage { get; set; }
            public List<SearchFileResults> FileList;

            public SearchFileResponseData() { Status = "-1"; ErrorCode = ""; ErrorMessage = ""; }
            public SearchFileResponseData(String strStatus, String strErrorCode, String strErrorMessage, List<SearchFileResults> listResult) { Status = strStatus; ErrorCode = strErrorCode; ErrorMessage = strErrorCode; FileList = listResult; }
        }
        public class SearchFileResults
        {
            public String VerID;
            public String ProfileID;
            public String DocID;
            public String ImageName;
            public String FileSize;
            public String Datecreated;

            public String Field1;
            public String Field2;
            public String Field3;
            public String Field4;
            public String Field5;
            public String Field6;
            public String Field7;
            public String Field8;
            public String Field9;
            public String Field10;

            public String BatchNo;
            public String BatchDesc;
        }
        public class SearchFileRequest
        {
            public String ColumnName;
            public String ColumnKeyword;
        }

        public class DeleteFileResponseData
        {
            public String Status { get; set; }
            public String ErrorCode { get; set; }
            public String ErrorMessage { get; set; }
        }

        public class SearchCifResponseData
        {
            public String Status;
            public String ErrorCode;
            public String ErrorMessage;
            public String ReasonCode;

            public String CustName;
            public String CifNum;
            public String IDNum;
        }
        public class SearchTradeTxnResponseData
        {
            public String Status;
            public String ErrorCode;
            public String ErrorMessage;
            public String ReasonCode;

            public String OwnerCIFNo;
            public String OwnerShortName;
            public String ProductType;
            public String BillAmt;
            public String BankRefNo;
        }

        public string GetValueByPropertiesName(SearchResult adsSearchResult, string PropertiesName)
        {
            string strResult = "";
            if (adsSearchResult.Properties.Contains(PropertiesName))
            {
                strResult = adsSearchResult.Properties[PropertiesName][0].ToString();
            }
            return strResult;
        }
        
        [WebMethod]
        public string getIP(string callback)
        {            
            string clientIPAddress = "";

            System.Web.HttpContext context = System.Web.HttpContext.Current;
            
            string IP = context.Request.UserHostName;
        
            clientIPAddress = IP;

            StringBuilder sb = new StringBuilder();
            JavaScriptSerializer js = new JavaScriptSerializer();
            sb.Append(callback + "(");
            sb.Append(js.Serialize(clientIPAddress));
            sb.Append(");");

            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(sb.ToString());
            //Context.Response.End();

            Context.Response.Flush(); // Sends all currently buffered output to the client.
            Context.Response.SuppressContent = true;  // Gets or sets a value indicating whether to send HTTP content to the client.
            Context.ApplicationInstance.CompleteRequest(); // Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.

            return clientIPAddress;
        }
       

        [WebMethod]
        public LdapAuthenticationResponseData LdapAuthentication(string DomainName, string UserName, string Password)
        {
            LdapAuthenticationResponseData response = new LdapAuthenticationResponseData();
            response.Status = "-1";
            response.ErrorCode = "";
            response.ErrorMessage = "";
            response.AccountName = "";
            response.DisplayName = "";
            response.Department = "";
            response.Mail = "";

            try
            {
                string path = "LDAP://" + DomainName.Trim();
                string strLoginAccountId = DomainName.Trim() + @"\" + UserName.Trim();
                string strFindAccountId = UserName.Trim();
                string strPassword = Password.Trim();

                using (DirectoryEntry adsEntry = new DirectoryEntry(path, strLoginAccountId, strPassword))
                {
                    using (DirectorySearcher adsSearcher = new DirectorySearcher(adsEntry))
                    {
                        //adsSearcher.Filter = "(sAMAccountName=" + strFindAccountId + ")";
                        adsSearcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + strFindAccountId + "))";

                        SearchResult adsSearchResult = adsSearcher.FindOne();
                        //this.txtResult.Text = adsSearchResult.Path.ToString();
                        clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + adsSearchResult.Path.ToString());

                        response.AccountName = GetValueByPropertiesName(adsSearchResult, "samaccountname");
                        response.DisplayName = GetValueByPropertiesName(adsSearchResult, "displayname");
                        response.Department = GetValueByPropertiesName(adsSearchResult, "department");
                        response.Mail = GetValueByPropertiesName(adsSearchResult, "mail");

                        //response.AccountName = adsSearchResult.Properties["samaccountname"][0].ToString();
                        //response.DisplayName = adsSearchResult.Properties["displayname"][0].ToString();
                        //response.Department = adsSearchResult.Properties["department"][0].ToString();
                        //response.Mail = adsSearchResult.Properties["mail"][0].ToString();

                        response.Status = "1";
                        response.ErrorCode = "";
                        response.ErrorMessage = "";

                        adsEntry.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                response.Status = "-1";
                response.ErrorCode = "1";
                response.ErrorMessage = "Unexpected Error: " + ex.Message;
                clsLog.WriteSystemLog(clsLog.MessageType.Error, "LdapAuthentication()", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {

            }

            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", ConvertResponseToXmlText(EnumResponseType.LdapAuthentication, "UserName=" + DomainName + @"\" + UserName, response));
            return response;
        }

        [WebMethod]
        public void DP_LdapAuthentication(string DomainName, string UserName, string Password, ref string str_error, ref string str_Status, ref string str_ErrorCode, ref string str_ErrorMessage, ref string str_AccountName, ref string str_DisplayName, ref string str_Department, ref string str_Mail)
        {
            str_error = "";
            str_Status = "";
            str_ErrorCode = "";
            str_ErrorMessage = "";
            str_AccountName = "";
            str_DisplayName = "";
            str_Department = "";
            str_Mail = "";

            LdapAuthenticationResponseData response = new LdapAuthenticationResponseData();
            response.Status = "-1";
            response.ErrorCode = "";
            response.ErrorMessage = "";
            response.AccountName = "";
            response.DisplayName = "";
            response.Department = "";
            response.Mail = "";

            try
            {
                string path = "LDAP://" + DomainName.Trim();
                string strLoginAccountId = DomainName.Trim() + @"\" + UserName.Trim();
                string strFindAccountId = UserName.Trim();
                string strPassword = Password.Trim();

                //using (DirectoryEntry adsEntry = new DirectoryEntry(path, strLoginAccountId, strPassword))
                using (DirectoryEntry adsEntry = new DirectoryEntry())
                {
                    using (DirectorySearcher adsSearcher = new DirectorySearcher(adsEntry))
                    {
                        //adsSearcher.Filter = "(sAMAccountName=" + strFindAccountId + ")";
                        adsSearcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + strFindAccountId + "))";

                        SearchResult adsSearchResult = adsSearcher.FindOne();
                        //this.txtResult.Text = adsSearchResult.Path.ToString();
                        clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + adsSearchResult.Path.ToString());

                        response.AccountName = GetValueByPropertiesName(adsSearchResult, "samaccountname");
                        response.DisplayName = GetValueByPropertiesName(adsSearchResult, "displayname");
                        response.Department = GetValueByPropertiesName(adsSearchResult, "department");
                        response.Mail = GetValueByPropertiesName(adsSearchResult, "mail");

                        //response.AccountName = adsSearchResult.Properties["samaccountname"][0].ToString();
                        //response.DisplayName = adsSearchResult.Properties["displayname"][0].ToString();
                        //response.Department = adsSearchResult.Properties["department"][0].ToString();
                        //response.Mail = adsSearchResult.Properties["mail"][0].ToString();

                        response.Status = "1";
                        response.ErrorCode = "";
                        response.ErrorMessage = "";

                        adsEntry.Close();
                    }
                }

                if (response.Status== "1")
                {
                    str_error = "";
                    str_Status = response.Status;
                    str_ErrorCode = response.ErrorCode;
                    str_ErrorMessage = response.ErrorMessage;
                    str_AccountName = response.AccountName;
                    str_DisplayName = response.DisplayName;
                    str_Department = response.Department;
                    str_Mail = response.Mail;

                }
                else
                {
                    str_error = "1";
                }

            }
            catch (Exception ex)
            {
                str_error = "1";
            }           
        }


        [WebMethod]
        public LdapSearchUserResponseData LdapSearchUser(string DomainName, string UserName)
        {
            LdapSearchUserResponseData response = new LdapSearchUserResponseData();
            response.Status = "-1";
            response.ErrorCode = "";
            response.ErrorMessage = "";
            response.AccountName = "";
            response.DisplayName = "";
            response.Department = "";
            response.Mail = "";

            try
            {
                string path = "LDAP://" + DomainName.Trim();
                //string strLoginAccountId = DomainName.Trim() + @"\" + UserName.Trim();
                string strFindAccountId = UserName.Trim();
                //string strPassword = Password.Trim();

                using (DirectoryEntry adsEntry = new DirectoryEntry(path))
                {
                    using (DirectorySearcher adsSearcher = new DirectorySearcher(adsEntry))
                    {
                        adsSearcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + strFindAccountId + "))";

                        SearchResult adsSearchResult = adsSearcher.FindOne();
                        if (adsSearchResult != null)
                        {
                            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + adsSearchResult.Path.ToString());

                            response.AccountName = GetValueByPropertiesName(adsSearchResult, "samaccountname");
                            response.DisplayName = GetValueByPropertiesName(adsSearchResult, "displayname");
                            response.Department = GetValueByPropertiesName(adsSearchResult, "department");
                            response.Mail = GetValueByPropertiesName(adsSearchResult, "mail");

                            response.Status = "1";
                            response.ErrorCode = "";
                            response.ErrorMessage = "";

                        }
                        else
                        {
                            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=Account not found in domain server");

                            response.Status = "0";
                            response.ErrorCode = "";
                            response.ErrorMessage = "Account not found in domain server";
                        }
                    }
                    adsEntry.Close();
                }
            }
            catch (Exception ex)
            {
                response.Status = "-1";
                response.ErrorCode = "1";
                response.ErrorMessage = "Unexpected Error: " + ex.Message;
                clsLog.WriteSystemLog(clsLog.MessageType.Error, "LdapSearchUser()", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {

            }

            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", ConvertResponseToXmlText(EnumResponseType.LdapSearchUser, "UserName=" + DomainName + @"\" + UserName, response));
            return response;
        }

        [WebMethod]
        public void DP_LdapSearchUser(string DomainName, string UserName, ref string str_error, ref string str_Status, ref string str_ErrorCode, ref string str_ErrorMessage, ref string str_AccountName, ref string str_DisplayName, ref string str_Department, ref string str_Mail)
        {

            str_error = "";
            str_Status = "";
            str_ErrorCode = "";
            str_ErrorMessage = "";
            str_AccountName = "";
            str_DisplayName = "";
            str_Department = "";
            str_Mail = "";

            LdapSearchUserResponseData response = new LdapSearchUserResponseData();
            response.Status = "-1";
            response.ErrorCode = "";
            response.ErrorMessage = "";
            response.AccountName = "";
            response.DisplayName = "";
            response.Department = "";
            response.Mail = "";

            try
            {
                string path = "LDAP://" + DomainName.Trim();
                //string strLoginAccountId = DomainName.Trim() + @"\" + UserName.Trim();
                string strFindAccountId = UserName.Trim();
                //string strPassword = Password.Trim();

                using (DirectoryEntry adsEntry = new DirectoryEntry(path))
                {
                    using (DirectorySearcher adsSearcher = new DirectorySearcher(adsEntry))
                    {
                        adsSearcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + strFindAccountId + "))";

                        SearchResult adsSearchResult = adsSearcher.FindOne();
                        if (adsSearchResult != null)
                        {

                            //var IsClosed = 0;

                            DataSet ds = null;
                            DataTable dt = null;
                            SqlConnection conn = null;
                            SqlDataAdapter sqlDA = null;

                            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                            string strDBName = clsGlobal.MG_SQL_DB_NAME;
                            string strID = clsGlobal.MG_SQL_ID;
                            string strPassword = clsGlobal.MG_SQL_PASSWORD;
                            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                            if (blnIsWinAuth)
                            {
                                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                            }
                            
                            var DBUserName = DomainName + "\\" + UserName;

                            SqlConnection conny = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                            //sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_InternalUser_CheckClosed] @arn, @error output", conny);
                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_InternalUser_CheckClosed] @username", conny);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@username", DBUserName);
                            //sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsy = new DataSet("ds");
                            DataTable dty = null;

                            sqlDAy.Fill(dsy);
                            dty = dsy.Tables[0];
                            var IsClosed = dty.Rows[0]["result"].ToString();

                            if (IsClosed == "0")
                            {
                                clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + adsSearchResult.Path.ToString());

                                response.AccountName = GetValueByPropertiesName(adsSearchResult, "samaccountname");
                                response.DisplayName = GetValueByPropertiesName(adsSearchResult, "displayname");
                                response.Department = GetValueByPropertiesName(adsSearchResult, "department");
                                response.Mail = GetValueByPropertiesName(adsSearchResult, "mail");

                                response.Status = "1";
                                response.ErrorCode = "";
                                response.ErrorMessage = "";
                            }
                            else
                            {
                                str_error = "Closed User";
                            }

                            

                        }                       
                    }
                    adsEntry.Close();
                }

                if (response.Status == "1")
                {
                    str_error = "";
                    str_Status = response.Status;
                    str_ErrorCode = response.ErrorCode;
                    str_ErrorMessage = response.ErrorMessage;
                    str_AccountName = DomainName.Trim() + "\\" +response.AccountName;
                    str_DisplayName = response.DisplayName;
                    str_Department = response.Department;
                    str_Mail = response.Mail;

                }
                else
                {
                    str_error = "1";
                }
            }
            catch (Exception ex)
            {
                str_error = "1";
            }            
            
        }


        [WebMethod]
        public SearchFileResponseData SearchFileFromEDMS(string ProfileName, string RefNo, List<SearchFileRequest> SearchFile)
        {
            SearchFileResponseData response = new SearchFileResponseData();

            System.ServiceModel.BasicHttpBinding binding = null;
            EDMS_WSSDK.WSSDKSoapClient client = null;

            List<SearchFileResults> fl = new List<SearchFileResults>();
            SearchFileResults sfr = null;

            try
            {
                //Specify the binding to be used for the client.
                binding = new System.ServiceModel.BasicHttpBinding();
                client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);

                string strChannelID = clsGlobal.EDMS_HOST_ID;
                string strErrorCode = "";
                string strErrorMsg = "";
                bool blnHasFailed = false;

                if (SearchFile.Count > 0)
                {
                    string[] strColumns = new String[SearchFile.Count];
                    string[] strKeywords = new String[SearchFile.Count];
                    for (int i = 0; i < SearchFile.Count; i++)
                    {
                        strColumns[i] = SearchFile[i].ColumnName;
                        strKeywords[i] = SearchFile[i].ColumnKeyword;
                    }

                    EDMS_WSSDK.DataProfileResult1[] dpResult = client.ProfileSearch(ProfileName, strColumns, strKeywords, strChannelID, ref strErrorCode, ref strErrorMsg);
                    clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + dpResult.Length.ToString());
                    if (strErrorCode == "0")
                    {
                        for (int i = 0; i < dpResult.Length; i++)
                        {
                            sfr = new SearchFileResults();
                            sfr.VerID = dpResult[i].VerID.ToString();
                            sfr.ProfileID = dpResult[i].ProfileID.ToString();
                            sfr.ImageName = dpResult[i].ImageName.ToString();
                            sfr.FileSize = dpResult[i].FileSize.ToString();
                            sfr.DocID = dpResult[i].DocID.ToString();
                            sfr.Datecreated = dpResult[i].Datecreated.ToString();

                            EDMS_WSSDK.DataColumn1[] arr = dpResult[i].Arr_DataValue;
                            if (arr != null)
                            {
                                for (int x = 0; x < arr.Length; x++)
                                {
                                    if (arr[x].Col_Name.ToUpper() == "FIELD1")
                                    {
                                        sfr.Field1 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD2")
                                    {
                                        sfr.Field2 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD3")
                                    {
                                        sfr.Field3 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD4")
                                    {
                                        sfr.Field4 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD5")
                                    {
                                        sfr.Field5 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD6")
                                    {
                                        sfr.Field6 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD7")
                                    {
                                        sfr.Field7 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD8")
                                    {
                                        sfr.Field8 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD9")
                                    {
                                        sfr.Field9 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "FIELD10")
                                    {
                                        sfr.Field10 = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "BATCH NO")
                                    {
                                        sfr.BatchNo = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Name.ToUpper() == "BATCH DESCRIPTION")
                                    {
                                        sfr.BatchDesc = arr[x].ProfileValue;
                                    }
                                }
                            }

                            fl.Add(sfr);
                        }

                        if (!blnHasFailed)
                        {
                            response.Status = "1";
                            response.ErrorCode = "";
                            response.ErrorMessage = "";
                            response.FileList = fl;
                        }
                    }
                    else
                    {
                        blnHasFailed = true;
                        response.Status = "-1";
                        response.ErrorCode = strErrorCode;
                        response.ErrorMessage = strErrorMsg;
                    }
                }
                else
                {
                    response.Status = "0";
                    response.ErrorCode = "";
                    response.ErrorMessage = "Warning: No record found";
                }
            }
            catch (Exception ex)
            {
                response.Status = "-1";
                response.ErrorCode = "1";
                response.ErrorMessage = "Unexpected Error: " + ex.Message;
                clsLog.WriteSystemLog(clsLog.MessageType.Error, "SearchFileFromEDMS()", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                fl = null;
                sfr = null;

                binding = null;
                client = null;
            }

            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", ConvertResponseToXmlText(EnumResponseType.SearchFile, "RefNo=" + RefNo, response));
            return response;
        }

        [WebMethod]
        public DownloadFileResponseData DownloadFileFromEDMS(string RefNo, string UserName, string VerID, string ProfileID, string FileType)
        {
            DownloadFileResponseData response = new DownloadFileResponseData();

            System.ServiceModel.BasicHttpBinding binding = null;
            EDMS_WSSDK.WSSDKSoapClient client = null;

            try
            {
                //Specify the binding to be used for the client.
                binding = new System.ServiceModel.BasicHttpBinding();
                client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);

                string strChannelID = clsGlobal.EDMS_HOST_ID;
                string strErrorCode = "";
                string strErrorMsg = "";
                string strFileUrl = "";
                string strResult = "";
                bool blnHasFailed = false;

                strResult = client.ViewFile_with_Requestor(Convert.ToInt64(VerID), Convert.ToInt64(ProfileID), Convert.ToInt16(FileType), ref strFileUrl, strChannelID, ref strErrorCode, ref strErrorMsg);
                clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + strResult);
                if (strResult == "1")
                {
                    response.FileUrl = strFileUrl;
                }
                else
                {
                    blnHasFailed = true;
                    response.Status = strResult;
                    response.ErrorCode = strErrorCode;
                    response.ErrorMessage = strErrorMsg;
                }

                if (!blnHasFailed)
                {
                    response.Status = "1";
                    response.ErrorCode = "";
                    response.ErrorMessage = "";
                }
            }
            catch (Exception ex)
            {
                response.Status = "-1";
                response.ErrorCode = "1";
                response.ErrorMessage = "Unexpected Error: " + ex.Message;
                clsLog.WriteSystemLog(clsLog.MessageType.Error, "DownloadFileFromEDMS()", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                binding = null;
                client = null;
            }

            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", ConvertResponseToXmlText(EnumResponseType.DownloadFile, "RefNo=" + RefNo, response));
            return response;
        }

        ///<summary>
        ///DeleteFileFromEDMS | EDMS | To delete file by DocID and ProfileID
        ///</summary>
        [WebMethod]
        public DeleteFileResponseData DeleteFileFromEDMS(string DocID, string ProfileID, string RequestorID)
        {
            DeleteFileResponseData response = new DeleteFileResponseData();

            System.ServiceModel.BasicHttpBinding binding = null;
            EDMS_WSSDK.WSSDKSoapClient client = null;

            try
            {
                //Specify the binding to be used for the client.
                binding = new System.ServiceModel.BasicHttpBinding();
                client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);

                string strChannelID = clsGlobal.EDMS_HOST_ID;
                string strErrorCode = "";
                string strErrorMsg = "";
                string strResult = "";
                bool blnHasFailed = false;

                strResult = client.DeleteDocument(DocID, ProfileID, RequestorID, ref strErrorCode, ref strErrorMsg);
                clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + strResult);
                if (strResult == "1")
                {
                    //-- successful --
                }
                else
                {
                    //-- failed --
                    blnHasFailed = true;
                    response.Status = strResult;
                    response.ErrorCode = strErrorCode;
                    response.ErrorMessage = strErrorMsg;
                }

                if (!blnHasFailed)
                {
                    response.Status = "1";
                    response.ErrorCode = "";
                    response.ErrorMessage = "";
                }
            }
            catch (Exception ex)
            {
                response.Status = "-1";
                response.ErrorCode = "1";
                response.ErrorMessage = "Unexpected Error: " + ex.Message;
                clsLog.WriteSystemLog(clsLog.MessageType.Error, "DeleteFileFromEDMS()", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                binding = null;
                client = null;
            }

            clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", ConvertResponseToXmlText(EnumResponseType.DeleteFile, "DocID=" + DocID + ",ProfileID=" + ProfileID, response));
            return response;
        }
        
        ///// <summary>
        ///// Test
        ///// </summary>
        ///// <param name="TFRef"></param>
        ///// <returns></returns>
        //[WebMethod]
        //public string SetOutOfOffice()
        //{
        //    string strResult = "0";

        //    //Make a connection that authenticates against the K2 SQL User Manager
        //    SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder builder = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
        //    builder.Authenticate = true;
        //    builder.Host = "workflow-sit2.hlbank.my"; //server name of the K2 host server
        //    builder.Port = 5555; //use port 5252 for SourceCode.Workflow.Client connections
        //    builder.Integrated = false;
        //    builder.IsPrimaryLogin = true;
        //    builder.SecurityLabelName = "K2"; //the name of the security label to use for authenticating the credentials below
        //    builder.UserID = "dsp_dms_apppool"; //user name to be authenticated
        //    builder.Password = "user123!"; //password for the user to be authenticated
        //    //open the connection

        //    using (SourceCode.Workflow.Client.Connection K2Conn = new SourceCode.Workflow.Client.Connection())
        //    {
        //        //open a simple connection for simplicity
        //        K2Conn.Open("[ServerName]", builder.ToString());
        //        //set Out of Office ON for the current user
        //        K2Conn.SetUserStatus(SourceCode.Workflow.Client.UserStatuses.OOF);
        //        //set Out of Office OFF for the current user
        //        K2Conn.SetUserStatus(SourceCode.Workflow.Client.UserStatuses.Available);

        //        //set Out of Office ON for a managed user
        //        K2Conn.SetUserStatus(@"[Label]:[Domain\Username]", SourceCode.Workflow.Client.UserStatuses.OOF); //e.g. K2:DOMAIN\Username 
        //        //set Out of Office OFF for a managed user
        //        K2Conn.SetUserStatus(@"[Label]:[Domain\Username]", SourceCode.Workflow.Client.UserStatuses.Available); //e.g. K2:DOMAIN\Username 
        //    }

        //    return strResult = "1";
        //}

        private string ConvertResponseToXmlText(EnumResponseType enumType, string strKey, object response)
        {
            System.Text.StringBuilder strOutput = new System.Text.StringBuilder();
            strOutput.AppendLine(strKey);
            strOutput.AppendLine("<response>");

            if (enumType == EnumResponseType.ExportFile)
            {
                foreach (var prop in ((ExportFileResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.SearchFile)
            {
                foreach (var prop in ((SearchFileResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.DownloadFile)
            {
                foreach (var prop in ((DownloadFileResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.DeleteFile)
            {
                foreach (var prop in ((DeleteFileResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.CifDetailsInquiryByIDNo || enumType == EnumResponseType.CifDetailsInquiryByCIFNum)
            {
                foreach (var prop in ((SearchCifResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.TradeTxnInquiry)
            {
                foreach (var prop in ((SearchTradeTxnResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.LdapAuthentication)
            {
                foreach (var prop in ((LdapAuthenticationResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }
            else if (enumType == EnumResponseType.LdapSearchUser)
            {
                foreach (var prop in ((LdapSearchUserResponseData)response).GetType().GetProperties())
                {
                    strOutput.AppendLine("    <" + prop.Name + ">" + prop.GetValue(response, null) + "</" + prop.Name + ">");
                }
            }

            strOutput.AppendLine("</response>");
            return strOutput.ToString();
        }

        private string FormatSqlValue(string strValue)
        {
            return strValue.Replace("'", "''");
        }

        private string Serialize(object input)
        {
            if (input == null)
                return null;

            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(input.GetType());

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            using (System.IO.StreamReader sr = new System.IO.StreamReader(ms))
            {
                ser.Serialize(ms, input);
                ms.Seek(0, 0);
                return sr.ReadToEnd();
            }
        }

        private string DecodeXmlSpecialCode(string strValue)
        {
            return System.Web.HttpUtility.HtmlDecode(strValue);
        }

        // Mortgage-MG API
        private void LogErrorToDB(string APIName, string errorType, string errorMessage, string errorDetail)
        {
            DataSet ds = null;
            //DataTable dt = null;
            SqlConnection conn = null;
            SqlDataAdapter sqlDA = null;

            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth)
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }
            conn = new SqlConnection(connstr);
            conn.Open();

            sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = new SqlCommand("usp_ws_errorLog @APIName, @errorType, @errorMessage, @errorDetail, @APIErrorDt", conn);
            sqlDA.SelectCommand.Parameters.AddWithValue("@APIName", APIName);
            sqlDA.SelectCommand.Parameters.AddWithValue("@errorType", errorType);
            sqlDA.SelectCommand.Parameters.AddWithValue("@errorMessage", errorMessage);
            sqlDA.SelectCommand.Parameters.AddWithValue("@errorDetail", errorDetail);
            sqlDA.SelectCommand.Parameters.AddWithValue("@APIErrorDt", DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));

            ds = new DataSet("ds");
            sqlDA.Fill(ds);

            conn.Close();
        }

        /*
        private void LogEmailErrorToDB(string Receiver, string Header, string Content, string errorDetail)
        {
            DataSet ds = null;
            //DataTable dt = null;
            SqlConnection conn = null;
            SqlDataAdapter sqlDA = null;

            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth)
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }
            conn = new SqlConnection(connstr);
            conn.Open();

           
            sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = new SqlCommand("usp_ws_FailedEmail_ErrorLog @Receiver, @Header, @Content, @ExceptionDetail", conn);
            sqlDA.SelectCommand.Parameters.AddWithValue("@Receiver", Receiver);
            sqlDA.SelectCommand.Parameters.AddWithValue("@Header", Header);
            sqlDA.SelectCommand.Parameters.AddWithValue("@Content", Content);
            sqlDA.SelectCommand.Parameters.AddWithValue("@ExceptionDetail", errorDetail);           

            ds = new DataSet("ds");
            sqlDA.Fill(ds);

            conn.Close();
        }
        */

        // Mortgage-MG API
        private void DP_DownloadFileFromEDMS(string VerID, string ProfileID, string FileType, ref string strFileURL, ref string error)
        {
            error = "";

            System.ServiceModel.BasicHttpBinding binding = null;
            EDMS_WSSDK.WSSDKSoapClient client = null;

            binding = new System.ServiceModel.BasicHttpBinding();
            client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);


            string strChannelID = clsGlobal.EDMS_HOST_ID;
            string strErrorCode = "";
            string strErrorMsg = "";
            string strResult = "";

            EDMS_WSSDK.DataColumnAccessList[] ListA = new EDMS_WSSDK.DataColumnAccessList[1];

            try
            {
                strResult = client.ViewFile_with_Requestor(Convert.ToInt64(VerID), Convert.ToInt64(ProfileID), 1, ref strFileURL, strChannelID, ref strErrorCode, ref strErrorMsg);

                if (strResult != "1")
                {
                    error = "DP_DownloadFileFromEDMS failed with message: " + strErrorMsg.ToString();
                    string errorDetail;
                    //errorDetail = strErrorCode.ToString() + "," + strErrorMsg.ToString();
                    errorDetail = "Input Param: " + VerID + "," + ProfileID + "," + FileType + "," + strFileURL;
                    LogErrorToDB("DP_DownloadFileFromEDMS", "Fail", error, errorDetail);
                }
            }
            catch (Exception ex)
            {
                error = "DP_DownloadFileFromEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + VerID + "," + ProfileID + "," + FileType + "," + strFileURL;
                LogErrorToDB("DP_DownloadFileFromEDMS", "Exception", error, errorDetail);
            }
        }

        // Mortgage-MG API
        public struct structureEDMSMortgageMG
        {
            public string BranchCode;
            public string SalesmanCode;
            public string ARNNumber;
            public string Name;
            public string IDNumber;
            public string DocumentType;
            public string Category;
            public string BoxNumber;
            public string BatchNo;
            public string BatchDescription;
            public string FileName;
            public long VerID;
            public long DocID;
            public long ProfileID;
            public string FileURL;
        }

        // Mortgage-MG API
        [WebMethod]
        public List<structureEDMSMortgageMG> DP_SearchFileFromEDMS(string ProfileName, string strColumn, string strKeyword)
        {
            string error = "";
            List<structureEDMSMortgageMG> list = new List<structureEDMSMortgageMG>();
            try
            {
                SearchFileResponseData response = new SearchFileResponseData();

                System.ServiceModel.BasicHttpBinding binding = null;
                EDMS_WSSDK.WSSDKSoapClient client = null;
                //eDMSTTMS.DocufloSDKSoapClient client = null;

                DataTable dt = new DataTable();
                dt.Columns.Add("Branch Code");
                dt.Columns.Add("Salesman Code");
                dt.Columns.Add("ARN Number");
                dt.Columns.Add("Name");
                dt.Columns.Add("ID Number");
                dt.Columns.Add("Document Type");
                dt.Columns.Add("Category");
                dt.Columns.Add("Box Number");
                //dt.Columns.Add("Batch No");
                //dt.Columns.Add("Batch Description");                        

                //List<SearchFileResults> fl = new List<SearchFileResults>();
                //SearchFileResults sfr = null;

                //Specify the binding to be used for the client.
                binding = new System.ServiceModel.BasicHttpBinding();
                client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);

                //client = new eDMSTTMS.DocufloSDKSoapClient("DocufloSDKSoap", clsGlobal.EDMS_HOST_URL);

                string strChannelID = clsGlobal.EDMS_HOST_ID;
                string strErrorCode = "";
                string strErrorMsg = "";
                //bool blnHasFailed = false;

                //if (SearchFile.Count > 0)
                // {
                //string[] strColumns = new String[SearchFile.Count];
                //string[] strKeywords = new String[SearchFile.Count];

                string[] strColumns = new String[1];
                string[] strKeywords = new String[1];

                strColumns[0] = strColumn;
                strKeywords[0] = strKeyword.Trim();

                //strColumns.Add(strColumn);
                //strKeywords.Add(strKeyword);


                /*
                for (int i = 0; i < SearchFile.Count; i++)
                    {
                        strColumns[i] = SearchFile[i].ColumnName;
                        strKeywords[i] = SearchFile[i].ColumnKeyword;
                    }
                */
                EDMS_WSSDK.DataProfileResult1[] dpResult = client.ProfileSearch(ProfileName, strColumns, strKeywords, strChannelID, ref strErrorCode, ref strErrorMsg);
                //EDMS_WSSDK.DataProfileResult[] dpResult = client.Search("arn2", ref strErrorCode, ref strErrorMsg);
                //eDMSTTMS.DataProfileResult[] dpResult = client.ProfileSearch(ProfileName, strColumns, strKeywords, ref strErrorMsg);

                //eDMSTTMS.DataProfileResult[] dpResult = client.Search("strValue3");

                if (strErrorCode == "0")
                //if (strErrorCode == "")
                {
                    for (int i = 0; i < dpResult.Length; i++)
                    {

                        //sfr = new SearchFileResults();

                        //sfr.VerID = dpResult[i].VerID.ToString();
                        //sfr.ProfileID = dpResult[i].ProfileID.ToString();
                        //sfr.ImageName = dpResult[i].ImageName.ToString();
                        //sfr.FileSize = dpResult[i].FileSize.ToString();
                        //sfr.DocID = dpResult[i].DocID.ToString();
                        // sfr.Datecreated = dpResult[i].Datecreated.ToString();

                        EDMS_WSSDK.DataColumn1[] arr = dpResult[i].Arr_DataValue;
                        //eDMSTTMS.DataColumn[] arr = dpResult[i].Arr_DataValue;

                        structureEDMSMortgageMG instance = new structureEDMSMortgageMG();

                        long strDocID = dpResult[i].DocID;
                        long strProfileID = dpResult[i].ProfileID;
                        long stVerID = dpResult[i].VerID;
                        string strFileName = dpResult[i].ImageName;

                        instance.FileName = strFileName;
                        instance.VerID = stVerID;
                        instance.ProfileID = strProfileID;
                        instance.DocID = strDocID;
                        string strFileURL = "";
                        string DP_DownloadFileFromEDMS_error;
                        DP_DownloadFileFromEDMS_error = "";

                        DP_DownloadFileFromEDMS(stVerID.ToString(), strProfileID.ToString(), strDocID.ToString(), ref strFileURL, ref DP_DownloadFileFromEDMS_error);

                        if (DP_DownloadFileFromEDMS_error == "")
                        {
                            instance.FileURL = strFileURL;
                            //instance.FileURL = "http://kapps2/edms/view_file.aspx?verid=" + stVerID + "&proid=" + strProfileID;

                            if (arr != null)
                            {
                                for (int x = 0; x < arr.Length; x++)
                                {
                                    if (arr[x].Col_Desc == "Branch Code")
                                    {
                                        instance.BranchCode = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Salesman Code")
                                    {
                                        instance.SalesmanCode = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "ARN Number")
                                    {
                                        instance.ARNNumber = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Name")
                                    {
                                        instance.Name = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "ID Number")
                                    {
                                        instance.IDNumber = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Document Type")
                                    {
                                        instance.DocumentType = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Category")
                                    {
                                        instance.Category = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Box Number")
                                    {
                                        instance.BoxNumber = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Batch No")
                                    {
                                        instance.BatchNo = arr[x].ProfileValue;
                                    }
                                    else if (arr[x].Col_Desc == "Batch Description")
                                    {
                                        instance.BatchDescription = arr[x].ProfileValue;
                                    }
                                }
                            }
                            list.Add(instance);
                        }
                    }
                }
                else
                {
                    string errorDetail;
                    //errorDetail = strErrorCode + "," + strErrorMsg;
                    error = "DP_SearchFileFromEDMS failed with message:" + strErrorMsg;
                    errorDetail = "Input Param: " + ProfileName + "," + strColumn + "," + strKeyword;
                    LogErrorToDB("DP_SearchFileFromEDMS", "Error", error, errorDetail);
                }


            }
            catch (Exception ex)
            {
                error = "DP_SearchFileFromEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + ProfileName + "," + strColumn + "," + strKeyword;
                LogErrorToDB("DP_SearchFileFromEDMS", "Exception", error, errorDetail);

                //return list;                
            }
            return list;
        }

        // Mortgage-MG API
        [WebMethod]
        public ExportFileResponseData DP_ExportK2FileToEDMS(string strProfile, string strFolderName, string file, string fileName, string strARN, string strDocType, string strCategory, string strIDNumber, string Name, ref string error)
        {
            error = "";
            ExportFileResponseData response = new ExportFileResponseData();

            System.ServiceModel.BasicHttpBinding binding = null;
            EDMS_WSSDK.WSSDKSoapClient client = null;
            //eDMSTTMS.DocufloSDKSoapClient client = null;

            try
            {

                //Specify the binding to be used for the client.
                binding = new System.ServiceModel.BasicHttpBinding();
                client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);
                //client = new eDMSTTMS.DocufloSDKSoapClient("DocufloSDKSoap", clsGlobal.EDMS_HOST_URL);

                string strChannelID = clsGlobal.EDMS_HOST_ID;
                System.Xml.XmlDocument xmlDoc = null;
                System.Xml.XmlNodeList xmlNodeList = null;
                System.Xml.XmlNodeList xmlNodeListFileName = null;
                string strErrorCode = "";
                string strErrorMsg = "";
                string strResult = "";

                //bool blnHasFailed = false;

                //int intDocID;
                byte[] byteFileContent = null;
                //string strFileName = "";
                //string strProfile = "";
                //string strFolderName = "";
                string strBranchCode = "n/a";
                string strSalesmanCode = "n/a";
                //string strARN = strARN;
                string strName = Name;
                //string strID = "";
                //string strDocType = "";
                //string strCategory = "";
                string strBoxNumber = "n/a";


                // file method
                /*
                xmlDoc = new System.Xml.XmlDocument();

                xmlDoc.LoadXml(file);

                xmlNodeList = xmlDoc.GetElementsByTagName("content");
                xmlNodeListFileName = xmlDoc.GetElementsByTagName("name");

                string strFileName = xmlNodeListFileName[0].InnerText;

                byteFileContent = Convert.FromBase64String(xmlNodeList[0].InnerText);
                */
                string strFileName;
                // direct file image method
                if (String.IsNullOrEmpty(fileName))
                {
                    strFileName = "error.pdf";
                }
                else
                {
                    strFileName = fileName;
                }

                byteFileContent = Convert.FromBase64String(file);

                /*
                var xdoc = XDocument.Parse(file);
                var element = from e in xdoc.Descendants("content") select e;

                byteFileContent = Convert.FromBase64String(element.First().Value);
                */
                //System.Diagnostics.Debug.Write(xmlNodeList[0].InnerText);
                //intDocID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                //intDocID = 1001;


                //byteFileContent = BitConverter.GetBytes(1) ;

                //string base64Encoded = "YmFzZTY0IGVuY29kZWQgc3RyaW5n";
                //string base64Decoded;
                //byteFileContent = System.Convert.FromBase64String(base64Encoded);

                /*
                HLBBWS.eDMSTTMS.ArrayOfString str2x = new eDMSTTMS.ArrayOfString();
                str2.Add(strBranchCode.Trim());
                str2.Add(strSalesmanCode.Trim());
                str2.Add(strARN.Trim());
                str2.Add(strName.Trim());
                str2.Add(strIDNumber.Trim());
                str2.Add(strDocType.Trim());
                str2.Add(strCategory.Trim());
                str2.Add(strBoxNumber.Trim());
                */

                string[] str2 = new string[8];

                str2[0] = strBoxNumber.Trim();
                /*
                if (String.IsNullOrEmpty(strBoxNumber))
                {
                    str2[0] = "n/a";
                }
                else
                {
                    str2[0] = strBoxNumber.Trim();
                }
                */
                str2[1] = strBranchCode.Trim();
                /*
                if (String.IsNullOrEmpty(strBranchCode))
                {
                    str2[1] = "n/a";
                }
                else
                {
                    str2[1] = strBranchCode.Trim();
                }
                */
                str2[2] = strSalesmanCode.Trim();
                /*
                if (String.IsNullOrEmpty(strSalesmanCode))
                {
                    str2[2] = "n/a";
                }
                else
                {
                    str2[2] = strSalesmanCode.Trim();
                }
                */
                str2[3] = strARN.Trim();
                /*
                if (String.IsNullOrEmpty(strARN))
                {
                    str2[3] = "n/a";
                }
                else
                {
                    str2[3] = strARN.Trim();
                }
                */
                str2[4] = strName.Trim();
                /*
                if (String.IsNullOrEmpty(strName))
                {
                    str2[4] = "n/a";
                }
                else
                {
                    str2[4] = strName.Trim();
                }
                */
                str2[5] = strIDNumber.Trim();
                /*
                if (String.IsNullOrEmpty(strIDNumber))
                {
                    str2[5] = "n/a";
                }
                else
                {
                    str2[5] = strIDNumber.Trim();
                }
                */
                str2[6] = strDocType.Trim();
                /*
                if (String.IsNullOrEmpty(strDocType))
                {
                    str2[6] = "n/a";
                }
                else
                {
                    str2[6] = strDocType.Trim();
                }
                */
                str2[7] = strCategory.Trim();
                /*
                if (String.IsNullOrEmpty(strCategory))
                {
                    str2[7] = "n/a";
                }
                else
                {
                    str2[7] = strCategory.Trim();
                }
                */

                //strResult = client.Export(byteFileContent, strFileName, strProfile, strFolderName, new string[] { strValue1, strValue2, strValue3, strValue4, strValue5, strValue6, strValue7, strValue8, strValue9, strValue10 }, strChannelID, ref strErrorCode, ref strErrorMsg);   //client.Download(intVerID, intProfileID, intDocType, ref strFileName, ref byteDoc);


                //< FileContent > base64Binary </ FileContent >
                //< strFileName > string </ strFileName >
                //< strProfile > string </ strProfile >
                //< strFolderName > string </ strFolderName >
                //< arrProfileValue >
                //< string > string </ string >
                //< string > string </ string >
                //</ arrProfileValue >
                //< userID > string </ userID >
                //< error_code > string </ error_code >
                //< error_msg > string </ error_msg >

                strResult = client.Export(byteFileContent, strFileName, strProfile, strFolderName, str2, strChannelID, ref strErrorCode, ref strErrorMsg);   //client.Download(intVerID, intProfileID, intDocType, ref strFileName, ref byteDoc);
                //strResult = client.Export(byteFileContent, strFileName, strProfile, strFolderName, str2, strChannelID);   //client.Download(intVerID, intProfileID, intDocType, ref strFileName, ref byteDoc);

                //clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", "Result=" + strResult);

                if (strResult != "1")
                {
                    error = "DP_ExportK2FileToEDMS failed with message: " + strErrorMsg.ToString();
                    string errorDetail;
                    //errorDetail = strErrorCode.ToString() + "," + strErrorMsg.ToString();
                    errorDetail = "Input Param: " + strProfile.ToString() + "," + strFolderName.ToString() + "," + file.ToString() + "," + fileName.ToString() + "," + strARN.ToString() + "," + strDocType.ToString() + "," + strCategory.ToString() + "," + strIDNumber.ToString() + "," + Name.ToString();
                    LogErrorToDB("DP_ExportK2FileToEDMS", "Fail", error, errorDetail);
                }
            }
            catch (Exception ex)
            {
                error = "DP_ExportK2FileToEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + strProfile.ToString() + "," + strFolderName.ToString() + "," + file.ToString() + "," + fileName.ToString() + "," + strARN.ToString() + "," + strDocType.ToString() + "," + strCategory.ToString() + "," + strIDNumber.ToString() + "," + Name.ToString();
                LogErrorToDB("DP_ExportK2FileToEDMS", "Exception", error, errorDetail);
                /*
                response.Status = "-1";
                response.ErrorCode = "1";
                response.ErrorMessage = "Unexpected Error: " + ex.Message;
                clsLog.WriteSystemLog(clsLog.MessageType.Error, "ExportK2FileToEDMS()", ex.Message + Environment.NewLine + ex.StackTrace);
                */
            }

            //clsLog.WriteSystemLog(clsLog.MessageType.Info, "Response", ConvertResponseToXmlText(EnumResponseType.ExportFile, "RefNo=" + RefNo, response));
            return response;
        }

        // Mortgage-MG API
        public struct structureLOADS
        {
            public string collaterals_buildUpArea;
            public string collaterals_developerCode;
            public string collaterals_developerName;
            public string collaterals_financingType;
            public string collaterals_landArea;
            public string collaterals_projectCode;
            public string collaterals_projectName;
            public string collaterals_propertyAddress;
            public string collaterals_propertyType;
            public string collaterals_requiredValReportInd;

            public string collaterals_titleDetails;
            public string collaterals_valuerAccountNbr;
            public string collaterals_valuerAccountType;
            public string collaterals_valuerAddr1;
            public string collaterals_valuerAddr2;

            public string collaterals_valuerAddr3;
            public string collaterals_valuerCity;
            public string collaterals_valuerCode;
            public string collaterals_valuerCountry;
            public string collaterals_valuerEmail;
            public string collaterals_valuerName;
            public string collaterals_valuerPostcode;
            public string collaterals_valuerState;

            public string collaterals_verbalIndicativeValue;
            // new fields     
            public string collaterals_valuerFaxNbr;
            public string collaterals_valuerTelNbr;

            public string facilities_disbursementManner;
            public string facilities_facilityAmount1;
            public string facilities_facilityAmount2;
            public string facilities_facilityAmount3;

            public string facilities_facilityAmount4;
            public string facilities_gracePeriod;
            public string facilities_productName1;
            public string facilities_productName2;
            public string facilities_productName3;
            public string facilities_productName4;

            public string facilities_purposeCode;
            public string facilities_totFeesAmount;
            public string facilities_totFinancingAmount;
            public string facilities_totFinancingAmountIncFlvm;
            public string facilities_totInsAmount;
            public string facilities_totValuationFees;
            public string loanApplicationInfo_appStatus;
            public string loanApplicationInfo_branchAddr1;

            public string loanApplicationInfo_branchAddr2;
            public string loanApplicationInfo_branchAddr3;
            public string loanApplicationInfo_branchAddrCity;
            public string loanApplicationInfo_branchAddrCountry;
            public string loanApplicationInfo_branchAddrPostcode;
            public string loanApplicationInfo_branchAddrState;

            public string loanApplicationInfo_branchManagerEmail;
            public string loanApplicationInfo_branchManagerName;
            public string loanApplicationInfo_closingBranch;
            public string loanApplicationInfo_lendingType;
            public string loanApplicationInfo_loAcceptanceDt;
            public string loanApplicationInfo_mortgageCenterCode;
            public string loanApplicationInfo_mortgageCenterEmail;

            public string loanApplicationInfo_salesEmail;
            public string loanApplicationInfo_salesName;
            public string loanApplicationInfo_solicitorAccountType;
            public string loanApplicationInfo_solicitorAddr1;
            public string loanApplicationInfo_solicitorAddr2;
            public string loanApplicationInfo_solicitorAddr3;

            public string loanApplicationInfo_solicitorCity;
            public string loanApplicationInfo_solicitorCode;
            public string loanApplicationInfo_solicitorCountry;
            public string loanApplicationInfo_solicitorEmail;
            public string loanApplicationInfo_solicitorIntStatus;
            public string loanApplicationInfo_solicitorNBR;
            public string loanApplicationInfo_solicitorName;

            public string loanApplicationInfo_solicitorPostcode;
            public string loanApplicationInfo_solicitorState;
            public string loanApplicationInfo_topupLoanInd;
            
            public string loanApplicationInfo_solicitorFaxNbr;
            public string loanApplicationInfo_solicitorTelNbr;

            // dev portal new fields 
            public string loanApplicationInfo_phaseCode;
            public string loanApplicationInfo_phaseName;
            public string loanApplicationInfo_unitParcelNo;
            public string loanApplicationInfo_spaValue;
            public string loanApplicationInfo_category;          
            // dev portal new fields 

            public string loanApptPersonnelInfo_applicantAddr1;
            public string loanApptPersonnelInfo_applicantAddr2;
            public string loanApptPersonnelInfo_applicantAddr3;
            public string loanApptPersonnelInfo_applicantAddrCity;

            public string loanApptPersonnelInfo_applicantAddrCountry;
            public string loanApptPersonnelInfo_applicantAddrPostcode;
            public string loanApptPersonnelInfo_applicantAddrState;
            public string loanApptPersonnelInfo_applicantEmails;
            public string loanApptPersonnelInfo_applicantIDs;
            public string loanApptPersonnelInfo_applicantNamesCombine;
            public string loanApptPersonnelInfo_chargorIDs;

            public string loanApptPersonnelInfo_chargorNames;
            public string loanApptPersonnelInfo_eStatementFlagInd;
            public string loanApptPersonnelInfo_guarantorIDs;
            public string loanApptPersonnelInfo_guarantorNames;
            public string loanApptPersonnelInfo_priApplicantName;
            
            public string loanApptPersonnelInfo_priApplicantId;

            public string respInfo_respCode;
            public string respInfo_respDesc;


            /*
            public string SalesmanCode;
            public string ARNNumber;
            public string Name;
            public string IDNumber;
            public string DocumentType;
            public string Category;
            public string BoxNumber;
            public string BatchNo;
            public string BatchDescription;
            public string FileName;
            public long VerID;
            public long DocID;
            public long ProfileID;
            public string FileURL;
             * */
        }

        // Mortgage-MG API
        [WebMethod]
        public List<structureLOADS> DP_GetDataFromLOADS(string arn)
        {
            string error = "";
            List<structureLOADS> list = new List<structureLOADS>();
            structureLOADS loads = new structureLOADS();
            try
            {
                SearchFileResponseData response = new SearchFileResponseData();


                //System.ServiceModel.BasicHttpBinding binding = null;
                //LOADS_API.WsEIWSLosaLoanApplicantInfo proxy = new LOADS_API.WsEIWSLosaLoanApplicantInfo();
                LOADS_API.WsEIWSLosaAppBocImpService client = new LOADS_API.WsEIWSLosaAppBocImpService();
                //LOADS_API.AppHeader xmlAppHeader = new LOADS_API.AppHeader();
                LOADS_API.WsEIWSLosaAppHeader xmlAppHeader =  new LOADS_API.WsEIWSLosaAppHeader();
                xmlAppHeader.agencyId = "?";
                xmlAppHeader.bizRefNo = arn;
                xmlAppHeader.businessArea = "?";
                xmlAppHeader.date = "?";
                xmlAppHeader.processId = "?";
                
                LOADS_API.WsEIWSLosaAppLoanInfo output = client.LoanApplicationInfo(xmlAppHeader);
                
                /*
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("insert into LOADS_API_LOG values ('" + arn + "', '" + output.respInfo.respCode.ToString() + "', '" + output.respInfo.respDesc.ToString() + "', getdate())", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                //dt = ds.Tables[0];

                conn.Close();
                */
                if (output.respInfo.respCode == "00")
                {
                    // start collaterals section 
                    //collaterals_developerCode
                    if (string.IsNullOrEmpty(output.collaterals.developerCode))
                    {
                        loads.collaterals_developerCode = "";
                    }
                    else
                    {
                        loads.collaterals_developerCode = output.collaterals.developerCode.ToString();
                    }

                    //collaterals_buildUpArea
                    if (string.IsNullOrEmpty(output.collaterals.buildUpArea.ToString()))
                    {
                        loads.collaterals_buildUpArea = "0.00";
                    }
                    else
                    {
                        loads.collaterals_buildUpArea = output.collaterals.buildUpArea.ToString();
                    }

                    //collaterals_developerName
                    if (string.IsNullOrEmpty(output.collaterals.developerName))
                    {
                        loads.collaterals_developerName = "";
                    }
                    else
                    {
                        loads.collaterals_developerName = output.collaterals.developerName.ToString();
                    }

                    //collaterals_financingType
                    if (string.IsNullOrEmpty(output.collaterals.financingType))
                    {
                        loads.collaterals_financingType = "";
                    }
                    else
                    {
                        loads.collaterals_financingType = output.collaterals.financingType.ToString();
                    }

                    //collaterals_landArea
                    if (string.IsNullOrEmpty(output.collaterals.landArea.ToString()))
                    {
                        loads.collaterals_landArea = "0.00";
                    }
                    else
                    {
                        loads.collaterals_landArea = output.collaterals.landArea.ToString();
                    }


                    //collaterals_projectCode
                    if (string.IsNullOrEmpty(output.collaterals.projectCode))
                    {
                        loads.collaterals_projectCode = "";
                    }
                    else
                    {
                        loads.collaterals_projectCode = output.collaterals.projectCode.ToString();
                    }

                    //collaterals_projectName
                    if (string.IsNullOrEmpty(output.collaterals.projectName))
                    {
                        loads.collaterals_projectName = "";
                    }
                    else
                    {
                        loads.collaterals_projectName = output.collaterals.projectName.ToString();
                    }

                    //collaterals_propertyAddress
                    if (string.IsNullOrEmpty(output.collaterals.propertyAddress))
                    {
                        loads.collaterals_propertyAddress = "";
                    }
                    else
                    {
                        loads.collaterals_propertyAddress = output.collaterals.propertyAddress.ToString();
                    }

                    //collaterals_propertyType
                    if (string.IsNullOrEmpty(output.collaterals.propertyType))
                    {
                        loads.collaterals_propertyType = "";
                    }
                    else
                    {
                        loads.collaterals_propertyType = output.collaterals.propertyType.ToString();
                    }

                    //collaterals_requiredValReportInd
                    if (string.IsNullOrEmpty(output.collaterals.requiredValReportInd))
                    {
                        loads.collaterals_requiredValReportInd = "False";
                    }
                    else
                    {
                        if (output.collaterals.requiredValReportInd.ToString().ToUpper().Trim() == "YES")
                        {
                            loads.collaterals_requiredValReportInd = "True";
                        }
                        else
                        {
                            loads.collaterals_requiredValReportInd = "False";
                        }
                    }

                    if (string.IsNullOrEmpty(output.collaterals.titleDetails))
                    {
                        loads.collaterals_titleDetails = "";
                    }
                    else
                    {
                        loads.collaterals_titleDetails = output.collaterals.titleDetails.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerAccountNbr))
                    {
                        loads.collaterals_valuerAccountNbr = "";
                    }
                    else
                    {
                        loads.collaterals_valuerAccountNbr = output.collaterals.valuerAccountNbr.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerAccountType))
                    {
                        loads.collaterals_valuerAccountType = "";
                    }
                    else
                    {
                        loads.collaterals_valuerAccountType = output.collaterals.valuerAccountType.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerAddr1))
                    {
                        loads.collaterals_valuerAddr1 = "";
                    }
                    else
                    {
                        loads.collaterals_valuerAddr1 = output.collaterals.valuerAddr1.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerAddr2))
                    {
                        loads.collaterals_valuerAddr2 = "";
                    }
                    else
                    {
                        loads.collaterals_valuerAddr2 = output.collaterals.valuerAddr2.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerAddr3))
                    {
                        loads.collaterals_valuerAddr3 = "";
                    }
                    else
                    {
                        loads.collaterals_valuerAddr3 = output.collaterals.valuerAddr3.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerCity))
                    {
                        loads.collaterals_valuerCity = "";
                    }
                    else
                    {
                        loads.collaterals_valuerCity = output.collaterals.valuerCity.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerCode))
                    {
                        loads.collaterals_valuerCode = "";
                    }
                    else
                    {
                        loads.collaterals_valuerCode = output.collaterals.valuerCode.ToString();
                    }

                    // new field valuer fax 
                    loads.collaterals_valuerFaxNbr = "";
                    
                    if (string.IsNullOrEmpty(output.collaterals.valuerFaxNbr))
                    {
                        loads.collaterals_valuerFaxNbr = "";
                    }
                    else
                    {
                        loads.collaterals_valuerFaxNbr = output.collaterals.valuerFaxNbr.ToString();
                    }
                    

                    // new field valuer phone 
                    loads.collaterals_valuerTelNbr = "";
                    
                    if (string.IsNullOrEmpty(output.collaterals.valuerTelNbr))
                    {
                        loads.collaterals_valuerTelNbr = "";
                    }
                    else
                    {
                        loads.collaterals_valuerTelNbr = output.collaterals.valuerTelNbr.ToString();
                    }
                    

                    if (string.IsNullOrEmpty(output.collaterals.valuerCountry))
                    {
                        loads.collaterals_valuerCountry = "";
                    }
                    else
                    {
                        loads.collaterals_valuerCountry = output.collaterals.valuerCountry.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerEmail))
                    {
                        loads.collaterals_valuerEmail = "";
                    }
                    else
                    {
                        loads.collaterals_valuerEmail = output.collaterals.valuerEmail.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerName))
                    {
                        loads.collaterals_valuerName = "";
                    }
                    else
                    {
                        loads.collaterals_valuerName = output.collaterals.valuerName.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerPostcode))
                    {
                        loads.collaterals_valuerPostcode = "";
                    }
                    else
                    {
                        loads.collaterals_valuerPostcode = output.collaterals.valuerPostcode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.valuerState))
                    {
                        loads.collaterals_valuerState = "";
                    }
                    else
                    {
                        loads.collaterals_valuerState = output.collaterals.valuerState.ToString();
                    }

                    if (string.IsNullOrEmpty(output.collaterals.verbalIndicativeValue.ToString()))
                    {
                        loads.collaterals_verbalIndicativeValue = "0.00";
                    }
                    else
                    {
                        loads.collaterals_verbalIndicativeValue = output.collaterals.verbalIndicativeValue.ToString();
                    }
                    // end collaterals section 

                    // start facilities section 
                    if (string.IsNullOrEmpty(output.facilities.disbursementManner))
                    {
                        loads.facilities_disbursementManner = "";
                    }
                    else
                    {
                        loads.facilities_disbursementManner = output.facilities.disbursementManner.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.facilityAmount1.ToString()))
                    {
                        loads.facilities_facilityAmount1 = "0.00";
                    }
                    else
                    {
                        loads.facilities_facilityAmount1 = output.facilities.facilityAmount1.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.facilityAmount2.ToString()))
                    {
                        loads.facilities_facilityAmount2 = "0.00";
                    }
                    else
                    {
                        loads.facilities_facilityAmount2 = output.facilities.facilityAmount2.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.facilityAmount3.ToString()))
                    {
                        loads.facilities_facilityAmount3 = "0.00";
                    }
                    else
                    {
                        loads.facilities_facilityAmount3 = output.facilities.facilityAmount3.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.facilityAmount4.ToString()))
                    {
                        loads.facilities_facilityAmount4 = "0.00";
                    }
                    else
                    {
                        loads.facilities_facilityAmount4 = output.facilities.facilityAmount4.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.gracePeriod.ToString()))
                    {
                        loads.facilities_gracePeriod = "0";
                    }
                    else
                    {
                        loads.facilities_gracePeriod = output.facilities.gracePeriod.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.productName1))
                    {
                        loads.facilities_productName1 = "";
                    }
                    else
                    {
                        loads.facilities_productName1 = output.facilities.productName1.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.productName2))
                    {
                        loads.facilities_productName2 = "";
                    }
                    else
                    {
                        loads.facilities_productName2 = output.facilities.productName2.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.productName3))
                    {
                        loads.facilities_productName3 = "";
                    }
                    else
                    {
                        loads.facilities_productName3 = output.facilities.productName3.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.productName4))
                    {
                        loads.facilities_productName4 = "";
                    }
                    else
                    {
                        loads.facilities_productName4 = output.facilities.productName4.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.purposeCode))
                    {
                        loads.facilities_purposeCode = "";
                    }
                    else
                    {
                        loads.facilities_purposeCode = output.facilities.purposeCode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.totFeesAmount.ToString()))
                    {
                        loads.facilities_totFeesAmount = "0.00";
                    }
                    else
                    {
                        loads.facilities_totFeesAmount = output.facilities.totFeesAmount.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.totFinancingAmount.ToString()))
                    {
                        loads.facilities_totFinancingAmount = "0.00";
                    }
                    else
                    {
                        loads.facilities_totFinancingAmount = output.facilities.totFinancingAmount.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.totFinancingAmountIncFlvm.ToString()))
                    {
                        loads.facilities_totFinancingAmountIncFlvm = "0.00";
                    }
                    else
                    {
                        loads.facilities_totFinancingAmountIncFlvm = output.facilities.totFinancingAmountIncFlvm.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.totInsAmount.ToString()))
                    {
                        loads.facilities_totInsAmount = "0.00";
                    }
                    else
                    {
                        loads.facilities_totInsAmount = output.facilities.totInsAmount.ToString();
                    }

                    if (string.IsNullOrEmpty(output.facilities.totValuationFees.ToString()))
                    {
                        loads.facilities_totValuationFees = "0.00";
                    }
                    else
                    {
                        loads.facilities_totValuationFees = output.facilities.totValuationFees.ToString();
                    }
                    // end facilities section 

                    // start loanApplicationInfo section 
                    if (string.IsNullOrEmpty(output.loanApplicationInfo.appStatus))
                    {
                        loads.loanApplicationInfo_appStatus = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_appStatus = output.loanApplicationInfo.appStatus.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddr1))
                    {
                        loads.loanApplicationInfo_branchAddr1 = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddr1 = output.loanApplicationInfo.branchAddr1.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddr2))
                    {
                        loads.loanApplicationInfo_branchAddr2 = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddr2 = output.loanApplicationInfo.branchAddr2.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddr3))
                    {
                        loads.loanApplicationInfo_branchAddr3 = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddr3 = output.loanApplicationInfo.branchAddr3.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrCity))
                    {
                        loads.loanApplicationInfo_branchAddrCity = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddrCity = output.loanApplicationInfo.branchAddrCity.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrCountry))
                    {
                        loads.loanApplicationInfo_branchAddrCountry = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddrCountry = output.loanApplicationInfo.branchAddrCountry.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrPostcode))
                    {
                        loads.loanApplicationInfo_branchAddrPostcode = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddrPostcode = output.loanApplicationInfo.branchAddrPostcode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrState))
                    {
                        loads.loanApplicationInfo_branchAddrState = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchAddrState = output.loanApplicationInfo.branchAddrState.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchManagerEmail))
                    {
                        loads.loanApplicationInfo_branchManagerEmail = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchManagerEmail = output.loanApplicationInfo.branchManagerEmail.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.branchManagerName))
                    {
                        loads.loanApplicationInfo_branchManagerName = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_branchManagerName = output.loanApplicationInfo.branchManagerName.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.closingBranch))
                    {
                        loads.loanApplicationInfo_closingBranch = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_closingBranch = output.loanApplicationInfo.closingBranch.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.lendingType))
                    {
                        loads.loanApplicationInfo_lendingType = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_lendingType = output.loanApplicationInfo.lendingType.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.loAcceptanceDt))
                    {
                        loads.loanApplicationInfo_loAcceptanceDt = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_loAcceptanceDt = DateTime.ParseExact(output.loanApplicationInfo.loAcceptanceDt, "dd/MM/yyyy", null).ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.mortgageCenterCode))
                    {
                        loads.loanApplicationInfo_mortgageCenterCode = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_mortgageCenterCode = output.loanApplicationInfo.mortgageCenterCode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.mortgageCenterEmail))
                    {
                        loads.loanApplicationInfo_mortgageCenterEmail = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_mortgageCenterEmail = output.loanApplicationInfo.mortgageCenterEmail.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.salesEmail))
                    {
                        loads.loanApplicationInfo_salesEmail = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_salesEmail = output.loanApplicationInfo.salesEmail.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.salesName))
                    {
                        loads.loanApplicationInfo_salesName = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_salesName = output.loanApplicationInfo.salesName.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAccountType))
                    {
                        loads.loanApplicationInfo_solicitorAccountType = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorAccountType = output.loanApplicationInfo.solicitorAccountType.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAddr1))
                    {
                        loads.loanApplicationInfo_solicitorAddr1 = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorAddr1 = output.loanApplicationInfo.solicitorAddr1.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAddr2))
                    {
                        loads.loanApplicationInfo_solicitorAddr2 = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorAddr2 = output.loanApplicationInfo.solicitorAddr2.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAddr3))
                    {
                        loads.loanApplicationInfo_solicitorAddr3 = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorAddr3 = output.loanApplicationInfo.solicitorAddr3.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorCity))
                    {
                        loads.loanApplicationInfo_solicitorCity = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorCity = output.loanApplicationInfo.solicitorCity.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorCode))
                    {
                        loads.loanApplicationInfo_solicitorCode = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorCode = output.loanApplicationInfo.solicitorCode.ToString();
                    }

                    // new field solicitor fax
                    loads.loanApplicationInfo_solicitorFaxNbr = "";
                    
                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorFaxNbr))
                    {
                        loads.loanApplicationInfo_solicitorFaxNbr = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorFaxNbr = output.loanApplicationInfo.solicitorFaxNbr.ToString();
                    }
                    

                    // new field solicitor phone
                    loads.loanApplicationInfo_solicitorTelNbr = "";
                    
                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorTelNbr))
                    {
                        loads.loanApplicationInfo_solicitorTelNbr = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorTelNbr = output.loanApplicationInfo.solicitorTelNbr.ToString();
                    }
                    /*
                    public string loanApplicationInfo_phaseCode;
                    public string loanApplicationInfo_phaseName;
                    public string loanApplicationInfo_unitParcelNo;
                    public string loanApplicationInfo_spaValue;
                    public string loanApplicationInfo_category;
                    */

                    // dev portal new field loanApplicationInfo_phaseCode
                    loads.loanApplicationInfo_phaseCode = "";

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.phaseCode))
                    {
                        loads.loanApplicationInfo_phaseCode = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_phaseCode = output.loanApplicationInfo.phaseCode.ToString();
                    }

                    // dev portal new field loanApplicationInfo_phaseName
                    loads.loanApplicationInfo_phaseName = "";

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.phaseName))
                    {
                        loads.loanApplicationInfo_phaseName = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_phaseName = output.loanApplicationInfo.phaseName.ToString();
                    }

                    // dev portal new field loanApplicationInfo_unitParcelNo
                    loads.loanApplicationInfo_unitParcelNo = "";

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.unitParcelNo))
                    {
                        loads.loanApplicationInfo_unitParcelNo = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_unitParcelNo = output.loanApplicationInfo.unitParcelNo.ToString();
                    }

                    // dev portal new field loanApplicationInfo_unitParcelNo
                    //loads.loanApplicationInfo_spaValue = "";

                    /*
                    if (string.IsNullOrEmpty(output.loanApplicationInfo.spaValue))
                    {
                        loads.loanApplicationInfo_spaValue = "0.00";
                    }
                    else
                    {
                        loads.loanApplicationInfo_spaValue = output.loanApplicationInfo.spaValue.ToString();
                    }
                    */

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.spaValue.ToString()))
                    {
                        loads.loanApplicationInfo_spaValue = "0.00";
                    }
                    else
                    {
                        loads.loanApplicationInfo_spaValue = output.loanApplicationInfo.spaValue.ToString();
                    }

                    // dev portal new field loanApplicationInfo_category
                    loads.loanApplicationInfo_category = "";

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.category))
                    {
                        loads.loanApplicationInfo_category = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_category = output.loanApplicationInfo.category.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorCountry))
                    {
                        loads.loanApplicationInfo_solicitorCountry = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorCountry = output.loanApplicationInfo.solicitorCountry.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorEmail))
                    {
                        loads.loanApplicationInfo_solicitorEmail = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorEmail = output.loanApplicationInfo.solicitorEmail.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorIntStatus))
                    {
                        loads.loanApplicationInfo_solicitorIntStatus = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorIntStatus = output.loanApplicationInfo.solicitorIntStatus.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorNBR))
                    {
                        loads.loanApplicationInfo_solicitorNBR = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorNBR = output.loanApplicationInfo.solicitorNBR.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorName))
                    {
                        loads.loanApplicationInfo_solicitorName = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorName = output.loanApplicationInfo.solicitorName.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorPostcode))
                    {
                        loads.loanApplicationInfo_solicitorPostcode = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorPostcode = output.loanApplicationInfo.solicitorPostcode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorState))
                    {
                        loads.loanApplicationInfo_solicitorState = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_solicitorState = output.loanApplicationInfo.solicitorState.ToString();
                    }

                    /*
                    if (string.IsNullOrEmpty(output.loanApplicationInfo.topupLoanInd))
                    {
                        loads.loanApplicationInfo_topupLoanInd = "";
                    }
                    else
                    {
                        loads.loanApplicationInfo_topupLoanInd = output.loanApplicationInfo.topupLoanInd.ToString();
                    }                    
                    */

                    if (string.IsNullOrEmpty(output.loanApplicationInfo.topupLoanInd))
                    {
                        loads.loanApplicationInfo_topupLoanInd = "False";
                    }
                    else
                    {
                        if (output.loanApplicationInfo.topupLoanInd.ToString().ToUpper().Trim() == "YES")
                        {
                            loads.loanApplicationInfo_topupLoanInd = "True";
                        }
                        else
                        {
                            loads.loanApplicationInfo_topupLoanInd = "False";
                        }
                    }
                    // end loanApplicationInfo section 

                    // start loanApptPersonnelInfo section
                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddr1))
                    {
                        loads.loanApptPersonnelInfo_applicantAddr1 = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddr1 = output.loanApptPersonnelInfo.applicantAddr1.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddr2))
                    {
                        loads.loanApptPersonnelInfo_applicantAddr2 = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddr2 = output.loanApptPersonnelInfo.applicantAddr2.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddr3))
                    {
                        loads.loanApptPersonnelInfo_applicantAddr3 = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddr3 = output.loanApptPersonnelInfo.applicantAddr3.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrCity))
                    {
                        loads.loanApptPersonnelInfo_applicantAddrCity = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddrCity = output.loanApptPersonnelInfo.applicantAddrCity.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrCountry))
                    {
                        loads.loanApptPersonnelInfo_applicantAddrCountry = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddrCountry = output.loanApptPersonnelInfo.applicantAddrCountry.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrPostcode))
                    {
                        loads.loanApptPersonnelInfo_applicantAddrPostcode = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddrPostcode = output.loanApptPersonnelInfo.applicantAddrPostcode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrState))
                    {
                        loads.loanApptPersonnelInfo_applicantAddrState = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantAddrState = output.loanApptPersonnelInfo.applicantAddrState.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantEmails))
                    {
                        loads.loanApptPersonnelInfo_applicantEmails = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantEmails = output.loanApptPersonnelInfo.applicantEmails.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantIDs))
                    {
                        loads.loanApptPersonnelInfo_applicantIDs = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantIDs = output.loanApptPersonnelInfo.applicantIDs.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantNamesCombine))
                    {
                        loads.loanApptPersonnelInfo_applicantNamesCombine = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_applicantNamesCombine = output.loanApptPersonnelInfo.applicantNamesCombine.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.chargorIDs))
                    {
                        loads.loanApptPersonnelInfo_chargorIDs = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_chargorIDs = output.loanApptPersonnelInfo.chargorIDs.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.chargorNames))
                    {
                        loads.loanApptPersonnelInfo_chargorNames = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_chargorNames = output.loanApptPersonnelInfo.chargorNames.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.eStatementFlagInd))
                    {
                        loads.loanApptPersonnelInfo_eStatementFlagInd = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_eStatementFlagInd = output.loanApptPersonnelInfo.eStatementFlagInd.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.guarantorIDs))
                    {
                        loads.loanApptPersonnelInfo_guarantorIDs = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_guarantorIDs = output.loanApptPersonnelInfo.guarantorIDs.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.guarantorNames))
                    {
                        loads.loanApptPersonnelInfo_guarantorNames = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_guarantorNames = output.loanApptPersonnelInfo.guarantorNames.ToString();
                    }

                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.priApplicantName))
                    {
                        loads.loanApptPersonnelInfo_priApplicantName = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_priApplicantName = output.loanApptPersonnelInfo.priApplicantName.ToString();
                    }

                    loads.loanApptPersonnelInfo_priApplicantId = "";
                    // new field primary application id                     
                    
                    if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.priApplicantId))
                    {
                        loads.loanApptPersonnelInfo_priApplicantId = "";
                    }
                    else
                    {
                        loads.loanApptPersonnelInfo_priApplicantId = output.loanApptPersonnelInfo.priApplicantId.ToString();
                    }

                    // end loanApptPersonnelInfo section 
                    

                    // start respInfo section
                    if (string.IsNullOrEmpty(output.respInfo.respCode))
                    {
                        loads.respInfo_respCode = "";
                    }
                    else
                    {
                        loads.respInfo_respCode = output.respInfo.respCode.ToString();
                    }

                    if (string.IsNullOrEmpty(output.respInfo.respDesc))
                    {
                        loads.respInfo_respDesc = "";
                    }
                    else
                    {
                        loads.respInfo_respDesc = output.respInfo.respDesc.ToString();
                    }
                    // end respInfo section

                    list.Add(loads);

                }
                else
                {
                    error = "DP_GetDataFromLOADS failed with message: " + output.respInfo.respDesc.ToString();
                    string errorDetail;
                    errorDetail = "Input Param: " + arn.ToString();
                    //errorDetail = output.respInfo.respCode.ToString() + "," + output.respInfo.respDesc.ToString();
                    LogErrorToDB("DP_GetDataFromLOADS", "Fail", error, errorDetail);

                }
            }
            catch (Exception ex)
            {
                error = "DP_GetDataFromLOADS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn.ToString();
                LogErrorToDB("DP_GetDataFromLOADS", "Exception", error, errorDetail);

                throw ex;
            }

            return list;
        }

        [WebMethod]
        public List<structureLOADS> DP_NewLI_GetDataFromLOADS(string arn)
        {
            string error = "";
            List<structureLOADS> list = new List<structureLOADS>();
            structureLOADS loads = new structureLOADS();
            //try
            //{
            SearchFileResponseData response = new SearchFileResponseData();


            //System.ServiceModel.BasicHttpBinding binding = null;
            //LOADS_API.WsEIWSLosaLoanApplicantInfo proxy = new LOADS_API.WsEIWSLosaLoanApplicantInfo();
            LOADS_API.WsEIWSLosaAppBocImpService client = new LOADS_API.WsEIWSLosaAppBocImpService();
            //LOADS_API.AppHeader xmlAppHeader = new LOADS_API.AppHeader();
            LOADS_API.WsEIWSLosaAppHeader xmlAppHeader = new LOADS_API.WsEIWSLosaAppHeader();

            xmlAppHeader.agencyId = "?";
            xmlAppHeader.bizRefNo = arn;
            xmlAppHeader.businessArea = "?";
            xmlAppHeader.date = "?";
            xmlAppHeader.processId = "?";

            LOADS_API.WsEIWSLosaAppLoanInfo output = client.LoanApplicationInfo(xmlAppHeader);

            /*
            // log the result in db
            DataSet ds = null;
            DataTable dt = null;
            SqlConnection conn = null;
            SqlDataAdapter sqlDA = null;

            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth)
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }
            conn = new SqlConnection(connstr);
            conn.Open();

            sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = new SqlCommand("insert into LOADS_API_LOG values ('" + arn + "', '" + output.respInfo.respCode.ToString() + "', '" + output.respInfo.respDesc.ToString() + "', getdate())", conn);

            ds = new DataSet("ds");
            sqlDA.Fill(ds);
            //dt = ds.Tables[0];

            conn.Close();
            */
            if (output.respInfo.respCode == "00")
            {
                // start collaterals section 
                //collaterals_developerCode
                if (string.IsNullOrEmpty(output.collaterals.developerCode))
                {
                    loads.collaterals_developerCode = "";
                }
                else
                {
                    loads.collaterals_developerCode = output.collaterals.developerCode.ToString();
                }

                //collaterals_buildUpArea
                if (string.IsNullOrEmpty(output.collaterals.buildUpArea.ToString()))
                {
                    loads.collaterals_buildUpArea = "0.00";
                }
                else
                {
                    loads.collaterals_buildUpArea = output.collaterals.buildUpArea.ToString();
                }

                //collaterals_developerName
                if (string.IsNullOrEmpty(output.collaterals.developerName))
                {
                    loads.collaterals_developerName = "";
                }
                else
                {
                    loads.collaterals_developerName = output.collaterals.developerName.ToString();
                }

                //collaterals_financingType
                if (string.IsNullOrEmpty(output.collaterals.financingType))
                {
                    loads.collaterals_financingType = "";
                }
                else
                {
                    loads.collaterals_financingType = output.collaterals.financingType.ToString();
                }

                //collaterals_landArea
                if (string.IsNullOrEmpty(output.collaterals.landArea.ToString()))
                {
                    loads.collaterals_landArea = "0.00";
                }
                else
                {
                    loads.collaterals_landArea = output.collaterals.landArea.ToString();
                }


                //collaterals_projectCode
                if (string.IsNullOrEmpty(output.collaterals.projectCode))
                {
                    loads.collaterals_projectCode = "";
                }
                else
                {
                    loads.collaterals_projectCode = output.collaterals.projectCode.ToString();
                }

                //collaterals_projectName
                if (string.IsNullOrEmpty(output.collaterals.projectName))
                {
                    loads.collaterals_projectName = "";
                }
                else
                {
                    loads.collaterals_projectName = output.collaterals.projectName.ToString();
                }

                //collaterals_propertyAddress
                if (string.IsNullOrEmpty(output.collaterals.propertyAddress))
                {
                    loads.collaterals_propertyAddress = "";
                }
                else
                {
                    loads.collaterals_propertyAddress = output.collaterals.propertyAddress.ToString();
                }

                //collaterals_propertyType
                if (string.IsNullOrEmpty(output.collaterals.propertyType))
                {
                    loads.collaterals_propertyType = "";
                }
                else
                {
                    loads.collaterals_propertyType = output.collaterals.propertyType.ToString();
                }

                //collaterals_requiredValReportInd
                if (string.IsNullOrEmpty(output.collaterals.requiredValReportInd))
                {
                    loads.collaterals_requiredValReportInd = "False";
                }
                else
                {
                    if (output.collaterals.requiredValReportInd.ToString().ToUpper().Trim() == "YES")
                    {
                        loads.collaterals_requiredValReportInd = "True";
                    }
                    else
                    {
                        loads.collaterals_requiredValReportInd = "False";
                    }
                }

                if (string.IsNullOrEmpty(output.collaterals.titleDetails))
                {
                    loads.collaterals_titleDetails = "";
                }
                else
                {
                    loads.collaterals_titleDetails = output.collaterals.titleDetails.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerAccountNbr))
                {
                    loads.collaterals_valuerAccountNbr = "";
                }
                else
                {
                    loads.collaterals_valuerAccountNbr = output.collaterals.valuerAccountNbr.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerAccountType))
                {
                    loads.collaterals_valuerAccountType = "";
                }
                else
                {
                    loads.collaterals_valuerAccountType = output.collaterals.valuerAccountType.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerAddr1))
                {
                    loads.collaterals_valuerAddr1 = "";
                }
                else
                {
                    loads.collaterals_valuerAddr1 = output.collaterals.valuerAddr1.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerAddr2))
                {
                    loads.collaterals_valuerAddr2 = "";
                }
                else
                {
                    loads.collaterals_valuerAddr2 = output.collaterals.valuerAddr2.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerAddr3))
                {
                    loads.collaterals_valuerAddr3 = "";
                }
                else
                {
                    loads.collaterals_valuerAddr3 = output.collaterals.valuerAddr3.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerCity))
                {
                    loads.collaterals_valuerCity = "";
                }
                else
                {
                    loads.collaterals_valuerCity = output.collaterals.valuerCity.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerCode))
                {
                    loads.collaterals_valuerCode = "";
                }
                else
                {
                    loads.collaterals_valuerCode = output.collaterals.valuerCode.ToString();
                }

                // new field valuer fax 
                loads.collaterals_valuerFaxNbr = "";

                if (string.IsNullOrEmpty(output.collaterals.valuerFaxNbr))
                {
                    loads.collaterals_valuerFaxNbr = "";
                }
                else
                {
                    loads.collaterals_valuerFaxNbr = output.collaterals.valuerFaxNbr.ToString();
                }


                // new field valuer phone 
                loads.collaterals_valuerTelNbr = "";

                if (string.IsNullOrEmpty(output.collaterals.valuerTelNbr))
                {
                    loads.collaterals_valuerTelNbr = "";
                }
                else
                {
                    loads.collaterals_valuerTelNbr = output.collaterals.valuerTelNbr.ToString();
                }


                if (string.IsNullOrEmpty(output.collaterals.valuerCountry))
                {
                    loads.collaterals_valuerCountry = "";
                }
                else
                {
                    loads.collaterals_valuerCountry = output.collaterals.valuerCountry.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerEmail))
                {
                    loads.collaterals_valuerEmail = "";
                }
                else
                {
                    loads.collaterals_valuerEmail = output.collaterals.valuerEmail.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerName))
                {
                    loads.collaterals_valuerName = "";
                }
                else
                {
                    loads.collaterals_valuerName = output.collaterals.valuerName.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerPostcode))
                {
                    loads.collaterals_valuerPostcode = "";
                }
                else
                {
                    loads.collaterals_valuerPostcode = output.collaterals.valuerPostcode.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.valuerState))
                {
                    loads.collaterals_valuerState = "";
                }
                else
                {
                    loads.collaterals_valuerState = output.collaterals.valuerState.ToString();
                }

                if (string.IsNullOrEmpty(output.collaterals.verbalIndicativeValue.ToString()))
                {
                    loads.collaterals_verbalIndicativeValue = "0.00";
                }
                else
                {
                    loads.collaterals_verbalIndicativeValue = output.collaterals.verbalIndicativeValue.ToString();
                }
                // end collaterals section 

                // start facilities section 
                if (string.IsNullOrEmpty(output.facilities.disbursementManner))
                {
                    loads.facilities_disbursementManner = "";
                }
                else
                {
                    loads.facilities_disbursementManner = output.facilities.disbursementManner.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.facilityAmount1.ToString()))
                {
                    loads.facilities_facilityAmount1 = "0.00";
                }
                else
                {
                    loads.facilities_facilityAmount1 = output.facilities.facilityAmount1.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.facilityAmount2.ToString()))
                {
                    loads.facilities_facilityAmount2 = "0.00";
                }
                else
                {
                    loads.facilities_facilityAmount2 = output.facilities.facilityAmount2.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.facilityAmount3.ToString()))
                {
                    loads.facilities_facilityAmount3 = "0.00";
                }
                else
                {
                    loads.facilities_facilityAmount3 = output.facilities.facilityAmount3.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.facilityAmount4.ToString()))
                {
                    loads.facilities_facilityAmount4 = "0.00";
                }
                else
                {
                    loads.facilities_facilityAmount4 = output.facilities.facilityAmount4.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.gracePeriod.ToString()))
                {
                    loads.facilities_gracePeriod = "0";
                }
                else
                {
                    loads.facilities_gracePeriod = output.facilities.gracePeriod.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.productName1))
                {
                    loads.facilities_productName1 = "";
                }
                else
                {
                    loads.facilities_productName1 = output.facilities.productName1.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.productName2))
                {
                    loads.facilities_productName2 = "";
                }
                else
                {
                    loads.facilities_productName2 = output.facilities.productName2.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.productName3))
                {
                    loads.facilities_productName3 = "";
                }
                else
                {
                    loads.facilities_productName3 = output.facilities.productName3.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.productName4))
                {
                    loads.facilities_productName4 = "";
                }
                else
                {
                    loads.facilities_productName4 = output.facilities.productName4.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.purposeCode))
                {
                    loads.facilities_purposeCode = "";
                }
                else
                {
                    loads.facilities_purposeCode = output.facilities.purposeCode.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.totFeesAmount.ToString()))
                {
                    loads.facilities_totFeesAmount = "0.00";
                }
                else
                {
                    loads.facilities_totFeesAmount = output.facilities.totFeesAmount.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.totFinancingAmount.ToString()))
                {
                    loads.facilities_totFinancingAmount = "0.00";
                }
                else
                {
                    loads.facilities_totFinancingAmount = output.facilities.totFinancingAmount.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.totFinancingAmountIncFlvm.ToString()))
                {
                    loads.facilities_totFinancingAmountIncFlvm = "0.00";
                }
                else
                {
                    loads.facilities_totFinancingAmountIncFlvm = output.facilities.totFinancingAmountIncFlvm.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.totInsAmount.ToString()))
                {
                    loads.facilities_totInsAmount = "0.00";
                }
                else
                {
                    loads.facilities_totInsAmount = output.facilities.totInsAmount.ToString();
                }

                if (string.IsNullOrEmpty(output.facilities.totValuationFees.ToString()))
                {
                    loads.facilities_totValuationFees = "0.00";
                }
                else
                {
                    loads.facilities_totValuationFees = output.facilities.totValuationFees.ToString();
                }
                // end facilities section 

                // start loanApplicationInfo section 
                if (string.IsNullOrEmpty(output.loanApplicationInfo.appStatus))
                {
                    loads.loanApplicationInfo_appStatus = "";
                }
                else
                {
                    loads.loanApplicationInfo_appStatus = output.loanApplicationInfo.appStatus.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddr1))
                {
                    loads.loanApplicationInfo_branchAddr1 = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddr1 = output.loanApplicationInfo.branchAddr1.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddr2))
                {
                    loads.loanApplicationInfo_branchAddr2 = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddr2 = output.loanApplicationInfo.branchAddr2.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddr3))
                {
                    loads.loanApplicationInfo_branchAddr3 = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddr3 = output.loanApplicationInfo.branchAddr3.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrCity))
                {
                    loads.loanApplicationInfo_branchAddrCity = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddrCity = output.loanApplicationInfo.branchAddrCity.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrCountry))
                {
                    loads.loanApplicationInfo_branchAddrCountry = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddrCountry = output.loanApplicationInfo.branchAddrCountry.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrPostcode))
                {
                    loads.loanApplicationInfo_branchAddrPostcode = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddrPostcode = output.loanApplicationInfo.branchAddrPostcode.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchAddrState))
                {
                    loads.loanApplicationInfo_branchAddrState = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchAddrState = output.loanApplicationInfo.branchAddrState.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchManagerEmail))
                {
                    loads.loanApplicationInfo_branchManagerEmail = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchManagerEmail = output.loanApplicationInfo.branchManagerEmail.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.branchManagerName))
                {
                    loads.loanApplicationInfo_branchManagerName = "";
                }
                else
                {
                    loads.loanApplicationInfo_branchManagerName = output.loanApplicationInfo.branchManagerName.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.closingBranch))
                {
                    loads.loanApplicationInfo_closingBranch = "";
                }
                else
                {
                    loads.loanApplicationInfo_closingBranch = output.loanApplicationInfo.closingBranch.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.lendingType))
                {
                    loads.loanApplicationInfo_lendingType = "";
                }
                else
                {
                    loads.loanApplicationInfo_lendingType = output.loanApplicationInfo.lendingType.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.loAcceptanceDt))
                {
                    loads.loanApplicationInfo_loAcceptanceDt = "";
                }
                else
                {
                    loads.loanApplicationInfo_loAcceptanceDt = DateTime.ParseExact(output.loanApplicationInfo.loAcceptanceDt, "dd/MM/yyyy", null).ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.mortgageCenterCode))
                {
                    loads.loanApplicationInfo_mortgageCenterCode = "";
                }
                else
                {
                    loads.loanApplicationInfo_mortgageCenterCode = output.loanApplicationInfo.mortgageCenterCode.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.mortgageCenterEmail))
                {
                    loads.loanApplicationInfo_mortgageCenterEmail = "";
                }
                else
                {
                    loads.loanApplicationInfo_mortgageCenterEmail = output.loanApplicationInfo.mortgageCenterEmail.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.salesEmail))
                {
                    loads.loanApplicationInfo_salesEmail = "";
                }
                else
                {
                    loads.loanApplicationInfo_salesEmail = output.loanApplicationInfo.salesEmail.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.salesName))
                {
                    loads.loanApplicationInfo_salesName = "";
                }
                else
                {
                    loads.loanApplicationInfo_salesName = output.loanApplicationInfo.salesName.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAccountType))
                {
                    loads.loanApplicationInfo_solicitorAccountType = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorAccountType = output.loanApplicationInfo.solicitorAccountType.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAddr1))
                {
                    loads.loanApplicationInfo_solicitorAddr1 = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorAddr1 = output.loanApplicationInfo.solicitorAddr1.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAddr2))
                {
                    loads.loanApplicationInfo_solicitorAddr2 = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorAddr2 = output.loanApplicationInfo.solicitorAddr2.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorAddr3))
                {
                    loads.loanApplicationInfo_solicitorAddr3 = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorAddr3 = output.loanApplicationInfo.solicitorAddr3.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorCity))
                {
                    loads.loanApplicationInfo_solicitorCity = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorCity = output.loanApplicationInfo.solicitorCity.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorCode))
                {
                    loads.loanApplicationInfo_solicitorCode = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorCode = output.loanApplicationInfo.solicitorCode.ToString();
                }

                // new field solicitor fax
                loads.loanApplicationInfo_solicitorFaxNbr = "";

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorFaxNbr))
                {
                    loads.loanApplicationInfo_solicitorFaxNbr = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorFaxNbr = output.loanApplicationInfo.solicitorFaxNbr.ToString();
                }


                // new field solicitor phone
                loads.loanApplicationInfo_solicitorTelNbr = "";

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorTelNbr))
                {
                    loads.loanApplicationInfo_solicitorTelNbr = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorTelNbr = output.loanApplicationInfo.solicitorTelNbr.ToString();
                }

                /*
                   public string loanApplicationInfo_phaseCode;
                   public string loanApplicationInfo_phaseName;
                   public string loanApplicationInfo_unitParcelNo;
                   public string loanApplicationInfo_spaValue;
                   public string loanApplicationInfo_category;
                   */

                // dev portal new field loanApplicationInfo_phaseCode
                loads.loanApplicationInfo_phaseCode = "";

                if (string.IsNullOrEmpty(output.loanApplicationInfo.phaseCode))
                {
                    loads.loanApplicationInfo_phaseCode = "";
                }
                else
                {
                    loads.loanApplicationInfo_phaseCode = output.loanApplicationInfo.phaseCode.ToString();
                }

                // dev portal new field loanApplicationInfo_phaseName
                loads.loanApplicationInfo_phaseName = "";

                if (string.IsNullOrEmpty(output.loanApplicationInfo.phaseName))
                {
                    loads.loanApplicationInfo_phaseName = "";
                }
                else
                {
                    loads.loanApplicationInfo_phaseName = output.loanApplicationInfo.phaseName.ToString();
                }

                // dev portal new field loanApplicationInfo_unitParcelNo
                loads.loanApplicationInfo_unitParcelNo = "";

                if (string.IsNullOrEmpty(output.loanApplicationInfo.unitParcelNo))
                {
                    loads.loanApplicationInfo_unitParcelNo = "";
                }
                else
                {
                    loads.loanApplicationInfo_unitParcelNo = output.loanApplicationInfo.unitParcelNo.ToString();
                }

                // dev portal new field loanApplicationInfo_unitParcelNo
               // loads.loanApplicationInfo_spaValue = "";
                /*
                if (string.IsNullOrEmpty(output.loanApplicationInfo.spaValue))
                {
                    loads.loanApplicationInfo_spaValue = "0.00";
                }
                else
                {
                    loads.loanApplicationInfo_spaValue = output.loanApplicationInfo.spaValue.ToString();
                }
                */
                if (string.IsNullOrEmpty(output.loanApplicationInfo.spaValue.ToString()))
                {
                    loads.loanApplicationInfo_spaValue = "0.00";
                }
                else
                {
                    loads.loanApplicationInfo_spaValue = output.loanApplicationInfo.spaValue.ToString();
                }

                // dev portal new field loanApplicationInfo_category
                loads.loanApplicationInfo_category = "";

                if (string.IsNullOrEmpty(output.loanApplicationInfo.category))
                {
                    loads.loanApplicationInfo_category = "";
                }
                else
                {
                    loads.loanApplicationInfo_category = output.loanApplicationInfo.category.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorCountry))
                {
                    loads.loanApplicationInfo_solicitorCountry = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorCountry = output.loanApplicationInfo.solicitorCountry.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorEmail))
                {
                    loads.loanApplicationInfo_solicitorEmail = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorEmail = output.loanApplicationInfo.solicitorEmail.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorIntStatus))
                {
                    loads.loanApplicationInfo_solicitorIntStatus = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorIntStatus = output.loanApplicationInfo.solicitorIntStatus.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorNBR))
                {
                    loads.loanApplicationInfo_solicitorNBR = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorNBR = output.loanApplicationInfo.solicitorNBR.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorName))
                {
                    loads.loanApplicationInfo_solicitorName = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorName = output.loanApplicationInfo.solicitorName.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorPostcode))
                {
                    loads.loanApplicationInfo_solicitorPostcode = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorPostcode = output.loanApplicationInfo.solicitorPostcode.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApplicationInfo.solicitorState))
                {
                    loads.loanApplicationInfo_solicitorState = "";
                }
                else
                {
                    loads.loanApplicationInfo_solicitorState = output.loanApplicationInfo.solicitorState.ToString();
                }

                /*
                if (string.IsNullOrEmpty(output.loanApplicationInfo.topupLoanInd))
                {
                    loads.loanApplicationInfo_topupLoanInd = "";
                }
                else
                {
                    loads.loanApplicationInfo_topupLoanInd = output.loanApplicationInfo.topupLoanInd.ToString();
                }                    
                */

                if (string.IsNullOrEmpty(output.loanApplicationInfo.topupLoanInd))
                {
                    loads.loanApplicationInfo_topupLoanInd = "False";
                }
                else
                {
                    if (output.loanApplicationInfo.topupLoanInd.ToString().ToUpper().Trim() == "YES")
                    {
                        loads.loanApplicationInfo_topupLoanInd = "True";
                    }
                    else
                    {
                        loads.loanApplicationInfo_topupLoanInd = "False";
                    }
                }
                // end loanApplicationInfo section 

                // start loanApptPersonnelInfo section
                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddr1))
                {
                    loads.loanApptPersonnelInfo_applicantAddr1 = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddr1 = output.loanApptPersonnelInfo.applicantAddr1.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddr2))
                {
                    loads.loanApptPersonnelInfo_applicantAddr2 = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddr2 = output.loanApptPersonnelInfo.applicantAddr2.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddr3))
                {
                    loads.loanApptPersonnelInfo_applicantAddr3 = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddr3 = output.loanApptPersonnelInfo.applicantAddr3.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrCity))
                {
                    loads.loanApptPersonnelInfo_applicantAddrCity = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddrCity = output.loanApptPersonnelInfo.applicantAddrCity.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrCountry))
                {
                    loads.loanApptPersonnelInfo_applicantAddrCountry = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddrCountry = output.loanApptPersonnelInfo.applicantAddrCountry.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrPostcode))
                {
                    loads.loanApptPersonnelInfo_applicantAddrPostcode = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddrPostcode = output.loanApptPersonnelInfo.applicantAddrPostcode.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantAddrState))
                {
                    loads.loanApptPersonnelInfo_applicantAddrState = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantAddrState = output.loanApptPersonnelInfo.applicantAddrState.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantEmails))
                {
                    loads.loanApptPersonnelInfo_applicantEmails = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantEmails = output.loanApptPersonnelInfo.applicantEmails.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantIDs))
                {
                    loads.loanApptPersonnelInfo_applicantIDs = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantIDs = output.loanApptPersonnelInfo.applicantIDs.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.applicantNamesCombine))
                {
                    loads.loanApptPersonnelInfo_applicantNamesCombine = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_applicantNamesCombine = output.loanApptPersonnelInfo.applicantNamesCombine.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.chargorIDs))
                {
                    loads.loanApptPersonnelInfo_chargorIDs = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_chargorIDs = output.loanApptPersonnelInfo.chargorIDs.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.chargorNames))
                {
                    loads.loanApptPersonnelInfo_chargorNames = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_chargorNames = output.loanApptPersonnelInfo.chargorNames.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.eStatementFlagInd))
                {
                    loads.loanApptPersonnelInfo_eStatementFlagInd = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_eStatementFlagInd = output.loanApptPersonnelInfo.eStatementFlagInd.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.guarantorIDs))
                {
                    loads.loanApptPersonnelInfo_guarantorIDs = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_guarantorIDs = output.loanApptPersonnelInfo.guarantorIDs.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.guarantorNames))
                {
                    loads.loanApptPersonnelInfo_guarantorNames = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_guarantorNames = output.loanApptPersonnelInfo.guarantorNames.ToString();
                }

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.priApplicantName))
                {
                    loads.loanApptPersonnelInfo_priApplicantName = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_priApplicantName = output.loanApptPersonnelInfo.priApplicantName.ToString();
                }

                loads.loanApptPersonnelInfo_priApplicantId = "";
                // new field primary application id                     

                if (string.IsNullOrEmpty(output.loanApptPersonnelInfo.priApplicantId))
                {
                    loads.loanApptPersonnelInfo_priApplicantId = "";
                }
                else
                {
                    loads.loanApptPersonnelInfo_priApplicantId = output.loanApptPersonnelInfo.priApplicantId.ToString();
                }

                // end loanApptPersonnelInfo section 


                // start respInfo section
                if (string.IsNullOrEmpty(output.respInfo.respCode))
                {
                    loads.respInfo_respCode = "";
                }
                else
                {
                    loads.respInfo_respCode = output.respInfo.respCode.ToString();
                }

                if (string.IsNullOrEmpty(output.respInfo.respDesc))
                {
                    loads.respInfo_respDesc = "";
                }
                else
                {
                    loads.respInfo_respDesc = output.respInfo.respDesc.ToString();
                }
                // end respInfo section

                list.Add(loads);

            }
            else
            {
                error = "DP_NewLI_GetDataFromLOADS failed with message: " + output.respInfo.respDesc.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn.ToString();
                //errorDetail = output.respInfo.respCode.ToString() + "," + output.respInfo.respDesc.ToString();
                LogErrorToDB("DP_NewLI_GetDataFromLOADS", "Fail", error, errorDetail);

            }
            /*
            }
            catch (Exception ex)
            {
                error = "DP_NewLI_GetDataFromLOADS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn.ToString();
                LogErrorToDB("DP_NewLI_GetDataFromLOADS", "Exception", error, errorDetail);
            }
            */

            return list;
        }

        // Mortgage-MG API
        [WebMethod]
        public void DP_NewLI(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }


                //sqlcommand1.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                //sqlcommand1.Parameters.AddWithValue("@RESPONSECODE", list[0].respInfo_respCode);
                //sqlcommand1.Parameters.AddWithValue("@RESPONSEDESCRIPTION", list[0].respInfo_respDesc);

                SqlConnection conn0 = null;
                conn0 = new SqlConnection(connstr);
                SqlCommand sqlcommand0 = new SqlCommand("dbo.usp_ws_loads_staging_truncate_staging", conn0);

                conn0.Open();
                int rowsAffected = sqlcommand0.ExecuteNonQuery();
                conn0.Close();

                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.usp_ws_getnewli", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        HLBBWS.AppWS ws = new AppWS();
                        List<HLBBWS.AppWS.structureLOADS> list = new List<HLBBWS.AppWS.structureLOADS>();

                        string DP_GetDataFromLOADS_error = "";

                        list = ws.DP_NewLI_GetDataFromLOADS(dt.Rows[i]["ARN"].ToString());

                        if (list.Count > 0)
                        {
                            if (list[0].respInfo_respCode == "00")
                            {
                                //SqlDataAdapter sqlDA2 = null;
                                //sqlDA2 = new SqlDataAdapter();
                                //sqlDA2.SelectCommand = new SqlCommand("dbo.loads_staging_insert_test", conn);            


                                SqlConnection conn2 = null;
                                conn2 = new SqlConnection(connstr);

                                //SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_loads_staging_insert_test @param_ARN,@RESPONSECODE,@RESPONSEDESCRIPTION", conn2);

                                //SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_ws_loads_staging_insert @ARN  ,	@Status ,	@BranchAddr1 ,	@BranchAddr2  ,	@BranchAddr3  ,	@BranchAddrCity  ,	@BranchAddrCountry ,	@BranchAddrPostCode  ,	@BranchAddrState  ,	@BranchManagerEmailAddress  ,	@BranchManagerName  ,	@ClosingBranch ,	@DateOfLOAcceptance ,	@FinancingType  ,	@MortgateCenterCode  ,	@MortgateCenterEmail ,	@PFSalesEmailAddress ,	@PFCSalesName  ,	@SolicitorAccountNbr  ,	@SolicitorAccountType,	@SolicitorAddr1 ,	@SolicitorAddr2  ,	@SolicitorAddr3 ,	@SolicitorAddrCity  ,	@SolicitorAddrCountry  ,	@SolicitorAddrPostCode  ,	@SolicitorAddrState  ,	@SolicitorEmail  ,	@SolInternalStatus  ,	@SolicitorName  ,	@SolicitorCode  ,	@TopUpLoanIndicator  ,	@ChargorIDNumber ,	@ChargorName  ,	@CustomerAddr1  ,	@CustomerAddr2  ,	@CustomerAddr3  ,	@CustomerAddrCity  ,	@CustomerAddrCountry ,	@CustomerAddrPostCode ,	@CustomerAddrState,	@ApplicantEmail  ,	@CustomerID  ,	@ApplicantName  ,	@CustomerName  ,	@EStatementFlagIndicator ,	@GuarantorIDNumber ,	@GuarantorName ,	@DisbursementManner ,	@LoanAmount  ,	@FacilityAmount1  ,	@FacilityAmount2  ,	@FacilityAmount3  ,	@FacilityAmount4  ,	@FinancingProductName1  ,	@FinancingProductName2  ,	@FinancingProductName3  ,	@FinancingProductName4  ,	@GracePeriod  ,	@LegalFeesFinancedAmount  ,	@MRTAFinancedAmount  ,	@PurposeCode  ,	@TotalFinancingAmount  ,	@ValuationFeesFinancedAmount  ,	@BuildUpArea  ,	@DeveloperCode  ,	@DeveloperName  ,	@CollateralPurpose  ,	@LandArea  ,	@ProjectCode  ,	@ProjectName  ,	@PropertyAddress  ,	@PropertyType  ,	@ValuationRequired  ,	@TitleDetailsLO  ,	@ValuerAccountNBR  ,	@ValuerAccountType,	@ValuerAddr1  ,	@ValuerAddr2 ,	@ValuerAddr3 ,	@ValuerAddrCity  ,	@ValuerAddrCountry  ,	@ValuerAddrPostCode,	@ValuerAddrState,	@ValuerCode ,	@ValuerEmail,	@ValuerName ,	@VerbalIndicativeValue ,	@RESPONSECODE,	@RESPONSEDESCRIPTION", conn2);
                                //SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_ws_loads_staging_insert @ARN  ,	@Status ,	@BranchAddr1 ,	@BranchAddr2  ,	@BranchAddr3  ,	@BranchAddrCity  ,	@BranchAddrCountry ,	@BranchAddrPostCode  ,	@BranchAddrState  ,	@BranchManagerEmailAddress  ,	@BranchManagerName  ,	@ClosingBranch ,	@DateOfLOAcceptance ,	@FinancingType  ,	@MortgateCenterCode  ,	@MortgateCenterEmail ,	@PFSalesEmailAddress ,	@PFCSalesName  ,	@SolicitorAccountNbr  ,	@SolicitorAccountType,	@SolicitorAddr1 ,	@SolicitorAddr2  ,	@SolicitorAddr3 ,	@SolicitorAddrCity  ,	@SolicitorAddrCountry  ,	@SolicitorAddrPostCode  ,	@SolicitorAddrState  ,	@SolicitorEmail  ,	@SolInternalStatus  ,	@SolicitorName  ,	@SolicitorCode  ,	@TopUpLoanIndicator  ,	@ChargorIDNumber ,	@ChargorName  ,	@CustomerAddr1  ,	@CustomerAddr2  ,	@CustomerAddr3  ,	@CustomerAddrCity  ,	@CustomerAddrCountry ,	@CustomerAddrPostCode ,	@CustomerAddrState,	@ApplicantEmail  ,	@CustomerID  ,	@ApplicantName  ,	@CustomerName  ,	@EStatementFlagIndicator ,	@GuarantorIDNumber ,	@GuarantorName ,	@DisbursementManner ,	@LoanAmount  ,	@FacilityAmount1  ,	@FacilityAmount2  ,	@FacilityAmount3  ,	@FacilityAmount4  ,	@FinancingProductName1  ,	@FinancingProductName2  ,	@FinancingProductName3  ,	@FinancingProductName4  ,	@GracePeriod  ,	@LegalFeesFinancedAmount  ,	@MRTAFinancedAmount  ,	@PurposeCode  ,	@TotalFinancingAmount  ,	@ValuationFeesFinancedAmount  ,	@BuildUpArea  ,	@DeveloperCode  ,	@DeveloperName  ,	@CollateralPurpose  ,	@LandArea  ,	@ProjectCode  ,	@ProjectName  ,	@PropertyAddress  ,	@PropertyType  ,	@ValuationRequired  ,	@TitleDetailsLO  ,	@ValuerAccountNBR  ,	@ValuerAccountType,	@ValuerAddr1  ,	@ValuerAddr2 ,	@ValuerAddr3 ,	@ValuerAddrCity  ,	@ValuerAddrCountry  ,	@ValuerAddrPostCode,	@ValuerAddrState,	@ValuerCode ,	@ValuerEmail,	@ValuerName ,	@VerbalIndicativeValue ,	@RESPONSECODE,	@RESPONSEDESCRIPTION, @priApplicantId, @valuerFaxNbr, @valuerTelNbr, @solicitorFaxNbr, @solicitorTelNbr", conn2); 
                                SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_ws_loads_staging_insert @ARN  ,	@Status ,	@BranchAddr1 ,	@BranchAddr2  ,	@BranchAddr3  ,	@BranchAddrCity  ,	@BranchAddrCountry ,	@BranchAddrPostCode  ,	@BranchAddrState  ,	@BranchManagerEmailAddress  ,	@BranchManagerName  ,	@ClosingBranch ,	@DateOfLOAcceptance ,	@FinancingType  ,	@MortgateCenterCode  ,	@MortgateCenterEmail ,	@PFSalesEmailAddress ,	@PFCSalesName  ,	@SolicitorAccountNbr  ,	@SolicitorAccountType,	@SolicitorAddr1 ,	@SolicitorAddr2  ,	@SolicitorAddr3 ,	@SolicitorAddrCity  ,	@SolicitorAddrCountry  ,	@SolicitorAddrPostCode  ,	@SolicitorAddrState  ,	@SolicitorEmail  ,	@SolInternalStatus  ,	@SolicitorName  ,	@SolicitorCode  ,	@TopUpLoanIndicator  ,	@ChargorIDNumber ,	@ChargorName  ,	@CustomerAddr1  ,	@CustomerAddr2  ,	@CustomerAddr3  ,	@CustomerAddrCity  ,	@CustomerAddrCountry ,	@CustomerAddrPostCode ,	@CustomerAddrState,	@ApplicantEmail  ,	@CustomerID  ,	@ApplicantName  ,	@CustomerName  ,	@EStatementFlagIndicator ,	@GuarantorIDNumber ,	@GuarantorName ,	@DisbursementManner ,	@LoanAmount  ,	@FacilityAmount1  ,	@FacilityAmount2  ,	@FacilityAmount3  ,	@FacilityAmount4  ,	@FinancingProductName1  ,	@FinancingProductName2  ,	@FinancingProductName3  ,	@FinancingProductName4  ,	@GracePeriod  ,	@LegalFeesFinancedAmount  ,	@MRTAFinancedAmount  ,	@PurposeCode  ,	@TotalFinancingAmount  ,	@ValuationFeesFinancedAmount  ,	@BuildUpArea  ,	@DeveloperCode  ,	@DeveloperName  ,	@CollateralPurpose  ,	@LandArea  ,	@ProjectCode  ,	@ProjectName  ,	@PropertyAddress  ,	@PropertyType  ,	@ValuationRequired  ,	@TitleDetailsLO  ,	@ValuerAccountNBR  ,	@ValuerAccountType,	@ValuerAddr1  ,	@ValuerAddr2 ,	@ValuerAddr3 ,	@ValuerAddrCity  ,	@ValuerAddrCountry  ,	@ValuerAddrPostCode,	@ValuerAddrState,	@ValuerCode ,	@ValuerEmail,	@ValuerName ,	@VerbalIndicativeValue ,	@RESPONSECODE,	@RESPONSEDESCRIPTION, @priApplicantId, @valuerFaxNbr, @valuerTelNbr, @solicitorFaxNbr, @solicitorTelNbr,@phaseCode,@phaseName ,@unitParcelNo ,@spaValue,@category ", conn2);

                                sqlcommand1.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                                sqlcommand1.Parameters.AddWithValue("@Status", list[0].loanApplicationInfo_appStatus);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddr1", list[0].loanApplicationInfo_branchAddr1);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddr2", list[0].loanApplicationInfo_branchAddr2);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddr3", list[0].loanApplicationInfo_branchAddr3);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrCity", list[0].loanApplicationInfo_branchAddrCity);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrCountry", list[0].loanApplicationInfo_branchAddrCountry);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrPostCode", list[0].loanApplicationInfo_branchAddrPostcode);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrState", list[0].loanApplicationInfo_branchAddrState);
                                sqlcommand1.Parameters.AddWithValue("@BranchManagerEmailAddress", list[0].loanApplicationInfo_branchManagerEmail);
                                sqlcommand1.Parameters.AddWithValue("@BranchManagerName", list[0].loanApplicationInfo_branchManagerName);
                                sqlcommand1.Parameters.AddWithValue("@ClosingBranch", list[0].loanApplicationInfo_closingBranch);
                                sqlcommand1.Parameters.AddWithValue("@DateOfLOAcceptance", list[0].loanApplicationInfo_loAcceptanceDt);

                                // sqlcommand1.Parameters.AddWithValue("@FinancingType", list[0].collaterals_financingType);
                                sqlcommand1.Parameters.AddWithValue("@FinancingType", list[0].loanApplicationInfo_lendingType);
                                sqlcommand1.Parameters.AddWithValue("@MortgateCenterCode", list[0].loanApplicationInfo_mortgageCenterCode);
                                sqlcommand1.Parameters.AddWithValue("@MortgateCenterEmail", list[0].loanApplicationInfo_mortgageCenterEmail);
                                sqlcommand1.Parameters.AddWithValue("@PFSalesEmailAddress", list[0].loanApplicationInfo_salesEmail);
                                sqlcommand1.Parameters.AddWithValue("@PFCSalesName", list[0].loanApplicationInfo_salesName);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAccountNbr", list[0].loanApplicationInfo_solicitorNBR);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAccountType", list[0].loanApplicationInfo_solicitorAccountType);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddr1", list[0].loanApplicationInfo_solicitorAddr1);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddr2", list[0].loanApplicationInfo_solicitorAddr2);
                                //sqlcommand1.Parameters.AddWithValue("@SolicitorAddr3", list[0].loanApptPersonnelInfo_applicantAddr3);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddr3", list[0].loanApplicationInfo_solicitorAddr3);

                                //sqlcommand1.Parameters.AddWithValue("@SolicitorAddrCity", list[0].loanApptPersonnelInfo_applicantAddrCity);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrCity", list[0].loanApplicationInfo_solicitorCity);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrCountry", list[0].loanApplicationInfo_solicitorCountry);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrPostCode", list[0].loanApplicationInfo_solicitorPostcode);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrState", list[0].loanApplicationInfo_solicitorState);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorEmail", list[0].loanApplicationInfo_solicitorEmail);
                                sqlcommand1.Parameters.AddWithValue("@SolInternalStatus", list[0].loanApplicationInfo_solicitorIntStatus);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorName", list[0].loanApplicationInfo_solicitorName);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorCode", list[0].loanApplicationInfo_solicitorCode);
                                sqlcommand1.Parameters.AddWithValue("@TopUpLoanIndicator", list[0].loanApplicationInfo_topupLoanInd);
                                sqlcommand1.Parameters.AddWithValue("@ChargorIDNumber", list[0].loanApptPersonnelInfo_chargorIDs);

                                sqlcommand1.Parameters.AddWithValue("@ChargorName", list[0].loanApptPersonnelInfo_chargorNames);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddr1", list[0].loanApptPersonnelInfo_applicantAddr1);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddr2", list[0].loanApptPersonnelInfo_applicantAddr2);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddr3", list[0].loanApptPersonnelInfo_applicantAddr3);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrCity", list[0].loanApptPersonnelInfo_applicantAddrCity);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrCountry", list[0].loanApptPersonnelInfo_applicantAddrCountry);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrPostCode", list[0].loanApptPersonnelInfo_applicantAddrPostcode);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrState", list[0].loanApptPersonnelInfo_applicantAddrState);
                                sqlcommand1.Parameters.AddWithValue("@ApplicantEmail ", list[0].loanApptPersonnelInfo_applicantEmails);

                                sqlcommand1.Parameters.AddWithValue("@CustomerID", list[0].loanApptPersonnelInfo_applicantIDs);
                                sqlcommand1.Parameters.AddWithValue("@ApplicantName", list[0].loanApptPersonnelInfo_priApplicantName);
                                sqlcommand1.Parameters.AddWithValue("@CustomerName", list[0].loanApptPersonnelInfo_applicantNamesCombine);
                                sqlcommand1.Parameters.AddWithValue("@EStatementFlagIndicator", list[0].loanApptPersonnelInfo_eStatementFlagInd);
                                sqlcommand1.Parameters.AddWithValue("@GuarantorIDNumber", list[0].loanApptPersonnelInfo_guarantorIDs);
                                sqlcommand1.Parameters.AddWithValue("@GuarantorName", list[0].loanApptPersonnelInfo_guarantorNames);
                                sqlcommand1.Parameters.AddWithValue("@DisbursementManner", list[0].facilities_disbursementManner);
                                sqlcommand1.Parameters.AddWithValue("@LoanAmount", list[0].facilities_totFinancingAmount);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount1", list[0].facilities_facilityAmount1);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount2", list[0].facilities_facilityAmount2);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount3", list[0].facilities_facilityAmount3);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount4", list[0].facilities_facilityAmount4);

                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName1", list[0].facilities_productName1);
                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName2", list[0].facilities_productName2);
                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName3", list[0].facilities_productName3);
                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName4", list[0].facilities_productName4);
                                sqlcommand1.Parameters.AddWithValue("@GracePeriod", list[0].facilities_gracePeriod);
                                sqlcommand1.Parameters.AddWithValue("@LegalFeesFinancedAmount", list[0].facilities_totFeesAmount);
                                sqlcommand1.Parameters.AddWithValue("@MRTAFinancedAmount", list[0].facilities_totInsAmount);
                                sqlcommand1.Parameters.AddWithValue("@PurposeCode", list[0].facilities_purposeCode);
                                sqlcommand1.Parameters.AddWithValue("@TotalFinancingAmount", list[0].facilities_totFinancingAmountIncFlvm);
                                sqlcommand1.Parameters.AddWithValue("@ValuationFeesFinancedAmount", list[0].facilities_totValuationFees);
                                sqlcommand1.Parameters.AddWithValue("@BuildUpArea", list[0].collaterals_buildUpArea);
                                sqlcommand1.Parameters.AddWithValue("@DeveloperCode", list[0].collaterals_developerCode);

                                sqlcommand1.Parameters.AddWithValue("@DeveloperName", list[0].collaterals_developerName);
                                sqlcommand1.Parameters.AddWithValue("@CollateralPurpose", list[0].collaterals_financingType);
                                sqlcommand1.Parameters.AddWithValue("@LandArea", list[0].collaterals_landArea);
                                sqlcommand1.Parameters.AddWithValue("@ProjectCode", list[0].collaterals_projectCode);
                                sqlcommand1.Parameters.AddWithValue("@ProjectName", list[0].collaterals_projectName);
                                sqlcommand1.Parameters.AddWithValue("@PropertyAddress", list[0].collaterals_propertyAddress);
                                sqlcommand1.Parameters.AddWithValue("@PropertyType", list[0].collaterals_propertyType);
                                sqlcommand1.Parameters.AddWithValue("@ValuationRequired", list[0].collaterals_requiredValReportInd);
                                sqlcommand1.Parameters.AddWithValue("@TitleDetailsLO", list[0].collaterals_titleDetails);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAccountNBR", list[0].collaterals_valuerAccountNbr);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAccountType", list[0].collaterals_valuerAccountType);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddr1", list[0].collaterals_valuerAddr1);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddr2", list[0].collaterals_valuerAddr2);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddr3", list[0].collaterals_valuerAddr3);

                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrCity", list[0].collaterals_valuerCity);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrCountry", list[0].collaterals_valuerCountry);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrPostCode", list[0].collaterals_valuerPostcode);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrState", list[0].collaterals_valuerState);
                                sqlcommand1.Parameters.AddWithValue("@ValuerCode", list[0].collaterals_valuerCode);
                                sqlcommand1.Parameters.AddWithValue("@ValuerEmail", list[0].collaterals_valuerEmail);
                                sqlcommand1.Parameters.AddWithValue("@ValuerName", list[0].collaterals_valuerName);
                                sqlcommand1.Parameters.AddWithValue("@VerbalIndicativeValue", list[0].collaterals_verbalIndicativeValue);
                                sqlcommand1.Parameters.AddWithValue("@RESPONSECODE", list[0].respInfo_respCode);
                                sqlcommand1.Parameters.AddWithValue("@RESPONSEDESCRIPTION", list[0].respInfo_respDesc);

                                sqlcommand1.Parameters.AddWithValue("@priApplicantId", list[0].loanApptPersonnelInfo_priApplicantId);
                                sqlcommand1.Parameters.AddWithValue("@valuerFaxNbr", list[0].collaterals_valuerFaxNbr);
                                sqlcommand1.Parameters.AddWithValue("@valuerTelNbr", list[0].collaterals_valuerTelNbr);
                                sqlcommand1.Parameters.AddWithValue("@solicitorFaxNbr", list[0].loanApplicationInfo_solicitorFaxNbr);
                                sqlcommand1.Parameters.AddWithValue("@solicitorTelNbr", list[0].loanApplicationInfo_solicitorTelNbr);

                                //dev portal new fields 
                                sqlcommand1.Parameters.AddWithValue("@phaseCode", list[0].loanApplicationInfo_phaseCode);
                                sqlcommand1.Parameters.AddWithValue("@phaseName", list[0].loanApplicationInfo_phaseName);
                                sqlcommand1.Parameters.AddWithValue("@unitParcelNo", list[0].loanApplicationInfo_unitParcelNo);
                                sqlcommand1.Parameters.AddWithValue("@spaValue", list[0].loanApplicationInfo_spaValue);
                                sqlcommand1.Parameters.AddWithValue("@category", list[0].loanApplicationInfo_category);

                                

                                //sqlcommand1.Parameters.Add("@param_ARN", SqlDbType.NVarChar);
                                //sqlcommand1.Parameters["@param_ARN"].Value = dt.Rows[i]["ARN"].ToString();

                                //sqlcommand1.Parameters.Add("@RESPONSECODE", SqlDbType.NVarChar);
                                //sqlcommand1.Parameters["@RESPONSECODE"].Value = list[0].respInfo_respCode.ToString();

                                //sqlcommand1.Parameters.Add("@RESPONSEDESCRIPTION", SqlDbType.NVarChar);
                                //sqlcommand1.Parameters["@RESPONSEDESCRIPTION"].Value = list[0].respInfo_respDesc.ToString();


                                conn2.Open();
                                int rowsAffected2 = sqlcommand1.ExecuteNonQuery();
                                conn2.Close();

                            }
                        }
                    }
                    //sqlcommand2.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                    //sqlcommand1.Parameters.AddWithValue("@RESPONSECODE", list[0].respInfo_respCode);
                    //sqlcommand1.Parameters.AddWithValue("@RESPONSEDESCRIPTION", list[0].respInfo_respDesc);

                    SqlConnection conn3 = null;
                    conn3 = new SqlConnection(connstr);
                    SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_loads_staging_complete", conn3);
                    conn3.Open();
                    int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                    conn3.Close();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                error = "DP_NewLI failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewLI", "Exception", error, errorDetail);


            }
        }

        [WebMethod]
        public void DP_NewLI_Rerun(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }


                //sqlcommand1.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                //sqlcommand1.Parameters.AddWithValue("@RESPONSECODE", list[0].respInfo_respCode);
                //sqlcommand1.Parameters.AddWithValue("@RESPONSEDESCRIPTION", list[0].respInfo_respDesc);

                /*
                SqlConnection conn0 = null;
                conn0 = new SqlConnection(connstr);
                SqlCommand sqlcommand0 = new SqlCommand("dbo.usp_ws_loads_staging_truncate_staging", conn0);

                conn0.Open();
                int rowsAffected = sqlcommand0.ExecuteNonQuery();
                conn0.Close();
                */
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.usp_NewLI_Rerun_GetList", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        HLBBWS.AppWS ws = new AppWS();
                        List<HLBBWS.AppWS.structureLOADS> list = new List<HLBBWS.AppWS.structureLOADS>();

                        string DP_GetDataFromLOADS_error = "";

                        list = ws.DP_NewLI_GetDataFromLOADS(dt.Rows[i]["ARN"].ToString());
                        //list = ws.DP_GetDataFromLOADS(dt.Rows[i]["ARN"].ToString());

                        if (list.Count > 0)
                        {
                            if (list[0].respInfo_respCode == "00")
                            {
                                //SqlDataAdapter sqlDA2 = null;
                                //sqlDA2 = new SqlDataAdapter();
                                //sqlDA2.SelectCommand = new SqlCommand("dbo.loads_staging_insert_test", conn);            


                                SqlConnection conn2 = null;
                                conn2 = new SqlConnection(connstr);

                                //SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_loads_staging_insert_test @param_ARN,@RESPONSECODE,@RESPONSEDESCRIPTION", conn2);

                                //SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_ws_loads_staging_insert @ARN  ,	@Status ,	@BranchAddr1 ,	@BranchAddr2  ,	@BranchAddr3  ,	@BranchAddrCity  ,	@BranchAddrCountry ,	@BranchAddrPostCode  ,	@BranchAddrState  ,	@BranchManagerEmailAddress  ,	@BranchManagerName  ,	@ClosingBranch ,	@DateOfLOAcceptance ,	@FinancingType  ,	@MortgateCenterCode  ,	@MortgateCenterEmail ,	@PFSalesEmailAddress ,	@PFCSalesName  ,	@SolicitorAccountNbr  ,	@SolicitorAccountType,	@SolicitorAddr1 ,	@SolicitorAddr2  ,	@SolicitorAddr3 ,	@SolicitorAddrCity  ,	@SolicitorAddrCountry  ,	@SolicitorAddrPostCode  ,	@SolicitorAddrState  ,	@SolicitorEmail  ,	@SolInternalStatus  ,	@SolicitorName  ,	@SolicitorCode  ,	@TopUpLoanIndicator  ,	@ChargorIDNumber ,	@ChargorName  ,	@CustomerAddr1  ,	@CustomerAddr2  ,	@CustomerAddr3  ,	@CustomerAddrCity  ,	@CustomerAddrCountry ,	@CustomerAddrPostCode ,	@CustomerAddrState,	@ApplicantEmail  ,	@CustomerID  ,	@ApplicantName  ,	@CustomerName  ,	@EStatementFlagIndicator ,	@GuarantorIDNumber ,	@GuarantorName ,	@DisbursementManner ,	@LoanAmount  ,	@FacilityAmount1  ,	@FacilityAmount2  ,	@FacilityAmount3  ,	@FacilityAmount4  ,	@FinancingProductName1  ,	@FinancingProductName2  ,	@FinancingProductName3  ,	@FinancingProductName4  ,	@GracePeriod  ,	@LegalFeesFinancedAmount  ,	@MRTAFinancedAmount  ,	@PurposeCode  ,	@TotalFinancingAmount  ,	@ValuationFeesFinancedAmount  ,	@BuildUpArea  ,	@DeveloperCode  ,	@DeveloperName  ,	@CollateralPurpose  ,	@LandArea  ,	@ProjectCode  ,	@ProjectName  ,	@PropertyAddress  ,	@PropertyType  ,	@ValuationRequired  ,	@TitleDetailsLO  ,	@ValuerAccountNBR  ,	@ValuerAccountType,	@ValuerAddr1  ,	@ValuerAddr2 ,	@ValuerAddr3 ,	@ValuerAddrCity  ,	@ValuerAddrCountry  ,	@ValuerAddrPostCode,	@ValuerAddrState,	@ValuerCode ,	@ValuerEmail,	@ValuerName ,	@VerbalIndicativeValue ,	@RESPONSECODE,	@RESPONSEDESCRIPTION", conn2);
                                //SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_ws_loads_staging_insert2 @ARN  ,	@Status ,	@BranchAddr1 ,	@BranchAddr2  ,	@BranchAddr3  ,	@BranchAddrCity  ,	@BranchAddrCountry ,	@BranchAddrPostCode  ,	@BranchAddrState  ,	@BranchManagerEmailAddress  ,	@BranchManagerName  ,	@ClosingBranch ,	@DateOfLOAcceptance ,	@FinancingType  ,	@MortgateCenterCode  ,	@MortgateCenterEmail ,	@PFSalesEmailAddress ,	@PFCSalesName  ,	@SolicitorAccountNbr  ,	@SolicitorAccountType,	@SolicitorAddr1 ,	@SolicitorAddr2  ,	@SolicitorAddr3 ,	@SolicitorAddrCity  ,	@SolicitorAddrCountry  ,	@SolicitorAddrPostCode  ,	@SolicitorAddrState  ,	@SolicitorEmail  ,	@SolInternalStatus  ,	@SolicitorName  ,	@SolicitorCode  ,	@TopUpLoanIndicator  ,	@ChargorIDNumber ,	@ChargorName  ,	@CustomerAddr1  ,	@CustomerAddr2  ,	@CustomerAddr3  ,	@CustomerAddrCity  ,	@CustomerAddrCountry ,	@CustomerAddrPostCode ,	@CustomerAddrState,	@ApplicantEmail  ,	@CustomerID  ,	@ApplicantName  ,	@CustomerName  ,	@EStatementFlagIndicator ,	@GuarantorIDNumber ,	@GuarantorName ,	@DisbursementManner ,	@LoanAmount  ,	@FacilityAmount1  ,	@FacilityAmount2  ,	@FacilityAmount3  ,	@FacilityAmount4  ,	@FinancingProductName1  ,	@FinancingProductName2  ,	@FinancingProductName3  ,	@FinancingProductName4  ,	@GracePeriod  ,	@LegalFeesFinancedAmount  ,	@MRTAFinancedAmount  ,	@PurposeCode  ,	@TotalFinancingAmount  ,	@ValuationFeesFinancedAmount  ,	@BuildUpArea  ,	@DeveloperCode  ,	@DeveloperName  ,	@CollateralPurpose  ,	@LandArea  ,	@ProjectCode  ,	@ProjectName  ,	@PropertyAddress  ,	@PropertyType  ,	@ValuationRequired  ,	@TitleDetailsLO  ,	@ValuerAccountNBR  ,	@ValuerAccountType,	@ValuerAddr1  ,	@ValuerAddr2 ,	@ValuerAddr3 ,	@ValuerAddrCity  ,	@ValuerAddrCountry  ,	@ValuerAddrPostCode,	@ValuerAddrState,	@ValuerCode ,	@ValuerEmail,	@ValuerName ,	@VerbalIndicativeValue ,	@RESPONSECODE,	@RESPONSEDESCRIPTION, @priApplicantId, @valuerFaxNbr, @valuerTelNbr, @solicitorFaxNbr, @solicitorTelNbr", conn2);
                                SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_ws_loads_staging_insert @ARN  ,	@Status ,	@BranchAddr1 ,	@BranchAddr2  ,	@BranchAddr3  ,	@BranchAddrCity  ,	@BranchAddrCountry ,	@BranchAddrPostCode  ,	@BranchAddrState  ,	@BranchManagerEmailAddress  ,	@BranchManagerName  ,	@ClosingBranch ,	@DateOfLOAcceptance ,	@FinancingType  ,	@MortgateCenterCode  ,	@MortgateCenterEmail ,	@PFSalesEmailAddress ,	@PFCSalesName  ,	@SolicitorAccountNbr  ,	@SolicitorAccountType,	@SolicitorAddr1 ,	@SolicitorAddr2  ,	@SolicitorAddr3 ,	@SolicitorAddrCity  ,	@SolicitorAddrCountry  ,	@SolicitorAddrPostCode  ,	@SolicitorAddrState  ,	@SolicitorEmail  ,	@SolInternalStatus  ,	@SolicitorName  ,	@SolicitorCode  ,	@TopUpLoanIndicator  ,	@ChargorIDNumber ,	@ChargorName  ,	@CustomerAddr1  ,	@CustomerAddr2  ,	@CustomerAddr3  ,	@CustomerAddrCity  ,	@CustomerAddrCountry ,	@CustomerAddrPostCode ,	@CustomerAddrState,	@ApplicantEmail  ,	@CustomerID  ,	@ApplicantName  ,	@CustomerName  ,	@EStatementFlagIndicator ,	@GuarantorIDNumber ,	@GuarantorName ,	@DisbursementManner ,	@LoanAmount  ,	@FacilityAmount1  ,	@FacilityAmount2  ,	@FacilityAmount3  ,	@FacilityAmount4  ,	@FinancingProductName1  ,	@FinancingProductName2  ,	@FinancingProductName3  ,	@FinancingProductName4  ,	@GracePeriod  ,	@LegalFeesFinancedAmount  ,	@MRTAFinancedAmount  ,	@PurposeCode  ,	@TotalFinancingAmount  ,	@ValuationFeesFinancedAmount  ,	@BuildUpArea  ,	@DeveloperCode  ,	@DeveloperName  ,	@CollateralPurpose  ,	@LandArea  ,	@ProjectCode  ,	@ProjectName  ,	@PropertyAddress  ,	@PropertyType  ,	@ValuationRequired  ,	@TitleDetailsLO  ,	@ValuerAccountNBR  ,	@ValuerAccountType,	@ValuerAddr1  ,	@ValuerAddr2 ,	@ValuerAddr3 ,	@ValuerAddrCity  ,	@ValuerAddrCountry  ,	@ValuerAddrPostCode,	@ValuerAddrState,	@ValuerCode ,	@ValuerEmail,	@ValuerName ,	@VerbalIndicativeValue ,	@RESPONSECODE,	@RESPONSEDESCRIPTION, @priApplicantId, @valuerFaxNbr, @valuerTelNbr, @solicitorFaxNbr, @solicitorTelNbr,@phaseCode,@phaseName ,@unitParcelNo ,@spaValue,@category ", conn2);

                                sqlcommand1.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                                sqlcommand1.Parameters.AddWithValue("@Status", list[0].loanApplicationInfo_appStatus);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddr1", list[0].loanApplicationInfo_branchAddr1);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddr2", list[0].loanApplicationInfo_branchAddr2);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddr3", list[0].loanApplicationInfo_branchAddr3);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrCity", list[0].loanApplicationInfo_branchAddrCity);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrCountry", list[0].loanApplicationInfo_branchAddrCountry);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrPostCode", list[0].loanApplicationInfo_branchAddrPostcode);
                                sqlcommand1.Parameters.AddWithValue("@BranchAddrState", list[0].loanApplicationInfo_branchAddrState);
                                sqlcommand1.Parameters.AddWithValue("@BranchManagerEmailAddress", list[0].loanApplicationInfo_branchManagerEmail);
                                sqlcommand1.Parameters.AddWithValue("@BranchManagerName", list[0].loanApplicationInfo_branchManagerName);
                                sqlcommand1.Parameters.AddWithValue("@ClosingBranch", list[0].loanApplicationInfo_closingBranch);
                                sqlcommand1.Parameters.AddWithValue("@DateOfLOAcceptance", list[0].loanApplicationInfo_loAcceptanceDt);

                                // sqlcommand1.Parameters.AddWithValue("@FinancingType", list[0].collaterals_financingType);
                                sqlcommand1.Parameters.AddWithValue("@FinancingType", list[0].loanApplicationInfo_lendingType);
                                sqlcommand1.Parameters.AddWithValue("@MortgateCenterCode", list[0].loanApplicationInfo_mortgageCenterCode);
                                sqlcommand1.Parameters.AddWithValue("@MortgateCenterEmail", list[0].loanApplicationInfo_mortgageCenterEmail);
                                sqlcommand1.Parameters.AddWithValue("@PFSalesEmailAddress", list[0].loanApplicationInfo_salesEmail);
                                sqlcommand1.Parameters.AddWithValue("@PFCSalesName", list[0].loanApplicationInfo_salesName);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAccountNbr", list[0].loanApplicationInfo_solicitorNBR);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAccountType", list[0].loanApplicationInfo_solicitorAccountType);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddr1", list[0].loanApplicationInfo_solicitorAddr1);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddr2", list[0].loanApplicationInfo_solicitorAddr2);
                                //sqlcommand1.Parameters.AddWithValue("@SolicitorAddr3", list[0].loanApptPersonnelInfo_applicantAddr3);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddr3", list[0].loanApplicationInfo_solicitorAddr3);

                                //sqlcommand1.Parameters.AddWithValue("@SolicitorAddrCity", list[0].loanApptPersonnelInfo_applicantAddrCity);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrCity", list[0].loanApplicationInfo_solicitorCity);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrCountry", list[0].loanApplicationInfo_solicitorCountry);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrPostCode", list[0].loanApplicationInfo_solicitorPostcode);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorAddrState", list[0].loanApplicationInfo_solicitorState);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorEmail", list[0].loanApplicationInfo_solicitorEmail);
                                sqlcommand1.Parameters.AddWithValue("@SolInternalStatus", list[0].loanApplicationInfo_solicitorIntStatus);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorName", list[0].loanApplicationInfo_solicitorName);
                                sqlcommand1.Parameters.AddWithValue("@SolicitorCode", list[0].loanApplicationInfo_solicitorCode);
                                sqlcommand1.Parameters.AddWithValue("@TopUpLoanIndicator", list[0].loanApplicationInfo_topupLoanInd);
                                sqlcommand1.Parameters.AddWithValue("@ChargorIDNumber", list[0].loanApptPersonnelInfo_chargorIDs);

                                sqlcommand1.Parameters.AddWithValue("@ChargorName", list[0].loanApptPersonnelInfo_chargorNames);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddr1", list[0].loanApptPersonnelInfo_applicantAddr1);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddr2", list[0].loanApptPersonnelInfo_applicantAddr2);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddr3", list[0].loanApptPersonnelInfo_applicantAddr3);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrCity", list[0].loanApptPersonnelInfo_applicantAddrCity);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrCountry", list[0].loanApptPersonnelInfo_applicantAddrCountry);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrPostCode", list[0].loanApptPersonnelInfo_applicantAddrPostcode);
                                sqlcommand1.Parameters.AddWithValue("@CustomerAddrState", list[0].loanApptPersonnelInfo_applicantAddrState);
                                sqlcommand1.Parameters.AddWithValue("@ApplicantEmail ", list[0].loanApptPersonnelInfo_applicantEmails);

                                sqlcommand1.Parameters.AddWithValue("@CustomerID", list[0].loanApptPersonnelInfo_applicantIDs);
                                sqlcommand1.Parameters.AddWithValue("@ApplicantName", list[0].loanApptPersonnelInfo_priApplicantName);
                                sqlcommand1.Parameters.AddWithValue("@CustomerName", list[0].loanApptPersonnelInfo_applicantNamesCombine);
                                sqlcommand1.Parameters.AddWithValue("@EStatementFlagIndicator", list[0].loanApptPersonnelInfo_eStatementFlagInd);
                                sqlcommand1.Parameters.AddWithValue("@GuarantorIDNumber", list[0].loanApptPersonnelInfo_guarantorIDs);
                                sqlcommand1.Parameters.AddWithValue("@GuarantorName", list[0].loanApptPersonnelInfo_guarantorNames);
                                sqlcommand1.Parameters.AddWithValue("@DisbursementManner", list[0].facilities_disbursementManner);
                                sqlcommand1.Parameters.AddWithValue("@LoanAmount", list[0].facilities_totFinancingAmount);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount1", list[0].facilities_facilityAmount1);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount2", list[0].facilities_facilityAmount2);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount3", list[0].facilities_facilityAmount3);
                                sqlcommand1.Parameters.AddWithValue("@FacilityAmount4", list[0].facilities_facilityAmount4);

                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName1", list[0].facilities_productName1);
                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName2", list[0].facilities_productName2);
                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName3", list[0].facilities_productName3);
                                sqlcommand1.Parameters.AddWithValue("@FinancingProductName4", list[0].facilities_productName4);
                                sqlcommand1.Parameters.AddWithValue("@GracePeriod", list[0].facilities_gracePeriod);
                                sqlcommand1.Parameters.AddWithValue("@LegalFeesFinancedAmount", list[0].facilities_totFeesAmount);
                                sqlcommand1.Parameters.AddWithValue("@MRTAFinancedAmount", list[0].facilities_totInsAmount);
                                sqlcommand1.Parameters.AddWithValue("@PurposeCode", list[0].facilities_purposeCode);
                                sqlcommand1.Parameters.AddWithValue("@TotalFinancingAmount", list[0].facilities_totFinancingAmountIncFlvm);
                                sqlcommand1.Parameters.AddWithValue("@ValuationFeesFinancedAmount", list[0].facilities_totValuationFees);
                                sqlcommand1.Parameters.AddWithValue("@BuildUpArea", list[0].collaterals_buildUpArea);
                                sqlcommand1.Parameters.AddWithValue("@DeveloperCode", list[0].collaterals_developerCode);

                                sqlcommand1.Parameters.AddWithValue("@DeveloperName", list[0].collaterals_developerName);
                                sqlcommand1.Parameters.AddWithValue("@CollateralPurpose", list[0].collaterals_financingType);
                                sqlcommand1.Parameters.AddWithValue("@LandArea", list[0].collaterals_landArea);
                                sqlcommand1.Parameters.AddWithValue("@ProjectCode", list[0].collaterals_projectCode);
                                sqlcommand1.Parameters.AddWithValue("@ProjectName", list[0].collaterals_projectName);
                                sqlcommand1.Parameters.AddWithValue("@PropertyAddress", list[0].collaterals_propertyAddress);
                                sqlcommand1.Parameters.AddWithValue("@PropertyType", list[0].collaterals_propertyType);
                                sqlcommand1.Parameters.AddWithValue("@ValuationRequired", list[0].collaterals_requiredValReportInd);
                                sqlcommand1.Parameters.AddWithValue("@TitleDetailsLO", list[0].collaterals_titleDetails);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAccountNBR", list[0].collaterals_valuerAccountNbr);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAccountType", list[0].collaterals_valuerAccountType);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddr1", list[0].collaterals_valuerAddr1);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddr2", list[0].collaterals_valuerAddr2);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddr3", list[0].collaterals_valuerAddr3);

                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrCity", list[0].collaterals_valuerCity);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrCountry", list[0].collaterals_valuerCountry);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrPostCode", list[0].collaterals_valuerPostcode);
                                sqlcommand1.Parameters.AddWithValue("@ValuerAddrState", list[0].collaterals_valuerState);
                                sqlcommand1.Parameters.AddWithValue("@ValuerCode", list[0].collaterals_valuerCode);
                                sqlcommand1.Parameters.AddWithValue("@ValuerEmail", list[0].collaterals_valuerEmail);
                                sqlcommand1.Parameters.AddWithValue("@ValuerName", list[0].collaterals_valuerName);
                                sqlcommand1.Parameters.AddWithValue("@VerbalIndicativeValue", list[0].collaterals_verbalIndicativeValue);
                                sqlcommand1.Parameters.AddWithValue("@RESPONSECODE", list[0].respInfo_respCode);
                                sqlcommand1.Parameters.AddWithValue("@RESPONSEDESCRIPTION", list[0].respInfo_respDesc);

                                sqlcommand1.Parameters.AddWithValue("@priApplicantId", list[0].loanApptPersonnelInfo_priApplicantId);
                                sqlcommand1.Parameters.AddWithValue("@valuerFaxNbr", list[0].collaterals_valuerFaxNbr);
                                sqlcommand1.Parameters.AddWithValue("@valuerTelNbr", list[0].collaterals_valuerTelNbr);
                                sqlcommand1.Parameters.AddWithValue("@solicitorFaxNbr", list[0].loanApplicationInfo_solicitorFaxNbr);
                                sqlcommand1.Parameters.AddWithValue("@solicitorTelNbr", list[0].loanApplicationInfo_solicitorTelNbr);

                                //dev portal new fields 
                                sqlcommand1.Parameters.AddWithValue("@phaseCode", list[0].loanApplicationInfo_phaseCode);
                                sqlcommand1.Parameters.AddWithValue("@phaseName", list[0].loanApplicationInfo_phaseName);
                                sqlcommand1.Parameters.AddWithValue("@unitParcelNo", list[0].loanApplicationInfo_unitParcelNo);
                                sqlcommand1.Parameters.AddWithValue("@spaValue", list[0].loanApplicationInfo_spaValue);
                                sqlcommand1.Parameters.AddWithValue("@category", list[0].loanApplicationInfo_category);

                                //sqlcommand1.Parameters.Add("@param_ARN", SqlDbType.NVarChar);
                                //sqlcommand1.Parameters["@param_ARN"].Value = dt.Rows[i]["ARN"].ToString();

                                //sqlcommand1.Parameters.Add("@RESPONSECODE", SqlDbType.NVarChar);
                                //sqlcommand1.Parameters["@RESPONSECODE"].Value = list[0].respInfo_respCode.ToString();

                                //sqlcommand1.Parameters.Add("@RESPONSEDESCRIPTION", SqlDbType.NVarChar);
                                //sqlcommand1.Parameters["@RESPONSEDESCRIPTION"].Value = list[0].respInfo_respDesc.ToString();


                                conn2.Open();
                                int rowsAffected2 = sqlcommand1.ExecuteNonQuery();
                                conn2.Close();
                            }
                        }
                    }
                    //sqlcommand2.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                    //sqlcommand1.Parameters.AddWithValue("@RESPONSECODE", list[0].respInfo_respCode);
                    //sqlcommand1.Parameters.AddWithValue("@RESPONSEDESCRIPTION", list[0].respInfo_respDesc);

                    SqlConnection conn3 = null;
                    conn3 = new SqlConnection(connstr);
                    SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_loads_staging_complete2", conn3);
                    conn3.Open();
                    int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                    conn3.Close();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                error = "DP_NewLI_Rerun failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewLI_Rerun", "Exception", error, errorDetail);


            }
        }

        // Mortgage-MG API
        private const int Keysize = 256;

        // Mortgage-MG API
        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;

        // Mortgage-MG API
        [WebMethod]
        public string EncryptText(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        // Mortgage-MG API
        [WebMethod]
        public string DecryptText(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        // Mortgage-MG API
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        // Mortgage-MG API
        [WebMethod]
        public void DP_ExportSolicitorSubmissionOtherDocumentsToEDMS(string solicitorcode, string strProfile, string strFolderName, string strARN, string strDocType, string strCategory, string strIDNumber, string Name, ref string error)
        {
            error = "";
            //ExportFileResponseData response = new ExportFileResponseData();
            DataSet ds = null;
            DataTable dt = null;
            SqlConnection conn = null;
            SqlDataAdapter sqlDA = null;

            //System.ServiceModel.BasicHttpBinding binding = null;
            //EDMS_WSSDK.WSSDKSoapClient client = null;

            try
            {

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_getSolicitorOtherDocumentsFromARN @arn, @solicitorcode", conn);
                //SqlCommand command = new SqlCommand(commandText, connection);
                sqlDA.SelectCommand.Parameters.AddWithValue("@arn", strARN);
                sqlDA.SelectCommand.Parameters.AddWithValue("@solicitorcode", solicitorcode);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];

                conn.Close();

                //Specify the binding to be used for the client.
                //binding = new System.ServiceModel.BasicHttpBinding();
                //client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);
                if (dt.Rows.Count > 0)
                {
                    string outputARN;
                    string outputSolicitorCode;
                    string outputAttachmentID;
                    string outputAttachment;
                    string outputAttachmentName;
                    string outputImage;
                    string outputImageName;
                    string outputCustomerID;
                    string outputCustomerName;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        outputARN = dt.Rows[i]["ARN"].ToString();
                        outputSolicitorCode = dt.Rows[i]["SolicitorCode"].ToString();
                        outputAttachmentID = dt.Rows[i]["AttachmentID"].ToString();
                        outputAttachment = dt.Rows[i]["Attachment"].ToString();
                        outputAttachmentName = dt.Rows[i]["AttachmentName"].ToString();
                        outputImageName = dt.Rows[i]["ImageName"].ToString();
                        outputImage = dt.Rows[i]["Image"].ToString();
                        outputCustomerID = dt.Rows[i]["CustomerID"].ToString();
                        outputCustomerName = dt.Rows[i]["CustomerName"].ToString();
                        string DP_ExportK2FileToEDMS_error = "";
                        ExportFileResponseData response = DP_ExportK2FileToEDMS(strProfile, strFolderName, outputImage, outputImageName, strARN, strDocType, strCategory, strIDNumber, Name, ref DP_ExportK2FileToEDMS_error);

                    }

                }
            }
            catch (Exception ex)
            {
                error = "DP_ExportSolicitorSubmissionOtherDocumentsToEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + solicitorcode.ToString() + "," + strProfile.ToString() + "," + strFolderName.ToString() + "," + strARN.ToString() + "," + strDocType.ToString() + "," + strCategory.ToString() + "," + strIDNumber.ToString() + "," + Name.ToString();
                LogErrorToDB("DP_ExportSolicitorSubmissionOtherDocumentsToEDMS", "Exception", error, errorDetail);
                //clsLog.WriteSystemLog(clsLog.MessageType.Error, "ExportSolicitorSubmissionOtherDocumentsToEDMS()", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            /*
            finally
            {
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                    conn = null;
                }

                ds = null;
                dt = null;
                sqlDA = null;

            }
            */
        }

        [WebMethod]
        public void DP_SaveFile()
        {
            // log the result in db
            DataSet ds = null;
            DataTable dt = null;
            SqlConnection conn = null;
            SqlDataAdapter sqlDA = null;

            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth)
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }


            /*
            SqlConnection conn0 = null;
            conn0 = new SqlConnection(connstr);
            SqlCommand sqlcommand0 = new SqlCommand("dbo.testing_usp_getfilecontent", conn0);

            conn0.Open();
            int rowsAffected = sqlcommand0.ExecuteNonQuery();
            conn0.Close();
            */
            conn = new SqlConnection(connstr);
            conn.Open();

            sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = new SqlCommand("dbo.testing_usp_getfilecontent", conn);

            ds = new DataSet("ds");
            sqlDA.Fill(ds);
            dt = ds.Tables[0];

            string file = dt.Rows[0]["file"].ToString();
            //string filename = "testing.pdf";

            byte[] byteFileContent = null;

            byteFileContent = Convert.FromBase64String(file);

            File.WriteAllBytes(@"c:\temp\testing.pdf", byteFileContent);
        }

        [WebMethod]
        public void DP_NewSolicitor_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }

                if (fireeye_flag == "1")
                {
                    conn = new SqlConnection(connstr);

                    sqlDA = new SqlDataAdapter();
                    sqlDA.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_ListUploadedARN]", conn);

                    string arn;
                    ds = new DataSet("ds");
                    sqlDA.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            arn = dt.Rows[i]["ARN"].ToString();
                            // start validate arn 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr2);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_CheckARN] @ARN", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {
                                /*
                                SqlConnection conn2 = null;
                                conn2 = new SqlConnection(connstr);
                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_SQLSolicitorDPSubmission_SelectAttachments] @ARN", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);

                                //SqlCommand sqlcommand0 = new SqlCommand("dbo.usp_SQLSolicitorDPSubmission_SelectAttachments @ARN", conn1);
                                //sqlcommand0.Parameters.AddWithValue("@ARN", arn);

                                DataSet ds2 = null;
                                DataTable dt2 = null;

                                ds2 = new DataSet("ds");
                                sqlDA2.Fill(ds2);

                                if (ds2.Tables.Count > 0)
                                {
                                    dt2 = ds2.Tables[0];
                                    for (int j = 0; j < dt2.Rows.Count; j++)
                                    {
                                        SqlConnection conn3 = null;
                                        conn3 = new SqlConnection(connstr2);

                                        SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_solicitorattachment_upload @ARN, @attachmentfilename, @attachmentcontent, @attachmentfiletype, @attachmentuploaddate ", conn3);

                                        sqlcommand1.Parameters.AddWithValue("@ARN", arn);
                                        sqlcommand1.Parameters.AddWithValue("@attachmentfilename", dt2.Rows[j]["attachmentfilename"].ToString());
                                        sqlcommand1.Parameters.AddWithValue("@attachmentcontent", dt2.Rows[j]["attachmentcontent"].ToString());
                                        sqlcommand1.Parameters.AddWithValue("@attachmentfiletype", dt2.Rows[j]["attachmentfiletype"].ToString());
                                        sqlcommand1.Parameters.AddWithValue("@attachmentuploaddate", dt2.Rows[j]["attachmentuploaddate"]);

                                        conn3.Open();
                                        int rowsAffected2 = sqlcommand1.ExecuteNonQuery();
                                        conn3.Close();

                                    }
                                }
                                conn2.Close();
                                */
                                SqlConnection conn4 = null;
                                conn4 = new SqlConnection(connstr2);

                                SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_solicitorattachment_create_master_data @ARN ", conn4);
                                sqlcommand2.Parameters.AddWithValue("@ARN", arn);

                                conn4.Open();
                                int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                                conn4.Close();
                            }
                            // end validate arn 
                            conn1.Close();

                        }

                    }
                    conn.Close();
                }
                else
                {
                    // fireeye flag is set to off, directly save attachment to eDMS

                    // start get edms settings 
                    SqlConnection connx = new SqlConnection(connstr);

                    SqlDataAdapter sqlDAx = new SqlDataAdapter();
                    sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Solicitor_Setting] @error output", connx);
                    sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsx = new DataSet("ds");
                    DataTable dtx = null;

                    sqlDAx.Fill(dsx);
                    dtx = dsx.Tables[0];

                    var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                    var ProfileName = dtx.Rows[0]["ProfileName"];
                    var LoginUser = dtx.Rows[0]["LoginUser"];
                    var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                    var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                    var Category = dtx.Rows[0]["Category"];
                    connx.Close();
                    // end get edms settings


                    // start get all arn from staging
                    SqlConnection connALPHA = new SqlConnection(connstr);

                    SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
                    sqlDAALPHA.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_getallARNInStaging]", connALPHA);
                    //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsAPLHA = new DataSet("ds");
                    DataTable dtALPHA = null;

                    sqlDAALPHA.Fill(dsAPLHA);
                    dtALPHA = dsAPLHA.Tables[0];

                    if (dsAPLHA.Tables.Count > 0)
                    {
                        dtALPHA = dsAPLHA.Tables[0];

                        for (int s = 0; s < dtALPHA.Rows.Count; s++)
                        {
                            var arn = dtALPHA.Rows[s]["arn"];

                            // start get customer name and id for the selected arn 
                            SqlConnection conny = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsy = new DataSet("ds");
                            DataTable dty = null;

                            sqlDAy.Fill(dsy);
                            dty = dsy.Tables[0];
                            var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                            if (CustomerID.ToString() == "")
                            {
                                CustomerID = "N/A";
                            }
                            var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                            if (CustomerName.ToString() == "")
                            {
                                CustomerName = "N/A";
                            }
                            conny.Close();
                            // end get customer name and id for the selected arn 

                            // start get attachment detail 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_list_SolicitorDocumentationSubmissionAttachmentInStaging] @ARN", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {
                                dt1 = ds1.Tables[0];

                                for (int j = 0; j < dt1.Rows.Count; j++)
                                {
                                    var filename_original = dt1.Rows[j]["ItemFileName"];
                                    var filename_new = dt1.Rows[j]["ItemFileName"];
                                    var filecontent = dt1.Rows[j]["ItemContent"];
                                    //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                    var filetype = dt1.Rows[j]["ItemFileType"];
                                    // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                    //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                    //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                    //var d_result = dt1.Rows[j]["result"];

                                    string DP_ExportK2FileToEDMS_error = "";
                                    //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                                    ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                }
                            }
                            conn1.Close();
                            // end get attachment detail 

                            // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_Main_MoveToMain] @arn, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                            // start move arn from staging to main 

                            // start delete staging data in temp db 
                            SqlConnection connmeta = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
                            sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", connmeta);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsmeta = new DataSet("ds");
                            //DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAmeta.Fill(dsmeta);
                            connmeta.Close();
                            // start  delete staging data in temp db 
                        }
                    }
                    // end start get all arn in staging 
                }


            }
            catch (Exception ex)
            {
                error = "DP_NewSolicitor_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewSolicitor_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ExportSolicitorDisbSubmissionPDFFormToEDMS(string arn, string status, string pdfid, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                /*
                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }
                */

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_SolicitorDisbursement_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                /*
                // start get all arn from staging
                SqlConnection connALPHA = new SqlConnection(connstr);

                SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
                sqlDAALPHA.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_getallARNInStaging]", connALPHA);
                //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsAPLHA = new DataSet("ds");
                DataTable dtALPHA = null;

                sqlDAALPHA.Fill(dsAPLHA);
                dtALPHA = dsAPLHA.Tables[0];
                */

                // start get customer name and id for the selected arn 
                SqlConnection conny = new SqlConnection(connstr);

                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsy = new DataSet("ds");
                DataTable dty = null;

                sqlDAy.Fill(dsy);
                dty = dsy.Tables[0];
                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                if (CustomerID.ToString() == "")
                {
                    CustomerID = "N/A";
                }
                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                if (CustomerName.ToString() == "")
                {
                    CustomerName = "N/A";
                }
                conny.Close();
                // end get customer name and id for the selected arn 

                // start get attachment detail 
                SqlConnection conn1 = null;
                conn1 = new SqlConnection(connstr);
                SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                DataSet ds1 = null;
                DataTable dt1 = null;

                ds1 = new DataSet("ds");

                sqlDA1.Fill(ds1);

                if (ds1.Tables.Count > 0)
                {
                    dt1 = ds1.Tables[0];

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        var filename_original = dt1.Rows[j]["ItemFileName"];
                        var filename_new = dt1.Rows[j]["ItemFileName"];
                        var filecontent = dt1.Rows[j]["ItemContent"];
                        //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                        var filetype = dt1.Rows[j]["ItemFileType"];
                        // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                        //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                        //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                        //var d_result = dt1.Rows[j]["result"];

                        string DP_ExportK2FileToEDMS_error = "";
                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                        if (status != "UpdateInfo" && status != "Cancelled")
                        {
                            ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                        }                        

                    }
                }
                conn1.Close();
                // end get attachment detail 

                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_updatePDFID] @arn, @pdfID, @WorkflowOperation", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@pdfID", pdfid);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@WorkflowOperation", "DisbursementSolicitorSubmission");

                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 

                // 20210310- start change rules to check attachment count instead of status 

                SqlConnection connMeta = new SqlConnection(connstr2);

                SqlDataAdapter sqlDAMeta = new SqlDataAdapter();
                sqlDAMeta.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_SelectAll @arn", connMeta);
                sqlDAMeta.SelectCommand.Parameters.AddWithValue("@arn", arn);

                DataSet dsMeta = new DataSet("ds");
                dsMeta = new DataSet("ds");
                DataTable dtMeta = null;

                sqlDAMeta.Fill(dsMeta);

                if (dsMeta.Tables.Count > 0)
                {
                    dtMeta = dsMeta.Tables[0];

                    if (dtMeta.Rows.Count == 0)
                    {
                        // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                        SqlConnection connSS = new SqlConnection(connstr);

                        SqlDataAdapter sqlDASS = new SqlDataAdapter();
                        sqlDASS.SelectCommand = new SqlCommand("dbo.[aa_ws_SolDisbursementSubmission_MoveToMain] @arn, @error output", connSS);
                        sqlDASS.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDASS.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet dsSS = new DataSet("ds");
                        //dtz = dsz.Tables[0];
                        sqlDASS.Fill(dsSS);
                        connSS.Close();
                        // start move arn from staging to main 
                    }
                }
                // 20210310- end  change rules to check attachment count instead of status 

                /*
                if (status == "UpdateInfo")
                {

                    // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                    SqlConnection connSS = new SqlConnection(connstr);

                    SqlDataAdapter sqlDASS = new SqlDataAdapter();
                    sqlDASS.SelectCommand = new SqlCommand("dbo.[aa_ws_SolDisbursementSubmission_MoveToMain] @arn, @error output", connSS);
                    sqlDASS.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDASS.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsSS = new DataSet("ds");
                    //dtz = dsz.Tables[0];
                    sqlDASS.Fill(dsSS);
                    connSS.Close();
                    // start move arn from staging to main 
                   
                }
                */
            }
            catch (Exception ex)
            {
                error = "DP_ExportSolicitorDisbSubmissionPDFFormToEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn;
                LogErrorToDB("DP_ExportSolicitorDisbSubmissionPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ProjectSubSubmissionAcknowledgementPDFFormToEDMS(string UserID, string UserName, string IsSubUser, string pdfid, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                // start get attachment detail 

                var filename_original = "";
                var filename_new = "";
                var filecontent = "";
                var filetype = "";

                SqlConnection conn1 = null;
                conn1 = new SqlConnection(connstr);
                SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                DataSet ds1 = null;
                DataTable dt1 = null;

                ds1 = new DataSet("ds");

                sqlDA1.Fill(ds1);

                if (ds1.Tables.Count > 0)
                {
                    dt1 = ds1.Tables[0];

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        filename_original = dt1.Rows[j]["ItemFileName"].ToString();
                        filename_new = dt1.Rows[j]["ItemFileName"].ToString();
                        filecontent = dt1.Rows[j]["ItemContent"].ToString();
                        filetype = dt1.Rows[j]["ItemFileType"].ToString();

                        //string DP_ExportK2FileToEDMS_error = "";

                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                    }
                }
                conn1.Close();
                // end get attachment detail 

                string DP_ExportK2FileToEDMS_error = "";
                string arn = "Acknowledgement";

                string CustomerID = UserID;
                string CustomerName = UserName;

                ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);                

                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_AcknowledgementUpload_SaveRecord @LoginID, @IsSubUser", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@LoginID", UserID);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@IsSubUser", IsSubUser);
                
                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 

              


            }
            catch (Exception ex)
            {
                error = "DP_ProjectSubSubmissionAcknowledgementPDFFormToEDMS failed with exception: " + ex.Message.ToString() ;
                string errorDetail;
                errorDetail = "Input Param: UserID:" + UserID;
                LogErrorToDB("DP_ProjectSubSubmissionAcknowledgementPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ProjectNotificationOfPaymentPDFFormToEDMS(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                // start get master list in staging 
                SqlConnection connMasterList = null;
                connMasterList = new SqlConnection(connstr);
                SqlDataAdapter sqlDAMasterList = new SqlDataAdapter();

                sqlDAMasterList.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_NotificationOfPayment_EDMSList] ", connMasterList);                

                DataSet dsMasterList = null;
                DataTable dtMasterList = null;

                dsMasterList = new DataSet("ds");

                sqlDAMasterList.Fill(dsMasterList);

                if (dsMasterList.Tables.Count > 0)
                {
                    dtMasterList = dsMasterList.Tables[0];

                    for (int j = 0; j < dtMasterList.Rows.Count; j++)
                    {
                        string Devcode = dtMasterList.Rows[j]["Devcode"].ToString();
                        string ProjectCode = dtMasterList.Rows[j]["ProjectCode"].ToString();
                        string PhaseCode = dtMasterList.Rows[j]["PhaseCode"].ToString();
                        DateTime  DisCheckerApprovedDate = Convert.ToDateTime(dtMasterList.Rows[j]["DisCheckerApprovedDate"]);
                        
                        string pdfid = dtMasterList.Rows[j]["pdfid"].ToString();

                        // start get attachment detail 

                        var filename_original = "";
                        var filename_new = "";
                        var filecontent = "";
                        var filetype = "";

                        SqlConnection conn1 = null;
                        conn1 = new SqlConnection(connstr);
                        SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                        sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                        sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                        DataSet ds1 = null;
                        DataTable dt1 = null;

                        ds1 = new DataSet("ds");

                        sqlDA1.Fill(ds1);

                        if (ds1.Tables.Count > 0)
                        {
                            dt1 = ds1.Tables[0];

                            for (int jj = 0; jj < dt1.Rows.Count; jj++)
                            {
                                filename_original = dt1.Rows[jj]["ItemFileName"].ToString();
                                filename_new = dt1.Rows[jj]["ItemFileName"].ToString();
                                filecontent = dt1.Rows[jj]["ItemContent"].ToString();
                                filetype = dt1.Rows[jj]["ItemFileType"].ToString();

                                //string DP_ExportK2FileToEDMS_error = "";

                                //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                            }
                        }
                        conn1.Close();
                        // end get attachment detail 

                        // start get arn 
                        SqlConnection connARNList = null;
                        connARNList = new SqlConnection(connstr);
                        SqlDataAdapter sqlDARNList = new SqlDataAdapter();

                        sqlDARNList.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_NotificationOfPayment_EDMS_ARNList] @DevCode, @ProjectCode, @PhaseCode, @ProcessingDate", connARNList);
                        sqlDARNList.SelectCommand.Parameters.AddWithValue("@DevCode", Devcode);
                        sqlDARNList.SelectCommand.Parameters.AddWithValue("@ProjectCode", ProjectCode);
                        sqlDARNList.SelectCommand.Parameters.AddWithValue("@PhaseCode", PhaseCode);
                        sqlDARNList.SelectCommand.Parameters.AddWithValue("@ProcessingDate", DisCheckerApprovedDate);                        

                        
                        DataSet dsARNList = null;
                        DataTable dtARNList = null;

                        dsARNList = new DataSet("ds");

                        sqlDARNList.Fill(dsARNList);

                        if (dsARNList.Tables.Count > 0)
                        {
                            dtARNList = dsARNList.Tables[0];

                            for (int k = 0; k < dtARNList.Rows.Count; k++)
                            {
                                string arn = dtARNList.Rows[k]["arn"].ToString();

                                // start get customer name and id for the selected arn 
                                SqlConnection conny = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsy = new DataSet("ds");
                                DataTable dty = null;

                                sqlDAy.Fill(dsy);
                                dty = dsy.Tables[0];
                                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                                if (CustomerID.ToString() == "")
                                {
                                    CustomerID = "N/A";
                                }
                                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                                if (CustomerName.ToString() == "")
                                {
                                    CustomerName = "N/A";
                                }
                                conny.Close();

                                string DP_ExportK2FileToEDMS_error = "";

                                ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);


                                //string DP_ExportK2FileToEDMS_error = "";

                                //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                // start move record to completed 
                                
                                SqlConnection connMoveToMain = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAMoveToMain = new SqlDataAdapter();
                                sqlDAMoveToMain.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_NotificationOfPayment_MoveToCompleted @DevCode, @ProjectCode, @PhaseCode, @arn,@ProcessingDate ,@pdfid", connMoveToMain);
                                sqlDAMoveToMain.SelectCommand.Parameters.AddWithValue("@DevCode", Devcode);
                                sqlDAMoveToMain.SelectCommand.Parameters.AddWithValue("@ProjectCode", ProjectCode);
                                sqlDAMoveToMain.SelectCommand.Parameters.AddWithValue("@PhaseCode", PhaseCode);
                                sqlDAMoveToMain.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAMoveToMain.SelectCommand.Parameters.AddWithValue("@ProcessingDate", DisCheckerApprovedDate);
                                sqlDAMoveToMain.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);
                                

                               

                                DataSet dsMoveToMain = new DataSet("ds");
                                //DataTable dtARN = null;

                                sqlDAMoveToMain.Fill(dsMoveToMain);
                                
                                // start move record to completed 
                            }
                        }
                        connARNList.Close();
                        // end get arn 
                        //string DP_ExportK2FileToEDMS_error = "";

                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                        // start enchancement for email to send after edms proces
                        /*
                        @DevCode nvarchar(max) = null ,
                        @ProjectCode nvarchar(max) = null ,
                        @PhaseCode nvarchar(max) = null ,
                        @ProcessingDate datetime = null,
                        @ReceiverEmail nvarchar(max) = null output ,
                        @EmailBody nvarchar(max) = null output ,
                        @EmailHeader nvarchar(max) = null output ,
                        @pdfid bigint = null output ,
                        @DevName nvarchar(max) = null output
                        */

                        SqlConnection connEDMS_EMAIL_PRE = new SqlConnection(connstr);
                        SqlDataAdapter sqlDEDMS_EMAIL_PRE;

                        sqlDEDMS_EMAIL_PRE = new SqlDataAdapter();
                        sqlDEDMS_EMAIL_PRE.SelectCommand = new SqlCommand("dbo.ddProject_NOP_Email_CheckFlag @Flag output", connEDMS_EMAIL_PRE);


                        sqlDEDMS_EMAIL_PRE.SelectCommand.Parameters.Add("@Flag", SqlDbType.Int);
                        sqlDEDMS_EMAIL_PRE.SelectCommand.Parameters["@Flag"].Direction = ParameterDirection.Output;

                        DataSet dsAlpha = new DataSet("ds");
                        sqlDEDMS_EMAIL_PRE.Fill(dsAlpha);

                        int Flag = (int) sqlDEDMS_EMAIL_PRE.SelectCommand.Parameters["@Flag"].Value;

                        if (Flag ==1)
                        {
                            SqlConnection connEDMS_EMAIL = new SqlConnection(connstr);
                            SqlDataAdapter sqlDEDMS_EMAIL;

                            sqlDEDMS_EMAIL = new SqlDataAdapter();
                            sqlDEDMS_EMAIL.SelectCommand = new SqlCommand("dbo.ddProject_NOP_Email_GetRecord @DevCode, @ProjectCode , @PhaseCode, @ProcessingDate,  @ReceiverEmail output,@EmailBody output,@EmailHeader output ,@pdfid output,@DevName output", connEDMS_EMAIL);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters.AddWithValue("DevCode", Devcode);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters.AddWithValue("ProjectCode", ProjectCode);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters.AddWithValue("PhaseCode", PhaseCode);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters.AddWithValue("ProcessingDate", DisCheckerApprovedDate);

                            sqlDEDMS_EMAIL.SelectCommand.Parameters.Add("@ReceiverEmail", SqlDbType.NVarChar, 4000);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters["@ReceiverEmail"].Direction = ParameterDirection.Output;

                            sqlDEDMS_EMAIL.SelectCommand.Parameters.Add("@EmailBody", SqlDbType.NVarChar, 4000);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters["@EmailBody"].Direction = ParameterDirection.Output;

                            sqlDEDMS_EMAIL.SelectCommand.Parameters.Add("@EmailHeader", SqlDbType.NVarChar, 4000);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters["@EmailHeader"].Direction = ParameterDirection.Output;

                            sqlDEDMS_EMAIL.SelectCommand.Parameters.Add("@pdfid", SqlDbType.BigInt);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters["@pdfid"].Direction = ParameterDirection.Output;

                            sqlDEDMS_EMAIL.SelectCommand.Parameters.Add("@DevName", SqlDbType.NVarChar, 4000);
                            sqlDEDMS_EMAIL.SelectCommand.Parameters["@DevName"].Direction = ParameterDirection.Output;

                            //DataSet dsAlpha = new DataSet("ds");
                            sqlDEDMS_EMAIL.Fill(dsAlpha);

                            string ReceiverEmail = sqlDEDMS_EMAIL.SelectCommand.Parameters["@ReceiverEmail"].Value.ToString();
                            string EmailBody = sqlDEDMS_EMAIL.SelectCommand.Parameters["@EmailBody"].Value.ToString();
                            string EmailHeader = sqlDEDMS_EMAIL.SelectCommand.Parameters["@EmailHeader"].Value.ToString();
                            pdfid = sqlDEDMS_EMAIL.SelectCommand.Parameters["@pdfid"].Value.ToString();
                            string DevName = sqlDEDMS_EMAIL.SelectCommand.Parameters["@DevName"].Value.ToString();


                            SqlConnection connEDMS_EMAIL_2 = new SqlConnection(connstr);
                            SqlDataAdapter sqlDEDMS_EMAIL_2;

                            sqlDEDMS_EMAIL_2 = new SqlDataAdapter();
                            sqlDEDMS_EMAIL_2.SelectCommand = new SqlCommand("dbo.usp_getK2PDFFileContent @id", connEDMS_EMAIL_2);
                            sqlDEDMS_EMAIL_2.SelectCommand.Parameters.AddWithValue("id", pdfid);

                            // DataSet dsAlpha = new DataSet("ds");
                            sqlDEDMS_EMAIL_2.Fill(dsAlpha);


                            string filename = dsAlpha.Tables[0].Rows[0]["PDFFileName"].ToString();
                            string file = dsAlpha.Tables[0].Rows[0]["PDF"].ToString();

                            string EncryptedFile = DP_SetDeveloperPortalNotificationOfPaymentPassword(Devcode, DevName, ProjectCode, PhaseCode, file);

                            if (ReceiverEmail != "")
                            {
                                SendMailWFParser_WithAttachment(ReceiverEmail, EmailHeader, EmailBody, EncryptedFile, filename);
                            }
                            

                            SqlConnection connEDMS_EMAIL_LOG = new SqlConnection(connstr);
                            SqlDataAdapter sqlDEDMS_EMAIL_LOG;

                            sqlDEDMS_EMAIL_LOG = new SqlDataAdapter();
                            sqlDEDMS_EMAIL_LOG.SelectCommand = new SqlCommand("dbo.ddProject_NOP_Email_Log @DevCode, @ProjectCode , @PhaseCode, @ProcessingDate", connEDMS_EMAIL);
                            sqlDEDMS_EMAIL_LOG.SelectCommand.Parameters.AddWithValue("DevCode", Devcode);
                            sqlDEDMS_EMAIL_LOG.SelectCommand.Parameters.AddWithValue("ProjectCode", ProjectCode);
                            sqlDEDMS_EMAIL_LOG.SelectCommand.Parameters.AddWithValue("PhaseCode", PhaseCode);
                            sqlDEDMS_EMAIL_LOG.SelectCommand.Parameters.AddWithValue("ProcessingDate", DisCheckerApprovedDate);

                            sqlDEDMS_EMAIL_LOG.Fill(dsAlpha);
                        }
                        


                        // end enchancement for email to send after edms proces


                        // start move EDMS Staging to completed 
                        SqlConnection connMoveToMain2 = new SqlConnection(connstr);

                        SqlDataAdapter sqlDAMoveToMain2 = new SqlDataAdapter();
                        sqlDAMoveToMain2.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_NotificationOfPayment_EDMSStaging_MoveToCompleted @DevCode, @ProjectCode, @PhaseCode, @NotificationDate ", connMoveToMain2);
                        sqlDAMoveToMain2.SelectCommand.Parameters.AddWithValue("@DevCode", Devcode);
                        sqlDAMoveToMain2.SelectCommand.Parameters.AddWithValue("@ProjectCode", ProjectCode);
                        sqlDAMoveToMain2.SelectCommand.Parameters.AddWithValue("@PhaseCode", PhaseCode);
                        sqlDAMoveToMain2.SelectCommand.Parameters.AddWithValue("@NotificationDate", DisCheckerApprovedDate);
                        
                        

                         
                        /*
                        sqlDAARN.SelectCommand.Parameters.Add("@arn", SqlDbType.NVarChar, 4000);
                        sqlDAARN.SelectCommand.Parameters["@arn"].Direction = ParameterDirection.Output;
                        */

                        DataSet dsMoveToMain2 = new DataSet("ds");
                        //DataTable dtARN = null;

                        sqlDAMoveToMain2.Fill(dsMoveToMain2);
                        // start move EDMS Staging to completed 
                    }
                }
                connMasterList.Close();
                // end get master list in staging 

                

                /*
                // start get arn 
                SqlConnection connARN = new SqlConnection(connstr);

                SqlDataAdapter sqlDAARN = new SqlDataAdapter();
                sqlDAARN.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_PDF_GetARNFromRunningID @RejectedRunningID, @arn output", connARN);
                sqlDAARN.SelectCommand.Parameters.AddWithValue("@RejectedRunningID", runningid);
                sqlDAARN.SelectCommand.Parameters.Add("@arn", SqlDbType.NVarChar, 4000);
                sqlDAARN.SelectCommand.Parameters["@arn"].Direction = ParameterDirection.Output;

                DataSet dsARN = new DataSet("ds");
                DataTable dtARN = null;

                sqlDAARN.Fill(dsARN);

                string arn = sqlDAARN.SelectCommand.Parameters["@arn"].Value.ToString();
                */
               
                /*
                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_PDF_UpdatePDFID @RejectedRunningID, @pdfid", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@RejectedRunningID", runningid);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);

                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 
                */



            }
            catch (Exception ex)
            {
                error = "DP_ProjectNotificationOfPaymentPDFFormToEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_ProjectNotificationOfPaymentPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }
        [WebMethod]
        public void DP_ProjectResubmitPDFFormToEDMS(string runningid, string pdfid, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                // start get attachment detail 

                var filename_original = "";
                var filename_new = "";
                var filecontent = "";
                var filetype = "";

                SqlConnection conn1 = null;
                conn1 = new SqlConnection(connstr);
                SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                DataSet ds1 = null;
                DataTable dt1 = null;

                ds1 = new DataSet("ds");

                sqlDA1.Fill(ds1);

                if (ds1.Tables.Count > 0)
                {
                    dt1 = ds1.Tables[0];

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        filename_original = dt1.Rows[j]["ItemFileName"].ToString();
                        filename_new = dt1.Rows[j]["ItemFileName"].ToString();
                        filecontent = dt1.Rows[j]["ItemContent"].ToString();
                        filetype = dt1.Rows[j]["ItemFileType"].ToString();

                        //string DP_ExportK2FileToEDMS_error = "";

                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                    }
                }
                conn1.Close();
                // end get attachment detail 


                // start get arn 
                SqlConnection connARN = new SqlConnection(connstr);

                SqlDataAdapter sqlDAARN = new SqlDataAdapter();
                sqlDAARN.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_PDF_GetARNFromRunningID @RejectedRunningID, @arn output", connARN);
                sqlDAARN.SelectCommand.Parameters.AddWithValue("@RejectedRunningID", runningid);
                sqlDAARN.SelectCommand.Parameters.Add("@arn", SqlDbType.NVarChar, 4000);
                sqlDAARN.SelectCommand.Parameters["@arn"].Direction = ParameterDirection.Output;

                DataSet dsARN = new DataSet("ds");
                DataTable dtARN = null;

                sqlDAARN.Fill(dsARN);

                string arn = sqlDAARN.SelectCommand.Parameters["@arn"].Value.ToString();

                // start get customer name and id for the selected arn 
                SqlConnection conny = new SqlConnection(connstr);

                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsy = new DataSet("ds");
                DataTable dty = null;

                sqlDAy.Fill(dsy);
                dty = dsy.Tables[0];
                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                if (CustomerID.ToString() == "")
                {
                    CustomerID = "N/A";
                }
                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                if (CustomerName.ToString() == "")
                {
                    CustomerName = "N/A";
                }
                conny.Close();

                string DP_ExportK2FileToEDMS_error = "";

                ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);


                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_PDF_UpdatePDFID @RejectedRunningID, @pdfid", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@RejectedRunningID", runningid);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);

                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 

              


            }
            catch (Exception ex)
            {
                error = "DP_ProjectResubmitPDFFormToEDMS failed with exception: " + ex.Message.ToString() ;
                string errorDetail;
                errorDetail = "Input Param: runningid:" + runningid;
                LogErrorToDB("DP_ProjectResubmitPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }
        [WebMethod]
        public void DP_ProjectSubSubmissionPDFFormToEDMS(string draftID,  string pdfid, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                // start get attachment detail 

                var filename_original ="";
                var filename_new = "";
                var filecontent = "";
                var filetype = "";

                SqlConnection conn1 = null;
                conn1 = new SqlConnection(connstr);
                SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                DataSet ds1 = null;
                DataTable dt1 = null;

                ds1 = new DataSet("ds");

                sqlDA1.Fill(ds1);

                if (ds1.Tables.Count > 0)
                {
                    dt1 = ds1.Tables[0];

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                         filename_original = dt1.Rows[j]["ItemFileName"].ToString();
                         filename_new = dt1.Rows[j]["ItemFileName"].ToString();
                         filecontent = dt1.Rows[j]["ItemContent"].ToString();
                         filetype = dt1.Rows[j]["ItemFileType"].ToString();

                        //string DP_ExportK2FileToEDMS_error = "";

                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                    }
                }
                conn1.Close();
                // end get attachment detail 


                // start get arn 
                SqlConnection connARN = new SqlConnection(connstr);

                SqlDataAdapter sqlDAARN = new SqlDataAdapter();
                sqlDAARN.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_ws_PDF_GetARN @draftID", connARN);
                sqlDAARN.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                

                DataSet dsARN = new DataSet("ds");
                DataTable dtARN = null;

                sqlDAARN.Fill(dsARN);

                if (dsARN.Tables.Count > 0)
                {
                    dtARN = dsARN.Tables[0];

                    for (int j = 0; j < dtARN.Rows.Count; j++)
                    {
                        string arn = dtARN.Rows[j]["ARN"].ToString();

                        // start get customer name and id for the selected arn 
                        SqlConnection conny = new SqlConnection(connstr);

                        SqlDataAdapter sqlDAy = new SqlDataAdapter();
                        sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                        sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet dsy = new DataSet("ds");
                        DataTable dty = null;

                        sqlDAy.Fill(dsy);
                        dty = dsy.Tables[0];
                        var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                        if (CustomerID.ToString() == "")
                        {
                            CustomerID = "N/A";
                        }
                        var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                        if (CustomerName.ToString() == "")
                        {
                            CustomerName = "N/A";
                        }
                        conny.Close();

                        string DP_ExportK2FileToEDMS_error = "";

                        ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                    }
                }
               
                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_updatePDFID_ProjectSubmission] @draftID, @pdfID", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@draftID", draftID);                
                sqlDAz.SelectCommand.Parameters.AddWithValue("@pdfID", pdfid);                

                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 

                /*
                // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                SqlConnection connSS = new SqlConnection(connstr);

                SqlDataAdapter sqlDASS = new SqlDataAdapter();
                sqlDASS.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_MoveToMain] @draftID, @error output", connSS);
                sqlDASS.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                //sqlDASS.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDASS.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsSS = new DataSet("ds");
                //dtz = dsz.Tables[0];
                sqlDASS.Fill(dsSS);
                connSS.Close();
                // start move arn from staging to main 
                */
                /*
                SqlConnection connMeta = new SqlConnection(connstr2);

                SqlDataAdapter sqlDAMeta = new SqlDataAdapter();
                sqlDAMeta.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Attachment_CountBySubmission @draftID, @arn, @attachmentcount output", connMeta);
                sqlDAMeta.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                sqlDAMeta.SelectCommand.Parameters.AddWithValue("@arn", arn);

                sqlDAMeta.SelectCommand.Parameters.Add("@attachmentcount", SqlDbType.Int);
                sqlDAMeta.SelectCommand.Parameters["@attachmentcount"].Direction = ParameterDirection.Output;

                DataSet dsMeta = new DataSet("ds");
                dsMeta = new DataSet("ds");
                DataTable dtMeta = null;

                sqlDAMeta.Fill(dsMeta);

                int attachmentcount = Convert.ToInt32(sqlDAMeta.SelectCommand.Parameters["@attachmentcount"].Value.ToString());

                if (attachmentcount == 0)
                {
                    dtMeta = dsMeta.Tables[0];

                    if (dtMeta.Rows.Count == 0)
                    {
                        // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                        SqlConnection connSS = new SqlConnection(connstr);

                        SqlDataAdapter sqlDASS = new SqlDataAdapter();
                        sqlDASS.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_MoveToMain] @billingid, @arn, @error output", connSS);
                        sqlDASS.SelectCommand.Parameters.AddWithValue("@billingID", BillingID);
                        sqlDASS.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDASS.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet dsSS = new DataSet("ds");
                        //dtz = dsz.Tables[0];
                        sqlDASS.Fill(dsSS);
                        connSS.Close();
                        // start move arn from staging to main 
                    }
                }
                */


            }
            catch (Exception ex)
            {
                error = "DP_ProjectSubSubmissionPDFFormToEDMS failed with exception: " + ex.Message.ToString() + "draftID=" + draftID.ToString();
                string errorDetail;
                errorDetail = "Input Param: draftID:" + draftID;
                LogErrorToDB("DP_ProjectSubSubmissionPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ProjectSubSubmissionSaveAttachment(string draftID, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // start get data 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_GetAttachmentDetailFromStaging] @draftID, @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                
                if (dsx.Tables.Count > 0)
                {
                    dtx = dsx.Tables[0];

                    for (int j = 0; j < dtx.Rows.Count; j++)
                    {
                        var DraftID = dtx.Rows[j]["DraftID"];
                        var arn = dtx.Rows[j]["arn"];
                        var CancelLoan_File = dtx.Rows[j]["CancelLoan_File"];

                        // start save attachment
                        SqlConnection conn2 = new SqlConnection(connstr2);

                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                        sqlDA2.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_SaveAttachment] @draftID , @arn, @attachment", conn2);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@draftID", DraftID);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@attachment", CancelLoan_File);

                        DataSet ds2 = new DataSet("ds");
                        DataTable dt2 = null;

                        sqlDA2.Fill(ds2);
                        // end save attachment 
                    }
                }
                                     
                connx.Close();
                // end get data 

            }
            catch (Exception ex)
            {
                error = "DP_ProjectSubSubmissionSaveAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_ProjectSubSubmissionSaveAttachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ExportSolicitorDocSubmissionPDFFormToEDMS(string arn, string status, string pdfid, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                /*
                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }
                */

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Solicitor_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                /*
                // start get all arn from staging
                SqlConnection connALPHA = new SqlConnection(connstr);

                SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
                sqlDAALPHA.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_getallARNInStaging]", connALPHA);
                //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsAPLHA = new DataSet("ds");
                DataTable dtALPHA = null;

                sqlDAALPHA.Fill(dsAPLHA);
                dtALPHA = dsAPLHA.Tables[0];
                */

                // start get customer name and id for the selected arn 
                SqlConnection conny = new SqlConnection(connstr);

                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsy = new DataSet("ds");
                DataTable dty = null;

                sqlDAy.Fill(dsy);
                dty = dsy.Tables[0];
                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                if (CustomerID.ToString() == "")
                {
                    CustomerID = "N/A";
                }
                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                if (CustomerName.ToString() == "")
                {
                    CustomerName = "N/A";
                }
                conny.Close();
                // end get customer name and id for the selected arn 

                // start get attachment detail 
                SqlConnection conn1 = null;
                conn1 = new SqlConnection(connstr);
                SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                DataSet ds1 = null;
                DataTable dt1 = null;

                ds1 = new DataSet("ds");

                sqlDA1.Fill(ds1);

                if (ds1.Tables.Count > 0)
                {
                    dt1 = ds1.Tables[0];

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        var filename_original = dt1.Rows[j]["ItemFileName"];
                        var filename_new = dt1.Rows[j]["ItemFileName"];
                        var filecontent = dt1.Rows[j]["ItemContent"];
                        //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                        var filetype = dt1.Rows[j]["ItemFileType"];
                        // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                        //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                        //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                        //var d_result = dt1.Rows[j]["result"];

                        string DP_ExportK2FileToEDMS_error = "";
                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                        ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                    }
                }
                conn1.Close();
                // end get attachment detail 

                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_updatePDFID] @arn, @pdfID, @WorkflowOperation", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@pdfID", pdfid);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@WorkflowOperation", "DPSolicitorSubmission");

                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 

                if (status == "UpdateInfo")
                {

                    // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                    SqlConnection connSS = new SqlConnection(connstr);

                    SqlDataAdapter sqlDASS = new SqlDataAdapter();
                    sqlDASS.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_Main_MoveToMain] @arn, @error output", connSS);
                    sqlDASS.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDASS.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsSS = new DataSet("ds");
                    //dtz = dsz.Tables[0];
                    sqlDASS.Fill(dsSS);
                    connSS.Close();
                    // start move arn from staging to main 
                    /*
                    // start delete K2DBSERVER.K2.dbo.PdfFile 
                    SqlConnection connmeta = new SqlConnection(connstr);

                   SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
                   sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_DeleteK2File] @pdfid, @error output", connmeta);
                   sqlDAmeta.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);                  

                   DataSet dsmeta = new DataSet("ds");
                   //DataTable dtz = null;
                   //dtz = dsz.Tables[0];
                   sqlDAmeta.Fill(dsmeta);
                   connmeta.Close();
                    // start  delete K2DBSERVER.K2.dbo.PdfFile
                    */
                }
            }
            catch (Exception ex)
            {
                error = "DP_ExportSolicitorDocSubmissionPDFFormToEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn;
                LogErrorToDB("DP_ExportSolicitorDocSubmissionPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ExportValuerDocSubmissionPDFFormToEDMS(string arn, string status, string pdfid, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                /*
                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }
                */

                // start get edms settings 
                SqlConnection connx = new SqlConnection(connstr);

                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Valuer_Setting] @error output", connx);
                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsx = new DataSet("ds");
                DataTable dtx = null;

                sqlDAx.Fill(dsx);
                dtx = dsx.Tables[0];

                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                var ProfileName = dtx.Rows[0]["ProfileName"];
                var LoginUser = dtx.Rows[0]["LoginUser"];
                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                var Category = dtx.Rows[0]["Category"];
                connx.Close();
                // end get edms settings

                /*
                // start get all arn from staging
                SqlConnection connALPHA = new SqlConnection(connstr);

                SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
                sqlDAALPHA.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_getallARNInStaging]", connALPHA);
                //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsAPLHA = new DataSet("ds");
                DataTable dtALPHA = null;

                sqlDAALPHA.Fill(dsAPLHA);
                dtALPHA = dsAPLHA.Tables[0];
                */

                // start get customer name and id for the selected arn 
                SqlConnection conny = new SqlConnection(connstr);

                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                DataSet dsy = new DataSet("ds");
                DataTable dty = null;

                sqlDAy.Fill(dsy);
                dty = dsy.Tables[0];
                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                if (CustomerID.ToString() == "")
                {
                    CustomerID = "N/A";
                }
                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                if (CustomerName.ToString() == "")
                {
                    CustomerName = "N/A";
                }
                conny.Close();
                // end get customer name and id for the selected arn 

                // start get attachment detail 
                SqlConnection conn1 = null;
                conn1 = new SqlConnection(connstr);
                SqlDataAdapter sqlDA1 = new SqlDataAdapter();

                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_select_SolicitorDocumentationSubmissionPFDFFormData] @pdfid", conn1);
                sqlDA1.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);


                DataSet ds1 = null;
                DataTable dt1 = null;

                ds1 = new DataSet("ds");

                sqlDA1.Fill(ds1);

                if (ds1.Tables.Count > 0)
                {
                    dt1 = ds1.Tables[0];

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        var filename_original = dt1.Rows[j]["ItemFileName"];
                        var filename_new = dt1.Rows[j]["ItemFileName"];
                        var filecontent = dt1.Rows[j]["ItemContent"];
                        //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                        var filetype = dt1.Rows[j]["ItemFileType"];
                        // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                        //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                        //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                        //var d_result = dt1.Rows[j]["result"];

                        string DP_ExportK2FileToEDMS_error = "";
                        //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                        ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                    }
                }
                conn1.Close();
                // end get attachment detail 

                // start update pdf id                 
                SqlConnection connz = new SqlConnection(connstr);

                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_updatePDFID] @arn, @pdfID, @WorkflowOperation", connz);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@pdfID", pdfid);
                sqlDAz.SelectCommand.Parameters.AddWithValue("@WorkflowOperation", "DPValuerSubmission");

                DataSet dsz = new DataSet("ds");
                DataTable dtz = null;
                sqlDAz.Fill(dsz);
                connz.Close();
                // end update pdf id 

                if (status == "UpdateInfo" || status == "LowerOMV" || status == "Cancelled")
                {

                    // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                    SqlConnection connSS = new SqlConnection(connstr);

                    SqlDataAdapter sqlDASS = new SqlDataAdapter();
                    sqlDASS.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLValuerDPSubmission_Main_MoveToMain] @arn, @error output", connSS);
                    sqlDASS.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDASS.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsSS = new DataSet("ds");
                    //dtz = dsz.Tables[0];
                    sqlDASS.Fill(dsSS);
                    connSS.Close();
                    // start move arn from staging to main 
                    /*
                    // start delete K2DBSERVER.K2.dbo.PdfFile 
                    SqlConnection connmeta = new SqlConnection(connstr);

                   SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
                   sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_DeleteK2File] @pdfid, @error output", connmeta);
                   sqlDAmeta.SelectCommand.Parameters.AddWithValue("@pdfid", pdfid);                  

                   DataSet dsmeta = new DataSet("ds");
                   //DataTable dtz = null;
                   //dtz = dsz.Tables[0];
                   sqlDAmeta.Fill(dsmeta);
                   connmeta.Close();
                    // start  delete K2DBSERVER.K2.dbo.PdfFile
                    */
                }
            }
            catch (Exception ex)
            {
                error = "DP_ExportValuerDocSubmissionPDFFormToEDMS failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn;
                LogErrorToDB("DP_ExportValuerDocSubmissionPDFFormToEDMS", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_NewSolicitorDisbursement_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }

                if (fireeye_flag == "1")
                {
                    conn = new SqlConnection(connstr);

                    sqlDA = new SqlDataAdapter();
                    sqlDA.SelectCommand = new SqlCommand("dbo.[aa_ws_SolicitorDisbursementSubmission_ListUploadedARN]", conn);

                    string arn;
                    ds = new DataSet("ds");
                    sqlDA.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            arn = dt.Rows[i]["ARN"].ToString();
                            // start validate arn 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr2);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[aa_ws_SolicitorDisbursementSubmission_CheckARN] @ARN", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {

                                SqlConnection conn4 = null;
                                conn4 = new SqlConnection(connstr2);

                                SqlCommand sqlcommand2 = new SqlCommand("dbo.aa_ws_solicitorDisbursementAttachment_create_master_data @ARN ", conn4);
                                sqlcommand2.Parameters.AddWithValue("@ARN", arn);

                                conn4.Open();
                                int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                                conn4.Close();
                            }
                            // end validate arn 
                            conn1.Close();
                        }
                    }
                    conn.Close();
                }
                else
                {
                    // fireeye flag is set to off, directly save attachment to eDMS

                    // start get edms settings 
                    SqlConnection connx = new SqlConnection(connstr);

                    SqlDataAdapter sqlDAx = new SqlDataAdapter();
                    sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_SolicitorDisbursement_Setting] @error output", connx);
                    sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsx = new DataSet("ds");
                    DataTable dtx = null;

                    sqlDAx.Fill(dsx);
                    dtx = dsx.Tables[0];

                    var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                    var ProfileName = dtx.Rows[0]["ProfileName"];
                    var LoginUser = dtx.Rows[0]["LoginUser"];
                    var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                    var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                    var Category = dtx.Rows[0]["Category"];
                    connx.Close();
                    // end get edms settings

                    // start get all arn from staging
                    SqlConnection connALPHA = new SqlConnection(connstr);

                    SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
                    sqlDAALPHA.SelectCommand = new SqlCommand("dbo.aa_ws_SolicitorDisbursementSubmission_getallARNInStaging", connALPHA);
                    //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsAPLHA = new DataSet("ds");
                    DataTable dtALPHA = null;

                    sqlDAALPHA.Fill(dsAPLHA);
                    dtALPHA = dsAPLHA.Tables[0];

                    if (dsAPLHA.Tables.Count > 0)
                    {
                        dtALPHA = dsAPLHA.Tables[0];

                        for (int s = 0; s < dtALPHA.Rows.Count; s++)
                        {
                            var arn = dtALPHA.Rows[s]["arn"];

                            // start get customer name and id for the selected arn 
                            SqlConnection conny = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsy = new DataSet("ds");
                            DataTable dty = null;

                            sqlDAy.Fill(dsy);
                            dty = dsy.Tables[0];
                            var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                            if (CustomerID.ToString() == "")
                            {
                                CustomerID = "N/A";
                            }
                            var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                            if (CustomerName.ToString() == "")
                            {
                                CustomerName = "N/A";
                            }
                            conny.Close();
                            // end get customer name and id for the selected arn 

                            // start get attachment detail 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            //sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_list_SolicitorSubmissionAttachmentInStaging] @ARN, @error output", conn1);
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[aa_ws_list_SolicitorDisbursementSubmissionAttachmentInStaging] @ARN", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            //sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {
                                dt1 = ds1.Tables[0];

                                for (int j = 0; j < dt1.Rows.Count; j++)
                                {
                                    var filename_original = dt1.Rows[j]["ItemFileName"];
                                    var filename_new = dt1.Rows[j]["ItemFileName"];
                                    var filecontent = dt1.Rows[j]["ItemContent"];
                                    //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                    var filetype = dt1.Rows[j]["ItemFileType"];
                                    // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                    //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                    //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                    //var d_result = dt1.Rows[j]["result"];

                                    string DP_ExportK2FileToEDMS_error = "";
                                    //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                                    ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                }
                            }
                            conn1.Close();
                            // end get attachment detail 

                            // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[aa_ws_SolDisbursementSubmission_MoveToMain] @arn, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                            // start move arn from staging to main 

                            // start delete staging data in temp db 
                            SqlConnection connmeta = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
                            sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", connmeta);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@workflow", "DisbursementSolicitorSubmission");
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsmeta = new DataSet("ds");
                            //DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAmeta.Fill(dsmeta);
                            connmeta.Close();
                            // start  delete staging data in temp db                             

                            DP_DeleteSolicitorDisbursement_Attachment(arn.ToString(), ref error);
                        }
                    }
                    // end start get all arn in staging 
                }


            }
            catch (Exception ex)
            {
                error = "DP_NewSolicitorDisbursement_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewSolicitorDisbursement_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_NewProjectDisbursement_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // get fireeye setting 
                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }

                // get available draftID
                /*
                SqlConnection conn_ForDraft = null;
                SqlDataAdapter sqlDA_ForDraft = null;

                conn_ForDraft = new SqlConnection(connstr);

                sqlDA_ForDraft = new SqlDataAdapter();
                sqlDA_ForDraft.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_ws_av_GetDraft @DraftCount output, @DraftID output, @error output ", conn_ForDraft);
                
                sqlDA_ForDraft.SelectCommand.Parameters.Add("@DraftCount", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@DraftCount"].Direction = ParameterDirection.Output;

                sqlDA_ForDraft.SelectCommand.Parameters.Add("@DraftID", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@DraftID"].Direction = ParameterDirection.Output;

                sqlDA_ForDraft.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet ds_ForDraft = new DataSet("ds");
                sqlDA_ForDraft.Fill(ds_ForDraft);

                int draftCount = Int32.Parse(sqlDA_ForDraft.SelectCommand.Parameters["@DraftCount"].Value.ToString());
                string draftID = sqlDA_ForDraft.SelectCommand.Parameters["@DraftID"].Value.ToString();
                */

                // get draft list
                SqlConnection conn_ForDraftList = null;
                SqlDataAdapter sqlDA_ForDraftList = null;

                conn_ForDraftList = new SqlConnection(connstr);

                sqlDA_ForDraftList = new SqlDataAdapter();
                sqlDA_ForDraftList.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_ws_av_GetDraftList", conn_ForDraftList);
                //sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@DraftID", draftID);
                //sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@arn", arn);

                DataSet ds_ForDraftList = new DataSet("ds");
                sqlDA_ForDraftList.Fill(ds_ForDraftList);               

                if (ds_ForDraftList.Tables.Count > 0)
                {
                    DataTable dt_ForDraftList = ds_ForDraftList.Tables[0];
                    for (int ll = 0; ll < dt_ForDraftList.Rows.Count; ll++)
                    {
                        string draftID = dt_ForDraftList.Rows[ll]["draftID"].ToString();

                        // get unique arn by draftid                    
                        SqlConnection conn_ForARNList = null;
                        SqlDataAdapter sqlDA_ForARNList = null;

                        conn_ForARNList = new SqlConnection(connstr);

                        sqlDA_ForARNList = new SqlDataAdapter();
                        sqlDA_ForARNList.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_ws_av_GetARNList_ByDraft @DraftID", conn_ForARNList);
                        sqlDA_ForARNList.SelectCommand.Parameters.AddWithValue("@DraftID", draftID);

                        DataSet ds_ForARNList = new DataSet("ds");
                        sqlDA_ForARNList.Fill(ds_ForARNList);

                        //int attachmentcount = 0;

                        // get attachment list and save attachment to attachment staging 
                        if (ds_ForARNList.Tables.Count > 0)
                        {
                            DataTable dt_ForARNList = ds_ForARNList.Tables[0];
                            for (int i = 0; i < dt_ForARNList.Rows.Count; i++)
                            {
                                //string arn =
                                string arn = dt_ForARNList.Rows[i]["ARN"].ToString();

                                // get attachment list
                                SqlConnection conn_ForAttachmentList = null;
                                SqlDataAdapter sqlDA_ForAttachmentList = null;

                                conn_ForAttachmentList = new SqlConnection(connstr);

                                sqlDA_ForAttachmentList = new SqlDataAdapter();
                                sqlDA_ForAttachmentList.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_ws_av_GetAttachmentListFromDraftID @DraftID, @arn", conn_ForAttachmentList);
                                sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@DraftID", draftID);
                                sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@arn", arn);

                                DataSet ds_ForAttachmentList = new DataSet("ds");
                                sqlDA_ForAttachmentList.Fill(ds_ForAttachmentList);

                                int attachmentcount = 0;

                                if (ds_ForAttachmentList.Tables.Count > 0)
                                {
                                    DataTable dt_ForAttachmentList = ds_ForAttachmentList.Tables[0];
                                    for (int ii = 0; ii < dt_ForAttachmentList.Rows.Count; ii++)
                                    {
                                        attachmentcount += 1;

                                        //string DraftID = dt_ForAttachmentList.Rows[i]["DraftID"].ToString();
                                        //string arn = dt_ForAttachmentList.Rows[i]["ARN"].ToString();
                                        string AttachmentID = dt_ForAttachmentList.Rows[ii]["AttachmentID"].ToString();
                                        string Attachment = dt_ForAttachmentList.Rows[ii]["Attachment"].ToString();

                                        string filename_original = dt_ForAttachmentList.Rows[ii]["AttachmentFileName"].ToString();
                                        string filename_new = dt_ForAttachmentList.Rows[ii]["AttachmentFileName"].ToString();
                                        string filetype = dt_ForAttachmentList.Rows[ii]["AttachmentFileType"].ToString();
                                        string filecontent = dt_ForAttachmentList.Rows[ii]["AttachmentFileContent"].ToString();

                                        if (fireeye_flag == "1")
                                        {
                                            // save attachment to av table 
                                            /*
                                            // start save attachment
                                            SqlConnection conn2 = new SqlConnection(connstr2);

                                            SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                            sqlDA2.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_SaveAttachment] @draftID , @arn, @attachment", conn2);
                                            sqlDA2.SelectCommand.Parameters.AddWithValue("@draftID", DraftID);
                                            sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                            sqlDA2.SelectCommand.Parameters.AddWithValue("@attachment", Attachment);

                                            DataSet ds2 = new DataSet("ds");
                                            DataTable dt2 = null;

                                            sqlDA2.Fill(ds2);
                                            */
                                            SqlConnection conn2 = null;
                                            SqlDataAdapter sqlDA2 = null;

                                            conn2 = new SqlConnection(connstr2);

                                            sqlDA2 = new SqlDataAdapter();
                                            sqlDA2.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_SaveAttachment] @draftID , @arn, @attachment", conn2);
                                            sqlDA2.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                                            sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                            sqlDA2.SelectCommand.Parameters.AddWithValue("@attachment", Attachment);

                                            DataSet ds2 = new DataSet("ds");
                                            sqlDA2.Fill(ds2);

                                        }
                                        else
                                        {
                                            // start get edms settings 
                                            SqlConnection connx = new SqlConnection(connstr);

                                            SqlDataAdapter sqlDAx = new SqlDataAdapter();
                                            //sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                                            sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_CRA06_DevPortalDisbursement_Setting] @error output", connx);
                                            sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                                            DataSet dsx = new DataSet("ds");
                                            DataTable dtx = null;

                                            sqlDAx.Fill(dsx);
                                            dtx = dsx.Tables[0];

                                            var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                                            var ProfileName = dtx.Rows[0]["ProfileName"];
                                            var LoginUser = dtx.Rows[0]["LoginUser"];
                                            var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                                            var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                                            var Category = dtx.Rows[0]["Category"];
                                            connx.Close();
                                            // end get edms settings

                                            // start get customer name and id for the selected arn 
                                            SqlConnection conny = new SqlConnection(connstr);

                                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                                            sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                            sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                                            DataSet dsy = new DataSet("ds");
                                            DataTable dty = null;

                                            sqlDAy.Fill(dsy);
                                            dty = dsy.Tables[0];
                                            var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                                            if (CustomerID.ToString() == "")
                                            {
                                                CustomerID = "N/A";
                                            }
                                            var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                                            if (CustomerName.ToString() == "")
                                            {
                                                CustomerName = "N/A";
                                            }
                                            conny.Close();
                                            // end get customer name and id for the selected arn 

                                            string DP_ExportK2FileToEDMS_error = "";
                                            //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                                            ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                        }
                                    }
                                }

                                // generate AV master data if AV flag is 1
                                if (fireeye_flag == "1")
                                {
                                    if (attachmentcount > 0)
                                    {
                                        // generate AV master data 
                                        SqlConnection conn4 = null;
                                        conn4 = new SqlConnection(connstr2);

                                        SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_DeveloperAttachment_create_master_data @draftID, @arn ", conn4);
                                        sqlcommand2.Parameters.AddWithValue("@draftID", draftID);
                                        sqlcommand2.Parameters.AddWithValue("@arn", arn);

                                        conn4.Open();
                                        int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                                        conn4.Close();
                                    }
                                }
                            }
                        }

                        // move to main 
                        // start move arn from staging history + copy arn to main if AV flag is 0 and move arn from staging to history if AV flag is 1
                        if (fireeye_flag == "1")
                        {
                            //ddProjectDisbursementSubmission_MoveToHistory
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_MoveToHistory] @draftID, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                        }
                        else
                        {
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_MoveToMain] @draftID, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                        }


                    }
                }
                /*
                if (draftCount > 0)
                {

                   
                }

                */


            }
            catch (Exception ex)
            {
                error = "DP_NewProjectDisbursement_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewProjectDisbursement_Attachment", "Exception", error, errorDetail);
            }
        }


        [WebMethod]
        public void DP_NewProjectResubmit_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                // get fireeye setting 
                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }

                /*
                // get available draftID                
                SqlConnection conn_ForDraft = null;
                SqlDataAdapter sqlDA_ForDraft = null;

                conn_ForDraft = new SqlConnection(connstr);

                sqlDA_ForDraft = new SqlDataAdapter();
                sqlDA_ForDraft.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_ws_av_GetRejectedRunningID @IDCount output, @RunningID output, @error output,@arn output ", conn_ForDraft);

                sqlDA_ForDraft.SelectCommand.Parameters.Add("@IDCount", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@IDCount"].Direction = ParameterDirection.Output;

                sqlDA_ForDraft.SelectCommand.Parameters.Add("@RunningID", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@RunningID"].Direction = ParameterDirection.Output;

                sqlDA_ForDraft.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                sqlDA_ForDraft.SelectCommand.Parameters.Add("@arn", SqlDbType.NVarChar, 4000);
                sqlDA_ForDraft.SelectCommand.Parameters["@arn"].Direction = ParameterDirection.Output;

                DataSet ds_ForDraft = new DataSet("ds");
                sqlDA_ForDraft.Fill(ds_ForDraft);

                int draftCount = Int32.Parse(sqlDA_ForDraft.SelectCommand.Parameters["@IDCount"].Value.ToString());
                string RejectedRunningID = sqlDA_ForDraft.SelectCommand.Parameters["@RunningID"].Value.ToString();
                string arn = sqlDA_ForDraft.SelectCommand.Parameters["@arn"].Value.ToString();
                */

                // get draft list
                SqlConnection conn_ForDraftList = null;
                SqlDataAdapter sqlDA_ForDraftList = null;

                conn_ForDraftList = new SqlConnection(connstr);

                sqlDA_ForDraftList = new SqlDataAdapter();
                sqlDA_ForDraftList.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_ws_av_GetRejectedRunningIDList", conn_ForDraftList);
                //sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@DraftID", draftID);
                //sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@arn", arn);

                DataSet ds_ForDraftList = new DataSet("ds");
                sqlDA_ForDraftList.Fill(ds_ForDraftList);

                if (ds_ForDraftList.Tables.Count > 0)
                {
                    DataTable dt_ForDraftList = ds_ForDraftList.Tables[0];
                    for (int ll = 0; ll < dt_ForDraftList.Rows.Count; ll++)
                    {
                        string RejectedRunningID = dt_ForDraftList.Rows[ll]["rejectedrunningid"].ToString();
                        string arn = dt_ForDraftList.Rows[ll]["arn"].ToString();

                        // start check if master table does not contain the case already
                        //SqlConnection conn_CheckCaseExisted = null;
                        //SqlDataAdapter sqlDA_CheckCaseExisted = null;

                        //conn_CheckCaseExisted = new SqlConnection(connstr2);

                        //sqlDA_CheckCaseExisted = new SqlDataAdapter();
                        //sqlDA_CheckCaseExisted.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_Resubmit_CheckDuplicate] @runningID , @arn,@CaseCount output", conn_CheckCaseExisted);
                        //sqlDA_CheckCaseExisted.SelectCommand.Parameters.AddWithValue("@runningID", RejectedRunningID);
                        //sqlDA_CheckCaseExisted.SelectCommand.Parameters.AddWithValue("@arn", arn);

                        //sqlDA_CheckCaseExisted.SelectCommand.Parameters.Add("@CaseCount", SqlDbType.Int);
                        //sqlDA_CheckCaseExisted.SelectCommand.Parameters["@CaseCount"].Direction = ParameterDirection.Output;

                        //DataSet ds_CheckCaseExisted = new DataSet("ds");
                        //sqlDA_CheckCaseExisted.Fill(ds_CheckCaseExisted);

                        //int CaseCount = Int32.Parse(sqlDA_CheckCaseExisted.SelectCommand.Parameters["@CaseCount"].Value.ToString());

                        // start check if master table does not contain the case already

                        // get attachment list
                        SqlConnection conn_ForAttachmentList = null;
                        SqlDataAdapter sqlDA_ForAttachmentList = null;

                        conn_ForAttachmentList = new SqlConnection(connstr);

                        sqlDA_ForAttachmentList = new SqlDataAdapter();
                        sqlDA_ForAttachmentList.SelectCommand = new SqlCommand("dbo.ddProjectDisbursementSubmission_Resubmit_ws_av_GetAttachmentListFromDraftID @RunningID", conn_ForAttachmentList);
                        sqlDA_ForAttachmentList.SelectCommand.Parameters.AddWithValue("@RunningID", RejectedRunningID);

                        DataSet ds_ForAttachmentList = new DataSet("ds");
                        sqlDA_ForAttachmentList.Fill(ds_ForAttachmentList);

                        int attachmentcount = 0;

                        if (ds_ForAttachmentList.Tables.Count > 0)
                        {
                            DataTable dt_ForAttachmentList = ds_ForAttachmentList.Tables[0];
                            for (int i = 0; i < dt_ForAttachmentList.Rows.Count; i++)
                            {
                                attachmentcount += 1;

                                //string RejectedRunningID = dt_ForAttachmentList.Rows[i]["RejectedRunningID"].ToString();
                                //string arn = dt_ForAttachmentList.Rows[i]["ARN"].ToString();
                                string AttachmentID = dt_ForAttachmentList.Rows[i]["AttachmentID"].ToString();
                                string Attachment = dt_ForAttachmentList.Rows[i]["Attachment"].ToString();

                                string filename_original = dt_ForAttachmentList.Rows[i]["AttachmentFileName"].ToString();
                                string filename_new = dt_ForAttachmentList.Rows[i]["AttachmentFileName"].ToString();
                                string filetype = dt_ForAttachmentList.Rows[i]["AttachmentFileType"].ToString();
                                string filecontent = dt_ForAttachmentList.Rows[i]["AttachmentFileContent"].ToString();

                                if (fireeye_flag == "1")
                                {
                                    // if ( CaseCount == 0)
                                    //  {
                                    // save attachment to av table 
                                    /*
                                    // start save attachment
                                    SqlConnection conn2 = new SqlConnection(connstr2);

                                    SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                    sqlDA2.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_SaveAttachment] @draftID , @arn, @attachment", conn2);
                                    sqlDA2.SelectCommand.Parameters.AddWithValue("@draftID", DraftID);
                                    sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                    sqlDA2.SelectCommand.Parameters.AddWithValue("@attachment", Attachment);

                                    DataSet ds2 = new DataSet("ds");
                                    DataTable dt2 = null;

                                    sqlDA2.Fill(ds2);
                                    */
                                    SqlConnection conn2 = null;
                                    SqlDataAdapter sqlDA2 = null;

                                    conn2 = new SqlConnection(connstr2);

                                    sqlDA2 = new SqlDataAdapter();
                                    sqlDA2.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_Resubmit_SaveAttachment] @runningID , @arn, @attachment", conn2);
                                    sqlDA2.SelectCommand.Parameters.AddWithValue("@runningID", RejectedRunningID);
                                    sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                    sqlDA2.SelectCommand.Parameters.AddWithValue("@attachment", Attachment);

                                    DataSet ds2 = new DataSet("ds");
                                    sqlDA2.Fill(ds2);
                                    // }


                                }
                                else
                                {
                                    // start get edms settings 
                                    SqlConnection connx = new SqlConnection(connstr);

                                    SqlDataAdapter sqlDAx = new SqlDataAdapter();
                                    //sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                                    sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_CRA06_DevPortalDisbursement_Setting] @error output", connx);
                                    sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                                    DataSet dsx = new DataSet("ds");
                                    DataTable dtx = null;

                                    sqlDAx.Fill(dsx);
                                    dtx = dsx.Tables[0];

                                    var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                                    var ProfileName = dtx.Rows[0]["ProfileName"];
                                    var LoginUser = dtx.Rows[0]["LoginUser"];
                                    var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                                    var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                                    var Category = dtx.Rows[0]["Category"];
                                    connx.Close();
                                    // end get edms settings

                                    // start get customer name and id for the selected arn 
                                    SqlConnection conny = new SqlConnection(connstr);

                                    SqlDataAdapter sqlDAy = new SqlDataAdapter();
                                    sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                                    sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                    sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                                    DataSet dsy = new DataSet("ds");
                                    DataTable dty = null;

                                    sqlDAy.Fill(dsy);
                                    dty = dsy.Tables[0];
                                    var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                                    if (CustomerID.ToString() == "")
                                    {
                                        CustomerID = "N/A";
                                    }
                                    var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                                    if (CustomerName.ToString() == "")
                                    {
                                        CustomerName = "N/A";
                                    }
                                    conny.Close();
                                    // end get customer name and id for the selected arn 

                                    string DP_ExportK2FileToEDMS_error = "";
                                    //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                                    ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                }
                            }
                        }

                        if (fireeye_flag == "1")
                        {
                            // if (CaseCount == 0)
                            //  {
                            if (attachmentcount > 0)
                            {
                                // generate AV master data 
                                SqlConnection conn4 = null;
                                conn4 = new SqlConnection(connstr2);

                                SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_DeveloperResubmitAttachment_create_master_data @RunningID, @arn", conn4);
                                sqlcommand2.Parameters.AddWithValue("@RunningID", RejectedRunningID);
                                sqlcommand2.Parameters.AddWithValue("@arn", arn);

                                conn4.Open();
                                int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                                conn4.Close();
                            }
                            // }
                        }
                        else
                        {
                            // move to main 
                            // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_Resubmit_MoveToMain] @RejectedRunningID, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@RejectedRunningID", @RejectedRunningID);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                            // start move arn from staging to main 

                            /*
                            // start delete staging data in temp db 
                            SqlConnection connmeta = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
                            sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", connmeta);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@workflow", "DisbursementSolicitorSubmission");
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsmeta = new DataSet("ds");
                            //DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAmeta.Fill(dsmeta);
                            connmeta.Close();
                            // start  delete staging data in temp db                             

                            DP_DeleteSolicitorDisbursement_Attachment(arn.ToString(), ref error);
                            */
                        }
                    }
                }
                /*
                if (draftCount > 0)
                {
                  
                }
                */



            }
            catch (Exception ex)
            {
                error = "DP_NewProjectResubmit_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewProjectResubmit_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_DeleteSolicitorDisbursement_Attachment(string arn, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr2);
                
                sqlDAPRE = new SqlDataAdapter();                

                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_DeleteAllAttachments] @ARN, @error output", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                /*
                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                } 
                */

            }
            catch (Exception ex)
            {
                error = "DP_DeleteSolicitorDisbursement_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                //errorDetail = "Input Param: N/A";
                errorDetail = "Input Param:" + "arn:" + arn;
                LogErrorToDB("DP_DeleteSolicitorDisbursement_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_NewValuer_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    DataTable dtPRE = dsPRE.Tables[0];
                    fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
                }

                if (fireeye_flag == "1")
                {
                    conn = new SqlConnection(connstr);

                    sqlDA = new SqlDataAdapter();
                    sqlDA.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLValuerDPSubmission_ListUploadedARN]", conn);

                    string arn;
                    ds = new DataSet("ds");
                    sqlDA.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            arn = dt.Rows[i]["ARN"].ToString();
                            // start validate arn 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr2);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_ValuerSubmission_CheckARN] @ARN", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {

                                SqlConnection conn4 = null;
                                conn4 = new SqlConnection(connstr2);

                                SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_valuerattachment_create_master_data @ARN ", conn4);
                                sqlcommand2.Parameters.AddWithValue("@ARN", arn);

                                conn4.Open();
                                int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
                                conn4.Close();
                            }
                            // end validate arn 
                            conn1.Close();

                        }

                    }
                    conn.Close();
                }
                else
                {
                    // fireeye flag is set to off, directly save attachment to eDMS

                    // start get edms settings 
                    SqlConnection connx = new SqlConnection(connstr);

                    SqlDataAdapter sqlDAx = new SqlDataAdapter();
                    sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Valuer_Setting] @error output", connx);
                    sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsx = new DataSet("ds");
                    DataTable dtx = null;

                    sqlDAx.Fill(dsx);
                    dtx = dsx.Tables[0];

                    var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                    var ProfileName = dtx.Rows[0]["ProfileName"];
                    var LoginUser = dtx.Rows[0]["LoginUser"];
                    var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                    var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                    var Category = dtx.Rows[0]["Category"];
                    connx.Close();
                    // end get edms settings


                    // start get all arn from staging
                    SqlConnection connALPHA = new SqlConnection(connstr);

                    SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
                    sqlDAALPHA.SelectCommand = new SqlCommand("dbo.[usp_ws_ValuerSubmission_getallARNInStaging]", connALPHA);
                    //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsAPLHA = new DataSet("ds");
                    DataTable dtALPHA = null;

                    sqlDAALPHA.Fill(dsAPLHA);
                    dtALPHA = dsAPLHA.Tables[0];

                    if (dsAPLHA.Tables.Count > 0)
                    {
                        dtALPHA = dsAPLHA.Tables[0];

                        for (int s = 0; s < dtALPHA.Rows.Count; s++)
                        {
                            var arn = dtALPHA.Rows[s]["arn"];

                            // start get customer name and id for the selected arn 
                            SqlConnection conny = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsy = new DataSet("ds");
                            DataTable dty = null;

                            sqlDAy.Fill(dsy);
                            dty = dsy.Tables[0];
                            var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                            if (CustomerID.ToString() == "")
                            {
                                CustomerID = "N/A";
                            }
                            var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                            if (CustomerName.ToString() == "")
                            {
                                CustomerName = "N/A";
                            }
                            conny.Close();
                            // end get customer name and id for the selected arn 

                            // start get attachment detail 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            //sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_list_SolicitorSubmissionAttachmentInStaging] @ARN, @error output", conn1);
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_list_ValuerSubmissionAttachmentInStaging] @ARN", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            //sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {
                                dt1 = ds1.Tables[0];

                                for (int j = 0; j < dt1.Rows.Count; j++)
                                {
                                    var filename_original = dt1.Rows[j]["ItemFileName"];
                                    var filename_new = dt1.Rows[j]["ItemFileName"];
                                    var filecontent = dt1.Rows[j]["ItemContent"];
                                    //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                    var filetype = dt1.Rows[j]["ItemFileType"];
                                    // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                    //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                    //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                    //var d_result = dt1.Rows[j]["result"];

                                    string DP_ExportK2FileToEDMS_error = "";
                                    //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
                                    ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                }
                            }
                            conn1.Close();
                            // end get attachment detail 

                            // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLValuerDPSubmission_Main_MoveToMain] @arn, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                            // start move arn from staging to main 

                            // start delete staging data in temp db 
                            SqlConnection connmeta = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
                            sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", connmeta);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@workflow", "ValuerDPSubmission");
                            sqlDAmeta.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsmeta = new DataSet("ds");
                            //DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAmeta.Fill(dsmeta);
                            connmeta.Close();
                            // start  delete staging data in temp db 
                        }
                    }
                    // end start get all arn in staging 
                }


            }
            catch (Exception ex)
            {
                error = "DP_NewValuer_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_NewValuer_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_CompletedSolicitor_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                conn = new SqlConnection(connstr2);

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.[usp_ws_Check_SolicitorSubmissionAttachment_Completed_ARN] @error output", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@error", "");

                string arn;
                string result;
                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        arn = dt.Rows[i]["ARN"].ToString();
                        result = dt.Rows[i]["result"].ToString();

                        // start check if the record still in staging
                        DataSet dsBETA = null;
                        DataTable dtBETA = null;
                        SqlConnection connBETA = null;
                        SqlDataAdapter sqlDABETA = null;
                        connBETA = new SqlConnection(connstr);

                        string errorBETA = "";

                        sqlDABETA = new SqlDataAdapter();
                        sqlDABETA.SelectCommand = new SqlCommand("dbo.[usp_ws_check_SolicitorSubmissionStillInStaging] @arn, @error output", connBETA);
                        sqlDABETA.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDABETA.SelectCommand.Parameters.AddWithValue("@error", errorBETA);

                        dsBETA = new DataSet("ds");
                        sqlDABETA.Fill(dsBETA);

                        if (errorBETA == "")
                        {
                            // end check if the record still in staging 
                            if (result == "passed")
                            //if (result == "failed")
                            {
                                // start get edms settings 
                                SqlConnection connx = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Solicitor_Setting] @error output", connx);
                                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsx = new DataSet("ds");
                                DataTable dtx = null;

                                sqlDAx.Fill(dsx);
                                dtx = dsx.Tables[0];

                                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                                var ProfileName = dtx.Rows[0]["ProfileName"];
                                var LoginUser = dtx.Rows[0]["LoginUser"];
                                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                                var Category = dtx.Rows[0]["Category"];
                                connx.Close();
                                // end get edms settings

                                // start get customer name and id for the selected arn 
                                SqlConnection conny = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsy = new DataSet("ds");
                                DataTable dty = null;

                                sqlDAy.Fill(dsy);
                                dty = dsy.Tables[0];
                                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                                if (CustomerID.ToString() == "")
                                {
                                    CustomerID = "N/A";
                                }
                                
                                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                                if (CustomerName.ToString() == "")
                                {
                                    CustomerName = "N/A";
                                }
                                conny.Close();
                                // end get customer name and id for the selected arn 

                                // start get attachment detail 
                                SqlConnection conn1 = null;
                                conn1 = new SqlConnection(connstr2);
                                SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_list_SolicitorSubmissionAttachment_For_Completed_ARN] @ARN, @error output", conn1);
                                sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                                DataSet ds1 = null;
                                DataTable dt1 = null;

                                ds1 = new DataSet("ds");

                                sqlDA1.Fill(ds1);

                                if (ds1.Tables.Count > 0)
                                {
                                    dt1 = ds1.Tables[0];

                                    for (int j = 0; j < dt1.Rows.Count; j++)
                                    {
                                        var filename_original = dt1.Rows[j]["filename_original"];
                                        var filename_new = dt1.Rows[j]["filename_new"];
                                        var filecontent = dt1.Rows[j]["filecontent"];
                                        //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                        var filetype = dt1.Rows[j]["filetype"];
                                        var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                        var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                        var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                        var d_result = dt1.Rows[j]["result"];

                                        string DP_ExportK2FileToEDMS_error = "";
                                        ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn, EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                    }
                                }
                                conn1.Close();
                                // end get attachment detail 

                                // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                                SqlConnection connz = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                                sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_Main_MoveToMain] @arn, @error output", connz);
                                sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsz = new DataSet("ds");
                                DataTable dtz = null;
                                //dtz = dsz.Tables[0];
                                sqlDAz.Fill(dsz);
                                connz.Close();
                                // start move arn from staging to main 

                                // start delete VS master data and detail data 
                                /*
                                SqlConnection conn2 = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds2 = new DataSet("ds");
                                DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDA2.Fill(ds2);
                                conn2.Close();
                                */
                                // end delete VS master data and detail data 

                            }
                            else
                            {
                                // start move failed record to SQLSolicitorDPSubmission_VirusLog
                                SqlConnection conn_alpha = new SqlConnection(connstr);

                                SqlDataAdapter sqlDA_alpha = new SqlDataAdapter();
                                sqlDA_alpha.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_MoveFailedToMain] @arn, @error output", conn_alpha);
                                sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds_alpha = new DataSet("ds");
                                //DataTable dt_alpha = null;
                                //dt_alpha = ds_alpha.Tables[0];
                                sqlDA_alpha.Fill(ds_alpha);
                                conn_alpha.Close();
                                // end move failed record to SQLSolicitorDPSubmission_VirusLog

                                // start get failed attachments
                                SqlConnection conn_beta = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA_beta = new SqlDataAdapter();
                                sqlDA_beta.SelectCommand = new SqlCommand("dbo.[usp_ws_getfailedattachments] @arn, @workflow, @error output", conn_beta);
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds_beta = new DataSet("ds");
                                DataTable dt_beta = null;
                                sqlDA_beta.Fill(ds_beta);

                                if (ds_beta.Tables.Count > 0)
                                {
                                    dt_beta = ds_beta.Tables[0];

                                    for (int beta = 0; beta < dt_beta.Rows.Count; beta++)
                                    {
                                        var workflow = dt_beta.Rows[beta]["workflow"];
                                        var filename_original = dt_beta.Rows[beta]["filename_original"];
                                        var filename_new = dt_beta.Rows[beta]["filename_new"];
                                        var filecontent = dt_beta.Rows[beta]["filecontent"];
                                        var filetype = dt_beta.Rows[beta]["filetype"];
                                        var attachmentuploaddate = dt_beta.Rows[beta]["attachmentuploaddate"];
                                        var fe_file_url = dt_beta.Rows[beta]["fe_file_url"];
                                        var fe_fireeye_id = dt_beta.Rows[beta]["fe_fireeye_id"];
                                        var fe_failed_description = dt_beta.Rows[beta]["fe_failed_description"];
                                        var fe_failed_code = dt_beta.Rows[beta]["fe_failed_code"];
                                        var VSresult = dt_beta.Rows[beta]["result"];
                                        var VSCreatedDate = dt_beta.Rows[beta]["CreatedDate"];
                                        var VSUpdatedDate = dt_beta.Rows[beta]["UpdatedDate"];

                                        // start log detail into VS_attachment_detail
                                        SqlConnection conn_gama = new SqlConnection(connstr);

                                        SqlDataAdapter sqlDA_gama = new SqlDataAdapter();
                                        sqlDA_gama.SelectCommand = new SqlCommand("dbo.[usp_ws_savefailedattachmentdata] @arn ,@workflow,@filename_original,@filename_new,@filecontent,@filetype,@attachmentuploaddate,@fe_file_url,@fe_fireeye_id,@fe_failed_description,@fe_failed_code,@result,@VSCreatedDate,@VSUpdatedDate, @error output", conn_gama);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@workflow", workflow);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_original", filename_original);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_new", filename_new);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filecontent", filecontent);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filetype", filetype);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@attachmentuploaddate", attachmentuploaddate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_file_url", fe_file_url);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_fireeye_id", fe_fireeye_id);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_description", fe_failed_description);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_code", fe_failed_code);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@result", VSresult);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSCreatedDate", VSCreatedDate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSUpdatedDate", VSUpdatedDate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@error", "");

                                        DataSet ds_gama = new DataSet("ds");
                                        DataTable dt_gama = null;
                                        //dt_gama = ds_gama.Tables[0];
                                        sqlDA_gama.Fill(ds_gama);
                                        conn_gama.Close();
                                        // end log detail into VS_attachment_detail
                                    }

                                }
                                conn_beta.Close();
                                // end get failed attachments

                                // 20200827 start direct send email from WS  
                                SqlConnection connZeta = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAZeta = new SqlDataAdapter();
                                sqlDAZeta.SelectCommand = new SqlCommand("dbo.[usp_DUMaker_Letter_AV_Solicitor_email_content_generate]", connZeta);

                                DataSet dsZeta = new DataSet("ds");
                                //DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDAZeta.Fill(dsZeta);
                                DataTable dtZeta = null;

                                if (dsZeta.Tables.Count > 0)
                                {
                                    dtZeta = dsZeta.Tables[0];

                                    var receiveremail = dtZeta.Rows[0]["receiveremail"].ToString();
                                    var email_header = dtZeta.Rows[0]["email_header"].ToString();
                                    var email_body = dtZeta.Rows[0]["email_body"].ToString();

                                    SendMail(receiveremail, email_header, email_body, null,null);
                                }
                                // 20200827 end direct send email from WS

                                // start delete VS master data and detail data 
                                /*
                                SqlConnection conn2 = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds2 = new DataSet("ds");
                                DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDA2.Fill(ds2);
                                conn2.Close();
                                */
                                // end delete VS master data and detail data 
                            }


                        }


                        // start delete VS master data and detail data                         
                        SqlConnection conn2 = new SqlConnection(connstr2);

                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                        sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", conn2);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet ds2 = new DataSet("ds");
                        //DataTable dt2 = null;
                        //dt2 = ds2.Tables[0];
                        sqlDA2.Fill(ds2);
                        conn2.Close();
                        // end delete VS master data and detail data 

                        
                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                error = "DP_CompletedSolicitor_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_CompletedSolicitor_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_CompletedSolicitorDisbursement_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                conn = new SqlConnection(connstr2);

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.[aa_ws_Check_SolicitorDisbursementSubmissionAttachment_Completed_ARN] @error output", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@error", "");

                string arn;
                string result;
                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        arn = dt.Rows[i]["ARN"].ToString();
                        result = dt.Rows[i]["result"].ToString();

                        // start check if the record still in staging
                        DataSet dsBETA = null;
                        DataTable dtBETA = null;
                        SqlConnection connBETA = null;
                        SqlDataAdapter sqlDABETA = null;
                        connBETA = new SqlConnection(connstr);

                        string errorBETA = "";

                        sqlDABETA = new SqlDataAdapter();
                        sqlDABETA.SelectCommand = new SqlCommand("dbo.[aa_ws_check_SolicitorDisbursementSubmissionStillInStaging] @arn, @error output", connBETA);
                        sqlDABETA.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDABETA.SelectCommand.Parameters.AddWithValue("@error", errorBETA);

                        dsBETA = new DataSet("ds");
                        sqlDABETA.Fill(dsBETA);
                        // end check if the record still in staging 

                        if (errorBETA == "")
                        {
                            
                            if (result == "passed")
                            //if (result == "failed")
                            {
                                // start get edms settings 
                                SqlConnection connx = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                                sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_SolicitorDisbursement_Setting] @error output", connx);
                                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsx = new DataSet("ds");
                                DataTable dtx = null;

                                sqlDAx.Fill(dsx);
                                dtx = dsx.Tables[0];

                                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                                var ProfileName = dtx.Rows[0]["ProfileName"];
                                var LoginUser = dtx.Rows[0]["LoginUser"];
                                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                                var Category = dtx.Rows[0]["Category"];
                                connx.Close();
                                // end get edms settings

                                // start get customer name and id for the selected arn 
                                SqlConnection conny = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsy = new DataSet("ds");
                                DataTable dty = null;

                                sqlDAy.Fill(dsy);
                                dty = dsy.Tables[0];
                                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                                if (CustomerID.ToString() == "")
                                {
                                    CustomerID = "N/A";
                                }
                                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                                if (CustomerName.ToString() == "")
                                {
                                    CustomerName = "N/A";
                                }
                                conny.Close();
                                // end get customer name and id for the selected arn 

                                // start get attachment detail 
                                SqlConnection conn1 = null;
                                conn1 = new SqlConnection(connstr2);
                                SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                                sqlDA1.SelectCommand = new SqlCommand("dbo.[aa_ws_list_SolicitorDisbursementSubmissionAttachment_For_Completed_ARN] @ARN, @error output", conn1);
                                sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                                DataSet ds1 = null;
                                DataTable dt1 = null;

                                ds1 = new DataSet("ds");

                                sqlDA1.Fill(ds1);

                                if (ds1.Tables.Count > 0)
                                {
                                    dt1 = ds1.Tables[0];

                                    for (int j = 0; j < dt1.Rows.Count; j++)
                                    {
                                        var filename_original = dt1.Rows[j]["filename_original"];
                                        var filename_new = dt1.Rows[j]["filename_new"];
                                        var filecontent = dt1.Rows[j]["filecontent"];
                                        //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                        var filetype = dt1.Rows[j]["filetype"];
                                        var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                        var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                        var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                        var d_result = dt1.Rows[j]["result"];

                                        string DP_ExportK2FileToEDMS_error = "";
                                        ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn, EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                    }
                                }
                                conn1.Close();
                                // end get attachment detail 

                                // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                                SqlConnection connz = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                                sqlDAz.SelectCommand = new SqlCommand("dbo.[aa_ws_SolDisbursementSubmission_MoveToMain] @arn, @error output", connz);
                                sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsz = new DataSet("ds");
                                DataTable dtz = null;
                                //dtz = dsz.Tables[0];
                                sqlDAz.Fill(dsz);
                                connz.Close();
                                // start move arn from staging to main 

                                // start delete VS master data and detail data 
                                /*
                                SqlConnection conn2 = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds2 = new DataSet("ds");
                                DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDA2.Fill(ds2);
                                conn2.Close();
                                */
                                // end delete VS master data and detail data 

                            }
                            else
                            {
                                // start move failed record to SQLSolicitorDPSubmission_VirusLog
                                SqlConnection conn_alpha = new SqlConnection(connstr);

                                SqlDataAdapter sqlDA_alpha = new SqlDataAdapter();
                                sqlDA_alpha.SelectCommand = new SqlCommand("dbo.[aa_ws_SolicitorDisbursementSubmission_MoveFailedToMain] @arn, @error output", conn_alpha);
                                sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds_alpha = new DataSet("ds");
                                //DataTable dt_alpha = null;
                                //dt_alpha = ds_alpha.Tables[0];
                                sqlDA_alpha.Fill(ds_alpha);
                                conn_alpha.Close();
                                // end move failed record to SQLSolicitorDPSubmission_VirusLog

                                // start get failed attachments
                                SqlConnection conn_beta = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA_beta = new SqlDataAdapter();
                                sqlDA_beta.SelectCommand = new SqlCommand("dbo.[usp_ws_getfailedattachments] @arn, @workflow, @error output", conn_beta);
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@workflow", "DisbursementSolicitorSubmission");
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds_beta = new DataSet("ds");
                                DataTable dt_beta = null;
                                sqlDA_beta.Fill(ds_beta);

                                if (ds_beta.Tables.Count > 0)
                                {
                                    dt_beta = ds_beta.Tables[0];

                                    for (int beta = 0; beta < dt_beta.Rows.Count; beta++)
                                    {
                                        var workflow = dt_beta.Rows[beta]["workflow"];
                                        var filename_original = dt_beta.Rows[beta]["filename_original"];
                                        var filename_new = dt_beta.Rows[beta]["filename_new"];
                                        var filecontent = dt_beta.Rows[beta]["filecontent"];
                                        var filetype = dt_beta.Rows[beta]["filetype"];
                                        var attachmentuploaddate = dt_beta.Rows[beta]["attachmentuploaddate"];
                                        var fe_file_url = dt_beta.Rows[beta]["fe_file_url"];
                                        var fe_fireeye_id = dt_beta.Rows[beta]["fe_fireeye_id"];
                                        var fe_failed_description = dt_beta.Rows[beta]["fe_failed_description"];
                                        var fe_failed_code = dt_beta.Rows[beta]["fe_failed_code"];
                                        var VSresult = dt_beta.Rows[beta]["result"];
                                        var VSCreatedDate = dt_beta.Rows[beta]["CreatedDate"];
                                        var VSUpdatedDate = dt_beta.Rows[beta]["UpdatedDate"];

                                        // start log detail into VS_attachment_detail
                                        SqlConnection conn_gama = new SqlConnection(connstr);

                                        SqlDataAdapter sqlDA_gama = new SqlDataAdapter();
                                        sqlDA_gama.SelectCommand = new SqlCommand("dbo.[usp_ws_savefailedattachmentdata] @arn ,@workflow,@filename_original,@filename_new,@filecontent,@filetype,@attachmentuploaddate,@fe_file_url,@fe_fireeye_id,@fe_failed_description,@fe_failed_code,@result,@VSCreatedDate,@VSUpdatedDate, @error output", conn_gama);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@workflow", workflow);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_original", filename_original);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_new", filename_new);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filecontent", filecontent);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filetype", filetype);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@attachmentuploaddate", attachmentuploaddate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_file_url", fe_file_url);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_fireeye_id", fe_fireeye_id);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_description", fe_failed_description);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_code", fe_failed_code);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@result", VSresult);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSCreatedDate", VSCreatedDate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSUpdatedDate", VSUpdatedDate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@error", "");

                                        DataSet ds_gama = new DataSet("ds");
                                        DataTable dt_gama = null;
                                        //dt_gama = ds_gama.Tables[0];
                                        sqlDA_gama.Fill(ds_gama);
                                        conn_gama.Close();
                                        // end log detail into VS_attachment_detail
                                    }

                                }
                                conn_beta.Close();
                                // end get failed attachments

                                // 20200827 start direct send email from WS  
                                SqlConnection connZeta = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAZeta = new SqlDataAdapter();
                                sqlDAZeta.SelectCommand = new SqlCommand("dbo.[usp_DUMaker_Letter_AV_SolicitorDisbursement_email_content_generate]", connZeta);

                                DataSet dsZeta = new DataSet("ds");
                                //DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDAZeta.Fill(dsZeta);
                                DataTable dtZeta = null;

                                if (dsZeta.Tables.Count > 0)
                                {
                                    dtZeta = dsZeta.Tables[0];

                                    var receiveremail = dtZeta.Rows[0]["receiveremail"].ToString();
                                    var email_header = dtZeta.Rows[0]["email_header"].ToString();
                                    var email_body = dtZeta.Rows[0]["email_body"].ToString();

                                    SendMail(receiveremail, email_header, email_body, null,null);
                                }
                                // 20200827 end direct send email from WS
                                // start delete VS master data and detail data 
                                /*
                                SqlConnection conn2 = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds2 = new DataSet("ds");
                                DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDA2.Fill(ds2);
                                conn2.Close();
                                */
                                // end delete VS master data and detail data 
                            }
                        }

                       

                        // start delete VS master data and detail data                         
                        SqlConnection conn2 = new SqlConnection(connstr2);

                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                        sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", conn2);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "DisbursementSolicitorSubmission");
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet ds2 = new DataSet("ds");
                        //DataTable dt2 = null;
                        //dt2 = ds2.Tables[0];
                        sqlDA2.Fill(ds2);
                        conn2.Close();
                        // end delete VS master data and detail data 

                        DP_DeleteSolicitorDisbursement_Attachment(arn, ref error);
                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                error = "DP_CompletedSolicitorDisbursement_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_CompletedSolicitorDisbursement_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_CompletedProjectResubmit_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                conn = new SqlConnection(connstr2);
                /*
                sqlDA = new SqlDataAdapter();                 

                sqlDA.SelectCommand = new SqlCommand("dbo.[aa_ws_Check_ProjectResubmissionAttachment_Completed_ARN] @error output, @RejectedRunningID output, @arn output, @result output, @RejectedRunningID_arn output, @datacount output", conn);

                sqlDA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                sqlDA.SelectCommand.Parameters.Add("@RejectedRunningID", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@RejectedRunningID"].Direction = ParameterDirection.Output;

                sqlDA.SelectCommand.Parameters.Add("@arn", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@arn"].Direction = ParameterDirection.Output;

                sqlDA.SelectCommand.Parameters.Add("@result", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@result"].Direction = ParameterDirection.Output;

                sqlDA.SelectCommand.Parameters.Add("@RejectedRunningID_arn", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@RejectedRunningID_arn"].Direction = ParameterDirection.Output;

                sqlDA.SelectCommand.Parameters.Add("@datacount", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@datacount"].Direction = ParameterDirection.Output;

                //sqlDA.SelectCommand.Parameters.AddWithValue("@error", "");

                string arn;
                string result;
                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                
                error = sqlDA.SelectCommand.Parameters["@error"].Value.ToString();
                string RejectedRunningID = sqlDA.SelectCommand.Parameters["@RejectedRunningID"].Value.ToString();
                result = sqlDA.SelectCommand.Parameters["@result"].Value.ToString();
                arn = sqlDA.SelectCommand.Parameters["@arn"].Value.ToString();
                string RejectedRunningID_arn = sqlDA.SelectCommand.Parameters["@RejectedRunningID_arn"].Value.ToString();
                string datacount = sqlDA.SelectCommand.Parameters["@datacount"].Value.ToString();

                */

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.aa_ws_Check_ProjectDisbursementReSubmitAttachment_Completed_GetList", conn);

                //string arn;
                //string result;
                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                //DataTable dt = null;

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];

                    for (int a = 0; a < dt.Rows.Count; a++)
                    {
                        var RejectedRunningID_arn = dt.Rows[a]["RejectedID_Arn"];
                        var workflow = dt.Rows[a]["workflow"];
                        var job_status = dt.Rows[a]["job_status"];
                        var result = dt.Rows[a]["result"];
                        var arn = dt.Rows[a]["ARN"];
                        var RejectedRunningID = dt.Rows[a]["RejectedID"];

                        if (result.ToString() == "passed")
                        //if (result == "failed")
                        {
                            // start get edms settings 
                            SqlConnection connx = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAx = new SqlDataAdapter();
                            //sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                            sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_CRA06_DevPortalDisbursement_Setting] @error output", connx);

                            sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsx = new DataSet("ds");
                            DataTable dtx = null;

                            sqlDAx.Fill(dsx);
                            dtx = dsx.Tables[0];

                            var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                            var ProfileName = dtx.Rows[0]["ProfileName"];
                            var LoginUser = dtx.Rows[0]["LoginUser"];
                            var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                            var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                            var Category = dtx.Rows[0]["Category"];
                            connx.Close();
                            // end get edms settings

                            // start get customer name and id for the selected arn 
                            SqlConnection conny = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsy = new DataSet("ds");
                            DataTable dty = null;

                            sqlDAy.Fill(dsy);
                            dty = dsy.Tables[0];
                            var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                            if (CustomerID.ToString() == "")
                            {
                                CustomerID = "N/A";
                            }
                            var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                            if (CustomerName.ToString() == "")
                            {
                                CustomerName = "N/A";
                            }
                            conny.Close();
                            // end get customer name and id for the selected arn 

                            // start get attachment detail 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr2);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[aa_ws_list_ProjectDisbursementResubmissionAttachment_For_Completed_ARN] @running_arn, @error output", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@running_arn", RejectedRunningID_arn);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {
                                dt1 = ds1.Tables[0];

                                for (int j = 0; j < dt1.Rows.Count; j++)
                                {
                                    var filename_original = dt1.Rows[j]["filename_original"];
                                    var filename_new = dt1.Rows[j]["filename_new"];
                                    var filecontent = dt1.Rows[j]["filecontent"];
                                    //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                    var filetype = dt1.Rows[j]["filetype"];
                                    var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                    var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                    var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                    var d_result = dt1.Rows[j]["result"];

                                    string DP_ExportK2FileToEDMS_error = "";
                                    ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                }
                            }
                            conn1.Close();
                            // end get attachment detail 

                            // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_Resubmit_MoveToMain] @RejectedRunningID, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@RejectedRunningID", RejectedRunningID);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                            // start move arn from staging to main 

                            // start delete VS master data and detail data 
                            /*
                            SqlConnection conn2 = new SqlConnection(connstr2);

                            SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                            sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet ds2 = new DataSet("ds");
                            DataTable dt2 = null;
                            //dt2 = ds2.Tables[0];
                            sqlDA2.Fill(ds2);
                            conn2.Close();
                            */
                            // end delete VS master data and detail data 

                        }
                        else
                        {
                            // start move failed record to SQLSolicitorDPSubmission_VirusLog
                            SqlConnection conn_alpha = new SqlConnection(connstr);

                            SqlDataAdapter sqlDA_alpha = new SqlDataAdapter();
                            sqlDA_alpha.SelectCommand = new SqlCommand("dbo.[aa_ws_ProjectDisbursementResubmission_MoveFailedToMain] @arn, @runningID, @error output, @senderemail output, @receiveremail output, @emailheader output, @emailcontent output ", conn_alpha);
                            sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@runningID", RejectedRunningID);
                            sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@error", "");

                            sqlDA_alpha.SelectCommand.Parameters.Add("@senderemail", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@senderemail"].Direction = ParameterDirection.Output;

                            sqlDA_alpha.SelectCommand.Parameters.Add("@receiveremail", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@receiveremail"].Direction = ParameterDirection.Output;

                            sqlDA_alpha.SelectCommand.Parameters.Add("@emailheader", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@emailheader"].Direction = ParameterDirection.Output;

                            sqlDA_alpha.SelectCommand.Parameters.Add("@emailcontent", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@emailcontent"].Direction = ParameterDirection.Output;

                            DataSet ds_alpha = new DataSet("ds");
                            //DataTable dt_alpha = null;
                            //dt_alpha = ds_alpha.Tables[0];
                            sqlDA_alpha.Fill(ds_alpha);

                            string senderemail = sqlDA_alpha.SelectCommand.Parameters["@senderemail"].Value.ToString();
                            string receiveremail = sqlDA_alpha.SelectCommand.Parameters["@receiveremail"].Value.ToString();
                            string emailheader = sqlDA_alpha.SelectCommand.Parameters["@emailheader"].Value.ToString();
                            string emailcontent = sqlDA_alpha.SelectCommand.Parameters["@emailcontent"].Value.ToString();

                            conn_alpha.Close();
                            // end move failed record to SQLSolicitorDPSubmission_VirusLog




                            // start get failed attachments
                            SqlConnection conn_beta = new SqlConnection(connstr2);

                            SqlDataAdapter sqlDA_beta = new SqlDataAdapter();
                            sqlDA_beta.SelectCommand = new SqlCommand("dbo.[usp_ws_getfailedattachments] @arn, @workflow, @error output", conn_beta);
                            sqlDA_beta.SelectCommand.Parameters.AddWithValue("@arn", RejectedRunningID_arn);
                            sqlDA_beta.SelectCommand.Parameters.AddWithValue("@workflow", "ProjectResubmit");
                            sqlDA_beta.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet ds_beta = new DataSet("ds");
                            DataTable dt_beta = null;
                            sqlDA_beta.Fill(ds_beta);

                            if (ds_beta.Tables.Count > 0)
                            {
                                dt_beta = ds_beta.Tables[0];

                                for (int beta = 0; beta < dt_beta.Rows.Count; beta++)
                                {
                                    //var workflow = dt_beta.Rows[beta]["workflow"];
                                    var filename_original = dt_beta.Rows[beta]["filename_original"];
                                    var filename_new = dt_beta.Rows[beta]["filename_new"];
                                    var filecontent = dt_beta.Rows[beta]["filecontent"];
                                    var filetype = dt_beta.Rows[beta]["filetype"];
                                    var attachmentuploaddate = dt_beta.Rows[beta]["attachmentuploaddate"];
                                    var fe_file_url = dt_beta.Rows[beta]["fe_file_url"];
                                    var fe_fireeye_id = dt_beta.Rows[beta]["fe_fireeye_id"];
                                    var fe_failed_description = dt_beta.Rows[beta]["fe_failed_description"];
                                    var fe_failed_code = dt_beta.Rows[beta]["fe_failed_code"];
                                    var VSresult = dt_beta.Rows[beta]["result"];
                                    var VSCreatedDate = dt_beta.Rows[beta]["CreatedDate"];
                                    var VSUpdatedDate = dt_beta.Rows[beta]["UpdatedDate"];

                                    // start log detail into VS_attachment_detail
                                    SqlConnection conn_gama = new SqlConnection(connstr);

                                    SqlDataAdapter sqlDA_gama = new SqlDataAdapter();
                                    sqlDA_gama.SelectCommand = new SqlCommand("dbo.[usp_ws_savefailedattachmentdata] @arn ,@workflow,@filename_original,@filename_new,@filecontent,@filetype,@attachmentuploaddate,@fe_file_url,@fe_fireeye_id,@fe_failed_description,@fe_failed_code,@result,@VSCreatedDate,@VSUpdatedDate, @error output", conn_gama);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@workflow", workflow);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_original", filename_original);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_new", filename_new);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filecontent", filecontent);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filetype", filetype);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@attachmentuploaddate", attachmentuploaddate);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_file_url", fe_file_url);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_fireeye_id", fe_fireeye_id);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_description", fe_failed_description);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_code", fe_failed_code);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@result", VSresult);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSCreatedDate", VSCreatedDate);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSUpdatedDate", VSUpdatedDate);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@error", "");

                                    DataSet ds_gama = new DataSet("ds");
                                    DataTable dt_gama = null;
                                    //dt_gama = ds_gama.Tables[0];
                                    sqlDA_gama.Fill(ds_gama);
                                    conn_gama.Close();
                                    // end log detail into VS_attachment_detail
                                }

                            }
                            conn_beta.Close();

                            if (receiveremail != "")
                            {
                                SendMail(receiveremail, emailheader, emailcontent, null, null);
                            }




                        }

                        // start delete VS master data and detail data                         
                        SqlConnection conn2 = new SqlConnection(connstr2);

                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                        sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", conn2);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", RejectedRunningID_arn);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "ProjectResubmit");
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet ds2 = new DataSet("ds");
                        //DataTable dt2 = null;
                        //dt2 = ds2.Tables[0];
                        sqlDA2.Fill(ds2);
                        conn2.Close();
                        // end delete VS master data and detail data 
                    }
                }

                


            }
            catch (Exception ex)
            {
                error = "DP_CompletedProjectResubmit_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_CompletedProjectResubmit_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_CompletedProjectDisbursement_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                conn = new SqlConnection(connstr2);

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.aa_ws_Check_ProjectDisbursementSubmissionAttachment_Completed_GetList", conn);

                //string arn;
                //string result;
                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                //DataTable dt = null;

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];

                    for (int a = 0; a < dt.Rows.Count; a++)
                    {
                        var draft_arn = dt.Rows[a]["Draft_Arn"];
                        var workflow = dt.Rows[a]["workflow"];
                        var job_status = dt.Rows[a]["job_status"];
                        var result = dt.Rows[a]["result"];
                        var arn = dt.Rows[a]["ARN"];
                        var draftID = dt.Rows[a]["Draft"];

                        if (result.ToString() == "passed")                        
                        {
                            // start get edms settings 
                            SqlConnection connx = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAx = new SqlDataAdapter();
                            //sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_ProjectDisbursement_Setting] @error output", connx);
                            sqlDAx.SelectCommand = new SqlCommand("dbo.[aa_ws_getEDMS_CRA06_DevPortalDisbursement_Setting] @error output", connx);

                            sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsx = new DataSet("ds");
                            DataTable dtx = null;

                            sqlDAx.Fill(dsx);
                            dtx = dsx.Tables[0];

                            var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                            var ProfileName = dtx.Rows[0]["ProfileName"];
                            var LoginUser = dtx.Rows[0]["LoginUser"];
                            var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                            var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                            var Category = dtx.Rows[0]["Category"];
                            connx.Close();
                            // end get edms settings

                            // start get customer name and id for the selected arn 
                            SqlConnection conny = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAy = new SqlDataAdapter();
                            sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsy = new DataSet("ds");
                            DataTable dty = null;

                            sqlDAy.Fill(dsy);
                            dty = dsy.Tables[0];
                            var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                            if (CustomerID.ToString() == "")
                            {
                                CustomerID = "N/A";
                            }
                            var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                            if (CustomerName.ToString() == "")
                            {
                                CustomerName = "N/A";
                            }
                            conny.Close();
                            // end get customer name and id for the selected arn 

                            // start get attachment detail 
                            SqlConnection conn1 = null;
                            conn1 = new SqlConnection(connstr2);
                            SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                            sqlDA1.SelectCommand = new SqlCommand("dbo.[aa_ws_list_ProjectDisbursementSubmissionAttachment_For_Completed_ARN] @draft_arn, @error output", conn1);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@draft_arn", draft_arn);
                            sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                            DataSet ds1 = null;
                            DataTable dt1 = null;

                            ds1 = new DataSet("ds");

                            sqlDA1.Fill(ds1);

                            if (ds1.Tables.Count > 0)
                            {
                                dt1 = ds1.Tables[0];

                                for (int j = 0; j < dt1.Rows.Count; j++)
                                {
                                    var filename_original = dt1.Rows[j]["filename_original"];
                                    var filename_new = dt1.Rows[j]["filename_new"];
                                    var filecontent = dt1.Rows[j]["filecontent"];
                                    //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                    var filetype = dt1.Rows[j]["filetype"];
                                    var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                    var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                    var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                    var d_result = dt1.Rows[j]["result"];

                                    string DP_ExportK2FileToEDMS_error = "";
                                    ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                }
                            }
                            conn1.Close();
                            // end get attachment detail 

                            // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                            SqlConnection connz = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAz = new SqlDataAdapter();
                            sqlDAz.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_MoveToMain_ByDraftARN] @draftID, @arn, @error output", connz);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                            sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet dsz = new DataSet("ds");
                            DataTable dtz = null;
                            //dtz = dsz.Tables[0];
                            sqlDAz.Fill(dsz);
                            connz.Close();
                            // start move arn from staging to main 

                            // start delete VS master data and detail data 
                            /*
                            SqlConnection conn2 = new SqlConnection(connstr2);

                            SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                            sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet ds2 = new DataSet("ds");
                            DataTable dt2 = null;
                            //dt2 = ds2.Tables[0];
                            sqlDA2.Fill(ds2);
                            conn2.Close();
                            */
                            // end delete VS master data and detail data 

                        }
                        else
                        {
                            // start move failed record to SQLSolicitorDPSubmission_VirusLog
                            SqlConnection conn_alpha = new SqlConnection(connstr);

                            SqlDataAdapter sqlDA_alpha = new SqlDataAdapter();
                            sqlDA_alpha.SelectCommand = new SqlCommand("dbo.[aa_ws_ProjectDisbursementSubmission_MoveFailedToMain] @arn, @draftID, @error output, @senderemail output, @receiveremail output, @emailheader output, @emailcontent output", conn_alpha);
                            sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                            sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@error", "");

                            sqlDA_alpha.SelectCommand.Parameters.Add("@senderemail", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@senderemail"].Direction = ParameterDirection.Output;

                            sqlDA_alpha.SelectCommand.Parameters.Add("@receiveremail", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@receiveremail"].Direction = ParameterDirection.Output;

                            sqlDA_alpha.SelectCommand.Parameters.Add("@emailheader", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@emailheader"].Direction = ParameterDirection.Output;

                            sqlDA_alpha.SelectCommand.Parameters.Add("@emailcontent", SqlDbType.NVarChar, 4000);
                            sqlDA_alpha.SelectCommand.Parameters["@emailcontent"].Direction = ParameterDirection.Output;

                            DataSet ds_alpha = new DataSet("ds");
                            //DataTable dt_alpha = null;
                            //dt_alpha = ds_alpha.Tables[0];
                            sqlDA_alpha.Fill(ds_alpha);

                            string senderemail = sqlDA_alpha.SelectCommand.Parameters["@senderemail"].Value.ToString();
                            string receiveremail = sqlDA_alpha.SelectCommand.Parameters["@receiveremail"].Value.ToString();
                            string emailheader = sqlDA_alpha.SelectCommand.Parameters["@emailheader"].Value.ToString();
                            string emailcontent = sqlDA_alpha.SelectCommand.Parameters["@emailcontent"].Value.ToString();

                            conn_alpha.Close();
                            // end move failed record to SQLSolicitorDPSubmission_VirusLog

                            // start get failed attachments
                            SqlConnection conn_beta = new SqlConnection(connstr2);

                            SqlDataAdapter sqlDA_beta = new SqlDataAdapter();
                            sqlDA_beta.SelectCommand = new SqlCommand("dbo.[usp_ws_getfailedattachments] @arn, @workflow, @error output", conn_beta);
                            sqlDA_beta.SelectCommand.Parameters.AddWithValue("@arn", draft_arn);
                            //sqlDA_beta.SelectCommand.Parameters.AddWithValue("@draftID", draftID);
                            sqlDA_beta.SelectCommand.Parameters.AddWithValue("@workflow", "ProjectSubmission");
                            sqlDA_beta.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet ds_beta = new DataSet("ds");
                            DataTable dt_beta = null;
                            sqlDA_beta.Fill(ds_beta);

                            if (ds_beta.Tables.Count > 0)
                            {
                                dt_beta = ds_beta.Tables[0];

                                for (int beta = 0; beta < dt_beta.Rows.Count; beta++)
                                {
                                    //var workflow = dt_beta.Rows[beta]["workflow"];
                                    var filename_original = dt_beta.Rows[beta]["filename_original"];
                                    var filename_new = dt_beta.Rows[beta]["filename_new"];
                                    var filecontent = dt_beta.Rows[beta]["filecontent"];
                                    var filetype = dt_beta.Rows[beta]["filetype"];
                                    var attachmentuploaddate = dt_beta.Rows[beta]["attachmentuploaddate"];
                                    var fe_file_url = dt_beta.Rows[beta]["fe_file_url"];
                                    var fe_fireeye_id = dt_beta.Rows[beta]["fe_fireeye_id"];
                                    var fe_failed_description = dt_beta.Rows[beta]["fe_failed_description"];
                                    var fe_failed_code = dt_beta.Rows[beta]["fe_failed_code"];
                                    var VSresult = dt_beta.Rows[beta]["result"];
                                    var VSCreatedDate = dt_beta.Rows[beta]["CreatedDate"];
                                    var VSUpdatedDate = dt_beta.Rows[beta]["UpdatedDate"];

                                    // start log detail into VS_attachment_detail
                                    SqlConnection conn_gama = new SqlConnection(connstr);

                                    SqlDataAdapter sqlDA_gama = new SqlDataAdapter();
                                    sqlDA_gama.SelectCommand = new SqlCommand("dbo.[usp_ws_savefailedattachmentdata] @arn ,@workflow,@filename_original,@filename_new,@filecontent,@filetype,@attachmentuploaddate,@fe_file_url,@fe_fireeye_id,@fe_failed_description,@fe_failed_code,@result,@VSCreatedDate,@VSUpdatedDate, @error output", conn_gama);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@workflow", workflow);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_original", filename_original);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_new", filename_new);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filecontent", filecontent);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filetype", filetype);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@attachmentuploaddate", attachmentuploaddate);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_file_url", fe_file_url);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_fireeye_id", fe_fireeye_id);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_description", fe_failed_description);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_code", fe_failed_code);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@result", VSresult);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSCreatedDate", VSCreatedDate);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSUpdatedDate", VSUpdatedDate);
                                    sqlDA_gama.SelectCommand.Parameters.AddWithValue("@error", "");

                                    DataSet ds_gama = new DataSet("ds");
                                    DataTable dt_gama = null;
                                    //dt_gama = ds_gama.Tables[0];
                                    sqlDA_gama.Fill(ds_gama);
                                    conn_gama.Close();
                                    // end log detail into VS_attachment_detail
                                }

                            }
                            conn_beta.Close();
                            // end get failed attachments

                            if (receiveremail != "")
                            {
                                SendMail(receiveremail, emailheader, emailcontent, null, null);
                            }


                            /*
                            // 20200827 start direct send email from WS  
                            SqlConnection connZeta = new SqlConnection(connstr);

                            SqlDataAdapter sqlDAZeta = new SqlDataAdapter();
                            sqlDAZeta.SelectCommand = new SqlCommand("dbo.[usp_DUMaker_Letter_AV_SolicitorDisbursement_email_content_generate]", connZeta);

                            DataSet dsZeta = new DataSet("ds");
                            //DataTable dt2 = null;
                            //dt2 = ds2.Tables[0];
                            sqlDAZeta.Fill(dsZeta);
                            DataTable dtZeta = null;

                            if (dsZeta.Tables.Count > 0)
                            {
                                dtZeta = dsZeta.Tables[0];

                                var receiveremail = dtZeta.Rows[0]["receiveremail"].ToString();
                                var email_header = dtZeta.Rows[0]["email_header"].ToString();
                                var email_body = dtZeta.Rows[0]["email_body"].ToString();

                                SendMail(receiveremail, email_header, email_body, null, null);
                            }
                            // 20200827 end direct send email from WS
                            */
                            // start delete VS master data and detail data 
                            /*
                            SqlConnection conn2 = new SqlConnection(connstr2);

                            SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                            sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                            DataSet ds2 = new DataSet("ds");
                            DataTable dt2 = null;
                            //dt2 = ds2.Tables[0];
                            sqlDA2.Fill(ds2);
                            conn2.Close();
                            */
                            // end delete VS master data and detail data 
                        }

                        // start delete VS master data and detail data                         
                        SqlConnection conn2 = new SqlConnection(connstr2);

                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                        sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", conn2);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", draft_arn);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "ProjectSubmission");
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet ds2 = new DataSet("ds");
                        //DataTable dt2 = null;
                        //dt2 = ds2.Tables[0];
                        sqlDA2.Fill(ds2);
                        conn2.Close();
                        // end delete VS master data and detail data 
                    }
                }

                



                // DP_DeleteSolicitorDisbursement_Attachment(arn, ref error);


            }
            catch (Exception ex)
            {
                error = "DP_CompletedProjectDisbursement_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_CompletedProjectDisbursement_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_CompletedValuer_Attachment(ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                conn = new SqlConnection(connstr2);

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.[usp_ws_Check_ValuerSubmissionAttachment_Completed_ARN] @error output", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@error", "");

                string arn;
                string result;
                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        arn = dt.Rows[i]["ARN"].ToString();
                        result = dt.Rows[i]["result"].ToString();

                        // start check if the record still in staging
                        DataSet dsBETA = null;
                        DataTable dtBETA = null;
                        SqlConnection connBETA = null;
                        SqlDataAdapter sqlDABETA = null;
                        connBETA = new SqlConnection(connstr);

                        string errorBETA = "";

                        sqlDABETA = new SqlDataAdapter();
                        sqlDABETA.SelectCommand = new SqlCommand("dbo.[usp_ws_check_ValuerSubmissionStillInStaging] @arn, @error output", connBETA);
                        sqlDABETA.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDABETA.SelectCommand.Parameters.AddWithValue("@error", errorBETA);

                        dsBETA = new DataSet("ds");
                        sqlDABETA.Fill(dsBETA);

                        if (errorBETA == "")
                        {
                            // end check if the record still in staging 
                            if (result == "passed")
                            //if (result == "failed")
                            {
                                // start get edms settings 
                                SqlConnection connx = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAx = new SqlDataAdapter();
                                sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Valuer_Setting] @error output", connx);
                                sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsx = new DataSet("ds");
                                DataTable dtx = null;

                                sqlDAx.Fill(dsx);
                                dtx = dsx.Tables[0];

                                var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
                                var ProfileName = dtx.Rows[0]["ProfileName"];
                                var LoginUser = dtx.Rows[0]["LoginUser"];
                                var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
                                var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
                                var Category = dtx.Rows[0]["Category"];
                                connx.Close();
                                // end get edms settings

                                // start get customer name and id for the selected arn 
                                SqlConnection conny = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAy = new SqlDataAdapter();
                                sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsy = new DataSet("ds");
                                DataTable dty = null;

                                sqlDAy.Fill(dsy);
                                dty = dsy.Tables[0];
                                var CustomerID = dty.Rows[0]["CustomerID"].ToString();
                                if (CustomerID.ToString() == "")
                                {
                                    CustomerID = "N/A";
                                }
                                var CustomerName = dty.Rows[0]["CustomerName"].ToString();
                                if (CustomerName.ToString() == "")
                                {
                                    CustomerName = "N/A";
                                }
                                conny.Close();
                                // end get customer name and id for the selected arn 

                                // start get attachment detail 
                                SqlConnection conn1 = null;
                                conn1 = new SqlConnection(connstr2);
                                SqlDataAdapter sqlDA1 = new SqlDataAdapter();
                                sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_list_ValuerSubmissionAttachment_For_Completed_ARN] @ARN, @error output", conn1);
                                sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA1.SelectCommand.Parameters.AddWithValue("@error", error);

                                DataSet ds1 = null;
                                DataTable dt1 = null;

                                ds1 = new DataSet("ds");

                                sqlDA1.Fill(ds1);

                                if (ds1.Tables.Count > 0)
                                {
                                    dt1 = ds1.Tables[0];

                                    for (int j = 0; j < dt1.Rows.Count; j++)
                                    {
                                        var filename_original = dt1.Rows[j]["filename_original"];
                                        var filename_new = dt1.Rows[j]["filename_new"];
                                        var filecontent = dt1.Rows[j]["filecontent"];
                                        //byte[] byteFileContent = Convert.FromBase64String(filecontent);
                                        var filetype = dt1.Rows[j]["filetype"];
                                        var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
                                        var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
                                        var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
                                        var d_result = dt1.Rows[j]["result"];

                                        string DP_ExportK2FileToEDMS_error = "";
                                        ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn, EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

                                    }
                                }
                                conn1.Close();
                                // end get attachment detail 

                                // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
                                SqlConnection connz = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAz = new SqlDataAdapter();
                                sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLValuerDPSubmission_Main_MoveToMain] @arn, @error output", connz);
                                sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsz = new DataSet("ds");
                                DataTable dtz = null;
                                //dtz = dsz.Tables[0];
                                sqlDAz.Fill(dsz);
                                connz.Close();
                                // start move arn from staging to main 

                                // start delete VS master data and detail data 
                                /*
                                SqlConnection conn2 = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds2 = new DataSet("ds");
                                DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDA2.Fill(ds2);
                                conn2.Close();
                                */
                                // end delete VS master data and detail data 

                            }
                            else
                            {
                                // start move failed record to SQLSolicitorDPSubmission_VirusLog
                                SqlConnection conn_alpha = new SqlConnection(connstr);

                                SqlDataAdapter sqlDA_alpha = new SqlDataAdapter();
                                sqlDA_alpha.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLValuerDPSubmission_MoveFailedToMain] @arn, @error output", conn_alpha);
                                sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA_alpha.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds_alpha = new DataSet("ds");
                                //DataTable dt_alpha = null;
                                //dt_alpha = ds_alpha.Tables[0];
                                sqlDA_alpha.Fill(ds_alpha);
                                conn_alpha.Close();
                                // end move failed record to SQLSolicitorDPSubmission_VirusLog

                                // start get failed attachments
                                SqlConnection conn_beta = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA_beta = new SqlDataAdapter();
                                sqlDA_beta.SelectCommand = new SqlCommand("dbo.[usp_ws_getfailedattachments] @arn, @workflow, @error output", conn_beta);
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@workflow", "ValuerDPSubmission");
                                sqlDA_beta.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds_beta = new DataSet("ds");
                                DataTable dt_beta = null;
                                sqlDA_beta.Fill(ds_beta);

                                if (ds_beta.Tables.Count > 0)
                                {
                                    dt_beta = ds_beta.Tables[0];

                                    for (int beta = 0; beta < dt_beta.Rows.Count; beta++)
                                    {
                                        var workflow = dt_beta.Rows[beta]["workflow"];
                                        var filename_original = dt_beta.Rows[beta]["filename_original"];
                                        var filename_new = dt_beta.Rows[beta]["filename_new"];
                                        var filecontent = dt_beta.Rows[beta]["filecontent"];
                                        var filetype = dt_beta.Rows[beta]["filetype"];
                                        var attachmentuploaddate = dt_beta.Rows[beta]["attachmentuploaddate"];
                                        var fe_file_url = dt_beta.Rows[beta]["fe_file_url"];
                                        var fe_fireeye_id = dt_beta.Rows[beta]["fe_fireeye_id"];
                                        var fe_failed_description = dt_beta.Rows[beta]["fe_failed_description"];
                                        var fe_failed_code = dt_beta.Rows[beta]["fe_failed_code"];
                                        var VSresult = dt_beta.Rows[beta]["result"];
                                        var VSCreatedDate = dt_beta.Rows[beta]["CreatedDate"];
                                        var VSUpdatedDate = dt_beta.Rows[beta]["UpdatedDate"];

                                        // start log detail into VS_attachment_detail
                                        SqlConnection conn_gama = new SqlConnection(connstr);

                                        SqlDataAdapter sqlDA_gama = new SqlDataAdapter();
                                        sqlDA_gama.SelectCommand = new SqlCommand("dbo.[usp_ws_savefailedattachmentdata] @arn ,@workflow,@filename_original,@filename_new,@filecontent,@filetype,@attachmentuploaddate,@fe_file_url,@fe_fireeye_id,@fe_failed_description,@fe_failed_code,@result,@VSCreatedDate,@VSUpdatedDate, @error output", conn_gama);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@workflow", workflow);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_original", filename_original);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filename_new", filename_new);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filecontent", filecontent);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@filetype", filetype);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@attachmentuploaddate", attachmentuploaddate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_file_url", fe_file_url);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_fireeye_id", fe_fireeye_id);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_description", fe_failed_description);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@fe_failed_code", fe_failed_code);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@result", VSresult);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSCreatedDate", VSCreatedDate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@VSUpdatedDate", VSUpdatedDate);
                                        sqlDA_gama.SelectCommand.Parameters.AddWithValue("@error", "");

                                        DataSet ds_gama = new DataSet("ds");
                                        DataTable dt_gama = null;
                                        //dt_gama = ds_gama.Tables[0];
                                        sqlDA_gama.Fill(ds_gama);
                                        conn_gama.Close();
                                        // end log detail into VS_attachment_detail
                                    }
                                    
                                }
                                conn_beta.Close();
                                // end get failed attachments

                                // 20200827 start direct send email from WS  
                                SqlConnection connZeta = new SqlConnection(connstr);

                                SqlDataAdapter sqlDAZeta = new SqlDataAdapter();
                                sqlDAZeta.SelectCommand = new SqlCommand("dbo.[usp_DUMaker_Letter_AV_Valuer_email_content_generate]", connZeta);

                                DataSet dsZeta = new DataSet("ds");
                                //DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDAZeta.Fill(dsZeta);
                                DataTable dtZeta = null;

                                if (dsZeta.Tables.Count > 0)
                                {
                                    dtZeta = dsZeta.Tables[0];

                                    var receiveremail = dtZeta.Rows[0]["receiveremail"].ToString();
                                    var email_header = dtZeta.Rows[0]["email_header"].ToString();
                                    var email_body = dtZeta.Rows[0]["email_body"].ToString();

                                    SendMail(receiveremail, email_header, email_body, null,null);
                                }
                                // 20200827 end direct send email from WS  

                                // start delete VS master data and detail data 
                                /*
                                SqlConnection conn2 = new SqlConnection(connstr2);

                                SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_deleterecords] @arn, @workflow, @error output", conn2);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet ds2 = new DataSet("ds");
                                DataTable dt2 = null;
                                //dt2 = ds2.Tables[0];
                                sqlDA2.Fill(ds2);
                                conn2.Close();
                                */
                                // end delete VS master data and detail data 
                            }
                        }

                        

                        // start delete VS master data and detail data                         
                        SqlConnection conn2 = new SqlConnection(connstr2);

                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
                        sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", conn2);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@workflow", "ValuerDPSubmission");
                        sqlDA2.SelectCommand.Parameters.AddWithValue("@error", "");

                        DataSet ds2 = new DataSet("ds");
                        //DataTable dt2 = null;
                        //dt2 = ds2.Tables[0];
                        sqlDA2.Fill(ds2);
                        conn2.Close();
                        // end delete VS master data and detail data 

                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                error = "DP_CompletedValuer_Attachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_CompletedValuer_Attachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SaveSolicitorAttachment(string arn, string k2fileattachment, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }


                SqlConnection connPRE0 = null;
                SqlDataAdapter sqlDAPRE0 = null;

                connPRE0 = new SqlConnection(connstr);

                sqlDAPRE0 = new SqlDataAdapter();
                sqlDAPRE0.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE0);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE0 = new DataSet("ds");
                sqlDAPRE0.Fill(dsPRE0);

                if (dsPRE0.Tables.Count > 0)
                {
                    DataTable dtPRE0 = dsPRE0.Tables[0];
                    fireeye_flag = dtPRE0.Rows[0]["fireeye_flag"].ToString();
                }

                if (fireeye_flag == "1")
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr2);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_solicitorattachment_preupload] @arn,@k2attachment, @error output", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", k2fileattachment);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);
                }
                else
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_solicitorattachment_preupload] @arn,@k2attachment, @error output", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", k2fileattachment);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);
                }

            }
            catch (Exception ex)
            {
                error = "DP_SaveSolicitorAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", k2fileattachment:" + k2fileattachment;
                LogErrorToDB("DP_SaveSolicitorAttachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_MoveSolicitorDisbursementAttachmentToStaging(string arn, string SolicitorCode,  ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                /*
                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;
                */

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                /*
                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }
                */

                SqlConnection connPRE0 = null;
                SqlDataAdapter sqlDAPRE0 = null;

                connPRE0 = new SqlConnection(connstr);

                sqlDAPRE0 = new SqlDataAdapter();
                sqlDAPRE0.SelectCommand = new SqlCommand("dbo.[aa_ws_SolicitorDisbursementAttachment_ListByARN] @arn, @SolicitorCode, @error output", connPRE0);
                sqlDAPRE0.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAPRE0.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolicitorCode);
                sqlDAPRE0.SelectCommand.Parameters.AddWithValue("@error", "");
               
                DataSet dsPRE0 = new DataSet("ds");
                sqlDAPRE0.Fill(dsPRE0);

                string k2fileattachment;

                if (dsPRE0.Tables.Count > 0)
                {
                    dt = dsPRE0.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //arn = dt.Rows[i]["ARN"].ToString();                        
                        k2fileattachment = dt.Rows[0]["Attachment"].ToString();

                        string ref_error = "";
                        DP_SaveSolicitorDisbursementAttachment2(arn, k2fileattachment, SolicitorCode, ref ref_error);
                    }
                }

            }
            catch (Exception ex)
            {
                error = "DP_MoveSolicitorDisbursementAttachmentToStaging failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", SolicitorCode:" + SolicitorCode;
                LogErrorToDB("DP_MoveSolicitorDisbursementAttachmentToStaging", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SaveSolicitorDisbursementAttachment2(string arn, string k2fileattachment, string solicitorcode,ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }


                SqlConnection connPRE0 = null;
                SqlDataAdapter sqlDAPRE0 = null;

                connPRE0 = new SqlConnection(connstr);

                sqlDAPRE0 = new SqlDataAdapter();
                sqlDAPRE0.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE0);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE0 = new DataSet("ds");
                sqlDAPRE0.Fill(dsPRE0);

                if (dsPRE0.Tables.Count > 0)
                {
                    DataTable dtPRE0 = dsPRE0.Tables[0];
                    fireeye_flag = dtPRE0.Rows[0]["fireeye_flag"].ToString();
                }

                if (fireeye_flag == "1")
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr2);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.[aa_ws_solicitordisbursementattachment_preupload] @arn,@k2attachment, @error output", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", k2fileattachment);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);
                }
                else
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.[aa_ws_SolicitorDisbursementAttachment_PreUpload] @arn,@k2attachment, @error output", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", k2fileattachment);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);
                }

            }
            catch (Exception ex)
            {
                error = "DP_SaveSolicitorDisbursementAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", k2fileattachment:" + k2fileattachment;
                LogErrorToDB("DP_SaveSolicitorDisbursementAttachment", "Exception", error, errorDetail);
            }
        }


        [WebMethod]
        public void DP_SaveSolicitorDisbursementAttachment3(string arn, ref string error)
        {
            error = "";

            try
            {
                // step 1: get list of attachments
                DataSet dsY = null;
                DataTable dtY = null;
                SqlConnection connY = null;
                SqlDataAdapter sqlDAY = null;

                string strDataSourceY = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBNameY = clsGlobal.MG_SQL_DB_NAME2;
                string strIDY = clsGlobal.MG_SQL_ID2;
                string strPasswordY = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuthY = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstrY = @"Data Source=" + strDataSourceY + ";Initial Catalog=" + strDBNameY + ";Persist Security Info=True;User ID=" + strIDY + ";Password=" + strPasswordY;
                if (blnIsWinAuthY)
                {
                    connstrY = @"Data Source=" + strDataSourceY + ";Initial Catalog=" + strDBNameY + ";Integrated Security=True;";
                }

                connY = null;
                sqlDAY = null;

                connY = new SqlConnection(connstrY);

                sqlDAY = new SqlDataAdapter();
                sqlDAY.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_SelectAll @arn", connY);
                sqlDAY.SelectCommand.Parameters.AddWithValue("@arn", arn);

                dsY = new DataSet("ds");
                sqlDAY.Fill(dsY);

                string Attachment;

                if (dsY.Tables.Count > 0)
                {
                    dtY = dsY.Tables[0];

                    if (dtY.Rows.Count > 0)
                    {
                        // step 2: loop each attachments 
                        for (int i = 0; i < dtY.Rows.Count; i++)
                        {
                            Attachment = dtY.Rows[i]["Attachment"].ToString();

                            // step 3: get fireeye flag 
                            DataSet ds = null;
                            DataTable dt = null;
                            SqlConnection conn = null;
                            SqlDataAdapter sqlDA = null;

                            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                            string strDBName = clsGlobal.MG_SQL_DB_NAME;
                            string strID = clsGlobal.MG_SQL_ID;
                            string strPassword = clsGlobal.MG_SQL_PASSWORD;
                            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                            string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                            string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                            string strID2 = clsGlobal.MG_SQL_ID2;
                            string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                            bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                            if (blnIsWinAuth)
                            {
                                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                            }

                            string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                            if (blnIsWinAuth2)
                            {
                                connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                            }


                            SqlConnection connPRE0 = null;
                            SqlDataAdapter sqlDAPRE0 = null;

                            connPRE0 = new SqlConnection(connstr);

                            sqlDAPRE0 = new SqlDataAdapter();
                            sqlDAPRE0.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE0);

                            string fireeye_flag;
                            fireeye_flag = "";
                            DataSet dsPRE0 = new DataSet("ds");
                            sqlDAPRE0.Fill(dsPRE0);

                            if (dsPRE0.Tables.Count > 0)
                            {
                                DataTable dtPRE0 = dsPRE0.Tables[0];
                                fireeye_flag = dtPRE0.Rows[0]["fireeye_flag"].ToString();
                            }

                            if (fireeye_flag == "1")
                            {
                                //step 4a: move attachment to VS staging 
                                SqlConnection connPRE = null;
                                SqlDataAdapter sqlDAPRE = null;

                                connPRE = new SqlConnection(connstr2);

                                sqlDAPRE = new SqlDataAdapter();
                                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[aa_ws_solicitordisbursementattachment_preupload] @arn,@k2attachment, @error output", connPRE);
                                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", Attachment);
                                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsPRE = new DataSet("ds");
                                sqlDAPRE.Fill(dsPRE);
                            }
                            else
                            {
                                //step 4a: move attachment to MG staging 
                                SqlConnection connPRE = null;
                                SqlDataAdapter sqlDAPRE = null;

                                connPRE = new SqlConnection(connstr);

                                sqlDAPRE = new SqlDataAdapter();
                                sqlDAPRE.SelectCommand = new SqlCommand("dbo.[aa_ws_SolicitorDisbursementAttachment_PreUpload] @arn,@k2attachment, @error output", connPRE);
                                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", Attachment);
                                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                                DataSet dsPRE = new DataSet("ds");
                                sqlDAPRE.Fill(dsPRE);
                            }
                        }
                    }
                }

                

            }
            catch (Exception ex)
            {
                error = "DP_SaveSolicitorDisbursementAttachment3 failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn ;
                LogErrorToDB("DP_SaveSolicitorDisbursementAttachment3", "Exception", error, errorDetail);
            }
        }
        [WebMethod]
        public void DP_SolicitorDPSubmissionAttachment_add_withattachment(string arn, string k2fileattachment, string solicitorcode, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_ws_SQLSolicitorDPSubmissionAttachment_add_withattachment @solicitoremail, @arn, @attachment", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@solicitoremail", solicitorcode);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@attachment", k2fileattachment);

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

            }
            catch (Exception ex)
            {
                error = "DP_SolicitorDPSubmissionAttachment_add_withattachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", solicitorcode:" + solicitorcode;
                LogErrorToDB("DP_SolicitorDPSubmissionAttachment_add_withattachment", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolDisbursementSubmission_Main
            (
                string arn, 
                string BalanceAdviceLetterApplicableFlag, 
                string UrgentFlag,
                string LS_RedemptionDueDateFlag,
                string LS_RedemptionDueDate,
                string LS_ExtendedCompletionDateFlag,
                string LS_CompletionDate,
                string LS_ExtendedCompletionDate,
                string PR_DeveloperBillingDueDateFlag,
                string PR_Stage2AFlag,

                string PR_Stage2BFlag,
                string PR_Stage2CFlag,
                string PR_Stage2DFlag,
                string PR_Stage2EFlag,
                string PR_Stage2FFlag,
                string PR_Stage2GFlag,
                string PR_Stage2HFlag,
                string PR_StageOthers,
                string PR_EarliestBillingDueDate,
                string PR_TotalBillingAmount,

                string PR_AnyBridgingFinancierFlag,
                string PR_BridgingFinancier,
                string PR_BridgingFinancierEmailAddress,
                string PR_BridgingFinancierRedemptionSum ,
                string PR_RedemptionPaymentAccountNumber,
                string PR_BeneficiaryBank,
                string PR_BridgingFinancierRedemptionExpiryDate,
                string PR_DeveloperName,
                string PR_DeveloperEmailAddress,
                string PR_DeveloperPIC,

                string PR_DeveloperHDA,
                string PR_DeveloperHDABank,
                string LF_PayeeName,
                string LF_BilledAmount,
                string LF_AccountNumber,
                string LF_Bank,
                string LF_PaymentDescription,
                string LF_PaymentMode,
                string UpdateInfo_Reason,
                string UpdateInfo_Others,

                string CancelLoan_Remarks,
                string CancelLoan_File,
                string SolicitorSubmissionOption,
                string SolicitorSubmissionStatus,
                string SolicitorCode,
                ref string error)
        {
            error = "";

            try
            {
                // start get attachment count from VS DB
                DataSet dsZ = null;
                DataTable dtZ = null;
                SqlConnection connZ = null;
                SqlDataAdapter sqlDAZ = null;

                if (PR_BridgingFinancierRedemptionSum != null)
                {
                    if (PR_BridgingFinancierRedemptionSum.Trim() == "") PR_BridgingFinancierRedemptionSum = null;
                }
                
                if (PR_TotalBillingAmount != null)
                {
                    if (PR_TotalBillingAmount.Trim() == "") PR_TotalBillingAmount = null;
                }
                
                if (LF_BilledAmount != null)
                {
                    if (LF_BilledAmount.Trim() == "") LF_BilledAmount = null;
                }
                

                string strDataSourceZ = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBNameZ = clsGlobal.MG_SQL_DB_NAME2;
                string strIDZ = clsGlobal.MG_SQL_ID2;
                string strPasswordZ = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuthZ = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstrZ = @"Data Source=" + strDataSourceZ + ";Initial Catalog=" + strDBNameZ + ";Persist Security Info=True;User ID=" + strIDZ + ";Password=" + strPasswordZ;
                if (blnIsWinAuthZ)
                {
                    connstrZ = @"Data Source=" + strDataSourceZ + ";Initial Catalog=" + strDBNameZ + ";Integrated Security=True;";
                }

                connZ = new SqlConnection(connstrZ);

                sqlDAZ = new SqlDataAdapter();
                sqlDAZ.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_SelectAttachmentCount @arn", connZ);
                sqlDAZ.SelectCommand.Parameters.AddWithValue("@arn", arn);

                dsZ = new DataSet("ds");
                sqlDAZ.Fill(dsZ);

                string AttachmentCount = dsZ.Tables[0].Rows[0]["AttachmentCount"].ToString();

                // end get attachment count from VS DB


                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                //sqlDAPRE = new SqlDataAdapter();
                //sqlDAPRE.SelectCommand = new SqlCommand("dbo.aa_SolDisbursementSubmission_Main @arn , @BalanceAdviceLetterApplicableFlag, @UrgentFlag, @LS_RedemptionDueDateFlag, @LS_RedemptionDueDate, @LS_ExtendedCompletionDateFlag, @LS_CompletionDate, @LS_ExtendedCompletionDate, @PR_DeveloperBillingDueDateFlag, @PR_Stage2AFlag, @PR_Stage2BFlag, @PR_Stage2CFlag, @PR_Stage2DFlag, @PR_Stage2EFlag, @PR_Stage2FFlag, @PR_Stage2GFlag, @PR_Stage2HFlag, @PR_StageOthers, @PR_EarliestBillingDueDate, @PR_TotalBillingAmount, @PR_AnyBridgingFinancierFlag, @PR_BridgingFinancier, @PR_BridgingFinancierEmailAddress, @PR_BridgingFinancierRedemptionSum, @PR_RedemptionPaymentAccountNumber, @PR_BeneficiaryBank, @PR_BridgingFinancierRedemptionExpiryDate, @PR_DeveloperName, @PR_DeveloperEmailAddress, @PR_DeveloperPIC, @PR_DeveloperHDA, @PR_DeveloperHDABank, @LF_PayeeName, @LF_BilledAmount, @LF_AccountNumber, @LF_Bank, @LF_PaymentDescription, @LF_PaymentMode, @UpdateInfo_Reason, @UpdateInfo_Others, @CancelLoan_Remarks, @CancelLoan_File, @SolicitorSubmissionOption, @SolicitorSubmissionStatus, @SolicitorCode, @Error output ", connPRE);
                SqlCommand command = new SqlCommand("aa_SolDisbursementSubmission_Main", connPRE);
                command.CommandType = CommandType.StoredProcedure;                

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                SqlParameter p_arn = new SqlParameter("@arn", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_arn.Value = arn;
                command.Parameters.Add(p_arn);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@BalanceAdviceLetterApplicableFlag", BalanceAdviceLetterApplicableFlag);
                SqlParameter p_BalanceAdviceLetterApplicableFlag = new SqlParameter("@BalanceAdviceLetterApplicableFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_BalanceAdviceLetterApplicableFlag.Value = BalanceAdviceLetterApplicableFlag;
                command.Parameters.Add(p_BalanceAdviceLetterApplicableFlag);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@UrgentFlag", UrgentFlag);
                SqlParameter p_UrgentFlagg = new SqlParameter("@UrgentFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_UrgentFlagg.Value = UrgentFlag;
                command.Parameters.Add(p_UrgentFlagg);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LS_RedemptionDueDateFlag", LS_RedemptionDueDateFlag);
                SqlParameter p_LS_RedemptionDueDateFlag = new SqlParameter("@LS_RedemptionDueDateFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LS_RedemptionDueDateFlag.Value = LS_RedemptionDueDateFlag;
                command.Parameters.Add(p_LS_RedemptionDueDateFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LS_RedemptionDueDate", LS_RedemptionDueDate);
                SqlParameter p_LS_RedemptionDueDate = new SqlParameter("@LS_RedemptionDueDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LS_RedemptionDueDate.Value = LS_RedemptionDueDate;
                command.Parameters.Add(p_LS_RedemptionDueDate);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LS_ExtendedCompletionDateFlag", LS_ExtendedCompletionDateFlag);
                SqlParameter p_LS_ExtendedCompletionDateFlag = new SqlParameter("@LS_ExtendedCompletionDateFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LS_ExtendedCompletionDateFlag.Value = LS_ExtendedCompletionDateFlag;
                command.Parameters.Add(p_LS_ExtendedCompletionDateFlag);


                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LS_CompletionDate", LS_CompletionDate);
                SqlParameter p_LS_CompletionDate = new SqlParameter("@LS_CompletionDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LS_CompletionDate.Value = LS_CompletionDate;
                command.Parameters.Add(p_LS_CompletionDate);


                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LS_ExtendedCompletionDate", LS_ExtendedCompletionDate);
                SqlParameter p_LS_ExtendedCompletionDate = new SqlParameter("@LS_ExtendedCompletionDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LS_ExtendedCompletionDate.Value = LS_ExtendedCompletionDate;
                command.Parameters.Add(p_LS_ExtendedCompletionDate);


                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_DeveloperBillingDueDateFlag", PR_DeveloperBillingDueDateFlag);
                SqlParameter p_PR_DeveloperBillingDueDateFlag = new SqlParameter("@PR_DeveloperBillingDueDateFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_DeveloperBillingDueDateFlag.Value = PR_DeveloperBillingDueDateFlag;
                command.Parameters.Add(p_PR_DeveloperBillingDueDateFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2AFlag", PR_Stage2AFlag);
                SqlParameter p_PR_Stage2AFlag = new SqlParameter("@PR_Stage2AFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2AFlag.Value = PR_Stage2AFlag;
                command.Parameters.Add(p_PR_Stage2AFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2BFlag", PR_Stage2BFlag);
                SqlParameter p_PR_Stage2BFlag = new SqlParameter("@PR_Stage2BFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2BFlag.Value = PR_Stage2BFlag;
                command.Parameters.Add(p_PR_Stage2BFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2CFlag", PR_Stage2CFlag);
                SqlParameter p_PR_Stage2CFlag = new SqlParameter("@PR_Stage2CFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2CFlag.Value = PR_Stage2CFlag;
                command.Parameters.Add(p_PR_Stage2CFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2DFlag", PR_Stage2DFlag);
                SqlParameter p_PR_Stage2DFlag = new SqlParameter("@PR_Stage2DFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2DFlag.Value = PR_Stage2DFlag;
                command.Parameters.Add(p_PR_Stage2DFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2EFlag", PR_Stage2EFlag);
                SqlParameter p_PR_Stage2EFlag = new SqlParameter("@PR_Stage2EFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2EFlag.Value = PR_Stage2EFlag;
                command.Parameters.Add(p_PR_Stage2EFlag);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2FFlag", PR_Stage2FFlag);
                SqlParameter p_PR_Stage2FFlag = new SqlParameter("@PR_Stage2FFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2FFlag.Value = PR_Stage2FFlag;
                command.Parameters.Add(p_PR_Stage2FFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2GFlag", PR_Stage2GFlag);
                SqlParameter p_PR_Stage2GFlag = new SqlParameter("@PR_Stage2GFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2GFlag.Value = PR_Stage2GFlag;
                command.Parameters.Add(p_PR_Stage2GFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_Stage2HFlag", PR_Stage2HFlag);
                SqlParameter p_PR_Stage2HFlag = new SqlParameter("@PR_Stage2HFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_Stage2HFlag.Value = PR_Stage2HFlag;
                command.Parameters.Add(p_PR_Stage2HFlag);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_StageOthers", PR_StageOthers);
                SqlParameter p_PR_StageOthers = new SqlParameter("@PR_StageOthers", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_StageOthers.Value = PR_StageOthers;
                command.Parameters.Add(p_PR_StageOthers);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_EarliestBillingDueDate", PR_EarliestBillingDueDate);
                SqlParameter p_PR_EarliestBillingDueDate = new SqlParameter("@PR_EarliestBillingDueDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_EarliestBillingDueDate.Value = PR_EarliestBillingDueDate;
                command.Parameters.Add(p_PR_EarliestBillingDueDate);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_TotalBillingAmount", PR_TotalBillingAmount);
                SqlParameter p_PR_TotalBillingAmount = new SqlParameter("@PR_TotalBillingAmount", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_TotalBillingAmount.Value = PR_TotalBillingAmount;
                command.Parameters.Add(p_PR_TotalBillingAmount);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_AnyBridgingFinancierFlag", PR_AnyBridgingFinancierFlag);
                SqlParameter p_PR_AnyBridgingFinancierFlag = new SqlParameter("@PR_AnyBridgingFinancierFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_AnyBridgingFinancierFlag.Value = PR_AnyBridgingFinancierFlag;
                command.Parameters.Add(p_PR_AnyBridgingFinancierFlag);


                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_BridgingFinancier", PR_BridgingFinancier);
                SqlParameter p_PR_BridgingFinancier = new SqlParameter("@PR_BridgingFinancier", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_BridgingFinancier.Value = PR_BridgingFinancier;
                command.Parameters.Add(p_PR_BridgingFinancier);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_BridgingFinancierEmailAddress", PR_BridgingFinancierEmailAddress);
                SqlParameter p_PR_BridgingFinancierEmailAddress = new SqlParameter("@PR_BridgingFinancierEmailAddress", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_BridgingFinancierEmailAddress.Value = PR_BridgingFinancierEmailAddress;
                command.Parameters.Add(p_PR_BridgingFinancierEmailAddress);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_BridgingFinancierRedemptionSum", PR_BridgingFinancierRedemptionSum);
                SqlParameter p_PR_BridgingFinancierRedemptionSum = new SqlParameter("@PR_BridgingFinancierRedemptionSum", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_BridgingFinancierRedemptionSum.Value = PR_BridgingFinancierRedemptionSum;
                command.Parameters.Add(p_PR_BridgingFinancierRedemptionSum);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_RedemptionPaymentAccountNumber", PR_RedemptionPaymentAccountNumber);
                SqlParameter p_PR_RedemptionPaymentAccountNumber = new SqlParameter("@PR_RedemptionPaymentAccountNumber", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_RedemptionPaymentAccountNumber.Value = PR_RedemptionPaymentAccountNumber;
                command.Parameters.Add(p_PR_RedemptionPaymentAccountNumber);


                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_BeneficiaryBank", PR_BeneficiaryBank);
                SqlParameter p_PR_BeneficiaryBank = new SqlParameter("@PR_BeneficiaryBank", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_BeneficiaryBank.Value = PR_BeneficiaryBank;
                command.Parameters.Add(p_PR_BeneficiaryBank);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_BridgingFinancierRedemptionExpiryDate", PR_BridgingFinancierRedemptionExpiryDate);
                SqlParameter p_PR_BridgingFinancierRedemptionExpiryDate = new SqlParameter("@PR_BridgingFinancierRedemptionExpiryDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_BridgingFinancierRedemptionExpiryDate.Value = PR_BridgingFinancierRedemptionExpiryDate;
                command.Parameters.Add(p_PR_BridgingFinancierRedemptionExpiryDate);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_DeveloperName", PR_DeveloperName);
                SqlParameter p_PR_DeveloperName = new SqlParameter("@PR_DeveloperName", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_DeveloperName.Value = PR_DeveloperName;
                command.Parameters.Add(p_PR_DeveloperName);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_DeveloperEmailAddress", PR_DeveloperEmailAddress);
                SqlParameter p_PR_DeveloperEmailAddress = new SqlParameter("@PR_DeveloperEmailAddress", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_DeveloperEmailAddress.Value = PR_DeveloperEmailAddress;
                command.Parameters.Add(p_PR_DeveloperEmailAddress);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_DeveloperPIC", PR_DeveloperPIC);
                SqlParameter p_PR_DeveloperPIC = new SqlParameter("@PR_DeveloperPIC", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_DeveloperPIC.Value = PR_DeveloperPIC;
                command.Parameters.Add(p_PR_DeveloperPIC);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_DeveloperHDA", PR_DeveloperHDA);
                SqlParameter p_PR_DeveloperHDA = new SqlParameter("@PR_DeveloperHDA", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_DeveloperHDA.Value = PR_DeveloperHDA;
                command.Parameters.Add(p_PR_DeveloperHDA);


               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PR_DeveloperHDABank", PR_DeveloperHDABank);
                SqlParameter p_PR_DeveloperHDABank = new SqlParameter("@PR_DeveloperHDABank", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PR_DeveloperHDABank.Value = PR_DeveloperHDABank;
                command.Parameters.Add(p_PR_DeveloperHDABank);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LF_PayeeName", LF_PayeeName);
                SqlParameter p_LF_PayeeName = new SqlParameter("@LF_PayeeName", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_PayeeName.Value = LF_PayeeName;
                command.Parameters.Add(p_LF_PayeeName);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LF_BilledAmount", LF_BilledAmount);
                SqlParameter p_LF_BilledAmount = new SqlParameter("@LF_BilledAmount", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_BilledAmount.Value = LF_BilledAmount;
                command.Parameters.Add(p_LF_BilledAmount);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LF_AccountNumber", LF_AccountNumber);
                SqlParameter p_LF_AccountNumber = new SqlParameter("@LF_AccountNumber", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_AccountNumber.Value = LF_AccountNumber;
                command.Parameters.Add(p_LF_AccountNumber);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LF_Bank", LF_Bank);
                SqlParameter p_LF_Bank = new SqlParameter("@LF_Bank", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_Bank.Value = LF_Bank;
                command.Parameters.Add(p_LF_Bank);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LF_PaymentDescription", LF_PaymentDescription);
                SqlParameter p_LF_PaymentDescription = new SqlParameter("@LF_PaymentDescription", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_PaymentDescription.Value = LF_PaymentDescription;
                command.Parameters.Add(p_LF_PaymentDescription);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@LF_PaymentMode", LF_PaymentMode);
                SqlParameter p_LF_PaymentMode = new SqlParameter("@LF_PaymentMode", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_PaymentMode.Value = LF_PaymentMode;
                command.Parameters.Add(p_LF_PaymentMode);

                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@UpdateInfo_Reason", UpdateInfo_Reason);
                SqlParameter p_UpdateInfo_Reason = new SqlParameter("@UpdateInfo_Reason", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_UpdateInfo_Reason.Value = UpdateInfo_Reason;
                command.Parameters.Add(p_UpdateInfo_Reason);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@UpdateInfo_Others", UpdateInfo_Others);
                SqlParameter p_UpdateInfo_Others = new SqlParameter("@UpdateInfo_Others", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_UpdateInfo_Others.Value = UpdateInfo_Others;
                command.Parameters.Add(p_UpdateInfo_Others);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@CancelLoan_Remarks", CancelLoan_Remarks);
                SqlParameter p_CancelLoan_Remarks = new SqlParameter("@CancelLoan_Remarks", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_CancelLoan_Remarks.Value = CancelLoan_Remarks;
                command.Parameters.Add(p_CancelLoan_Remarks);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@CancelLoan_File", CancelLoan_File);
                SqlParameter p_CancelLoan_File = new SqlParameter("@CancelLoan_File", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_CancelLoan_File.Value = CancelLoan_File;
                command.Parameters.Add(p_CancelLoan_File);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorSubmissionOption", SolicitorSubmissionOption);
                SqlParameter p_SolicitorSubmissionOption = new SqlParameter("@SolicitorSubmissionOption", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorSubmissionOption.Value = SolicitorSubmissionOption;
                command.Parameters.Add(p_SolicitorSubmissionOption);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorSubmissionStatus", SolicitorSubmissionStatus);
                SqlParameter p_SolicitorSubmissionStatus = new SqlParameter("@SolicitorSubmissionStatus", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorSubmissionStatus.Value = SolicitorSubmissionStatus;
                command.Parameters.Add(p_SolicitorSubmissionStatus);

               // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolicitorCode);
                SqlParameter p_SolicitorCode = new SqlParameter("@SolicitorCode", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorCode.Value = SolicitorCode;
                command.Parameters.Add(p_SolicitorCode);

                SqlParameter p_AttachmentCount = new SqlParameter("@AttachmentCount", SqlDbType.NVarChar, -1);
                p_AttachmentCount.Value = AttachmentCount;
                command.Parameters.Add(p_AttachmentCount);

                
                // sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;
                SqlParameter p_error = new SqlParameter("@error", SqlDbType.NVarChar, -1);
                p_error.Direction = ParameterDirection.InputOutput;
                p_error.Value = error;
                command.Parameters.Add(p_error);

                //DataSet dsPRE = new DataSet("ds");
                // sqlDAPRE.Fill(dsPRE);
                sqlDAPRE = new SqlDataAdapter();

                sqlDAPRE.SelectCommand = command;
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                error = Convert.ToString(p_error.Value);

            }
            catch (Exception ex)
            {
                error = "DP_SolDisbursementSubmission_Main failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn ;
                LogErrorToDB("DP_SolDisbursementSubmission_Main", "Exception", error, errorDetail);
            }
        }

       

        [WebMethod]
        public void DP_SQLSolicitorDPSubmission_Main
            (                
                string  arn,
               string SolicitorEmail,
                string SolicitorCancellationReportAttachmentURL,
                string SolicitorCancellationReportAttachment,
                string SolicitorCancellationReportAttachmentDate,
                string SolicitorReferenceNumber,
                string PersonInChargeName,
                string DocAdminFeePaid,
                string Remarks,
                string SolicitorCIFNumber,
                string ExecutionDateByCustomer,
                string SNPCompletionDateCommence,
                string SNPCompletionDate,
                string SNPExtendedCompletionDate,
                string DeveloperBillingDueForPayment,
                string DeveloperBillingDueDate,
                string AttendingSolicitor,
                string SolicitorDeclaration,
                string RefCoverLetter,
                string RefCustNRIC,
                string RefBoardResolution,
                string RefLandSearch,
                string RefPrincipalSPA,
                string RefLUToDev,
                string RefSpecimenOfCaveator,
                string RefDocAdminFeeForm,
                string RefOtherDocRemark,
                string ExeFacilitiesAgreement,
                string ExeChargeAnnexure,
                string ExeDeedOfAssignment,
                string ExePowerOfAttorney,
                string ExeLetterOfGuarantee,
                string ExeChargeOverCashDeposit,
                string ExeForm34,
                string ExeEntryOfPrivateCaveat,
                string exeF16ANLC,
                string Status,
                string SStatus,
                string SStatusOthers,
                string SolicitorRefReportAttachmentURL,
                string SolicitorRefReportAttachment,
                string SolicitorRefReportAttachmentDate,                
                string Completed,
                ref string error
                 )
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                SqlCommand command = new SqlCommand("usp_SQLSolicitorDPSubmission_Main", connPRE);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter p_arn = new SqlParameter("@arn", SqlDbType.NVarChar,-1);
                //param.Direction = ParameterDirection.InputOutput;
                p_arn.Value = arn;
                command.Parameters.Add(p_arn);

                SqlParameter p_SolicitorEmail = new SqlParameter("@SolicitorEmail", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorEmail.Value = SolicitorEmail;
                command.Parameters.Add(p_SolicitorEmail);

                SqlParameter p_SolicitorCancellationReportAttachmentURL = new SqlParameter("@SolicitorCancellationReportAttachmentURL", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorCancellationReportAttachmentURL.Value = SolicitorCancellationReportAttachmentURL;
                command.Parameters.Add(p_SolicitorCancellationReportAttachmentURL);

                SqlParameter p_SolicitorCancellationReportAttachment = new SqlParameter("@SolicitorCancellationReportAttachment", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorCancellationReportAttachment.Value = SolicitorCancellationReportAttachment;
                command.Parameters.Add(p_SolicitorCancellationReportAttachment);

                SqlParameter p_SolicitorCancellationReportAttachmentDate = new SqlParameter("@SolicitorCancellationReportAttachmentDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorCancellationReportAttachmentDate.Value = SolicitorCancellationReportAttachmentDate;
                command.Parameters.Add(p_SolicitorCancellationReportAttachmentDate);

                SqlParameter p_SolicitorReferenceNumber = new SqlParameter("@SolicitorReferenceNumber", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorReferenceNumber.Value = SolicitorReferenceNumber;
                command.Parameters.Add(p_SolicitorReferenceNumber);

                SqlParameter p_PersonInChargeName = new SqlParameter("@PersonInChargeName", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PersonInChargeName.Value = PersonInChargeName;
                command.Parameters.Add(p_PersonInChargeName);

                SqlParameter p_DocAdminFeePaid = new SqlParameter("@DocAdminFeePaid", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_DocAdminFeePaid.Value = DocAdminFeePaid;
                command.Parameters.Add(p_DocAdminFeePaid);

                SqlParameter p_Remarks = new SqlParameter("@Remarks", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_Remarks.Value = Remarks;
                command.Parameters.Add(p_Remarks);

                SqlParameter p_SolicitorCIFNumber = new SqlParameter("@SolicitorCIFNumber", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorCIFNumber.Value = SolicitorCIFNumber;
                command.Parameters.Add(p_SolicitorCIFNumber);

                SqlParameter p_ExecutionDateByCustomer = new SqlParameter("@ExecutionDateByCustomer", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExecutionDateByCustomer.Value = ExecutionDateByCustomer;
                command.Parameters.Add(p_ExecutionDateByCustomer);

                SqlParameter p_SNPCompletionDateCommence = new SqlParameter("@SNPCompletionDateCommence", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SNPCompletionDateCommence.Value = SNPCompletionDateCommence;
                command.Parameters.Add(p_SNPCompletionDateCommence);

                SqlParameter p_SNPCompletionDate = new SqlParameter("@SNPCompletionDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SNPCompletionDate.Value = SNPCompletionDate;
                command.Parameters.Add(p_SNPCompletionDate);

                SqlParameter p_SNPExtendedCompletionDate = new SqlParameter("@SNPExtendedCompletionDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SNPExtendedCompletionDate.Value = SNPExtendedCompletionDate;
                command.Parameters.Add(p_SNPExtendedCompletionDate);

                SqlParameter p_DeveloperBillingDueForPayment = new SqlParameter("@DeveloperBillingDueForPayment", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_DeveloperBillingDueForPayment.Value = DeveloperBillingDueForPayment;
                command.Parameters.Add(p_DeveloperBillingDueForPayment);

                SqlParameter p_DeveloperBillingDueDate = new SqlParameter("@DeveloperBillingDueDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_DeveloperBillingDueDate.Value = DeveloperBillingDueDate;
                command.Parameters.Add(p_DeveloperBillingDueDate);

                SqlParameter p_AttendingSolicitor = new SqlParameter("@AttendingSolicitor", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_AttendingSolicitor.Value = AttendingSolicitor;
                command.Parameters.Add(p_AttendingSolicitor);

                SqlParameter p_SolicitorDeclaration = new SqlParameter("@SolicitorDeclaration", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorDeclaration.Value = SolicitorDeclaration;
                command.Parameters.Add(p_SolicitorDeclaration);

                SqlParameter p_RefCoverLetter = new SqlParameter("@RefCoverLetter", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefCoverLetter.Value = RefCoverLetter;
                command.Parameters.Add(p_RefCoverLetter);

                SqlParameter p_RefCustNRIC = new SqlParameter("@RefCustNRIC", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefCustNRIC.Value = RefCustNRIC;
                command.Parameters.Add(p_RefCustNRIC);

                SqlParameter p_RefBoardResolution = new SqlParameter("@RefBoardResolution", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefBoardResolution.Value = RefBoardResolution;
                command.Parameters.Add(p_RefBoardResolution);

                SqlParameter p_RefLandSearch = new SqlParameter("@RefLandSearch", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefLandSearch.Value = RefLandSearch;
                command.Parameters.Add(p_RefLandSearch);

                SqlParameter p_RefPrincipalSPA = new SqlParameter("@RefPrincipalSPA", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefPrincipalSPA.Value = RefPrincipalSPA;
                command.Parameters.Add(p_RefPrincipalSPA);

                SqlParameter p_RefLUToDev = new SqlParameter("@RefLUToDev", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefLUToDev.Value = RefLUToDev;
                command.Parameters.Add(p_RefLUToDev);

                SqlParameter p_RefSpecimenOfCaveator = new SqlParameter("@RefSpecimenOfCaveator", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefSpecimenOfCaveator.Value = RefSpecimenOfCaveator;
                command.Parameters.Add(p_RefSpecimenOfCaveator);

                SqlParameter p_RefDocAdminFeeForm = new SqlParameter("@RefDocAdminFeeForm", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefDocAdminFeeForm.Value = RefDocAdminFeeForm;
                command.Parameters.Add(p_RefDocAdminFeeForm);

                SqlParameter p_ExeFacilitiesAgreement = new SqlParameter("@ExeFacilitiesAgreement", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeFacilitiesAgreement.Value = ExeFacilitiesAgreement;
                command.Parameters.Add(p_ExeFacilitiesAgreement);

                SqlParameter p_ExeChargeAnnexure = new SqlParameter("@ExeChargeAnnexure", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeChargeAnnexure.Value = ExeChargeAnnexure;
                command.Parameters.Add(p_ExeChargeAnnexure);

                SqlParameter p_ExeDeedOfAssignment = new SqlParameter("@ExeDeedOfAssignment", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeDeedOfAssignment.Value = ExeDeedOfAssignment;
                command.Parameters.Add(p_ExeDeedOfAssignment);

                SqlParameter p_ExePowerOfAttorney = new SqlParameter("@ExePowerOfAttorney", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExePowerOfAttorney.Value = ExePowerOfAttorney;
                command.Parameters.Add(p_ExePowerOfAttorney);

                SqlParameter p_ExeLetterOfGuarantee = new SqlParameter("@ExeLetterOfGuarantee", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeLetterOfGuarantee.Value = ExeLetterOfGuarantee;
                command.Parameters.Add(p_ExeLetterOfGuarantee);

                SqlParameter p_ExeChargeOverCashDeposit = new SqlParameter("@ExeChargeOverCashDeposit", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeChargeOverCashDeposit.Value = ExeChargeOverCashDeposit;
                command.Parameters.Add(p_ExeChargeOverCashDeposit);

                SqlParameter p_ExeForm34 = new SqlParameter("@ExeForm34", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeForm34.Value = ExeForm34;
                command.Parameters.Add(p_ExeForm34);

                SqlParameter p_ExeEntryOfPrivateCaveat = new SqlParameter("@ExeEntryOfPrivateCaveat", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ExeEntryOfPrivateCaveat.Value = ExeEntryOfPrivateCaveat;
                command.Parameters.Add(p_ExeEntryOfPrivateCaveat);

                SqlParameter p_Status = new SqlParameter("@Status", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_Status.Value = Status;
                command.Parameters.Add(p_Status);

                SqlParameter p_SStatus = new SqlParameter("@SStatus", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SStatus.Value = SStatus;
                command.Parameters.Add(p_SStatus);

                SqlParameter p_SStatusOthers = new SqlParameter("@SStatusOthers", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SStatusOthers.Value = SStatusOthers;
                command.Parameters.Add(p_SStatusOthers);

                SqlParameter p_SolicitorRefReportAttachmentURL = new SqlParameter("@SolicitorRefReportAttachmentURL", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorRefReportAttachmentURL.Value = SolicitorRefReportAttachmentURL;
                command.Parameters.Add(p_SolicitorRefReportAttachmentURL);

                SqlParameter p_SolicitorRefReportAttachment = new SqlParameter("@SolicitorRefReportAttachment", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorRefReportAttachment.Value = SolicitorRefReportAttachment;
                command.Parameters.Add(p_SolicitorRefReportAttachment);

                SqlParameter p_SolicitorRefReportAttachmentDate = new SqlParameter("@SolicitorRefReportAttachmentDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_SolicitorRefReportAttachmentDate.Value = SolicitorRefReportAttachmentDate;
                command.Parameters.Add(p_SolicitorRefReportAttachmentDate);

                SqlParameter p_RefOtherDocRemark = new SqlParameter("@RefOtherDocRemark", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_RefOtherDocRemark.Value = RefOtherDocRemark;
                command.Parameters.Add(p_RefOtherDocRemark);

                SqlParameter p_exeF16ANLC = new SqlParameter("@exeF16ANLC", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_exeF16ANLC.Value = exeF16ANLC;
                command.Parameters.Add(p_exeF16ANLC);

                /*
                SqlParameter p_CIFNew = new SqlParameter("@CIFNew", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_CIFNew.Value = CIFNew;
                command.Parameters.Add(p_CIFNew);
                */

                SqlParameter p_Completed = new SqlParameter("@Completed", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_Completed.Value = Completed;
                command.Parameters.Add(p_Completed);

                SqlParameter p_error = new SqlParameter("@error", SqlDbType.NVarChar, -1);
                p_error.Direction = ParameterDirection.InputOutput;
                p_error.Value = error;
                command.Parameters.Add(p_error);

                sqlDAPRE = new SqlDataAdapter();

                /*
                //sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLSolicitorDPSubmission_Main @ARN ,@SolicitorEmail ,@SolicitorCancellationReportAttachmentURL ,@SolicitorCancellationReportAttachment ,@SolicitorCancellationReportAttachmentDate , @SolicitorReferenceNumber ,@PersonInChargeName ,@DocAdminFeePaid ,@Remarks ,@SolicitorCIFNumber  , @ExecutionDateByCustomer , @SNPCompletionDateCommence , @SNPCompletionDate , @SNPExtendedCompletionDate , @DeveloperBillingDueForPayment , @DeveloperBillingDueDate , @AttendingSolicitor ,@SolicitorDeclaration , @RefCoverLetter , @RefCustNRIC , @RefBoardResolution , @RefLandSearch , @RefPrincipalSPA , @RefLUToDev , @RefSpecimenOfCaveator , @RefDocAdminFeeForm , @ExeFacilitiesAgreement , @ExeChargeAnnexure , @ExeDeedOfAssignment , @ExePowerOfAttorney , @ExeLetterOfGuarantee , @ExeChargeOverCashDeposit , @ExeForm34 , @ExeEntryOfPrivateCaveat , @Status ,@SStatus ,@SStatusOthers ,@SolicitorRefReportAttachmentURL ,@SolicitorRefReportAttachment ,@SolicitorRefReportAttachmentDate ,@RefOtherDocRemark ,@F16ANLC ,@CIFNew ,@Completed , @Error output ", connPRE);
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLSolicitorDPSubmission_Main", connPRE);
                sqlDAPRE.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorEmail", SolicitorEmail);                
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCancellationReportAttachmentURL", SolicitorCancellationReportAttachmentURL);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCancellationReportAttachment", SolicitorCancellationReportAttachment);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCancellationReportAttachmentDate", SolicitorCancellationReportAttachmentDate);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorReferenceNumber", SolicitorReferenceNumber);
                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorReferenceNumber", DBNULL.Value);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@PersonInChargeName", PersonInChargeName);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@DocAdminFeePaid", DocAdminFeePaid);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@Remarks", Remarks);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCIFNumber", SolicitorCIFNumber);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExecutionDateByCustomer", ExecutionDateByCustomer);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SNPCompletionDateCommence", SNPCompletionDateCommence);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SNPCompletionDate", SNPCompletionDate);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SNPExtendedCompletionDate", SNPExtendedCompletionDate);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@DeveloperBillingDueForPayment", DeveloperBillingDueForPayment);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@DeveloperBillingDueDate", DeveloperBillingDueDate);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@AttendingSolicitor", AttendingSolicitor);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorDeclaration", SolicitorDeclaration);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefCoverLetter", RefCoverLetter);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefCustNRIC", RefCustNRIC);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefBoardResolution", RefBoardResolution);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefLandSearch", RefLandSearch);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefPrincipalSPA", RefPrincipalSPA);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefLUToDev", RefLUToDev);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefSpecimenOfCaveator", RefSpecimenOfCaveator);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefDocAdminFeeForm", RefDocAdminFeeForm);                
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeFacilitiesAgreement", ExeFacilitiesAgreement); 
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeChargeAnnexure", ExeChargeAnnexure);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeDeedOfAssignment", ExeDeedOfAssignment);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExePowerOfAttorney", ExePowerOfAttorney);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeLetterOfGuarantee", ExeLetterOfGuarantee);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeChargeOverCashDeposit", ExeChargeOverCashDeposit);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeForm34", ExeForm34);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ExeEntryOfPrivateCaveat", ExeEntryOfPrivateCaveat);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@Status", Status);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SStatus", SStatus);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SStatusOthers", SStatusOthers);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorRefReportAttachmentURL", SolicitorRefReportAttachmentURL);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorRefReportAttachment", SolicitorRefReportAttachment);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorRefReportAttachmentDate", SolicitorRefReportAttachmentDate);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@RefOtherDocRemark", RefOtherDocRemark);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@F16ANLC", F16ANLC);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@CIFNew", CIFNew);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@Completed", Completed);

                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");
                sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;
                */

                sqlDAPRE.SelectCommand = command;
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                error = Convert.ToString(p_error.Value);

                //return outputValue;

            }
            catch (Exception ex)
            {
                error = "usp_SQLSolicitorDPSubmission_Main failed with exception: " + ex.Message.ToString();
                //outputValue = "usp_SQLSolicitorDPSubmission_Main failed with exception: " + ex.Message.ToString();
                string errorDetail;
                 errorDetail = "Input Param:" + "arn:" + arn ;
                 LogErrorToDB("usp_SQLSolicitorDPSubmission_Main", "Exception", error, errorDetail);
                //return outputValue;
            }
        }


        [WebMethod]
        public void DP_SQLValuerDPSubmission_Main
            (
                string arn,
                string valueremail,
                string ValuerReportAttachmentURL,
                string ValuerReportAttachment,
                string ValuerReportAttachmentDate,
                string VRInstructionDate,
                string ValuerReference,
                string PersonInChargeName,
                string VUpdateInfoStatus,
                string VLowerOMVStatus,
                string VUpdateInfoStatusOthers,
                string VLowerOMVReasons,
                string DateOfValuation,
                string MarketValue,
                string FireInsuranceValue,
                string InvoiceNumber,
                string ShortfallAmount,
                string Declaration,
                string status,
                string ValuationFeeFinancedByBankFlag,
                string LF_PayeeName,
                string LF_BilledAmount,
                string LF_AccountNumber,
                string LF_Bank,
                string LF_PaymentDescription,
                string LF_PaymentMode,
                string Completed,
                ref string error
                 )
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                SqlCommand command = new SqlCommand("usp_SQLValuerDPSubmission_Main", connPRE);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter p_arn = new SqlParameter("@arn", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_arn.Value = arn;
                command.Parameters.Add(p_arn);

                SqlParameter p_valueremail = new SqlParameter("@valueremail", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_valueremail.Value = valueremail;
                command.Parameters.Add(p_valueremail);

                SqlParameter p_ValuerReportAttachmentURL = new SqlParameter("@ValuerReportAttachmentURL", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ValuerReportAttachmentURL.Value = ValuerReportAttachmentURL;
                command.Parameters.Add(p_ValuerReportAttachmentURL);

                SqlParameter p_ValuerReportAttachment = new SqlParameter("@ValuerReportAttachment", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ValuerReportAttachment.Value = ValuerReportAttachment;
                command.Parameters.Add(p_ValuerReportAttachment);

                SqlParameter p_ValuerReportAttachmentDate = new SqlParameter("@ValuerReportAttachmentDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ValuerReportAttachmentDate.Value = ValuerReportAttachmentDate;
                command.Parameters.Add(p_ValuerReportAttachmentDate);

                SqlParameter p_VRInstructionDate = new SqlParameter("@VRInstructionDate", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_VRInstructionDate.Value = VRInstructionDate;
                command.Parameters.Add(p_VRInstructionDate);                

                SqlParameter p_ValuerReference = new SqlParameter("@ValuerReference", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ValuerReference.Value = ValuerReference;
                command.Parameters.Add(p_ValuerReference);

                SqlParameter p_PersonInChargeName = new SqlParameter("@PersonInChargeName", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_PersonInChargeName.Value = PersonInChargeName;
                command.Parameters.Add(p_PersonInChargeName);

                SqlParameter p_VUpdateInfoStatus = new SqlParameter("@VUpdateInfoStatus", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_VUpdateInfoStatus.Value = VUpdateInfoStatus;
                command.Parameters.Add(p_VUpdateInfoStatus);

                SqlParameter p_VLowerOMVStatus = new SqlParameter("@VLowerOMVStatus", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_VLowerOMVStatus.Value = VLowerOMVStatus;
                command.Parameters.Add(p_VLowerOMVStatus);

                SqlParameter p_VUpdateInfoStatusOthers = new SqlParameter("@VUpdateInfoStatusOthers", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_VUpdateInfoStatusOthers.Value = VUpdateInfoStatusOthers;
                command.Parameters.Add(p_VUpdateInfoStatusOthers);

                SqlParameter p_VLowerOMVReasons = new SqlParameter("@VLowerOMVReasons", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_VLowerOMVReasons.Value = VLowerOMVReasons;
                command.Parameters.Add(p_VLowerOMVReasons);

                SqlParameter p_DateOfValuation = new SqlParameter("@DateOfValuation", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_DateOfValuation.Value = DateOfValuation;
                command.Parameters.Add(p_DateOfValuation);

                SqlParameter p_MarketValue = new SqlParameter("@MarketValue", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_MarketValue.Value = MarketValue;
                command.Parameters.Add(p_MarketValue);

                SqlParameter p_FireInsuranceValue = new SqlParameter("@FireInsuranceValue", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_FireInsuranceValue.Value = FireInsuranceValue;
                command.Parameters.Add(p_FireInsuranceValue);

                SqlParameter p_InvoiceNumber = new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_InvoiceNumber.Value = InvoiceNumber;
                command.Parameters.Add(p_InvoiceNumber);

                SqlParameter p_ShortfallAmount = new SqlParameter("@ShortfallAmount", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ShortfallAmount.Value = ShortfallAmount;
                command.Parameters.Add(p_ShortfallAmount);

                SqlParameter p_Declaration = new SqlParameter("@Declaration", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_Declaration.Value = Declaration;
                command.Parameters.Add(p_Declaration);

                SqlParameter p_status = new SqlParameter("@status", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_status.Value = status;
                command.Parameters.Add(p_status);

                SqlParameter p_ValuationFeeFinancedByBankFlag = new SqlParameter("@ValuationFeeFinancedByBankFlag", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_ValuationFeeFinancedByBankFlag.Value = ValuationFeeFinancedByBankFlag;
                command.Parameters.Add(p_ValuationFeeFinancedByBankFlag);

                SqlParameter p_LF_PayeeName = new SqlParameter("@LF_PayeeName", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_PayeeName.Value = LF_PayeeName;
                command.Parameters.Add(p_LF_PayeeName);

                SqlParameter p_LF_BilledAmount = new SqlParameter("@LF_BilledAmount", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_BilledAmount.Value = LF_BilledAmount;
                command.Parameters.Add(p_LF_BilledAmount);

                SqlParameter p_LF_AccountNumber = new SqlParameter("@LF_AccountNumber", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_AccountNumber.Value = LF_AccountNumber;
                command.Parameters.Add(p_LF_AccountNumber);

                SqlParameter p_LF_Bank = new SqlParameter("@LF_Bank", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_Bank.Value = LF_Bank;
                command.Parameters.Add(p_LF_Bank);

                SqlParameter p_LF_PaymentDescription = new SqlParameter("@LF_PaymentDescription", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_PaymentDescription.Value = LF_PaymentDescription;
                command.Parameters.Add(p_LF_PaymentDescription);

                SqlParameter p_LF_PaymentMode = new SqlParameter("@LF_PaymentMode", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_LF_PaymentMode.Value = LF_PaymentMode;
                command.Parameters.Add(p_LF_PaymentMode);

                SqlParameter p_Completed = new SqlParameter("@Completed", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_Completed.Value = Completed;
                command.Parameters.Add(p_Completed);

                SqlParameter p_result = new SqlParameter("@result", SqlDbType.NVarChar, -1);
                p_result.Direction = ParameterDirection.InputOutput;
                p_result.Value = error;
                command.Parameters.Add(p_result);

                sqlDAPRE = new SqlDataAdapter();

                sqlDAPRE.SelectCommand = command;
                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                error = Convert.ToString(p_result.Value);                

            }
            catch (Exception ex)
            {
                error = "DP_SQLValuerDPSubmission_Main failed with exception: " + ex.Message.ToString();                
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn;
                LogErrorToDB("DP_SQLValuerDPSubmission_Main", "Exception", error, errorDetail);                
            }
        }


        [WebMethod]
        public void DP_SolicitorDisbursementSubmissionAttachment_DeleteAllAttachments(string arn, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName = clsGlobal.MG_SQL_DB_NAME2;
                string strID = clsGlobal.MG_SQL_ID2;
                string strPassword = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_DeleteAllAttachments @arn, @error output", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@AttachmentID", AttachmentID);

                sqlDAPRE.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                error = sqlDAPRE.SelectCommand.Parameters["@error"].Value.ToString();
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorDisbursementSubmissionAttachment_DeleteAllAttachments failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn ;
                LogErrorToDB("DP_SolicitorDisbursementSubmissionAttachment_DeleteAllAttachments", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolicitorDisbursementSubmissionAttachment_DeleteAttachment(string arn, string AttachmentID, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName = clsGlobal.MG_SQL_DB_NAME2;
                string strID = clsGlobal.MG_SQL_ID2;
                string strPassword = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_DeleteAttachment @arn, @AttachmentID, @error output", connPRE);                
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@AttachmentID", AttachmentID);                

                sqlDAPRE.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                error = sqlDAPRE.SelectCommand.Parameters["@error"].Value.ToString();
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorDisbursementSubmissionAttachment_DeleteAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", AttachmentID:" + AttachmentID;
                LogErrorToDB("DP_SolicitorDisbursementSubmissionAttachment_DeleteAttachment", "Exception", error, errorDetail);
            }
        }


        [WebMethod]
        public void DP_SolicitorDisbursementSubmissionAttachment_add_withattachment(string arn, string k2fileattachment, string solicitorcode, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName = clsGlobal.MG_SQL_DB_NAME2;
                string strID = clsGlobal.MG_SQL_ID2;
                string strPassword = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_add_withattachment @solicitoremail, @arn, @attachment", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@solicitoremail", solicitorcode);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@attachment", k2fileattachment);

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);
                
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorDPSubmissionAttachment_add_withattachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", solicitorcode:"+ solicitorcode;
                LogErrorToDB("DP_SolicitorDPSubmissionAttachment_add_withattachment", "Exception", error, errorDetail);
            }
                }

        [WebMethod]
        public void TBD_DP_UpdatePhaseCode()
        {
            //error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.ddProject_LOADSUpdatePhaseCode_Select", connPRE);
                // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@solicitoremail", solicitorcode);
                // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                // sqlDAPRE.SelectCommand.Parameters.AddWithValue("@attachment", k2fileattachment);

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                if (dsPRE.Tables.Count > 0)
                {
                    dt = dsPRE.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            //string arn = dt.Rows[i]["arn"].ToString();
                           // HLBBWS.AppWS ws = new AppWS();
                           // List<HLBBWS.AppWS.structureLOADS> list = new List<HLBBWS.AppWS.structureLOADS>();

                           // list = ws.DP_NewLI_GetDataFromLOADS(dt.Rows[i]["ARN"].ToString());

                            //if (list.Count > 0)
                           // {
                               // if (list[0].respInfo_respCode == "00")
                               // {
                                    SqlConnection conn2 = null;
                                    conn2 = new SqlConnection(connstr);
                                    
                                    SqlDataAdapter sqlDAPRE2 = null;

                                    sqlDAPRE2 = new SqlDataAdapter();
                                    sqlDAPRE2.SelectCommand = new SqlCommand("dbo.ddProject_LOADSUpdatePhaseCode_Update @arn, @PhaseCode, @PhaseName, @AddressLine1, @SPAValue, @Category", conn2);
                                    sqlDAPRE2.SelectCommand.Parameters.AddWithValue("@arn", dt.Rows[i]["ARN"].ToString());
                                    sqlDAPRE2.SelectCommand.Parameters.AddWithValue("@PhaseCode", "phase code 1");
                                    sqlDAPRE2.SelectCommand.Parameters.AddWithValue("@PhaseName", "phase name 1");
                                    sqlDAPRE2.SelectCommand.Parameters.AddWithValue("@AddressLine1", "addr line 1");
                                    sqlDAPRE2.SelectCommand.Parameters.AddWithValue("@SPAValue", "10000.00");
                                    sqlDAPRE2.SelectCommand.Parameters.AddWithValue("@Category", "cat 1");

                                    //sqlcommand1.Parameters.AddWithValue("@ARN", dt.Rows[i]["ARN"].ToString());
                                    /*
                                    sqlcommand1.Parameters.AddWithValue("@PhaseCode", list[0].loanApplicationInfo_appStatus);
                                    */

                                    DataSet dsPRE2 = new DataSet("ds");
                                    sqlDAPRE2.Fill(dsPRE2);

                              //  }
                          //  }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //error = "DP_SolicitorDPSubmissionAttachment_add_withattachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                //errorDetail = "Input Param:" + "arn:" + arn + ", solicitorcode:" + solicitorcode;
                //LogErrorToDB("DP_SolicitorDPSubmissionAttachment_add_withattachment", "Exception", error, errorDetail);
            }
        }

        public struct SolicitorDisbursementSubmissionAttachmentSelectAll
        {
            public string AttachmentID;
            public string ARN;
            public string SolicitorCode;
            public string Attachment;
            public string CreatedDate;
            public string AttachmentName;
        }

        [WebMethod]
        public List<SolicitorDisbursementSubmissionAttachmentSelectAll> DP_SolicitorDisbursementSubmissionAttachment_SelectAll2(string arn)
        {
            //error = "";
            
            List<SolicitorDisbursementSubmissionAttachmentSelectAll> list = new List<SolicitorDisbursementSubmissionAttachmentSelectAll>();
            
            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName = clsGlobal.MG_SQL_DB_NAME2;
                string strID = clsGlobal.MG_SQL_ID2;
                string strPassword = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.aaa_ws_SQLSolicitorDisbursementSubmissionAttachment_SelectAll @arn", connPRE);                
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);                

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);
                //dt = dsPRE.Tables[0];

                if (dsPRE.Tables.Count > 0)
                {
                    dt = dsPRE.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            SolicitorDisbursementSubmissionAttachmentSelectAll inst = new SolicitorDisbursementSubmissionAttachmentSelectAll();

                            inst.AttachmentID = dt.Rows[i]["AttachmentID"].ToString();
                            inst.ARN = dt.Rows[i]["ARN"].ToString();
                            inst.SolicitorCode = dt.Rows[i]["SolicitorCode"].ToString();
                            inst.Attachment = dt.Rows[i]["Attachment"].ToString();
                            inst.CreatedDate = dt.Rows[i]["CreatedDate"].ToString();
                            inst.AttachmentName = dt.Rows[i]["AttachmentName"].ToString();
                            list.Add(inst);
                        }
                    }
                }
                
                

               

            }
            catch (Exception ex)
            {
                string error;
                error = "DP_SolicitorDisbursementSubmissionAttachment_SelectAll failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn ;
                LogErrorToDB("DP_SolicitorDisbursementSubmissionAttachment_SelectAll", "Exception", error, errorDetail);                
            }
            return list;
        }

        public class MailConst
        {           
            public static string Username = clsGlobal.MailUsername;
            public static string Password = clsGlobal.MailPassword;
            public static string SmtpServer = clsGlobal.MailServer;

            
            //public static string From = Username + "@hlbb.hongleong.com.my";
            public static string From = clsGlobal.FromEmail;
            
        }

        [WebMethod]
        public void SendMailWFParser_NoAttachment(string recipient, string subject, string body)
        {
            try
            {
                SendMail(recipient, subject, body, null, null);
            }
            catch (Exception ex)
            {
                string error;
                error = "POC_SendMailWFParser_NoAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                //errorDetail = "Input Param: N/A";
                errorDetail = "Input Param: recipient:" + recipient + ",subject:" + subject + ",body:" + body;
                LogErrorToDB("POC_SendMailWFParser_NoAttachment", "Exception", error, errorDetail);
            }            
        }

        /*
        [WebMethod]
        public void POC_SendMailWFParser_NoAttachment(string recipient, string subject, string body)
        {
            try
            { 
                SendMail(recipient, subject, body, null, null);  
            }
            catch (Exception ex)
            {
                string error;
                error = "POC_SendMailWFParser_NoAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("POC_SendMailWFParser_NoAttachment", "Exception", error, errorDetail);
            }
        }
        */

        [WebMethod]
        public void SendMailWFParser_WithAttachment(string recipient, string subject, string body, string attachment, string AttachmentFileName)
        {
            try
            {
                SendMail(recipient, subject, body, attachment, AttachmentFileName);
                //SendMail(recipient, subject, body, null, null);
            }
            catch (Exception ex)
            {
                string error;
                error = "SendMailWFParser_WithAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                //errorDetail = "Input Param: N/A";
                errorDetail = "Input Param: recipient:" + recipient + ",subject:" + subject + ",body:" + body;
                LogErrorToDB("SendMailWFParser_WithAttachment", "Exception", error, errorDetail);
            }
            
        }

        [WebMethod]
        public void SendMailWFParser_WithMultipleAttachments(string recipient, string subject, string body, ArrayList attachment, ArrayList AttachmentFileName)
        {
            try
            {
                SendMail_MultipleAttachment(recipient, subject, body, attachment, AttachmentFileName);
                //SendMail(recipient, subject, body, null, null);
            }
            catch (Exception ex)
            {
                string error;
                error = "SendMailWFParser_WithMultipleAttachments failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: recipient:" + recipient + ",subject:" + subject + ",body:" + body;
                LogErrorToDB("SendMailWFParser_WithMultipleAttachments", "Exception", error, errorDetail);
            }

        }

        [WebMethod]
        public void SendMail(string recipient, string subject, string body, string attachment, string AttachmentFileName)
        {
            /*
            SmtpClient smtpClient = new SmtpClient();
            NetworkCredential basicCredential = new NetworkCredential(MailConst.Username, MailConst.Password, MailConst.SmtpServer);
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(MailConst.From);

            

            // setup up the host, increase the timeout to 5 minutes
            smtpClient.Host = MailConst.SmtpServer;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;
            smtpClient.Timeout = (60 * 5 * 1000);
            smtpClient.EnableSsl = true;
            
            message.From = fromAddress;
            //message.Subject = subject + " - " + DateTime.Now.Date.ToString().Split(' ')[0];
            message.Subject = subject ;
            message.IsBodyHtml = true;
            message.Body = body.Replace("\r\n", "<br>");
            message.To.Add(recipient);

            if (attachments != null)
            {
                foreach (string attachment in attachments)
                {
                    message.Attachments.Add(new Attachment(attachment));
                }
            }
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            smtpClient.Send(message);
             * */
            
            
            MailMessage msg = new MailMessage();
            
            //msg.From = new MailAddress("HLBBEIWS-SIT@hlbb.hongleong.com.my");
            msg.From = new MailAddress(MailConst.From);
            //msg.To.Add(new MailAddress("ShaikAlavudeen@hlbb.hongleong.com.my"));
            //20210712 - add support to multiple receiver 
            
            //msg.To.Add(new MailAddress(recipient));
           // msg.To.Add(recipient);

            
            int Commafreq = recipient.Split(',').Length - 1;
            int SemiCommafreq = recipient.Split(';').Length - 1;

            if (Commafreq !=0 && SemiCommafreq !=0 )
            {
                //throw new Exception("Invalid Email Address Seperator");
                foreach (var address in recipient.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {                    
                    SemiCommafreq = address.Split(';').Length - 1;
                    if (SemiCommafreq != 0)
                    {
                        foreach (var address2 in address.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            msg.To.Add(new MailAddress(address2));
                        }
                    }
                    else
                    {
                        msg.To.Add(new MailAddress(address));
                    }

                   
                }

            }
            else
            {
                if (Commafreq >0 && SemiCommafreq == 0)
                {
                    foreach (var address in recipient.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                    {                        
                        //msg.To.Add(address);
                        msg.To.Add(new MailAddress(address));
                        //recipient = address;
                        //break;
                    }
                }

                if (Commafreq == 0 && SemiCommafreq > 0)
                {
                    foreach (var address in recipient.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        
                        //msg.To.Add(address);
                        msg.To.Add(new MailAddress(address));
                        // recipient = address;
                       // break;
                    }
                }

                if (Commafreq == 0 && SemiCommafreq == 0)
                {
                    msg.To.Add(new MailAddress(recipient));
                    //msg.To.Add(recipient);                    
                }
            }
            
            //20210712 - end support to multiple receiver

            msg.Subject = subject;
            msg.Body = body;
            msg.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient("hlgmail.hongleong.com.my");
            SmtpClient client = new SmtpClient(MailConst.SmtpServer);
            client.EnableSsl = false;
            //client.Credentials = new System.Net.NetworkCredential("EIWSSIT", "W1gg$168");
            client.Credentials = new System.Net.NetworkCredential(MailConst.Username, MailConst.Password);
            client.Port = 25;
            //client.Port = 587;


            if (attachment != null)
            {
                byte[] byteFileContent = null; 
                byteFileContent = Convert.FromBase64String(attachment);

                Stream stream = new MemoryStream(byteFileContent);
                Attachment att = System.Net.Mail.Attachment.CreateAttachmentFromString(attachment, AttachmentFileName);

                System.Net.Mime.ContentType ct = new System.Net.Mime.ContentType(System.Net.Mime.MediaTypeNames.Application.Pdf);
                // Attach the log file stream to the email message.

                Attachment data = new Attachment(stream, ct);

                System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
                // Suggest a file name for the attachment.
                disposition.FileName = AttachmentFileName;
                
                //msg.Attachments.Add(new Attachment(att.ToString()));
                msg.Attachments.Add(data);

                
                
            }

            //client.Send(msg);

            
            try {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();

            //   throw ex;
            }
            

        }


        [WebMethod]
        public void DP_ValuerChangePassword(string ValCode, string CurrentPasswordDecrypted, string NewPasswordDecrypted, string NewPasswordConfirmationDecrypted, ref string error)
        {
            error = "";

            if (CurrentPasswordDecrypted == null)
            {
                CurrentPasswordDecrypted = "";
            }

            if (NewPasswordDecrypted == null)
            {
                NewPasswordDecrypted = "";
            }

            if (NewPasswordConfirmationDecrypted == null)
            {
                NewPasswordConfirmationDecrypted = "";
            }


            try
            {

                string ValuerCurrentPasswordEncrypted;
                string ValuerCurrentPasswordDecrypted;

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);               

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                //string EncryptionKey = sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Value.ToString();
                // end get encrypted key

                // start get current password                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_GetCurrentPassword @ValuerCode, @ValuerCurrentPassword output, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("ValuerCode", ValCode);

                sqlDAlpha.SelectCommand.Parameters.Add("@ValuerCurrentPassword", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@ValuerCurrentPassword"].Direction = ParameterDirection.Output;

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                ValuerCurrentPasswordEncrypted = sqlDAlpha.SelectCommand.Parameters["@ValuerCurrentPassword"].Value.ToString();
                ValuerCurrentPasswordDecrypted = DecryptText(ValuerCurrentPasswordEncrypted, EncryptionKey);

                // end get current password

                // start validate current password
                if (ValuerCurrentPasswordDecrypted != CurrentPasswordDecrypted)
                {
                    error = "Current password is incorrect";
                }
                // end validate current password               

                // start call usp_Maintenance_SQLSolicitor_PasswordUpdate
                if (error == "")
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLvaluer_PasswordUpdate @ValuerCode, @ValuerNewPassword, @ValuerNewPasswordConfirmation, @error output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerNewPassword", NewPasswordDecrypted);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    error = sqlDAPRE.SelectCommand.Parameters["@error"].Value.ToString();
                }

                // end call usp_Maintenance_SQLSolicitor_PasswordUpdate

                // start get solicitor password history 
                if (error == "")
                {
                    SqlConnection connGAMA = null;
                    SqlDataAdapter sqlDAGAMA = null;
                    DataTable dtGAMA = null;

                    connGAMA = new SqlConnection(connstr);

                    sqlDAGAMA = new SqlDataAdapter();
                    sqlDAGAMA.SelectCommand = new SqlCommand("dbo.usp_valuerpasswordhistorylist @ValuerCode, @error output ", connGAMA);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAGAMA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsGAMA = new DataSet("ds");
                    sqlDAGAMA.Fill(dsGAMA);

                    if (dsGAMA.Tables.Count > 0)
                    {
                        dtGAMA = dsGAMA.Tables[0];

                        if (dtGAMA.Rows.Count > 0)
                        {
                            string PasswordHistoryEncrypted;
                            string PasswordHistoryDecrypted;
                            string ValuerLoginPasswordHistoryCount;

                            for (int i = 0; i < dtGAMA.Rows.Count; i++)
                            {
                                PasswordHistoryEncrypted = dtGAMA.Rows[i]["ValuerPassword"].ToString();
                                ValuerLoginPasswordHistoryCount = dtGAMA.Rows[i]["ValuerLoginPasswordHistoryCount"].ToString();

                                PasswordHistoryDecrypted = DecryptText(PasswordHistoryEncrypted, EncryptionKey);

                                if (PasswordHistoryDecrypted == NewPasswordDecrypted)
                                {
                                    error = "The new password was used in the past " + ValuerLoginPasswordHistoryCount + " times. Please use a different password";
                                    break;
                                }

                            }
                        }
                    }
                    //error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();
                }
                // end get solicitor password history 

                // start call  usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
                if (error == "")
                {
                    SqlConnection connDELTA = null;
                    SqlDataAdapter sqlDADELTA = null;
                    DataTable dtDELTA = null;

                    connDELTA = new SqlConnection(connstr);

                    string ValuerEncryptedNewPassword;
                    ValuerEncryptedNewPassword = EncryptText(NewPasswordDecrypted, EncryptionKey);

                    sqlDADELTA = new SqlDataAdapter();
                    sqlDADELTA.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordUpdate_Final @ValuerCode, @ValuerEncryptedNewPassword ", connDELTA);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@ValuerEncryptedNewPassword", ValuerEncryptedNewPassword);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    //sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    //sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsDELTA = new DataSet("ds");
                    sqlDADELTA.Fill(dsDELTA);

                }
                // end call  usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
            }
            catch (Exception ex)
            {
                error = "DP_ValuerChangePassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " ValuerCode:" + ValCode;
                LogErrorToDB("DP_ValuerChangePassword", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ProjectChangePassword(string Code, string CurrentPasswordDecrypted, string NewPasswordDecrypted, string NewPasswordConfirmationDecrypted, ref string error)
        {
            error = "";

            if (CurrentPasswordDecrypted == null)
            {
                CurrentPasswordDecrypted = "";
            }

            if (NewPasswordDecrypted == null)
            {
                NewPasswordDecrypted = "";
            }

            if (NewPasswordConfirmationDecrypted == null)
            {
                NewPasswordConfirmationDecrypted = "";
            }


            try
            {

                string CurrentPasswordEncrypted;
                string CurrentPasswordDecryptedFromDB;

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                //string EncryptionKey = sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Value.ToString();
                // end get encrypted key

                // start get current password                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLProject_GetCurrentPassword @Code, @CurrentPassword output, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("Code", Code);

                sqlDAlpha.SelectCommand.Parameters.Add("@CurrentPassword", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@CurrentPassword"].Direction = ParameterDirection.Output;

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                CurrentPasswordEncrypted = sqlDAlpha.SelectCommand.Parameters["@CurrentPassword"].Value.ToString();
                CurrentPasswordDecryptedFromDB = DecryptText(CurrentPasswordEncrypted, EncryptionKey);

                // end get current password

                // start validate current password
                if (CurrentPasswordDecrypted != CurrentPasswordDecryptedFromDB)
                {
                    error = "Current password is incorrect";
                }
                // end validate current password               

                // start call usp_Maintenance_SQLSolicitor_PasswordUpdate
                if (error == "")
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLProject_PasswordUpdate @Code, @NewPassword, @NewPasswordConfirmation, @CurrentPassword, @error output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@Code", Code);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@NewPassword", NewPasswordDecrypted);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@NewPasswordConfirmation", NewPasswordConfirmationDecrypted);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@CurrentPassword", CurrentPasswordDecrypted);
                    
                    sqlDAPRE.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    error = sqlDAPRE.SelectCommand.Parameters["@error"].Value.ToString();
                }

                // end call usp_Maintenance_SQLSolicitor_PasswordUpdate

                // start get solicitor password history 
                if (error == "")
                {
                    SqlConnection connGAMA = null;
                    SqlDataAdapter sqlDAGAMA = null;
                    DataTable dtGAMA = null;

                    connGAMA = new SqlConnection(connstr);

                    sqlDAGAMA = new SqlDataAdapter();
                    sqlDAGAMA.SelectCommand = new SqlCommand("dbo.ddProjectPasswordHistoryList @ProjectCode, @error output ", connGAMA);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@ProjectCode", Code);
                    
                    sqlDAGAMA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsGAMA = new DataSet("ds");
                    sqlDAGAMA.Fill(dsGAMA);

                    if (dsGAMA.Tables.Count > 0)
                    {
                        dtGAMA = dsGAMA.Tables[0];

                        if (dtGAMA.Rows.Count > 0)
                        {
                            string PasswordHistoryEncrypted;
                            string PasswordHistoryDecrypted;
                            string ValuerLoginPasswordHistoryCount;

                            for (int i = 0; i < dtGAMA.Rows.Count; i++)
                            {
                                PasswordHistoryEncrypted = dtGAMA.Rows[i]["ProjectPassword"].ToString();
                                ValuerLoginPasswordHistoryCount = dtGAMA.Rows[i]["ProjectLoginPasswordHistoryCount"].ToString();

                                PasswordHistoryDecrypted = DecryptText(PasswordHistoryEncrypted, EncryptionKey);

                                if (PasswordHistoryDecrypted == NewPasswordDecrypted)
                                {
                                    error = "The new password was used in the past " + ValuerLoginPasswordHistoryCount + " times. Please use a different password";
                                    break;
                                }

                            }
                        }
                    }
                    //error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();
                }
                // end get solicitor password history 

                // start call  usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
                if (error == "")
                {
                    SqlConnection connDELTA = null;
                    SqlDataAdapter sqlDADELTA = null;
                    DataTable dtDELTA = null;

                    connDELTA = new SqlConnection(connstr);

                    string EncryptedNewPassword;
                    EncryptedNewPassword = EncryptText(NewPasswordDecrypted, EncryptionKey);

                    sqlDADELTA = new SqlDataAdapter();
                    sqlDADELTA.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLProject_PasswordUpdate_Final @Code, @EncryptedNewPassword ", connDELTA);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@Code", Code);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@EncryptedNewPassword", EncryptedNewPassword);
                    
                    DataSet dsDELTA = new DataSet("ds");
                    sqlDADELTA.Fill(dsDELTA);

                }
                // end call  usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
            }
            catch (Exception ex)
            {
                error = "DP_ProjectChangePassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " Code:" + Code;
                LogErrorToDB("DP_ProjectChangePassword", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolicitorChangePassword(string SolCode, string CurrentPasswordDecrypted, string NewPasswordDecrypted, string NewPasswordConfirmationDecrypted, ref string error)
        {
            error = "";

            try
            {

                if (CurrentPasswordDecrypted == null)
                {
                    CurrentPasswordDecrypted = "";
                }

                if (NewPasswordDecrypted == null)
                {
                    NewPasswordDecrypted = "";
                }

                if (NewPasswordConfirmationDecrypted == null)
                {
                    NewPasswordConfirmationDecrypted = "";
                }

                string SolicitorCurrentPasswordEncrypted;
                string SolicitorCurrentPasswordDecrypted;

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);
                //sqlDABeta.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);

                //sqlDABeta.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                //sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                //sqlDABeta.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                //sqlDABeta.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                //string EncryptionKey = sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Value.ToString();
                // end get encrypted key

                // start get current password                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_GetCurrentPassword @SolicitorCode, @SolicitorCurrentPassword output, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                
                sqlDAlpha.SelectCommand.Parameters.Add("@SolicitorCurrentPassword", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@SolicitorCurrentPassword"].Direction = ParameterDirection.Output;

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                SolicitorCurrentPasswordEncrypted = sqlDAlpha.SelectCommand.Parameters["@SolicitorCurrentPassword"].Value.ToString();

                SolicitorCurrentPasswordDecrypted = DecryptText(SolicitorCurrentPasswordEncrypted,EncryptionKey);

                // end get current password

                // start validate current password
                if (SolicitorCurrentPasswordDecrypted != CurrentPasswordDecrypted)
                {
                    error = "Current password is incorrect";
                }
                // end validate current password               

                // start call usp_Maintenance_SQLSolicitor_PasswordUpdate
                if (error == "")
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordUpdate @SolicitorCode, @SolicitorNewPassword, @SolicitorNewPasswordConfirmation, @error output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    error = sqlDAPRE.SelectCommand.Parameters["@error"].Value.ToString();
                }

                // end call usp_Maintenance_SQLSolicitor_PasswordUpdate

                // start get solicitor password history 
                if (error == "")
                {
                    SqlConnection connGAMA = null;
                    SqlDataAdapter sqlDAGAMA = null;
                    DataTable dtGAMA = null;

                    connGAMA = new SqlConnection(connstr);

                    sqlDAGAMA = new SqlDataAdapter();
                    sqlDAGAMA.SelectCommand = new SqlCommand("dbo.usp_solicitorpasswordhistorylist @SolicitorCode, @error output ", connGAMA);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAGAMA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsGAMA = new DataSet("ds");
                    sqlDAGAMA.Fill(dsGAMA);

                    if (dsGAMA.Tables.Count > 0)
                    {
                        dtGAMA = dsGAMA.Tables[0];

                        if (dtGAMA.Rows.Count > 0)
                        {
                            string PasswordHistoryEncrypted;
                            string PasswordHistoryDecrypted;
                            string SolicitorLoginPasswordHistoryCount;

                            for (int i = 0; i < dtGAMA.Rows.Count; i++)
                            {
                                PasswordHistoryEncrypted = dtGAMA.Rows[i]["SolicitorPassword"].ToString();
                                SolicitorLoginPasswordHistoryCount = dtGAMA.Rows[i]["SolicitorLoginPasswordHistoryCount"].ToString();
                                
                                PasswordHistoryDecrypted = DecryptText(PasswordHistoryEncrypted,EncryptionKey);

                                if (PasswordHistoryDecrypted == NewPasswordDecrypted)
                                {
                                    error = "The new password was used in the past "+ SolicitorLoginPasswordHistoryCount + " times. Please use a different password";
                                    break;
                                }
                                
                            }
                        }
                    }
                    //error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();
                }
                // end get solicitor password history 

                // start call  usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
                if (error == "")
                {
                    SqlConnection connDELTA = null;
                    SqlDataAdapter sqlDADELTA = null;
                    DataTable dtDELTA = null;

                    connDELTA = new SqlConnection(connstr);

                    string SolicitorEncryptedNewPassword;
                    SolicitorEncryptedNewPassword = EncryptText(NewPasswordDecrypted,EncryptionKey);

                    sqlDADELTA = new SqlDataAdapter();
                    sqlDADELTA.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordUpdate_Final @SolicitorCode, @SolicitorEncryptedNewPassword ", connDELTA);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@SolicitorEncryptedNewPassword", SolicitorEncryptedNewPassword);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    //sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    //sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsDELTA = new DataSet("ds");
                    sqlDADELTA.Fill(dsDELTA);

                }
                // end call  usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorChangePassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " solicitorcode:" + SolCode;
                LogErrorToDB("DP_SolicitorChangePassword", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolicitorResetPassword(string SolCode, ref string ReceiverEmail, ref string error)
        {
            error = "";

            try
            {
               
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);
                //sqlDABeta.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);

                //sqlDABeta.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                //sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                //sqlDABeta.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                //sqlDABeta.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                //string EncryptionKey = sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Value.ToString();
                // end get encrypted key

                // start call usp_Maintenance_SQLSolicitor_PasswordReset_Check                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordReset_Check @SolicitorCode, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                
                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

               // SolicitorCurrentPasswordDecrypted = DecryptText(SolicitorCurrentPasswordEncrypted, EncryptionKey);

                // end call usp_Maintenance_SQLSolicitor_PasswordReset_Check

                if (error == "")
                {
                    // start call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword     
                    
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword @SolicitorCode, @defaultPassword output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@defaultPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@defaultPassword"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string defaultPasswordDecrypted = sqlDAPRE.SelectCommand.Parameters["@defaultPassword"].Value.ToString();

                    // end call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword     
                    
                    string defaultPasswordEncrypted = EncryptText(defaultPasswordDecrypted, EncryptionKey);

                    // start call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final  
                    SqlConnection connDELTA = null;
                    SqlDataAdapter sqlDADELTA = null;
                    DataTable dtDELTA = null;

                    connDELTA = new SqlConnection(connstr);                    

                    sqlDADELTA = new SqlDataAdapter();
                    sqlDADELTA.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final @SolicitorCode, @SolicitorEncryptedNewPassword ", connDELTA);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@SolicitorEncryptedNewPassword", defaultPasswordEncrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    //sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    //sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsDELTA = new DataSet("ds");
                    sqlDADELTA.Fill(dsDELTA);
                    //end call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final

                    //start call usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail
                    SqlConnection connGAMA = null;
                    SqlDataAdapter sqlDAGAMA = null;
                    DataTable dtGAMA = null;

                    connGAMA = new SqlConnection(connstr);

                    sqlDAGAMA = new SqlDataAdapter();
                    sqlDAGAMA.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail @SolicitorCode,@Password,  @senderemail output, @receiveremail output, @emailheader output,@emailbody output ", connGAMA);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@Password", defaultPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAGAMA.SelectCommand.Parameters.Add("@senderemail", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@senderemail"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@receiveremail", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@receiveremail"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@emailheader", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@emailheader"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@emailbody", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@emailbody"].Direction = ParameterDirection.Output;

                    DataSet dsGAMA = new DataSet("ds");
                    sqlDAGAMA.Fill(dsGAMA);

                    string senderemail = sqlDAGAMA.SelectCommand.Parameters["@senderemail"].Value.ToString();
                    ReceiverEmail = sqlDAGAMA.SelectCommand.Parameters["@receiveremail"].Value.ToString();
                    string emailheader = sqlDAGAMA.SelectCommand.Parameters["@emailheader"].Value.ToString();
                    string emailbody = sqlDAGAMA.SelectCommand.Parameters["@emailbody"].Value.ToString();
                    //end call usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail

                    SendMail(ReceiverEmail, emailheader, emailbody, null,null);
                }               
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorResetPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " solicitorcode:" + SolCode;
                LogErrorToDB("DP_SolicitorResetPassword", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ValuerResetPassword(string ValCode, ref string ReceiverEmail, ref string error)
        {
            error = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);
                //sqlDABeta.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);

                //sqlDABeta.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                //sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                //sqlDABeta.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                //sqlDABeta.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                //string EncryptionKey = sqlDABeta.SelectCommand.Parameters["@EncryptionKey"].Value.ToString();
                // end get encrypted key

                // start call usp_Maintenance_SQLSolicitor_PasswordReset_Check                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordReset_Check @ValuerCode, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // SolicitorCurrentPasswordDecrypted = DecryptText(SolicitorCurrentPasswordEncrypted, EncryptionKey);

                // end call usp_Maintenance_SQLSolicitor_PasswordReset_Check

                if (error == "")
                {
                    // start call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordReset_updatePassword @ValuerCode, @defaultPassword output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@defaultPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@defaultPassword"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string defaultPasswordDecrypted = sqlDAPRE.SelectCommand.Parameters["@defaultPassword"].Value.ToString();

                    // end call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword     

                    string defaultPasswordEncrypted = EncryptText(defaultPasswordDecrypted, EncryptionKey);

                    // start call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final  
                    SqlConnection connDELTA = null;
                    SqlDataAdapter sqlDADELTA = null;
                    DataTable dtDELTA = null;

                    connDELTA = new SqlConnection(connstr);

                    sqlDADELTA = new SqlDataAdapter();
                    sqlDADELTA.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordReset_updatePassword_Final @ValuerCode, @ValuerEncryptedNewPassword ", connDELTA);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@ValuerEncryptedNewPassword", defaultPasswordEncrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    //sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    //sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsDELTA = new DataSet("ds");
                    sqlDADELTA.Fill(dsDELTA);
                    //end call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final

                    //start call usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail
                    SqlConnection connGAMA = null;
                    SqlDataAdapter sqlDAGAMA = null;
                    DataTable dtGAMA = null;

                    connGAMA = new SqlConnection(connstr);

                    sqlDAGAMA = new SqlDataAdapter();
                    sqlDAGAMA.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordReset_GenerateEmail @ValuerCode,@Password,  @senderemail output, @receiveremail output, @emailheader output,@emailbody output ", connGAMA);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@Password", defaultPasswordDecrypted);
                    //sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAGAMA.SelectCommand.Parameters.Add("@senderemail", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@senderemail"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@receiveremail", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@receiveremail"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@emailheader", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@emailheader"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@emailbody", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@emailbody"].Direction = ParameterDirection.Output;

                    DataSet dsGAMA = new DataSet("ds");
                    sqlDAGAMA.Fill(dsGAMA);

                    string senderemail = sqlDAGAMA.SelectCommand.Parameters["@senderemail"].Value.ToString();
                    ReceiverEmail = sqlDAGAMA.SelectCommand.Parameters["@receiveremail"].Value.ToString();
                    string emailheader = sqlDAGAMA.SelectCommand.Parameters["@emailheader"].Value.ToString();
                    string emailbody = sqlDAGAMA.SelectCommand.Parameters["@emailbody"].Value.ToString();
                    //end call usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail

                    SendMail(ReceiverEmail, emailheader, emailbody, null,null);
                }
            }
            catch (Exception ex)
            {
                error = "DP_ValuerResetPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " valuercode:" + ValCode;
                LogErrorToDB("DP_ValuerResetPassword", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_DeveloperResetPassword(string ID, ref string ReceiverEmail, ref string error)
        {
            error = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);                

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();
                
                // end get encrypted key

                // start call usp_Maintenance_SQLSolicitor_PasswordReset_Check                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLProject_PasswordReset_Check @ID, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ID", ID);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;               

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // SolicitorCurrentPasswordDecrypted = DecryptText(SolicitorCurrentPasswordEncrypted, EncryptionKey);

                // end call usp_Maintenance_SQLSolicitor_PasswordReset_Check

                if (error == "")
                {
                    // start call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLDeveloper_PasswordReset_updatePassword @ID, @defaultPassword output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@defaultPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@defaultPassword"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string defaultPasswordDecrypted = sqlDAPRE.SelectCommand.Parameters["@defaultPassword"].Value.ToString();

                    // end call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword     

                    string defaultPasswordEncrypted = EncryptText(defaultPasswordDecrypted, EncryptionKey);

                    // start call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final  
                    SqlConnection connDELTA = null;
                    SqlDataAdapter sqlDADELTA = null;
                    DataTable dtDELTA = null;

                    connDELTA = new SqlConnection(connstr);

                    sqlDADELTA = new SqlDataAdapter();
                    sqlDADELTA.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLDeveloper_PasswordReset_updatePassword_Final @ID, @EncryptedNewPassword ", connDELTA);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    sqlDADELTA.SelectCommand.Parameters.AddWithValue("@EncryptedNewPassword", defaultPasswordEncrypted);
                    
                    

                    //sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    //sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsDELTA = new DataSet("ds");
                    sqlDADELTA.Fill(dsDELTA);
                    //end call usp_Maintenance_SQLSolicitor_PasswordReset_updatePassword_Final

                    //start call usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail
                    SqlConnection connGAMA = null;
                    SqlDataAdapter sqlDAGAMA = null;
                    DataTable dtGAMA = null;

                    connGAMA = new SqlConnection(connstr);

                    sqlDAGAMA = new SqlDataAdapter();
                    sqlDAGAMA.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLDeveloper_PasswordReset_GenerateEmail @ID,@Password,  @senderemail output, @receiveremail output, @emailheader output,@emailbody output ", connGAMA);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@Password", defaultPasswordDecrypted);
                    
                    sqlDAGAMA.SelectCommand.Parameters.Add("@senderemail", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@senderemail"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@receiveremail", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@receiveremail"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@emailheader", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@emailheader"].Direction = ParameterDirection.Output;

                    sqlDAGAMA.SelectCommand.Parameters.Add("@emailbody", SqlDbType.NVarChar, 4000);
                    sqlDAGAMA.SelectCommand.Parameters["@emailbody"].Direction = ParameterDirection.Output;

                    DataSet dsGAMA = new DataSet("ds");
                    sqlDAGAMA.Fill(dsGAMA);

                    string senderemail = sqlDAGAMA.SelectCommand.Parameters["@senderemail"].Value.ToString();
                    ReceiverEmail = sqlDAGAMA.SelectCommand.Parameters["@receiveremail"].Value.ToString();
                    string emailheader = sqlDAGAMA.SelectCommand.Parameters["@emailheader"].Value.ToString();
                    string emailbody = sqlDAGAMA.SelectCommand.Parameters["@emailbody"].Value.ToString();
                    //end call usp_Maintenance_SQLSolicitor_PasswordReset_GenerateEmail

                    SendMail(ReceiverEmail, emailheader, emailbody, null, null);
                }
            }
            catch (Exception ex)
            {
                error = "DP_DeveloperResetPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " ID:" + ID;
                LogErrorToDB("DP_DeveloperResetPassword", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolicitorLogin(string SolCode , string SolPassword , ref string ForcePasswordChange, ref string PasswordExpiryWarning, ref string error)
        {
            error = "";
            ForcePasswordChange = "";
            PasswordExpiryWarning = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);               

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                // start call usp_SQLSolicitor_Login                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_SQLSolicitor_Login @SolicitorCode, @SolicitorPassword, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorPassword", SolPassword);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCurrentPassword", SolicitorCurrentPasswordEncrypted);
                //sqlDAlpha.SelectCommand.Parameters.AddWithValue("@error", error);

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // SolicitorCurrentPasswordDecrypted = DecryptText(SolicitorCurrentPasswordEncrypted, EncryptionKey);

                // end call usp_SQLSolicitor_Login

                if (error == "")
                {
                    // start call usp_SQLSolicitor_getPassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLSolicitor_getPassword @SolicitorCode, @SolicitorPassword output,@EncryptionKey output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@SolicitorPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@SolicitorPassword"].Direction = ParameterDirection.Output;

                    sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string EncryptedSolicitorPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@SolicitorPassword"].Value.ToString();

                    // end call usp_SQLSolicitor_getPassword     

                    string DecryptedSolicitorPasswordFromDB = DecryptText(EncryptedSolicitorPasswordFromDB, EncryptionKey);

                    if (DecryptedSolicitorPasswordFromDB== SolPassword)
                    {
                        //start call usp_SolicitorLogin_ForcePasswordChangeCheck
                        SqlConnection connEpsilon = null;
                        SqlDataAdapter sqlDAEpsilon = null;
                        DataTable dtEpsilon = null;

                        connEpsilon = new SqlConnection(connstr);

                        sqlDAEpsilon = new SqlDataAdapter();
                        sqlDAEpsilon.SelectCommand = new SqlCommand("dbo.usp_SolicitorLogin_ForcePasswordChangeCheck @solicitorcode,@error output ", connEpsilon);
                        sqlDAEpsilon.SelectCommand.Parameters.AddWithValue("@solicitorcode", SolCode);

                        sqlDAEpsilon.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAEpsilon.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsEpsilon = new DataSet("ds");
                        sqlDAEpsilon.Fill(dsEpsilon);

                        ForcePasswordChange = sqlDAEpsilon.SelectCommand.Parameters["@error"].Value.ToString();
                        //end call usp_SolicitorLogin_ForcePasswordChangeCheck

                        //start call usp_SolicitorLogin_GetExpiryWarning
                        SqlConnection connZata = null;
                        SqlDataAdapter sqlDAZata = null;
                        DataTable dtZata = null;

                        connZata = new SqlConnection(connstr);

                        sqlDAZata = new SqlDataAdapter();
                        sqlDAZata.SelectCommand = new SqlCommand("dbo.usp_SolicitorLogin_GetExpiryWarning @scode,@error output ", connZata);
                        sqlDAZata.SelectCommand.Parameters.AddWithValue("@scode", SolCode);

                        sqlDAZata.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAZata.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsZata = new DataSet("ds");
                        sqlDAZata.Fill(dsZata);

                        PasswordExpiryWarning = sqlDAZata.SelectCommand.Parameters["@error"].Value.ToString();
                        //end call usp_SolicitorLogin_GetExpiryWarning

                    }
                    
                    else
                    {
                        // start call usp_SolicitorLoginSessionCheck  
                        SqlConnection connDELTA = null;
                        SqlDataAdapter sqlDADELTA = null;
                        DataTable dtDELTA = null;

                        connDELTA = new SqlConnection(connstr);

                        sqlDADELTA = new SqlDataAdapter();
                        sqlDADELTA.SelectCommand = new SqlCommand("dbo.usp_SolicitorLoginSessionCheck @solicitorcode,  @error output", connDELTA);
                        sqlDADELTA.SelectCommand.Parameters.AddWithValue("@solicitorcode", SolCode);
                        
                        sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsDELTA = new DataSet("ds");
                        sqlDADELTA.Fill(dsDELTA);

                        error = sqlDADELTA.SelectCommand.Parameters["@error"].Value.ToString();

                        //end call usp_SolicitorLoginSessionCheck

                        if (error == "")
                        {
                            //start call usp_SolicitorLogin_getNumberOfTrialLeft
                            SqlConnection connGAMA = null;
                            SqlDataAdapter sqlDAGAMA = null;
                            DataTable dtGAMA = null;

                            connGAMA = new SqlConnection(connstr);

                            sqlDAGAMA = new SqlDataAdapter();
                            sqlDAGAMA.SelectCommand = new SqlCommand("dbo.usp_SolicitorLogin_getNumberOfTrialLeft @solicitorcode,@error output ", connGAMA);
                            sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@solicitorcode", SolCode);

                            sqlDAGAMA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                            sqlDAGAMA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                            DataSet dsGAMA = new DataSet("ds");
                            sqlDAGAMA.Fill(dsGAMA);

                            error = dsGAMA.Tables[0].Rows[0]["msg"].ToString();

                            //error = sqlDAGAMA.SelectCommand.Parameters["@error"].Value.ToString();
                            //end call usp_SolicitorLogin_getNumberOfTrialLeft
                        }                        
                    }                    
                }
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorLogin failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " SolCode:" + SolCode;
                LogErrorToDB("DP_SolicitorLogin", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_DeveloperLogin(string DevCode, string DevPassword, ref string ForcePasswordChange, ref string PasswordExpiryWarning, ref string error)
        {
            error = "";
            ForcePasswordChange = "";
            PasswordExpiryWarning = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                // start call usp_SQDeveloper_Login                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.ddProject_Login @DeveloperCode, @DeveloperPassword, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DevCode);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@DeveloperPassword", DevPassword);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // end call usp_SQDeveloper_Login

                if (error == "")
                {
                    // start call usp_SQLDeveloper_getPassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.ddProject_getPassword @DeveloperCode, @DeveloperPassword output,@EncryptionKey output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DevCode);                    

                    sqlDAPRE.SelectCommand.Parameters.Add("@DeveloperPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@DeveloperPassword"].Direction = ParameterDirection.Output;

                    sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string EncryptedDeveloperPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@DeveloperPassword"].Value.ToString();

                    // end call usp_SQLDeveloper_getPassword     

                    string DecryptedDeveloperPasswordFromDB = DecryptText(EncryptedDeveloperPasswordFromDB, EncryptionKey);

                    if (DecryptedDeveloperPasswordFromDB == DevPassword)
                    {
                        //start call usp_DeveloperLogin_ForcePasswordChangeCheck
                        SqlConnection connEpsilon = null;
                        SqlDataAdapter sqlDAEpsilon = null;
                        DataTable dtEpsilon = null;

                        connEpsilon = new SqlConnection(connstr);

                        sqlDAEpsilon = new SqlDataAdapter();
                        sqlDAEpsilon.SelectCommand = new SqlCommand("dbo.ddProjectLogin_ForcePasswordChangeCheck @DeveloperCode,@error output ", connEpsilon);
                        sqlDAEpsilon.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DevCode);

                        sqlDAEpsilon.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAEpsilon.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsEpsilon = new DataSet("ds");
                        sqlDAEpsilon.Fill(dsEpsilon);

                        ForcePasswordChange = sqlDAEpsilon.SelectCommand.Parameters["@error"].Value.ToString();
                        //end call usp_DeveloperLogin_ForcePasswordChangeCheck

                        //start call usp_DeveloperLogin_GetExpiryWarning
                        SqlConnection connZata = null;
                        SqlDataAdapter sqlDAZata = null;
                        DataTable dtZata = null;

                        connZata = new SqlConnection(connstr);

                        sqlDAZata = new SqlDataAdapter();
                        sqlDAZata.SelectCommand = new SqlCommand("dbo.ddProjectLogin_GetExpiryWarning @DeveloperCode,@error output ", connZata);
                        sqlDAZata.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DevCode);

                        sqlDAZata.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAZata.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsZata = new DataSet("ds");
                        sqlDAZata.Fill(dsZata);

                        PasswordExpiryWarning = sqlDAZata.SelectCommand.Parameters["@error"].Value.ToString();
                        //end call usp_DeveloperLogin_GetExpiryWarning

                    }
                    else
                    {
                        // start call usp_DeveloperLoginSessionCheck  
                        SqlConnection connDELTA = null;
                        SqlDataAdapter sqlDADELTA = null;
                        DataTable dtDELTA = null;

                        connDELTA = new SqlConnection(connstr);

                        sqlDADELTA = new SqlDataAdapter();
                        sqlDADELTA.SelectCommand = new SqlCommand("dbo.ddProjectLoginSessionCheck @DeveloperCode,  @error output", connDELTA);
                        sqlDADELTA.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DevCode);

                        sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsDELTA = new DataSet("ds");
                        sqlDADELTA.Fill(dsDELTA);

                        error = sqlDADELTA.SelectCommand.Parameters["@error"].Value.ToString();

                        //end call usp_DeveloperLoginSessionCheck

                        if (error == "")
                        {
                            //start call usp_DeveloperLogin_getNumberOfTrialLeft
                            SqlConnection connGAMA = null;
                            SqlDataAdapter sqlDAGAMA = null;
                            DataTable dtGAMA = null;

                            connGAMA = new SqlConnection(connstr);

                            sqlDAGAMA = new SqlDataAdapter();
                            sqlDAGAMA.SelectCommand = new SqlCommand("dbo.ddProjectLogin_getNumberOfTrialLeft @DeveloperCode,@error output ", connGAMA);
                            sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DevCode);

                            sqlDAGAMA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                            sqlDAGAMA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                            DataSet dsGAMA = new DataSet("ds");
                            sqlDAGAMA.Fill(dsGAMA);

                            error = dsGAMA.Tables[0].Rows[0]["msg"].ToString();
                            
                            //end call usp_DeveloperLogin_getNumberOfTrialLeft
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = "DP_DeveloperLogin failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " DevCode:" + DevCode;
                LogErrorToDB("DP_DeveloperLogin", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_ValuerLogin(string ValCode, string ValPassword, ref string ForcePasswordChange, ref string PasswordExpiryWarning, ref string error)
        {
            error = "";
            ForcePasswordChange = "";
            PasswordExpiryWarning = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                // start call usp_SQLValuer_Login                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_SQLValuer_Login @ValuerCode, @ValuerPassword, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerPassword", ValPassword);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // end call usp_SQLValuer_Login

                if (error == "")
                {
                    // start call usp_SQLValuer_getPassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLValuer_getPassword @ValuerCode, @ValuerPassword output,@EncryptionKey output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);

                    sqlDAPRE.SelectCommand.Parameters.Add("@ValuerPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@ValuerPassword"].Direction = ParameterDirection.Output;

                    sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string EncryptedValuerPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@ValuerPassword"].Value.ToString();

                    // end call usp_SQLValuer_getPassword     

                    string DecryptedValuerPasswordFromDB = DecryptText(EncryptedValuerPasswordFromDB, EncryptionKey);

                    if (DecryptedValuerPasswordFromDB == ValPassword)
                    {
                        //start call usp_ValuerLogin_ForcePasswordChangeCheck
                        SqlConnection connEpsilon = null;
                        SqlDataAdapter sqlDAEpsilon = null;
                        DataTable dtEpsilon = null;

                        connEpsilon = new SqlConnection(connstr);

                        sqlDAEpsilon = new SqlDataAdapter();
                        sqlDAEpsilon.SelectCommand = new SqlCommand("dbo.usp_ValuerLogin_ForcePasswordChangeCheck @Valuercode,@error output ", connEpsilon);
                        sqlDAEpsilon.SelectCommand.Parameters.AddWithValue("@Valuercode", ValCode);

                        sqlDAEpsilon.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAEpsilon.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsEpsilon = new DataSet("ds");
                        sqlDAEpsilon.Fill(dsEpsilon);

                        ForcePasswordChange = sqlDAEpsilon.SelectCommand.Parameters["@error"].Value.ToString();
                        //end call usp_ValuerLogin_ForcePasswordChangeCheck

                        //start call usp_ValuerLogin_GetExpiryWarning
                        SqlConnection connZata = null;
                        SqlDataAdapter sqlDAZata = null;
                        DataTable dtZata = null;

                        connZata = new SqlConnection(connstr);

                        sqlDAZata = new SqlDataAdapter();
                        sqlDAZata.SelectCommand = new SqlCommand("dbo.usp_ValuerLogin_GetExpiryWarning @vcode,@error output ", connZata);
                        sqlDAZata.SelectCommand.Parameters.AddWithValue("@vcode", ValCode);

                        sqlDAZata.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAZata.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsZata = new DataSet("ds");
                        sqlDAZata.Fill(dsZata);

                        PasswordExpiryWarning = sqlDAZata.SelectCommand.Parameters["@error"].Value.ToString();
                        //end call usp_ValuerLogin_GetExpiryWarning

                    }
                    else
                    {
                        // start call usp_ValuerLoginSessionCheck  
                        SqlConnection connDELTA = null;
                        SqlDataAdapter sqlDADELTA = null;
                        DataTable dtDELTA = null;

                        connDELTA = new SqlConnection(connstr);

                        sqlDADELTA = new SqlDataAdapter();
                        sqlDADELTA.SelectCommand = new SqlCommand("dbo.usp_ValuerLoginSessionCheck @valuercode,  @error output", connDELTA);
                        sqlDADELTA.SelectCommand.Parameters.AddWithValue("@valuercode", ValCode);

                        sqlDADELTA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDADELTA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsDELTA = new DataSet("ds");
                        sqlDADELTA.Fill(dsDELTA);

                        error = sqlDADELTA.SelectCommand.Parameters["@error"].Value.ToString();

                        //end call usp_ValuerLoginSessionCheck

                        if (error == "")
                        {
                            //start call usp_ValuerLogin_getNumberOfTrialLeft
                            SqlConnection connGAMA = null;
                            SqlDataAdapter sqlDAGAMA = null;
                            DataTable dtGAMA = null;

                            connGAMA = new SqlConnection(connstr);

                            sqlDAGAMA = new SqlDataAdapter();
                            sqlDAGAMA.SelectCommand = new SqlCommand("dbo.usp_ValuerLogin_getNumberOfTrialLeft @Valuercode,@error output ", connGAMA);
                            sqlDAGAMA.SelectCommand.Parameters.AddWithValue("@Valuercode", ValCode);

                            sqlDAGAMA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                            sqlDAGAMA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                            DataSet dsGAMA = new DataSet("ds");
                            sqlDAGAMA.Fill(dsGAMA);

                            error = dsGAMA.Tables[0].Rows[0]["msg"].ToString();

                            //end call usp_ValuerLogin_getNumberOfTrialLeft
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = "DP_ValuerLogin failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " ValCode:" + ValCode;
                LogErrorToDB("DP_ValuerLogin", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolicitorForcePasswordChangeLogin(string EncryptedUISolCode, string EncryptedUISolPassword, ref string error)
        {
            error = "";
            //ForcePasswordChange = "";
            //PasswordExpiryWarning = "";

            string DecryptedUISolCode="";
            string DecryptedUISolPassword="";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                

                DecryptedUISolCode = DecryptText(EncryptedUISolCode, EncryptionKey);
                DecryptedUISolPassword = DecryptText(EncryptedUISolPassword, EncryptionKey);
                // start call usp_Maintenance_SQLSolicitor_Login_Check                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_Login_Check @SolicitorCode, @SolicitorPassword, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCode", DecryptedUISolCode);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorPassword", DecryptedUISolPassword);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // end call usp_Maintenance_SQLSolicitor_Login_Check

                if (error == "")
                {
                    // start call usp_SQLSolicitor_getPassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLSolicitor_getPassword @SolicitorCode, @SolicitorPassword output,@EncryptionKey output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCode", DecryptedUISolCode);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                    //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                    sqlDAPRE.SelectCommand.Parameters.Add("@SolicitorPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@SolicitorPassword"].Direction = ParameterDirection.Output;

                    sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string EncryptedSolicitorPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@SolicitorPassword"].Value.ToString();

                    // end call usp_SQLSolicitor_getPassword     

                    string DecryptedSolicitorPasswordFromDB = DecryptText(EncryptedSolicitorPasswordFromDB, EncryptionKey);

                    if (DecryptedSolicitorPasswordFromDB != DecryptedUISolPassword)
                    {
                        error = "Please login to continue";
                    }                    
                }
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorForcePasswordChangeLogin failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " SolCode:" + DecryptedUISolCode;
                LogErrorToDB("DP_SolicitorForcePasswordChangeLogin", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_DeveloperForcePasswordChangeLogin(string EncryptedUIDevCode, string EncryptedUIDevPassword, ref string error)
        {
            error = "";                        

            string DecryptedUIDevCode = "";
            string DecryptedUIDevPassword = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                DecryptedUIDevCode = DecryptText(EncryptedUIDevCode, EncryptionKey);
                DecryptedUIDevPassword = DecryptText(EncryptedUIDevPassword, EncryptionKey);
                // start call usp_Maintenance_SQLSolicitor_Login_Check                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLDeveloper_Login_Check @DeveloperCode, @DeveloperPassword, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DecryptedUIDevCode);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@DeveloperPassword", DecryptedUIDevPassword);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // end call usp_Maintenance_SQLSolicitor_Login_Check

                if (error == "")
                {
                    // start call usp_SQLSolicitor_getPassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.ddProject_getPassword @DeveloperCode, @DeveloperPassword output,@EncryptionKey output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@DeveloperCode", DecryptedUIDevCode);                                        

                    sqlDAPRE.SelectCommand.Parameters.Add("@DeveloperPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@DeveloperPassword"].Direction = ParameterDirection.Output;

                    sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string EncryptedDeveloperPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@DeveloperPassword"].Value.ToString();

                    // end call usp_SQLSolicitor_getPassword     

                    string DecryptedDeveloperPasswordFromDB = DecryptText(EncryptedDeveloperPasswordFromDB, EncryptionKey);

                    if (DecryptedDeveloperPasswordFromDB != DecryptedUIDevPassword)
                    {
                        error = "Please login to continue";
                    }
                }
            }
            catch (Exception ex)
            {
                error = "DP_DeveloperForcePasswordChangeLogin failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " DevCode:" + DecryptedUIDevCode;
                LogErrorToDB("DP_DeveloperForcePasswordChangeLogin", "Exception", error, errorDetail);
            }
        }
        [WebMethod]
        public void DP_ValuerForcePasswordChangeLogin(string EncryptedUIValCode, string EncryptedUIValPassword, ref string error)
        {
            error = "";
            //ForcePasswordChange = "";
            //PasswordExpiryWarning = "";

            string DecryptedUIValCode = "";
            string DecryptedUIValPassword = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                DecryptedUIValCode = DecryptText(EncryptedUIValCode, EncryptionKey);
                DecryptedUIValPassword = DecryptText(EncryptedUIValPassword, EncryptionKey);
                // start call usp_Maintenance_SQLValuer_Login_Check                               

                SqlConnection connAlpha = null;
                SqlDataAdapter sqlDAlpha = null;

                connAlpha = new SqlConnection(connstr);

                sqlDAlpha = new SqlDataAdapter();
                sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_Login_Check @ValuerCode, @ValuerPassword, @error output ", connAlpha);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerCode", DecryptedUIValCode);
                sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerPassword", DecryptedUIValPassword);

                sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                DataSet dsAlpha = new DataSet("ds");
                sqlDAlpha.Fill(dsAlpha);

                error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                // end call usp_Maintenance_SQLValuer_Login_Check

                if (error == "")
                {
                    // start call usp_SQLValuer_getPassword     

                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLValuer_getPassword @ValuerCode, @ValuerPassword output,@EncryptionKey output ", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerCode", DecryptedUIValCode);
                    
                    sqlDAPRE.SelectCommand.Parameters.Add("@ValuerPassword", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@ValuerPassword"].Direction = ParameterDirection.Output;

                    sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                    sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);

                    string EncryptedValuerPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@ValuerPassword"].Value.ToString();

                    // end call usp_SQLValuer_getPassword     

                    string DecryptedValuerPasswordFromDB = DecryptText(EncryptedValuerPasswordFromDB, EncryptionKey);

                    if (DecryptedValuerPasswordFromDB != DecryptedUIValPassword)
                    {
                        error = "Please login to continue";
                    }
                }
            }
            catch (Exception ex)
            {
                error = "DP_ValuerForcePasswordChangeLogin failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " ValCode:" + DecryptedUIValCode;
                LogErrorToDB("DP_ValuerForcePasswordChangeLogin", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_SolicitorForcePasswordChange(ref string error ,string SolCode = null, string CurrentSolPasswordFromUI = null, string NewSolPasswordFromUI = null, string NewSolPasswordFromUIConfirmation = null)
        {
            error = "";
            //ForcePasswordChange = "";
            //PasswordExpiryWarning = "";

            //string DecryptedUISolCode = "";
            //string DecryptedUISolPassword = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                // start call usp_SQLSolicitor_getPassword     

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLSolicitor_getPassword @SolicitorCode, @SolicitorPassword output,@EncryptionKey output ", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewPasswordDecrypted);
                //sqlDAPRE.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewPasswordConfirmationDecrypted);

                sqlDAPRE.SelectCommand.Parameters.Add("@SolicitorPassword", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@SolicitorPassword"].Direction = ParameterDirection.Output;

                sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                string EncryptedSolicitorPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@SolicitorPassword"].Value.ToString();

                // end call usp_SQLSolicitor_getPassword     

                string DecryptedSolicitorPasswordFromDB = DecryptText(EncryptedSolicitorPasswordFromDB, EncryptionKey);

                if (DecryptedSolicitorPasswordFromDB != CurrentSolPasswordFromUI)
                {
                    error = "Current Password is incorrect";
                }

                //DecryptedUISolCode = DecryptText(EncryptedUISolCode, EncryptionKey);
                //DecryptedUISolPassword = DecryptText(EncryptedUISolPassword, EncryptionKey);

                if (error == "")
                {
                    // start call usp_Maintenance_SQLSolicitor_PasswordUpdate   
                    SqlConnection connAlpha = null;
                    SqlDataAdapter sqlDAlpha = null;

                    connAlpha = new SqlConnection(connstr);

                    sqlDAlpha = new SqlDataAdapter();
                    sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordUpdate @SolicitorCode, @SolicitorNewPassword,@SolicitorNewPasswordConfirmation, @error output ", connAlpha);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorNewPassword", NewSolPasswordFromUI);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewSolPasswordFromUIConfirmation);
                    
                    sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsAlpha = new DataSet("ds");
                    sqlDAlpha.Fill(dsAlpha);

                    error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                    // end call usp_Maintenance_SQLSolicitor_PasswordUpdate

                    if (error =="")
                    {
                        // start call usp_solicitorpasswordhistorylist
                        SqlConnection connOmega = null;
                        SqlDataAdapter sqlDAOmega = null;

                        connOmega = new SqlConnection(connstr);

                        sqlDAOmega = new SqlDataAdapter();
                        sqlDAOmega.SelectCommand = new SqlCommand("dbo.usp_solicitorpasswordhistorylist @solicitorcode, @error output ", connOmega);
                        sqlDAOmega.SelectCommand.Parameters.AddWithValue("@solicitorcode", SolCode);
                       
                        sqlDAOmega.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAOmega.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsOmega = new DataSet("ds");
                        sqlDAOmega.Fill(dsOmega);
                        DataTable dtOmega;
                        //string EncryptedSolicitorPasswordFromDB = sqlDAOmega.SelectCommand.Parameters["@SolicitorPassword"].Value.ToString();

                        if (dsOmega.Tables.Count > 0)
                        {
                            dtOmega = dsOmega.Tables[0];

                            if (dtOmega.Rows.Count > 0)
                            {
                                for (int i = 0; i < dtOmega.Rows.Count; i++)
                                {

                                    string PH_SolicitorCode = dtOmega.Rows[i]["SolicitorCode"].ToString();
                                    string PH_SolicitorPassword = dtOmega.Rows[i]["SolicitorPassword"].ToString();
                                    string PH_CreatedDate = dtOmega.Rows[i]["CreatedDate"].ToString();
                                    string PH_encryptionkey = dtOmega.Rows[i]["encryptionkey"].ToString();
                                    string PH_SolicitorLoginPasswordHistoryCount = dtOmega.Rows[i]["SolicitorLoginPasswordHistoryCount"].ToString();

                                    string PH_DecryptedSolicitorPassword = DecryptText(PH_SolicitorPassword, EncryptionKey);

                                    if (NewSolPasswordFromUI == PH_DecryptedSolicitorPassword)
                                    {
                                        error = "The new password was used in the past " + PH_SolicitorLoginPasswordHistoryCount + " times. Please use a different password ";
                                        break;
                                    }
                                }
                            }
                        }

                        if (error =="")
                        {
                            string EncryptedNewSolPasswordFromUI = EncryptText(NewSolPasswordFromUI, EncryptionKey);

                            // start call usp_Maintenance_SQLSolicitor_PasswordUpdate_Final   
                            SqlConnection connEta = null;
                            SqlDataAdapter sqlDAEta = null;

                            connEta = new SqlConnection(connstr);

                            sqlDAEta = new SqlDataAdapter();
                            sqlDAEta.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLSolicitor_PasswordUpdate_Final @SolicitorCode, @SolicitorEncryptedNewPassword", connEta);
                            sqlDAEta.SelectCommand.Parameters.AddWithValue("@SolicitorCode", SolCode);
                            sqlDAEta.SelectCommand.Parameters.AddWithValue("@SolicitorEncryptedNewPassword", EncryptedNewSolPasswordFromUI);
                            //sqlDAEta.SelectCommand.Parameters.AddWithValue("@SolicitorNewPasswordConfirmation", NewSolPasswordFromUIConfirmation);

                            //sqlDAEta.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                            //sqlDAEta.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                            DataSet dsEta = new DataSet("ds");
                            sqlDAEta.Fill(dsEta);

                            //error = sqlDAEta.SelectCommand.Parameters["@error"].Value.ToString();

                            // end call usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
                        }
                        // end call usp_solicitorpasswordhistorylist
                    }

                }
                
            }
            catch (Exception ex)
            {
                error = "DP_SolicitorForcePasswordChange failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " SolCode:" + SolCode;
                LogErrorToDB("DP_SolicitorForcePasswordChange", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_DeveloperForcePasswordChange(ref string error, string ProjectCode = null, string CurrentProjectPasswordFromUI = null, string NewProjectPasswordFromUI = null, string NewProjectPasswordFromUIConfirmation = null)
        {
            error = "";            

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                // start call usp_SQLSolicitor_getPassword     

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.ddProject_getPassword @ProjectCode, @ProjectPassword output,@EncryptionKey output ", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ProjectCode", ProjectCode);                                

                sqlDAPRE.SelectCommand.Parameters.Add("@ProjectPassword", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@ProjectPassword"].Direction = ParameterDirection.Output;

                sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                string EncryptedProjectPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@ProjectPassword"].Value.ToString();

                // end call usp_SQLSolicitor_getPassword     

                string DecryptedProjectPasswordFromDB = DecryptText(EncryptedProjectPasswordFromDB, EncryptionKey);

                if (DecryptedProjectPasswordFromDB != CurrentProjectPasswordFromUI)
                {
                    error = "Current Password is incorrect";
                }

                //DecryptedUISolCode = DecryptText(EncryptedUISolCode, EncryptionKey);
                //DecryptedUISolPassword = DecryptText(EncryptedUISolPassword, EncryptionKey);

                if (error == "")
                {
                    // start call usp_Maintenance_SQLSolicitor_PasswordUpdate   
                    SqlConnection connAlpha = null;
                    SqlDataAdapter sqlDAlpha = null;

                    connAlpha = new SqlConnection(connstr);

                    sqlDAlpha = new SqlDataAdapter();
                    sqlDAlpha.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLProject_PasswordUpdate @Code, @NewPassword,@NewPasswordConfirmation, @CurrentPassword, @error output ", connAlpha);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@Code", ProjectCode);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@NewPassword", NewProjectPasswordFromUI);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@NewPasswordConfirmation", NewProjectPasswordFromUIConfirmation);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@CurrentPassword", CurrentProjectPasswordFromUI);

                    sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsAlpha = new DataSet("ds");
                    sqlDAlpha.Fill(dsAlpha);

                    error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                    // end call usp_Maintenance_SQLSolicitor_PasswordUpdate

                    if (error == "")
                    {
                        // start call usp_solicitorpasswordhistorylist
                        SqlConnection connOmega = null;
                        SqlDataAdapter sqlDAOmega = null;

                        connOmega = new SqlConnection(connstr);

                        sqlDAOmega = new SqlDataAdapter();
                        sqlDAOmega.SelectCommand = new SqlCommand("dbo.ddProjectPasswordHistoryList @ProjectCode, @error output ", connOmega);
                        sqlDAOmega.SelectCommand.Parameters.AddWithValue("@ProjectCode", ProjectCode);

                        sqlDAOmega.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAOmega.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsOmega = new DataSet("ds");
                        sqlDAOmega.Fill(dsOmega);
                        DataTable dtOmega;                        

                        if (dsOmega.Tables.Count > 0)
                        {
                            dtOmega = dsOmega.Tables[0];

                            if (dtOmega.Rows.Count > 0)
                            {
                                for (int i = 0; i < dtOmega.Rows.Count; i++)
                                {

                                    string PH_ProjectCode = dtOmega.Rows[i]["ProjectCode"].ToString();
                                    string PH_ProjectPassword = dtOmega.Rows[i]["ProjectPassword"].ToString();
                                    string PH_CreatedDate = dtOmega.Rows[i]["CreatedDate"].ToString();
                                    string PH_encryptionkey = dtOmega.Rows[i]["encryptionkey"].ToString();
                                    string PH_ProjectLoginPasswordHistoryCount = dtOmega.Rows[i]["ProjectLoginPasswordHistoryCount"].ToString();

                                    string PH_DecryptedProjectPassword = DecryptText(PH_ProjectPassword, EncryptionKey);

                                    if (NewProjectPasswordFromUI == PH_DecryptedProjectPassword)
                                    {
                                        error = "The new password was used in the past " + PH_ProjectLoginPasswordHistoryCount + " times. Please use a different password ";
                                        break;
                                    }
                                }
                            }
                        }

                        if (error == "")
                        {
                            string EncryptedNewProjectPasswordFromUI = EncryptText(NewProjectPasswordFromUI, EncryptionKey);

                            // start call usp_Maintenance_SQLSolicitor_PasswordUpdate_Final   
                            SqlConnection connEta = null;
                            SqlDataAdapter sqlDAEta = null;

                            connEta = new SqlConnection(connstr);

                            sqlDAEta = new SqlDataAdapter();
                            sqlDAEta.SelectCommand = new SqlCommand("dbo.ddMaintenance_SQLProject_PasswordUpdate_Final @Code, @EncryptedNewPassword", connEta);
                            sqlDAEta.SelectCommand.Parameters.AddWithValue("@Code", ProjectCode);
                            sqlDAEta.SelectCommand.Parameters.AddWithValue("@EncryptedNewPassword", EncryptedNewProjectPasswordFromUI);                            
                            
                            DataSet dsEta = new DataSet("ds");
                            sqlDAEta.Fill(dsEta);

                            //error = sqlDAEta.SelectCommand.Parameters["@error"].Value.ToString();

                            // end call usp_Maintenance_SQLSolicitor_PasswordUpdate_Final
                        }
                        // end call usp_solicitorpasswordhistorylist
                    }

                }

            }
            catch (Exception ex)
            {
                error = "DP_DeveloperForcePasswordChange failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " ProjectCode:" + ProjectCode;
                LogErrorToDB("DP_DeveloperForcePasswordChange", "Exception", error, errorDetail);
            }
        }
        [WebMethod]
        public void DP_ValuerForcePasswordChange(ref string error, string ValCode = null, string CurrentValPasswordFromUI = null, string NewValPasswordFromUI = null, string NewValPasswordFromUIConfirmation = null)
        {
            error = "";

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                string EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key

                // start call usp_SQLValuer_getPassword     

                SqlConnection connPRE = null;
                SqlDataAdapter sqlDAPRE = null;

                connPRE = new SqlConnection(connstr);

                sqlDAPRE = new SqlDataAdapter();
                sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_SQLValuer_getPassword @ValuerCode, @ValuerPassword output,@EncryptionKey output ", connPRE);
                sqlDAPRE.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);

                sqlDAPRE.SelectCommand.Parameters.Add("@ValuerPassword", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@ValuerPassword"].Direction = ParameterDirection.Output;

                sqlDAPRE.SelectCommand.Parameters.Add("@EncryptionKey", SqlDbType.NVarChar, 4000);
                sqlDAPRE.SelectCommand.Parameters["@EncryptionKey"].Direction = ParameterDirection.Output;

                DataSet dsPRE = new DataSet("ds");
                sqlDAPRE.Fill(dsPRE);

                string EncryptedValuerPasswordFromDB = sqlDAPRE.SelectCommand.Parameters["@ValuerPassword"].Value.ToString();

                // end call usp_SQLValuer_getPassword     

                string DecryptedValuerPasswordFromDB = DecryptText(EncryptedValuerPasswordFromDB, EncryptionKey);

                if (DecryptedValuerPasswordFromDB != CurrentValPasswordFromUI)
                {
                    error = "Current Password is incorrect";
                }                

                if (error == "")
                {
                    // start call usp_Maintenance_SQLValuer_PasswordUpdate   
                    SqlConnection connAlpha = null;
                    SqlDataAdapter sqlDAlpha = null;

                    connAlpha = new SqlConnection(connstr);

                    sqlDAlpha = new SqlDataAdapter();
                    sqlDAlpha.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordUpdate @ValuerCode, @ValuerNewPassword,@ValuerNewPasswordConfirmation, @error output ", connAlpha);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerNewPassword", NewValPasswordFromUI);
                    sqlDAlpha.SelectCommand.Parameters.AddWithValue("@ValuerNewPasswordConfirmation", NewValPasswordFromUIConfirmation);

                    sqlDAlpha.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                    sqlDAlpha.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                    DataSet dsAlpha = new DataSet("ds");
                    sqlDAlpha.Fill(dsAlpha);

                    error = sqlDAlpha.SelectCommand.Parameters["@error"].Value.ToString();

                    // end call usp_Maintenance_SQLValuer_PasswordUpdate

                    if (error == "")
                    {
                        // start call usp_valuerpasswordhistorylist
                        SqlConnection connOmega = null;
                        SqlDataAdapter sqlDAOmega = null;

                        connOmega = new SqlConnection(connstr);

                        sqlDAOmega = new SqlDataAdapter();
                        sqlDAOmega.SelectCommand = new SqlCommand("dbo.usp_valuerpasswordhistorylist @ValuerCode, @error output ", connOmega);
                        sqlDAOmega.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);

                        sqlDAOmega.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                        sqlDAOmega.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;

                        DataSet dsOmega = new DataSet("ds");
                        sqlDAOmega.Fill(dsOmega);
                        DataTable dtOmega;
                        // end call usp_valuerpasswordhistorylist
                        
                        if (dsOmega.Tables.Count > 0)
                        {
                            dtOmega = dsOmega.Tables[0];

                            if (dtOmega.Rows.Count > 0)
                            {
                                for (int i = 0; i < dtOmega.Rows.Count; i++)
                                {

                                    string PH_ValuerCode = dtOmega.Rows[i]["ValuerCode"].ToString();
                                    string PH_ValuerPassword = dtOmega.Rows[i]["ValuerPassword"].ToString();
                                    string PH_CreatedDate = dtOmega.Rows[i]["CreatedDate"].ToString();
                                    string PH_encryptionkey = dtOmega.Rows[i]["encryptionkey"].ToString();
                                    string PH_ValuerLoginPasswordHistoryCount = dtOmega.Rows[i]["ValuerLoginPasswordHistoryCount"].ToString();

                                    string PH_DecryptedValuerPassword = DecryptText(PH_ValuerPassword, EncryptionKey);

                                    if (NewValPasswordFromUI == PH_DecryptedValuerPassword)
                                    {
                                        error = "The new password was used in the past " + PH_ValuerLoginPasswordHistoryCount + " times. Please use a different password ";
                                        break;
                                    }
                                }
                            }
                        }

                        if (error == "")
                        {
                            string EncryptedNewValPasswordFromUI = EncryptText(NewValPasswordFromUI, EncryptionKey);

                            // start call usp_Maintenance_SQLValuer_PasswordUpdate_Final   
                            SqlConnection connEta = null;
                            SqlDataAdapter sqlDAEta = null;

                            connEta = new SqlConnection(connstr);

                            sqlDAEta = new SqlDataAdapter();
                            sqlDAEta.SelectCommand = new SqlCommand("dbo.usp_Maintenance_SQLValuer_PasswordUpdate_Final @ValuerCode, @ValuerEncryptedNewPassword", connEta);
                            sqlDAEta.SelectCommand.Parameters.AddWithValue("@ValuerCode", ValCode);
                            sqlDAEta.SelectCommand.Parameters.AddWithValue("@ValuerEncryptedNewPassword", EncryptedNewValPasswordFromUI);                            

                            DataSet dsEta = new DataSet("ds");
                            sqlDAEta.Fill(dsEta);

                            // end call usp_Maintenance_SQLValuer_PasswordUpdate_Final
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                error = "DP_ValuerForcePasswordChange failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + " ValCode:" + ValCode;
                LogErrorToDB("DP_ValuerForcePasswordChange", "Exception", error, errorDetail);
            }
        }

        [WebMethod]
        public void DP_GetEncryptionKey(ref string EncryptionKey, ref string error)
        {
            error = "";
            EncryptionKey = "";
            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                // start get encrypted key
                SqlConnection connBeta = null;
                SqlDataAdapter sqlDABeta = null;
                DataTable dtBeta = null;

                connBeta = new SqlConnection(connstr);

                sqlDABeta = new SqlDataAdapter();
                sqlDABeta.SelectCommand = new SqlCommand("dbo.usp_get_encryptionkey ", connBeta);

                DataSet dsBETA = new DataSet("ds");
                sqlDABeta.Fill(dsBETA);

                DataTable dtBETA = dsBETA.Tables[0];
                EncryptionKey = dtBETA.Rows[0]["EncryptionKey"].ToString();

                // end get encrypted key
                
                
            }
            catch (Exception ex)
            {
                error = "DP_GetEncryptionKey failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:"; 
                LogErrorToDB("DP_GetEncryptionKey", "Exception", error, errorDetail);
            }
        }

        [WebMethod(EnableSession = true)]
        public void SetSession(string ID,string Value)
        {
            Session["session1"] = Value;            
        }

        [WebMethod(EnableSession = true)]
        public void GetSession(string ID, ref string Value)
        {
            Value = Session["session1"].ToString();
        }

        [WebMethod]
        public void DP_SaveValuerAttachment(string arn, string k2fileattachment, ref string error)
        {
            error = "";

            try
            {
                // log the result in db
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
                string strID2 = clsGlobal.MG_SQL_ID2;
                string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
                if (blnIsWinAuth2)
                {
                    connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
                }

                SqlConnection connPRE0 = null;
                SqlDataAdapter sqlDAPRE0 = null;

                connPRE0 = new SqlConnection(connstr);

                sqlDAPRE0 = new SqlDataAdapter();
                sqlDAPRE0.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE0);

                string fireeye_flag;
                fireeye_flag = "";
                DataSet dsPRE0 = new DataSet("ds");
                sqlDAPRE0.Fill(dsPRE0);

                if (dsPRE0.Tables.Count > 0)
                {
                    DataTable dtPRE0 = dsPRE0.Tables[0];
                    fireeye_flag = dtPRE0.Rows[0]["fireeye_flag"].ToString();
                }

                if (fireeye_flag == "1")
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr2);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_valuerattachment_preupload] @arn,@k2attachment, @error output", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", k2fileattachment);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);
                }
                else
                {
                    SqlConnection connPRE = null;
                    SqlDataAdapter sqlDAPRE = null;

                    connPRE = new SqlConnection(connstr);

                    sqlDAPRE = new SqlDataAdapter();
                    sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_valuerattachment_preupload] @arn,@k2attachment, @error output", connPRE);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@k2attachment", k2fileattachment);
                    sqlDAPRE.SelectCommand.Parameters.AddWithValue("@error", "");

                    DataSet dsPRE = new DataSet("ds");
                    sqlDAPRE.Fill(dsPRE);
                }



            }
            catch (Exception ex)
            {
                error = "DP_SaveValuerAttachment failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param:" + "arn:" + arn + ", k2fileattachment:" + k2fileattachment;
                LogErrorToDB("DP_SaveValuerAttachment", "Exception", error, errorDetail);
            }
        }

        public struct structureErrorLog
        {
            public string id;
            public string APIName;
            public string errorType;
            public string errorMessage;
            public string errorDetail;
            public string APIErrorDt;
            public string DateInserted;
        }

        [WebMethod]
        public List<structureErrorLog> DP_GetErrorLogFromAVDB()
        {
            string error = "";
            List<structureErrorLog> list = new List<structureErrorLog>();

            try
            {


                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName = clsGlobal.MG_SQL_DB_NAME2;
                string strID = clsGlobal.MG_SQL_ID2;
                string strPassword = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_getErrorLog", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            structureErrorLog errorLogs = new structureErrorLog();
                            errorLogs.id = dt.Rows[i]["id"].ToString();
                            errorLogs.APIName = dt.Rows[i]["APIName"].ToString();
                            errorLogs.errorType = dt.Rows[i]["errorType"].ToString();
                            errorLogs.errorMessage = dt.Rows[i]["errorMessage"].ToString();
                            errorLogs.errorDetail = dt.Rows[i]["errorDetail"].ToString();
                            errorLogs.APIErrorDt = dt.Rows[i]["APIErrorDt"].ToString();
                            errorLogs.DateInserted = dt.Rows[i]["DateInserted"].ToString();

                            list.Add(errorLogs);
                        }

                    }
                }


                conn.Close();


            }
            catch (Exception ex)
            {
                error = "DP_GetErrorLogFromAVDB failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_GetErrorLogFromAVDB", "Exception", error, errorDetail);
            }
            return list;
        }

        public struct maliciousfilelog
        {
            public string arn;
            public string workflow;
            public string filename_original;
            public string filename_new;
            public string filecontent;
            public string filetype;
            public string attachmentuploaddate;

            public string fe_file_url;
            public string fe_fireeye_id;
            public string fe_failed_description;
            public string fe_failed_code;
            public string result;
            public string CreatedDate;
            public string UpdatedDate;
            public string SHA2_256;
        }

        [WebMethod]
        public List<maliciousfilelog> DP_GetMaliciousLogFromAVDB()
        {
            string error = "";
            List<maliciousfilelog> list = new List<maliciousfilelog>();

            try
            {

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE2;
                string strDBName = clsGlobal.MG_SQL_DB_NAME2;
                string strID = clsGlobal.MG_SQL_ID2;
                string strPassword = clsGlobal.MG_SQL_PASSWORD2;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH2;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_getmaliciousfilesLog", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            maliciousfilelog errorLogs = new maliciousfilelog();
                            errorLogs.arn = dt.Rows[i]["arn"].ToString();
                            errorLogs.workflow = dt.Rows[i]["workflow"].ToString();
                            errorLogs.filename_original = dt.Rows[i]["filename_original"].ToString();
                            errorLogs.filename_new = dt.Rows[i]["filename_new"].ToString();
                            errorLogs.filecontent = dt.Rows[i]["filecontent"].ToString();
                            errorLogs.filetype = dt.Rows[i]["filetype"].ToString();
                            errorLogs.attachmentuploaddate = dt.Rows[i]["attachmentuploaddate"].ToString();

                            errorLogs.fe_file_url = dt.Rows[i]["fe_file_url"].ToString();
                            errorLogs.fe_fireeye_id = dt.Rows[i]["fe_fireeye_id"].ToString();
                            errorLogs.fe_failed_description = dt.Rows[i]["fe_failed_description"].ToString();
                            errorLogs.fe_failed_code = dt.Rows[i]["fe_failed_code"].ToString();
                            errorLogs.result = dt.Rows[i]["result"].ToString();
                            errorLogs.CreatedDate = dt.Rows[i]["CreatedDate"].ToString();

                            errorLogs.UpdatedDate = dt.Rows[i]["UpdatedDate"].ToString();
                            errorLogs.SHA2_256 = dt.Rows[i]["SHA2_256"].ToString();

                            list.Add(errorLogs);
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                error = "DP_GetMaliciousLogFromAVDB failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("DP_GetMaliciousLogFromAVDB", "Exception", error, errorDetail);
            }
            return list;
        }

        public struct k2filestructure
        {
            public string filename;
            public string filecontent;
        }

        [WebMethod]
        public List<k2filestructure> DP_GetK2FileNameAndContent(string input_xml)
        {
            string error = "";
            List<k2filestructure> list = new List<k2filestructure>();

            try
            {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(input_xml); // suppose that myXmlString contains "<Names>...</Names>"

                XmlNodeList xnList = xml.SelectNodes("/file");
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    string content = xn["content"].InnerText;

                    k2filestructure item = new k2filestructure();
                    item.filecontent = content;
                    item.filename = name;
                    list.Add(item);
                }

            }
            catch (Exception ex)
            {
                error = "DP_GetK2FileNameAndContent failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + input_xml;
                LogErrorToDB("DP_GetK2FileNameAndContent", "Exception", error, errorDetail);
            }
            return list;
        }

        [WebMethod]
        public string DP_SetDULetterPassword(string id, string input_xml)
        {
            string error = "";
            string output_xml = input_xml;

            try
            {
                List<k2filestructure> list = new List<k2filestructure>();
                list = DP_GetK2FileNameAndContent(input_xml);

                string filename = "";
                string filecontent = "";

                foreach (var file in list)
                {
                    filename = file.filename;
                    filecontent = file.filecontent;
                }

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_setting_getDU1pdfmasterpassword", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];

                string masterpw = "";

                if (ds.Tables.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            masterpw = dt.Rows[j]["pdfmasterpassword"].ToString();
                        }
                    }
                }
                //conn.Close();

                //start get pdf password for sol                                 
                //conn.Open();
                SqlDataAdapter sqlDA2 = null;
                sqlDA2 = new SqlDataAdapter();                
                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_PDFPasswordSol_getPassword] @arn, @password output", conn);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", id);
                sqlDA2.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 4000);
                sqlDA2.SelectCommand.Parameters["@password"].Direction = ParameterDirection.Output;

                ds = new DataSet("ds");
                sqlDA2.Fill(ds);

                string PDFPassword = sqlDA2.SelectCommand.Parameters["@password"].Value.ToString();
               
                conn.Close();
                //end get pdf password for sol 

                byte[] byteFileContent = null;
                byte[] outputbyteFileContent = null;

                byteFileContent = Convert.FromBase64String(filecontent);

                Stream stream = new MemoryStream(byteFileContent);
                MemoryStream outputstream = new MemoryStream();

                Aspose.Pdf.License license = new Aspose.Pdf.License();

                license.SetLicense("Aspose.PDF.NET.lic");

                Document doc = new Document(stream);

                doc.Encrypt(PDFPassword, masterpw, 0, CryptoAlgorithm.AESx256);
                doc.Save(outputstream);
                outputbyteFileContent = outputstream.ToArray();
                string protectedfilecontent = Convert.ToBase64String(outputbyteFileContent, 0, outputbyteFileContent.Length);


                XDocument xdoc = XDocument.Parse(output_xml);

                IEnumerable<XElement> xfile = xdoc.Elements("file");

                foreach (XElement node in xfile)
                {
                    XElement content = node.Element("content");
                    content.Value = protectedfilecontent;
                }

                //xdoc.Save(output_xml);

                output_xml = xdoc.ToString();
                //XmlDocument xml = new XmlDocument();
                //xml.LoadXml(output_xml); // suppose that myXmlString contains "<Names>...</Names>"

                //XmlNodeList xnList = xml.SelectNodes("/file");
                //XmlNode node = xml.SelectSingleNode("/file");
                //node.Attributes["content"].Value = protectedfilecontent;

                // var element = xml.Elements("file/content").Single();
                // element.Value = "foo";

            }
            catch (Exception ex)
            {
                error = "DP_SetDULetterPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + input_xml;
                LogErrorToDB("DP_SetDULetterPassword", "Exception", error, errorDetail);
            }
            return output_xml;
        }

        [WebMethod]
        public string DP_SetDeveloperPortalNotificationOfPaymentPassword(string DevCode, string DevName, string ProjectCode, string PhaseCode, string filecontent)
        {
            string error = "";
            string protectedfilecontent = "";
            //string output_xml = input_xml;

            try
            {
                /*
                List<k2filestructure> list = new List<k2filestructure>();
                list = DP_GetK2FileNameAndContent(input_xml);

                string filename = "";
                string filecontent = "";

                foreach (var file in list)
                {
                    filename = file.filename;
                    filecontent = file.filecontent;
                }
                */

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_setting_getDU1pdfmasterpassword", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];

                string masterpw = "";

                if (ds.Tables.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            masterpw = dt.Rows[j]["pdfmasterpassword"].ToString();
                        }
                    }
                }
                //conn.Close();

                //start get pdf password for sol                                 
                //conn.Open();               

                SqlDataAdapter sqlDA2 = null;
                sqlDA2 = new SqlDataAdapter();
                sqlDA2.SelectCommand = new SqlCommand("dbo.[ddProjectDisbursementSubmission_NotificationOfPayment_PDFPassword_getPassword] @DevCode, @ProjectCode, @PhaseCode, @DevName, @password output", conn);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@DevCode", DevCode);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@ProjectCode", ProjectCode);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@PhaseCode", PhaseCode);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@DevName", DevName);
                sqlDA2.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 4000);
                sqlDA2.SelectCommand.Parameters["@password"].Direction = ParameterDirection.Output;

                ds = new DataSet("ds");
                sqlDA2.Fill(ds);

                string PDFPassword = sqlDA2.SelectCommand.Parameters["@password"].Value.ToString();

                conn.Close();
                //end get pdf password for sol 

                byte[] byteFileContent = null;
                byte[] outputbyteFileContent = null;

                byteFileContent = Convert.FromBase64String(filecontent);

                Stream stream = new MemoryStream(byteFileContent);
                MemoryStream outputstream = new MemoryStream();

                Aspose.Pdf.License license = new Aspose.Pdf.License();

                license.SetLicense("Aspose.PDF.NET.lic");

                Document doc = new Document(stream);

                doc.Encrypt(PDFPassword, masterpw, 0, CryptoAlgorithm.AESx256);
                doc.Save(outputstream);
                outputbyteFileContent = outputstream.ToArray();
                protectedfilecontent = Convert.ToBase64String(outputbyteFileContent, 0, outputbyteFileContent.Length);

                /*
                XDocument xdoc = XDocument.Parse(output_xml);

                IEnumerable<XElement> xfile = xdoc.Elements("file");

                foreach (XElement node in xfile)
                {
                    XElement content = node.Element("content");
                    content.Value = protectedfilecontent;
                }

                //xdoc.Save(output_xml);

                output_xml = xdoc.ToString();
                */
                //XmlDocument xml = new XmlDocument();
                //xml.LoadXml(output_xml); // suppose that myXmlString contains "<Names>...</Names>"

                //XmlNodeList xnList = xml.SelectNodes("/file");
                //XmlNode node = xml.SelectSingleNode("/file");
                //node.Attributes["content"].Value = protectedfilecontent;

                // var element = xml.Elements("file/content").Single();
                // element.Value = "foo";

            }
            catch (Exception ex)
            {
                error = "DP_SetDeveloperPortalNotificationOfPaymentPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: arn:" + DevCode + "filecontent:" + filecontent;
                LogErrorToDB("DP_SetDeveloperPortalNotificationOfPaymentPassword", "Exception", error, errorDetail);
            }
            return protectedfilecontent;
        }

        [WebMethod]
        public string DP_SetNotificationOfPaymentPassword(string id, string filecontent)
        {
            string error = "";
            string protectedfilecontent = "";
            //string output_xml = input_xml;

            try
            {
                /*
                List<k2filestructure> list = new List<k2filestructure>();
                list = DP_GetK2FileNameAndContent(input_xml);

                string filename = "";
                string filecontent = "";

                foreach (var file in list)
                {
                    filename = file.filename;
                    filecontent = file.filecontent;
                }
                */

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_setting_getDU1pdfmasterpassword", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];

                string masterpw = "";

                if (ds.Tables.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            masterpw = dt.Rows[j]["pdfmasterpassword"].ToString();
                        }
                    }
                }
                //conn.Close();

                //start get pdf password for sol                                 
                //conn.Open();
                SqlDataAdapter sqlDA2 = null;
                sqlDA2 = new SqlDataAdapter();
                sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_PDFPasswordSol_getPassword] @arn, @password output", conn);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", id);
                sqlDA2.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 4000);
                sqlDA2.SelectCommand.Parameters["@password"].Direction = ParameterDirection.Output;

                ds = new DataSet("ds");
                sqlDA2.Fill(ds);

                string PDFPassword = sqlDA2.SelectCommand.Parameters["@password"].Value.ToString();

                conn.Close();
                //end get pdf password for sol 

                byte[] byteFileContent = null;
                byte[] outputbyteFileContent = null;

                byteFileContent = Convert.FromBase64String(filecontent);

                Stream stream = new MemoryStream(byteFileContent);
                MemoryStream outputstream = new MemoryStream();

                Aspose.Pdf.License license = new Aspose.Pdf.License();

                license.SetLicense("Aspose.PDF.NET.lic");

                Document doc = new Document(stream);

                doc.Encrypt(PDFPassword, masterpw, 0, CryptoAlgorithm.AESx256);
                doc.Save(outputstream);
                outputbyteFileContent = outputstream.ToArray();
                protectedfilecontent = Convert.ToBase64String(outputbyteFileContent, 0, outputbyteFileContent.Length);

                /*
                XDocument xdoc = XDocument.Parse(output_xml);

                IEnumerable<XElement> xfile = xdoc.Elements("file");

                foreach (XElement node in xfile)
                {
                    XElement content = node.Element("content");
                    content.Value = protectedfilecontent;
                }

                //xdoc.Save(output_xml);

                output_xml = xdoc.ToString();
                */
                //XmlDocument xml = new XmlDocument();
                //xml.LoadXml(output_xml); // suppose that myXmlString contains "<Names>...</Names>"

                //XmlNodeList xnList = xml.SelectNodes("/file");
                //XmlNode node = xml.SelectSingleNode("/file");
                //node.Attributes["content"].Value = protectedfilecontent;

                // var element = xml.Elements("file/content").Single();
                // element.Value = "foo";

            }
            catch (Exception ex)
            {
                error = "DP_SetNotificationOfPaymentPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: arn:" + id + "filecontent:" + filecontent;
                LogErrorToDB("DP_SetNotificationOfPaymentPassword", "Exception", error, errorDetail);
            }
            return protectedfilecontent;
        }

        [WebMethod]
        public string DP_SetNotificationOfPaymentPasswordDeveloper(string id, string filecontent)
        {
            string error = "";
            string protectedfilecontent = "";
            //string output_xml = input_xml;

            try
            {
                /*
                List<k2filestructure> list = new List<k2filestructure>();
                list = DP_GetK2FileNameAndContent(input_xml);

                string filename = "";
                string filecontent = "";

                foreach (var file in list)
                {
                    filename = file.filename;
                    filecontent = file.filecontent;
                }
                */

                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("usp_ws_setting_getDU1pdfmasterpassword", conn);

                ds = new DataSet("ds");
                sqlDA.Fill(ds);
                dt = ds.Tables[0];

                string masterpw = "";

                if (ds.Tables.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            masterpw = dt.Rows[j]["pdfmasterpassword"].ToString();
                        }
                    }
                }
                //conn.Close();

                //start get pdf password for sol                                 
                //conn.Open();
                SqlDataAdapter sqlDA2 = null;
                sqlDA2 = new SqlDataAdapter();
                sqlDA2.SelectCommand = new SqlCommand("dbo.[aa_PDFPasswordDev_getPassword] @arn, @password output", conn);
                sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", id);
                sqlDA2.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 4000);
                sqlDA2.SelectCommand.Parameters["@password"].Direction = ParameterDirection.Output;

                ds = new DataSet("ds");
                sqlDA2.Fill(ds);

                string PDFPassword = sqlDA2.SelectCommand.Parameters["@password"].Value.ToString();

                conn.Close();
                //end get pdf password for sol 

                byte[] byteFileContent = null;
                byte[] outputbyteFileContent = null;

                byteFileContent = Convert.FromBase64String(filecontent);

                Stream stream = new MemoryStream(byteFileContent);
                MemoryStream outputstream = new MemoryStream();

                Aspose.Pdf.License license = new Aspose.Pdf.License();

                license.SetLicense("Aspose.PDF.NET.lic");

                Document doc = new Document(stream);

                doc.Encrypt(PDFPassword, masterpw, 0, CryptoAlgorithm.AESx256);
                doc.Save(outputstream);
                outputbyteFileContent = outputstream.ToArray();
                protectedfilecontent = Convert.ToBase64String(outputbyteFileContent, 0, outputbyteFileContent.Length);

                /*
                XDocument xdoc = XDocument.Parse(output_xml);

                IEnumerable<XElement> xfile = xdoc.Elements("file");

                foreach (XElement node in xfile)
                {
                    XElement content = node.Element("content");
                    content.Value = protectedfilecontent;
                }

                //xdoc.Save(output_xml);

                output_xml = xdoc.ToString();
                */
                //XmlDocument xml = new XmlDocument();
                //xml.LoadXml(output_xml); // suppose that myXmlString contains "<Names>...</Names>"

                //XmlNodeList xnList = xml.SelectNodes("/file");
                //XmlNode node = xml.SelectSingleNode("/file");
                //node.Attributes["content"].Value = protectedfilecontent;

                // var element = xml.Elements("file/content").Single();
                // element.Value = "foo";

            }
            catch (Exception ex)
            {
                error = "DP_SetNotificationOfPaymentPasswordDeveloper failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: arn:" + id + "filecontent:" + filecontent;
                LogErrorToDB("DP_SetNotificationOfPaymentPasswordDeveloper", "Exception", error, errorDetail);
                throw ex;
            }
            return protectedfilecontent;
        }

        [WebMethod]
        public int k2_getworkflowid(string workflowname)
        {
            /*
            //shows how to retrieve the list of workflows that the authenticated user has rights to 
            //you should be familiar with web request authentication and JSON to use this API

            //define the URI and URL for the workflows endpoint
            //URL for the K2 server 
            //string K2ServerURL = "https://dps-jasonang";
           // string worklistTasksEndpointURI = @"/Api/Workflow/V1/tasks/";
            string K2ServerURL = clsGlobal.K2_WEBSERVER_URL;
            //string workflowsEndpointURI = @"/Api/Workflow/V1/tasks/";
            string workflowsEndpointURI = @"/Api/Workflow/V1/workflows";
            string workflowsURL = K2ServerURL + workflowsEndpointURI;

            //set up client and credentials 
            //we use static windows credentials here for brevity, see authentication samples for other auth mechanisms 
            //string userID = "administrator@denallix.com";
            //string pwd = "K2pass!";
            string userID = clsGlobal.K2_ADMIN_USER;
            string pwd = clsGlobal.K2_ADMIN_PWD;
            
            System.Net.WebClient webclient = new System.Net.WebClient();
            webclient.Credentials = new System.Net.NetworkCredential(userID, pwd);
            
            NetworkCredential k2credentials = new NetworkCredential(userID, pwd);
            System.Net.Http.HttpClientHandler loginHandler = new System.Net.Http.HttpClientHandler();
            {
                loginHandler.Credentials = k2credentials;
            };
            
            //System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(loginHandler, true);

            //retrieve the authenticated user's available workflows as JSON      
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            string response = webclient.DownloadString(workflowsURL);

            //process the JSON response using a JSON deserializer. 
            //In this case the built-in .NET DataContractSerializer class (you may want to use JSON.NET instead) 
            //instantiate the DataContract used to parse the returned JSON worklist
            Workflows workflows = new Workflows();

            //Deserialize the response into the tasklist object, using the K2TaskList data contract.
            //see below this code snippet for example of the data contract 
            using (System.IO.MemoryStream memstream = new MemoryStream(Encoding.UTF8.GetBytes(response)))
            {
                System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new DataContractJsonSerializer(workflows.GetType());
                memstream.Position = 0;
                workflows = (Workflows)serializer.ReadObject(memstream);
            }
            int workflowid = 0;

            //do something with the collection of tasks in the retrieved task list
            foreach (Workflow workflow in workflows.K2Workflows)
            {
                
                Console.WriteLine("Workflow ID: " + workflow.Id.ToString());
                Console.WriteLine("Workflow Name: " + workflow.Name);
                Console.WriteLine("Folder: " + workflow.Folder);
                Console.WriteLine("System Name: " + workflow.SystemName);
                Console.WriteLine("**************");
                
                if (workflow.Name == workflowname)
                {
                    workflowid = System.Convert.ToInt32(workflow.Id.ToString());
                }
            }
            */
            int workflowid = 0;
            return workflowid;
        }

        [WebMethod]
        public void k2_startworkflowbyID(int workflowid, string folio)
        {            
            
            string K2ServerURL = clsGlobal.K2_WEBSERVER_URL;
            string workflowsEndpointURI = @"/Api/Workflow/V1/workflows";
            
            string workflowsURL = K2ServerURL + workflowsEndpointURI + "/" + workflowid.ToString();
            
            string userID = clsGlobal.K2_ADMIN_USER;
            string pwd = clsGlobal.K2_ADMIN_PWD;
            System.Net.WebClient webclient = new System.Net.WebClient();
            NetworkCredential k2credentials = new NetworkCredential(userID, pwd);
            //webclient.Credentials = new System.Net.NetworkCredential(userID, pwd);
                        
            string datafieldsToUpdateJSON = "{\"folio\": \""+ folio + "\"}";
            System.Net.Http.StringContent startWFkHttpContent = new System.Net.Http.StringContent(datafieldsToUpdateJSON, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClientHandler loginHandler = new System.Net.Http.HttpClientHandler();
            {
                loginHandler.Credentials = k2credentials;
            };

            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(loginHandler, true);
            var completeResult = httpClient.PostAsync(workflowsURL, startWFkHttpContent).Result;
            //do something with the result, if needed
            string completeResultStatus = completeResult.StatusCode.ToString();
            
        }

        [WebMethod]
        public void k2_startworkflowbyID_WithVariable(int workflowid, string folio, ArrayList VariableName, ArrayList VariableValue)
        {

            string K2ServerURL = clsGlobal.K2_WEBSERVER_URL;
            string workflowsEndpointURI = @"/Api/Workflow/V1/workflows";

            string workflowsURL = K2ServerURL + workflowsEndpointURI + "/" + workflowid.ToString();

            string userID = clsGlobal.K2_ADMIN_USER;
            string pwd = clsGlobal.K2_ADMIN_PWD;
            System.Net.WebClient webclient = new System.Net.WebClient();
            NetworkCredential k2credentials = new NetworkCredential(userID, pwd);
            //webclient.Credentials = new System.Net.NetworkCredential(userID, pwd);

            string datafieldsToUpdateJSON = "{\"folio\": \"" + folio + "\"";

            if (VariableName.Count> 0)
            {
                datafieldsToUpdateJSON = datafieldsToUpdateJSON + ",\"dataFields\": {";
            }
            
            for (int i = 0;i< VariableName.Count;i++)
            {
                datafieldsToUpdateJSON = datafieldsToUpdateJSON + "\"" + VariableName[i] + "\":\"" + VariableValue[i] + "\"";

                if (i!= VariableName.Count -1)
                {
                    datafieldsToUpdateJSON = datafieldsToUpdateJSON + ",";
                }
                else
                {
                    datafieldsToUpdateJSON = datafieldsToUpdateJSON + "}";
                }
            }

            datafieldsToUpdateJSON = datafieldsToUpdateJSON + "}";

            System.Net.Http.StringContent startWFkHttpContent = new System.Net.Http.StringContent(datafieldsToUpdateJSON, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClientHandler loginHandler = new System.Net.Http.HttpClientHandler();
            {
                loginHandler.Credentials = k2credentials;
            };

            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(loginHandler, true);
            var completeResult = httpClient.PostAsync(workflowsURL, startWFkHttpContent).Result;
            //do something with the result, if needed
            string completeResultStatus = completeResult.StatusCode.ToString();

        }
        [WebMethod]
        public string k2_getserialnumberfromfolio(string folio)
        {
            string serialnumber = "";
            
            string K2ServerURL = clsGlobal.K2_WEBSERVER_URL;
            //string workflowsEndpointURI = @"/Api/Workflow/V1/workflows";
            string workflowsEndpointURI = @"/Api/Workflow/V1/tasks/";
            string workflowsURL = K2ServerURL + workflowsEndpointURI;

            string userID = clsGlobal.K2_ADMIN_USER;
            string pwd = clsGlobal.K2_ADMIN_PWD;
            System.Net.WebClient webclient = new System.Net.WebClient();
            NetworkCredential k2credentials = new NetworkCredential(userID, pwd);
            //webclient.Credentials = new System.Net.NetworkCredential(userID, pwd);

            //string datafieldsToUpdateJSON = "{\"folio\": \"testing123\"}";
            //System.Net.Http.StringContent startWFkHttpContent = new System.Net.Http.StringContent(datafieldsToUpdateJSON, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClientHandler loginHandler = new System.Net.Http.HttpClientHandler();
            {
                loginHandler.Credentials = k2credentials;
            };

            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(loginHandler, true);

            string responseBody = httpClient.GetStringAsync(workflowsURL).Result;

            Tasks tasks = new Tasks();

            using (System.IO.MemoryStream memstream = new MemoryStream(Encoding.UTF8.GetBytes(responseBody)))
            {
                System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new DataContractJsonSerializer(tasks.GetType());
                memstream.Position = 0;
                tasks = (Tasks)serializer.ReadObject(memstream);
            }
            
            foreach (K2Task task in tasks.K2Tasks)
            {
                if (task.WorkflowInstanceFolio == folio)
                {
                    serialnumber = task.SerialNumber;                    
                }
                                
            }
            
            return serialnumber;
        }


        [WebMethod]
        public void startworkflow(string workflowname, string folio, ref string serialnumber)
        {
            
            serialnumber = "";
            string error = "";
            try
            {
                int wfid = k2_getworkflowid(workflowname);
                k2_startworkflowbyID(wfid, folio);
                serialnumber = k2_getserialnumberfromfolio(folio);
            }
            catch (Exception ex)
            {
                error = "startworkflow failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + workflowname + "," + folio;
                LogErrorToDB("startworkflow", "Exception", error, errorDetail);
            }
           // return serialnumber;
           
        }

        [WebMethod]
        public void redirecttask(string workflowname, string folio, string newuser)
        {
            string serialnumber = "";
            string error = "";

            
            if (newuser.ToLower().Contains("k2:"))
            {
                newuser = newuser.Replace("K2:", "");
            }

            
            if (newuser.ToLower().Contains("\\"))
            {
                newuser = newuser.Replace("\\", @"\");
            }
            

            String[] strlist = newuser.Split(new string[] { "\\" }, StringSplitOptions.None);

            newuser = strlist[1];
            
            try
            {
                int wfid = k2_getworkflowid(workflowname);
               // k2_startworkflowbyID(wfid, folio);
                serialnumber = k2_getserialnumberfromfolio(folio);
                k2_task_redirect(serialnumber, newuser);
            }
            catch (Exception ex)
            {
                error = "redirecttask failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + workflowname + "," + folio + "," + newuser;
                LogErrorToDB("redirecttask", "Exception", error, errorDetail);
            }
            // return serialnumber;

        }

        [WebMethod]
        public void DisbursementSubmission_RedirectTasktoPreviousDUMakerIfFound(string arn)
        {
            string error = "";
            try
            {
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("aa_ws_SolDisbursementSubmission_GetPreviousDUMaker @arn, @error output", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@arn", arn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@error", "");

                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string newuseremail = dt.Rows[0]["DisbursementMakerEmailAddress"].ToString();

                            string workflowname = "DisMaker_Approval";
                            string folio = "DisMakerDisbursementApproval_" + arn;

                            int wfid = k2_getworkflowid(workflowname);
                            k2_startworkflowbyID(wfid, folio);
                            string serialnumber = k2_getserialnumberfromfolio(folio);
                            redirecttask(workflowname, folio, newuseremail);

                            SqlDataAdapter sqlDA2 = null;
                            sqlDA2 = new SqlDataAdapter();
                            sqlDA2.SelectCommand = new SqlCommand("usp_ws_K2Instance_insert  @K2SerialNumber, @K2Folio, @arn,@Workflow", conn);                            
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@K2SerialNumber", serialnumber);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@K2Folio", folio);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);
                            sqlDA2.SelectCommand.Parameters.AddWithValue("@Workflow", workflowname);

                            ds = new DataSet("ds");
                            sqlDA2.Fill(ds);
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                error = "DisbursementSubmission_RedirectTasktoPreviousDUMakerIfFound failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + arn;
                LogErrorToDB("DisbursementSubmission_RedirectTasktoPreviousDUMakerIfFound", "Exception", error, errorDetail);
            }            
        }

        [WebMethod]
        public void k2_task_redirect(string serialnumber, string newuser)
        {
            /*
            string K2ServerURL = clsGlobal.K2_WEBSERVER_URL;
            string workflowsEndpointURI = @"/Api/Workflow/V1/tasks";

            string workflowsURL = K2ServerURL + workflowsEndpointURI + "/" + serialnumber + "/actions/redirect" ;

            string userID = clsGlobal.K2_ADMIN_USER;
            string pwd = clsGlobal.K2_ADMIN_PWD;
            System.Net.WebClient webclient = new System.Net.WebClient();
            NetworkCredential k2credentials = new NetworkCredential(userID, pwd);
            //webclient.Credentials = new System.Net.NetworkCredential(userID, pwd);

            string datafieldsToUpdateJSON = "{\"RedirectTo\": \"" + newuser + "\"}";
            System.Net.Http.StringContent startWFkHttpContent = new System.Net.Http.StringContent(datafieldsToUpdateJSON, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClientHandler loginHandler = new System.Net.Http.HttpClientHandler();
            {
                loginHandler.Credentials = k2credentials;
            };

            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(loginHandler, true);
            var completeResult = httpClient.PostAsync(workflowsURL, startWFkHttpContent).Result;
            //do something with the result, if needed
            string completeResultStatus = completeResult.StatusCode.ToString();
            */
        }

        [WebMethod]
        public string InternalUserLoginTrial(string UserName, string callback)
        {            
            string error = "";
            string sp_output = "";

            try
            {                
                DataSet ds = null;
                DataTable dt = null;
                SqlConnection conn = null;
                SqlDataAdapter sqlDA = null;

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }
                conn = new SqlConnection(connstr);
                conn.Open();

                //string error = "";

                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.[usp_ws_InternalUserLoginSessionCheck] @UserName, @error output", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                sqlDA.SelectCommand.Parameters.Add("@error", SqlDbType.NVarChar, 4000);
                sqlDA.SelectCommand.Parameters["@error"].Direction = ParameterDirection.Output;
                //sqlDA.SelectCommand.Parameters.AddWithValue("@error", error).Direction = ParameterDirection.Output;
                
                ds = new DataSet("ds");
                sqlDA.Fill(ds);

                sp_output = sqlDA.SelectCommand.Parameters["@error"].Value.ToString();

                StringBuilder sb = new StringBuilder();
                JavaScriptSerializer js = new JavaScriptSerializer();
                sb.Append(callback + "(");
                sb.Append(js.Serialize(sp_output));
                sb.Append(");");

                Context.Response.Clear();
                Context.Response.ContentType = "application/json";
                Context.Response.Write(sb.ToString());
                //Context.Response.End();

                Context.Response.Flush(); // Sends all currently buffered output to the client.
                Context.Response.SuppressContent = true;  // Gets or sets a value indicating whether to send HTTP content to the client.
                Context.ApplicationInstance.CompleteRequest(); // Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.

                /*
                dt = ds.Tables[0];

                string masterpw = "";

                if (ds.Tables.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            masterpw = dt.Rows[j]["pdfmasterpassword"].ToString();
                        }
                    }
                }
                */
                conn.Close();               
            }
            catch (Exception ex)
            {
                error = "InternalUserLoginTrial failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + UserName  ;
                LogErrorToDB("InternalUserLoginTrial", "Exception", error, errorDetail);                
            }
            return sp_output;
        }
        
        public void SendMail_MultipleAttachment(string recipient, string subject, string body, ArrayList attachment, ArrayList AttachmentFileName)
        {
           


            MailMessage msg = new MailMessage();

            //msg.From = new MailAddress("HLBBEIWS-SIT@hlbb.hongleong.com.my");
            msg.From = new MailAddress(MailConst.From);
            //msg.To.Add(new MailAddress("ShaikAlavudeen@hlbb.hongleong.com.my"));
            //20210712 - add support to multiple receiver 

            //msg.To.Add(new MailAddress(recipient));
            // msg.To.Add(recipient);


            int Commafreq = recipient.Split(',').Length - 1;
            int SemiCommafreq = recipient.Split(';').Length - 1;

            if (Commafreq != 0 && SemiCommafreq != 0)
            {
                //throw new Exception("Invalid Email Address Seperator");
                foreach (var address in recipient.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    SemiCommafreq = address.Split(';').Length - 1;
                    if (SemiCommafreq != 0)
                    {
                        foreach (var address2 in address.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            msg.To.Add(new MailAddress(address2));
                        }
                    }
                    else
                    {
                        msg.To.Add(new MailAddress(address));
                    }


                }

            }
            else
            {
                if (Commafreq > 0 && SemiCommafreq == 0)
                {
                    foreach (var address in recipient.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        //msg.To.Add(address);
                        msg.To.Add(new MailAddress(address));
                        //recipient = address;
                        //break;
                    }
                }

                if (Commafreq == 0 && SemiCommafreq > 0)
                {
                    foreach (var address in recipient.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                    {

                        //msg.To.Add(address);
                        msg.To.Add(new MailAddress(address));
                        // recipient = address;
                        // break;
                    }
                }

                if (Commafreq == 0 && SemiCommafreq == 0)
                {
                    msg.To.Add(new MailAddress(recipient));
                    //msg.To.Add(recipient);                    
                }
            }

            //20210712 - end support to multiple receiver

            msg.Subject = subject;
            msg.Body = body;
            msg.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient("hlgmail.hongleong.com.my");
            SmtpClient client = new SmtpClient(MailConst.SmtpServer);
            client.EnableSsl = false;
            //client.Credentials = new System.Net.NetworkCredential("EIWSSIT", "W1gg$168");
            client.Credentials = new System.Net.NetworkCredential(MailConst.Username, MailConst.Password);
            client.Port = 25;
            //client.Port = 587;


            if (attachment != null)
            {
                for (int i = 0;i < attachment.Count;i++)
                {
                    string attachment_item = attachment[i].ToString();

                    byte[] byteFileContent = null;
                    byteFileContent = Convert.FromBase64String(attachment_item);

                    Stream stream = new MemoryStream(byteFileContent);
                    Attachment att = System.Net.Mail.Attachment.CreateAttachmentFromString(attachment_item, AttachmentFileName[i].ToString());

                    System.Net.Mime.ContentType ct = new System.Net.Mime.ContentType(System.Net.Mime.MediaTypeNames.Application.Pdf);
                    // Attach the log file stream to the email message.

                    Attachment data = new Attachment(stream, ct);

                    System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
                    // Suggest a file name for the attachment.
                    disposition.FileName = AttachmentFileName[i].ToString();

                    //msg.Attachments.Add(new Attachment(att.ToString()));
                    msg.Attachments.Add(data);

                    
                }

                
            }

            //client.Send(msg);

            
            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();

                //throw ex;
            }
            

        }


        [WebMethod]
        public void Test_SendMail_MultipleAttachment_Call()
        {


            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
            string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
            string strID2 = clsGlobal.MG_SQL_ID2;
            string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
            bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth)
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }

            string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
            if (blnIsWinAuth2)
            {
                connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
            }

            ArrayList arr_att = new ArrayList();
            ArrayList arr_name = new ArrayList();

            SqlConnection connEDMS_EMAIL = new SqlConnection(connstr);

            SqlConnection connEDMS_EMAIL_2 = new SqlConnection(connstr);
            SqlDataAdapter sqlDEDMS_EMAIL_2;

            int pdfid = 1300;

            sqlDEDMS_EMAIL_2 = new SqlDataAdapter();
            sqlDEDMS_EMAIL_2.SelectCommand = new SqlCommand("dbo.usp_getK2PDFFileContent @id", connEDMS_EMAIL_2);
            sqlDEDMS_EMAIL_2.SelectCommand.Parameters.AddWithValue("id", pdfid);

            DataSet dsAlpha = new DataSet();

            sqlDEDMS_EMAIL_2.Fill(dsAlpha);


            string filename = dsAlpha.Tables[0].Rows[0]["PDFFileName"].ToString();
            string file = dsAlpha.Tables[0].Rows[0]["PDF"].ToString();
            
            
            arr_att.Add(file);
            arr_name.Add(filename);

            // file 2
             pdfid = 1301;

            sqlDEDMS_EMAIL_2 = new SqlDataAdapter();
            sqlDEDMS_EMAIL_2.SelectCommand = new SqlCommand("dbo.usp_getK2PDFFileContent @id", connEDMS_EMAIL_2);
            sqlDEDMS_EMAIL_2.SelectCommand.Parameters.AddWithValue("id", pdfid);

           // DataSet dsAlpha = new DataSet();

            sqlDEDMS_EMAIL_2.Fill(dsAlpha);


             filename = dsAlpha.Tables[0].Rows[0]["PDFFileName"].ToString();
             file = dsAlpha.Tables[0].Rows[0]["PDF"].ToString();


            arr_att.Add(file);
            arr_name.Add(filename);

            SendMail_MultipleAttachment("jasonangot@toshibatec.com.my", "test attachment", "test body", arr_att, arr_name);
        }

        [WebMethod]
        public void OneTime_ExtractAndImportNewLOADSFields()
        {


            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
            string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
            string strID2 = clsGlobal.MG_SQL_ID2;
            string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
            bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth)
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }

            string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
            if (blnIsWinAuth2)
            {
                connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
            }

            // ArrayList arr_att = new ArrayList();
            // ArrayList arr_name = new ArrayList();

           // try {
                SqlConnection conn_LOADSGetCase = new SqlConnection(connstr);
                SqlDataAdapter sqlDA_LOADSGetCase;

                //int pdfid = 1300;

                sqlDA_LOADSGetCase = new SqlDataAdapter();
                sqlDA_LOADSGetCase.SelectCommand = new SqlCommand("dbo.ddProject_LoadDevPortalNewFields_GetCase", conn_LOADSGetCase);
                //sqlDEDMS_EMAIL_2.SelectCommand.Parameters.AddWithValue("id", pdfid);

                DataSet dsGetCase = new DataSet();

                sqlDA_LOADSGetCase.Fill(dsGetCase);

                //sqlDA_LOADSGetCase.Fill(ds);
                DataTable dt_LOADSGetCase = new DataTable();

                dt_LOADSGetCase = dsGetCase.Tables[0];

                string arn = "";

                if (dsGetCase.Tables.Count > 0)
                {
                    if (dt_LOADSGetCase.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt_LOADSGetCase.Rows.Count; j++)
                        {
                            arn = dt_LOADSGetCase.Rows[j]["arn"].ToString();
                            
                            HLBBWS.AppWS ws = new AppWS();
                            List<HLBBWS.AppWS.structureLOADS> list = new List<HLBBWS.AppWS.structureLOADS>();

                            // string DP_GetDataFromLOADS_error = "";
                            
                            list = ws.DP_GetDataFromLOADS(arn);

                            
                             if (list.Count > 0)
                             {


                                if (list[0].respInfo_respCode == "00")
                                {
                                    SqlConnection conn2 = null;
                                    conn2 = new SqlConnection(connstr);

                                    SqlCommand sqlcommand1 = new SqlCommand("dbo.ddProject_LoadDevPortalNewFields @arn  ,	@phaseCode,@phaseName ,@unitParcelNo ,@spaValue,@category ", conn2);

                                    sqlcommand1.Parameters.AddWithValue("@arn", arn);

                                    //dev portal new fields 
                                    
                                    sqlcommand1.Parameters.AddWithValue("@phaseCode", list[0].loanApplicationInfo_phaseCode);
                                    sqlcommand1.Parameters.AddWithValue("@phaseName", list[0].loanApplicationInfo_phaseName);
                                    sqlcommand1.Parameters.AddWithValue("@unitParcelNo", list[0].loanApplicationInfo_unitParcelNo);
                                    sqlcommand1.Parameters.AddWithValue("@spaValue", list[0].loanApplicationInfo_spaValue);
                                    sqlcommand1.Parameters.AddWithValue("@category", list[0].loanApplicationInfo_category);
                                    
                                    
                                    conn2.Open();
                                    int rowsAffected2 = sqlcommand1.ExecuteNonQuery();
                                    conn2.Close();


                                }
                            }
                        }
                    }
                }
                /*
            }
            catch (Exception ex)
            {
                string error = "OneTime_ExtractAndImportNewLOADSFields failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("OneTime_ExtractAndImportNewLOADSFields", "Exception", error, errorDetail);
            }
            */
            
            //string filename = dsAlpha.Tables[0].Rows[0]["PDFFileName"].ToString();
            //string file = dsAlpha.Tables[0].Rows[0]["PDF"].ToString();


            //arr_att.Add(file);
            //arr_name.Add(filename);

            // file 2
            /*
            pdfid = 1301;

            sqlDEDMS_EMAIL_2 = new SqlDataAdapter();
            sqlDEDMS_EMAIL_2.SelectCommand = new SqlCommand("dbo.usp_getK2PDFFileContent @id", connEDMS_EMAIL_2);
            sqlDEDMS_EMAIL_2.SelectCommand.Parameters.AddWithValue("id", pdfid);

            // DataSet dsAlpha = new DataSet();

            sqlDEDMS_EMAIL_2.Fill(dsAlpha);


            filename = dsAlpha.Tables[0].Rows[0]["PDFFileName"].ToString();
            file = dsAlpha.Tables[0].Rows[0]["PDF"].ToString();


            arr_att.Add(file);
            arr_name.Add(filename);

            Test_SendMail_MultipleAttachment("jasonangot@toshibatec.com.my", "test attachment", "test body", arr_att, arr_name);
            */
        }
    }
}
