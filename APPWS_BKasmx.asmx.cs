using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
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
using System.Runtime.Serialization.Json;
using System.Diagnostics;
using System.Web.Script.Serialization;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net.Security;

namespace HLBBWS
{
    /// <summary>
    /// Summary description for APPWS_BKasmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class APPWS_BKasmx : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


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

        [WebMethod]
        public void tbd_SePDFPassword()
        {
            string error = "";
            //string output_xml = input_xml;

            try
            {
                /*
                List<k2filestructure> list = new List<k2filestructure>();
                //list = DP_GetK2FileNameAndContent(input_xml);

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
                sqlDA.SelectCommand = new SqlCommand("tbd_getk2pdffile", conn);

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
                            string pdf = dt.Rows[j]["pdf"].ToString();
                            string output_xml = pdf;

                            //string output_xml = input_xml;

                            List<k2filestructure> list = new List<k2filestructure>();

                            AppWS appws = new AppWS();
                            
                            //list DP_GetK2FileNameAndContent(pdf);

                            string filename = "";
                            string filecontent = "";

                            foreach (var file in list)
                            {
                                filename = file.filename;
                                filecontent = file.filecontent;

                                string PDFPassword = "fuda";

                                //conn.Close();
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

                                SqlDataAdapter sqlDA2 = null;
                                sqlDA2 = new SqlDataAdapter();
                                sqlDA2.SelectCommand = new SqlCommand("dbo.[tbd_updatek2pdffile] @pdf", conn);
                                sqlDA2.SelectCommand.Parameters.AddWithValue("@pdf", output_xml);
                                //sqlDA2.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 4000);
                                //sqlDA2.SelectCommand.Parameters["@password"].Direction = ParameterDirection.Output;

                                ds = new DataSet("ds");
                                sqlDA2.Fill(ds);
                            }

                        }
                    }
                }
                //conn.Close();
                /*
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
                */
                /*
                string PDFPassword = "fuda";

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
                */
            }
            catch (Exception ex)
            {
                //error = "DP_SetDULetterPassword failed with exception: " + ex.Message.ToString();
                string errorDetail;
                //errorDetail = "Input Param: " + input_xml;
                //LogErrorToDB("DP_SetDULetterPassword", "Exception", error, errorDetail);
            }
            // return output_xml;
        }

        public struct k2filestructure
        {
            public string filename;
            public string filecontent;
        }

        [WebMethod]
        public void POC_SendEmail(string recipient, string subject, string body, string xml)
        {
            try
            {
                List<k2filestructure> list = new List<k2filestructure>();

                //list = DP_GetK2FileNameAndContent(xml);

                string filename = "";
                string filecontent = "";

                foreach (var file in list)
                {
                    filename = file.filename;
                    filecontent = file.filecontent;

                  //  SendMail(recipient, subject, body, filecontent, filename);

                }
            }
            catch (Exception ex)
            {
                string error;
                error = "POC_SendEmail failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                //LogErrorToDB("POC_SendEmail", "Exception", error, errorDetail);
            }

        }

    }
}
