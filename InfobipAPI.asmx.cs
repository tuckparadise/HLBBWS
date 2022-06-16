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
using System.Threading;
using System.ServiceModel;
using RestSharp;
using System.Configuration;
using System.Web.Script.Services;
using RestSharp.Serialization.Json;
//using HttpServletRequest;


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
    public class InfobipAPI : System.Web.Services.WebService
    {

        public string FormatEmailAddressDelimiter(string list)
        {
            string newlist = "";

            newlist = list.Replace(";", ",");

            return newlist;
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class InfobipInitialResponse_Status
        {
            public int groupId { get; set; } = 0;
            public string groupName { get; set; } = "";
            public int id { get; set; } = 0;
            public string name { get; set; } = "";
            public string description { get; set; } = "";
        }

        public class InfobipInitialResponse_Message
        {
            public string to { get; set; } = "";
            public int messageCount { get; set; } = 0;
            public string messageId { get; set; } = "";
            public InfobipInitialResponse_Status status { get; set; }
        }

        public class InfobipInitialResponse
        {
            public List<InfobipInitialResponse_Message> messages { get; set; }
        }

        public void Infobip_SendEmail(Int64 runningid, ref string error)
        {
            // start get email detail            

            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

            /*
            var Environment = Configuration["EnvironmentX"];
            var blnIsWinAuth = Configuration[Environment + ":MG_SQL_Auth_Mode"];
            var strDataSource = Configuration[Environment + ":MG_SQL_Server"];
            var strDBName = Configuration[Environment + ":MG_SQL_Database"];
            var strID = Configuration[Environment + ":MG_SQL_ID"];
            var strPassword = Configuration[Environment + ":MG_SQL_Pwd"];
            */

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth )
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }

            SqlConnection conn = new SqlConnection(connstr);

            SqlDataAdapter sqlDA;
            sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_GetRecord @runningid", conn);
            sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);

            DataSet ds = new DataSet();

            sqlDA.Fill(ds);

            string Header = ds.Tables[0].Rows[0]["Header"].ToString();
            string Body = ds.Tables[0].Rows[0]["Body"].ToString();
            string Receiver = ds.Tables[0].Rows[0]["Receiver"].ToString();
            int AttachmentCount = System.Convert.ToInt32(ds.Tables[0].Rows[0]["AttachmentCount"].ToString());
            string InfobipFlag = ds.Tables[0].Rows[0]["InfobipFlag"].ToString();
            //string Status = ds.Tables[0].Rows[0]["Status"].ToString();

            ArrayList arrfilepath = new ArrayList();
            ArrayList arrfilename = new ArrayList();
            ArrayList arrfiletype = new ArrayList();
            //ArrayList arrReceiver = new ArrayList();

            string[] arrReceiver = Receiver.Split(',');
          
            
            // end get email detail

            // start get attachment detail if exists 
            if ((int)AttachmentCount > 0)
            {
                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_AttachmentMapping_GetRecord @runningid", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);

                ds = new DataSet();

                sqlDA.Fill(ds);

                //ArrayList arrfilename = new ArrayList();
                //ArrayList arrcontent = new ArrayList();


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                    string Base64FileContent = ds.Tables[0].Rows[0]["Base64FileContent"].ToString();

                    string[] arrstr = FileName.Split('.');

                    string subfilename = arrstr[0];
                    string subfiletype = arrstr[1];
                    // arrfilename.Add(FileName);
                    // arrcontent.Add(Base64FileContent);

                    // start generate attachment file if applicable 

                    long long_datetime = long.Parse(System.DateTime.Now.ToString("yyyyMMddHHmmssff"));
                    //System.Web.HttpContext.Current
                    
                    string savefilepath = HttpContext.Current.Server.MapPath("~/");
                    // string savefilepath = GetCurrentDirectory();
                    // string savefilepath = Directory.GetCurrentDirectory();
                    // string savefilepath = System.Web.HttpContext.Current.Server.MapPath("~/");
                    savefilepath += "\\files\\";

                   string newfilename = long_datetime.ToString() + "." + subfiletype;

                    byte[] byteFileContent = Convert.FromBase64String(Base64FileContent);

                    System.IO.File.WriteAllBytes(savefilepath + newfilename, byteFileContent);

                    arrfilepath.Add(savefilepath + newfilename);
                    arrfilename.Add(newfilename);
                    arrfiletype.Add(subfiletype);
                    // end generate attachment file if applicable 
                }




            }

            // end get attachment detail if exists 


            string infobip_base64credentials = ConfigurationManager.AppSettings["infobip_base64credentials"].ToString();
            string infobip_url_send = ConfigurationManager.AppSettings["infobip_url_send"].ToString();
            string infobip_user = ConfigurationManager.AppSettings["infobip_user"].ToString();
            string infobip_proxyserver = ConfigurationManager.AppSettings["infobip_proxyserver"].ToString();
            Int32 infobip_proxyport = System.Convert.ToInt32(ConfigurationManager.AppSettings["infobip_proxyport"].ToString());
            bool BypassProxyOnLocal = System.Convert.ToBoolean(ConfigurationManager.AppSettings["BypassProxyOnLocal"].ToString());
           

            if (BypassProxyOnLocal )
            {
                // start call infobip api            
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                System.Net.ServicePointManager.Expect100Continue = true;
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            }


           //System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
           //System.Net.ServicePointManager.Expect100Continue = true;
           //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // System.Uri  infobip_proxyserver = new System.Uri(ConfigurationManager.AppSettings["infobip_proxyserver"]);


            /*
            var infobip_base64credentials = Configuration[Environment + ":infobip_base64credentials"];
            var infobip_url = Configuration[Environment + ":infobip_url_send"];
            var infobip_user = Configuration[Environment + ":infobip_user"];           
            */
            // restClient.Proxy = new WebProxy(myProxyUrl, myProxyHost);



            var client = new RestClient(infobip_url_send);

            //System.Diagnostics.Debug.WriteLine("setting up proxy");
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('setting up proxy');", true);
            //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"JavaScript\">alert(\"setting up proxy\")</SCRIPT>");

            if (!BypassProxyOnLocal)
            {
                client.ConfigureWebRequest(wr => wr.Proxy = new WebProxy(infobip_proxyserver, infobip_proxyport) { BypassProxyOnLocal = false });
            }

            


            //WebProxy pr = new WebProxy(infobip_proxyserver, 20);
            //WebProxy myproxy = new WebProxy(infobip_proxyserver, infobip_proxyport);

            //client.ConfigureWebRequest(wr => wr.Proxy = new WebProxy(infobip_proxyserver,9999) );

            // var client = new RestClient(infobip_url_send) { Proxy = _webProxy }; ;
            // var client.ConfigureWebRequest(wr => wr.Proxy = new WebProxy("127.0.0.1", 8888) { BypassProxyOnLocal = false });

            client.Timeout = -1;

            var request = new RestRequest();
            request.Method = Method.POST;
            
            request.AddHeader("Authorization", "Basic " + infobip_base64credentials);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("from", infobip_user);
            request.AddParameter("subject", Header);
            //request.AddParameter("to", Receiver);

            for (int i = 0; i < arrReceiver.Length; i++)
            {
                if (arrReceiver[i] !="")
                {
                    request.AddParameter("to", arrReceiver[i]);
                }
            }

            request.AddParameter("HTML", Body);
           
            if (AttachmentCount > 0)
            {
                for (int i = 0; i < arrfilepath.Count; i++)
                {
                    request.AddFile("attachment", System.IO.File.ReadAllBytes(arrfilepath[i].ToString()), arrfilename[i].ToString() + "." + arrfiletype[i].ToString());
                }
            }

           // System.Diagnostics.Debug.WriteLine("calling API");
           // System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"JavaScript\">alert(\"calling API\")</SCRIPT>");
            IRestResponse response = client.Execute(request);
            
            string IsSuccessful = response.IsSuccessful.ToString();

            //string StatusCode = "";

            //if (response.StatusCode != null)
            //{
            //    StatusCode = response.StatusCode.ToString()
            //}

            string StatusDescription = response.StatusDescription?.ToString() ?? ""; 

            //if (response.StatusDescription != null)
            //{
            //    StatusDescription = response.StatusDescription.ToString();
            //}

            string ErrorMessage = response.ErrorMessage?.ToString() ?? "";

            //if (response.ErrorMessage != null )
            //{
            //    ErrorMessage = response.ErrorMessage?.ToString() ?? "";
            //}


            //System.Diagnostics.Debug.WriteLine("checking response");
            //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"JavaScript\">alert(\"checking response\")</SCRIPT>");
            if (IsSuccessful == "True")
            {
                InfobipInitialResponse obj = System.Text.Json.JsonSerializer.Deserialize<InfobipInitialResponse>(response.Content.ToString());

                InfobipInitialResponse_Message msg = (InfobipInitialResponse_Message)obj.messages[0];
                string messageId = msg.messageId;

                InfobipInitialResponse_Status sts = (InfobipInitialResponse_Status)obj.messages[0].status;

                string StatusGroupID = sts.groupId.ToString();
                string StatusGroupName = sts.groupName.ToString();
                /*
                ALTER procedure[dbo].[usp_EmailLogV2_UpdateStatus]
                @runningid bigint = null,
                @MessageID nvarchar(max) = null,
                @StatusGroupID nvarchar(max) = null,
                @StatusGroupName nvarchar(max) = null,
                @Logs nvarchar(max) = null
                */

                // start update email status 


                sqlDA = new SqlDataAdapter();

                sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_UpdateStatus @runningid, @MessageID, @StatusGroupID, @StatusGroupName,@Logs", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);
                sqlDA.SelectCommand.Parameters.AddWithValue("@MessageID", messageId);
                sqlDA.SelectCommand.Parameters.AddWithValue("@StatusGroupID", StatusGroupID);
                sqlDA.SelectCommand.Parameters.AddWithValue("@StatusGroupName", StatusGroupName);
                sqlDA.SelectCommand.Parameters.AddWithValue("@Logs", response.Content.ToString());

                ds = new DataSet();

                sqlDA.Fill(ds);
                // end update email status 

                // start gelete physical file 
                if (AttachmentCount > 0)
                {
                    for (int i = 0; i < arrfilepath.Count; i++)
                    {
                        System.IO.File.Delete(arrfilepath[i].ToString());
                    }
                }

                // end delete physical file 
            }
            else
            {
                //throw Exception (StatusDescription.ToString());
                throw new Exception("ErrorMessage:" + ErrorMessage.ToString() +",StatusDescription:" + StatusDescription.ToString());
            }
           


        }

        public void LogErrorToDB(string APIName, string errorType, string errorMessage, string errorDetail)
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

            /*
            var Environment = Configuration["EnvironmentX"];
            var blnIsWinAuth = Configuration[Environment + ":MG_SQL_Auth_Mode"];
            var strDataSource = Configuration[Environment + ":MG_SQL_Server"];
            var strDBName = Configuration[Environment + ":MG_SQL_Database"];
            var strID = Configuration[Environment + ":MG_SQL_ID"];
            var strPassword = Configuration[Environment + ":MG_SQL_Pwd"];
            */
            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth )
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


        public void Internal_SendEmail(Int64 runningid, ref string error)
        {
            // start get email detail            

            string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
            string strDBName = clsGlobal.MG_SQL_DB_NAME;
            string strID = clsGlobal.MG_SQL_ID;
            string strPassword = clsGlobal.MG_SQL_PASSWORD;
            bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;
            /*
            var Environment = Configuration["EnvironmentX"];
            var blnIsWinAuth = Configuration[Environment + ":MG_SQL_Auth_Mode"];
            var strDataSource = Configuration[Environment + ":MG_SQL_Server"];
            var strDBName = Configuration[Environment + ":MG_SQL_Database"];
            var strID = Configuration[Environment + ":MG_SQL_ID"];
            var strPassword = Configuration[Environment + ":MG_SQL_Pwd"];
            */

            string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
            if (blnIsWinAuth )
            {
                connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
            }

            SqlConnection conn = new SqlConnection(connstr);

            SqlDataAdapter sqlDA;
            sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_GetRecord @runningid", conn);
            sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);

            DataSet ds = new DataSet();

            sqlDA.Fill(ds);

            string Header = ds.Tables[0].Rows[0]["Header"].ToString();
            string Body = ds.Tables[0].Rows[0]["Body"].ToString();
            string Receiver = ds.Tables[0].Rows[0]["Receiver"].ToString();
            int AttachmentCount = System.Convert.ToInt32(ds.Tables[0].Rows[0]["AttachmentCount"].ToString());
            string InfobipFlag = ds.Tables[0].Rows[0]["InfobipFlag"].ToString();
            //string Status = ds.Tables[0].Rows[0]["Status"].ToString();

            ArrayList arrfilepath = new ArrayList();
            ArrayList arrfilename = new ArrayList();
            ArrayList arrfiletype = new ArrayList();

            // end get email detail
            MailMessage msg = new MailMessage();

            //var FromEmail = Configuration[Environment + ":internalmail_FromEmail"];
            string FromEmail = ConfigurationManager.AppSettings["FromEmail"].ToString();
            string SmtpServer = ConfigurationManager.AppSettings["SmtpServer"].ToString();
            string encryptedMailPassword = ConfigurationManager.AppSettings["encryptedMailPassword"].ToString();
            string MailUsername = ConfigurationManager.AppSettings["MailUsername"].ToString();
            string MailPortNumber = ConfigurationManager.AppSettings["MailPortNumber"].ToString();

            msg.From = new MailAddress(FromEmail);
            msg.To.Add(Receiver);

            // start get attachment detail if exists 
            if ((int)AttachmentCount > 0)
            {
                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_AttachmentMapping_GetRecord @runningid", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);

                ds = new DataSet();

                sqlDA.Fill(ds);

                //ArrayList arrfilename = new ArrayList();
                //ArrayList arrcontent = new ArrayList();



                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    long long_datetime = long.Parse(System.DateTime.Now.ToString("yyyyMMddHHmmssff"));

                    string FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                    string Base64FileContent = ds.Tables[0].Rows[0]["Base64FileContent"].ToString();

                    string[] arrstr = FileName.Split('.');

                    string subfilename = arrstr[0];
                    string subfiletype = arrstr[1];
                    // arrfilename.Add(FileName);
                    // arrcontent.Add(Base64FileContent);

                    //if (attachment != null)
                    //{
                    byte[] byteFileContent = null;
                    byteFileContent = Convert.FromBase64String(Base64FileContent);

                    Stream stream = new MemoryStream(byteFileContent);
                    // Attachment att = System.Net.Mail.Attachment.CreateAttachmentFromString(attachment, AttachmentFileName);

                    System.Net.Mime.ContentType ct = new System.Net.Mime.ContentType(System.Net.Mime.MediaTypeNames.Application.Pdf);
                    // Attach the log file stream to the email message.

                    Attachment data = new Attachment(stream, ct);

                    System.Net.Mime.ContentDisposition disposition = data.ContentDisposition;
                    // Suggest a file name for the attachment.
                    disposition.FileName = long_datetime + "." + subfiletype;

                    //msg.Attachments.Add(new Attachment(att.ToString()));
                    msg.Attachments.Add(data);

                    //}
                }

                msg.Subject = Header;
                msg.Body = Body;
                msg.IsBodyHtml = true;
                //SmtpClient client = new SmtpClient("hlgmail.hongleong.com.my");

                /*
                var SmtpServer = Configuration[Environment + ":internalmail_SmtpServer"];
                var encryptedMailPassword = Configuration[Environment + ":internalmail_Password"];
                var MailUsername = Configuration[Environment + ":internalmail_Username"];
                int MailPortNumber = System.Convert.ToInt32(Configuration[Environment + ":internalmail_port"]);
                */


                SmtpClient client = new SmtpClient(SmtpServer);
                //client.EnableSsl = false;
                client.EnableSsl = true;
                //client.Credentials = new System.Net.NetworkCredential("EIWSSIT", "W1gg$168");
                Global g = new Global();
                
                string result1 = g.DecryptTextFromTTMSWindowsEncryptionTool(encryptedMailPassword);
                string MailPassword = result1.Trim();

                client.Credentials = new System.Net.NetworkCredential(MailUsername, MailPassword);
                client.Port = System.Convert.ToInt32(MailPortNumber);
                //client.Port = 587;

                client.Send(msg);
            }


            // start update email status 


            sqlDA = new SqlDataAdapter();

            sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_UpdateStatus @runningid, @MessageID, @StatusGroupID, @StatusGroupName,@Logs", conn);
            sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);
            sqlDA.SelectCommand.Parameters.AddWithValue("@MessageID", runningid);
            sqlDA.SelectCommand.Parameters.AddWithValue("@StatusGroupID", 1);
            sqlDA.SelectCommand.Parameters.AddWithValue("@StatusGroupName", "Sent");
            sqlDA.SelectCommand.Parameters.AddWithValue("@Logs", "");

            ds = new DataSet();

            sqlDA.Fill(ds);
            // end update email status             

            // start Set Result Obtained Flag 


            sqlDA = new SqlDataAdapter();

            sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_SetResultObtainedFlag @runningid", conn);
            sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);

            ds = new DataSet();

            sqlDA.Fill(ds);
            // end  Set Result Obtained Flag       

        }

        //public struct Infobip_SendEmail_Main_Param
        //{
        //    public string WF { get; set; }
        //    public string UniqueKey { get; set; }
        //    public string UniqueKeyValue { get; set; }
        //    public string header { get; set; }
        //    public string body { get; set; }
        //    public string receiver { get; set; }
        //    public int attachmentcount { get; set; }
        //    public int InfobipFlag { get; set; }
        //    public string CommaDelimeteredAttFileName { get; set; }
        //    public string CommaDelimeteredAttFileContent { get; set; }
        //}

        //public class WEbHookEmailReport_PriceClass
        //{
        //    public string currency { get; set; }

        //    public double pricePerMessage { get; set; }
        //}

        //public class WEbHookEmailReport_StatusClass
        //{
        //    public string groupName { get; set; }
        //    public int id { get; set; }
        //    public int groupId { get; set; }
        //    public string name { get; set; }
        //    public string action { get; set; }
        //    public string description { get; set; }

        //}

        //public class WEbHookEmailReport_ErrorClass
        //{
        //    public string description { get; set; }
        //    public bool permanent { get; set; }
        //    public string name { get; set; }
        //    public int id { get; set; }
        //    public string groupName { get; set; }
        //    public int groupId { get; set; }

        //}

        //public class WEbHookEmailReport_Results
        //{
        //    public string bulkId { get; set; }

        //    public string messageId { get; set; }
        //    public string to { get; set; }
        //    public string sentAt { get; set; }
        //    public string doneAt { get; set; }
        //    public int smsCount { get; set; }
        //    public string callbackData { get; set; }
        //    public WEbHookEmailReport_PriceClass price { get; set; }
        //    public WEbHookEmailReport_StatusClass status { get; set; }
        //    public WEbHookEmailReport_ErrorClass error { get; set; }
        //    public string browserLink { get; set; }
        //}

        //public class WEbHookEmailReport
        //{
        //    WEbHookEmailReport_Results results { get; set; }
        //}

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Price
        {
            public double pricePerMessage { get; set; } = 0;
            public string currency { get; set; } = "";
        }

        public class Status
        {
            public int groupId { get; set; } = 0;
            public string groupName { get; set; } = "";
            public int id { get; set; } = 0;
            public string name { get; set; } = "";
            public string description { get; set; } = "";
        }

        public class Error
        {
            public int groupId { get; set; } = 0;
            public string groupName { get; set; } = "";
            public int id { get; set; } = 0;
            public string name { get; set; } = "";
            public string description { get; set; } = "";
            public bool permanent { get; set; } = false;
        }

        public class Result
        {
            public string messageId { get; set; } = "";
            public string to { get; set; 
            } = "";
            public string sentAt { get; set; } = "";
            public string doneAt { get; set; } = "";
            public int messageCount { get; set; } = 0;
            public Price price { get; set; }
            public Status status { get; set; }
            public Error error { get; set; }
            public string channel { get; set; } = "";
            public string callbackData { get; set; } = "";
        }

        public class WEbHookEmailReport
        {
            public List<Result> results { get; set; }
        }
        
        public string Infobip_SendEmail_Main(AppWS.Infobip_SendEmail_Main_Param param)
        {
            string output = "";
            try
            {

                //ControllerExtension ce = new ControllerExtension(Configuration);


                string receiver = FormatEmailAddressDelimiter(param.receiver);

                // start saving email log 


                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;
                /*
                var Environment = Configuration["EnvironmentX"];
                var blnIsWinAuth = Configuration[Environment + ":MG_SQL_Auth_Mode"];
                var strDataSource = Configuration[Environment + ":MG_SQL_Server"];
                var strDBName = Configuration[Environment + ":MG_SQL_Database"];
                var strID = Configuration[Environment + ":MG_SQL_ID"];
                var strPassword = Configuration[Environment + ":MG_SQL_Pwd"];
                */

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth )
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                //ArrayList arr_att = new ArrayList();
                //ArrayList arr_name = new ArrayList();

                /*
                 create or alter procedure dbo.usp_EmailLogV2_SaveLog
                   @WF nvarchar(max) = null, 
                    @UniqueKey nvarchar(max) = null, 
                    @UniqueKeyValue nvarchar(max) = null, 
                    @header nvarchar(max) = null, 
                    @body nvarchar(max) = null, 
                    @receiver nvarchar(max) = null, 
                    @attachmentcount int = null, 
                    @InfobipFlag int = null, 
                    @runningid bigint = null output
                */

                SqlConnection conn = new SqlConnection(connstr);

                SqlDataAdapter sqlDA;
                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_SaveLog @WF,@UniqueKey, @UniqueKeyValue, @header, @body, @receiver, @attachmentcount,@InfobipFlag, @runningid output ", conn);
                sqlDA.SelectCommand.Parameters.AddWithValue("@WF", param.WF);
                sqlDA.SelectCommand.Parameters.AddWithValue("@UniqueKey", param.UniqueKey);
                sqlDA.SelectCommand.Parameters.AddWithValue("@UniqueKeyValue", param.UniqueKeyValue);
                sqlDA.SelectCommand.Parameters.AddWithValue("@header", param.header);
                sqlDA.SelectCommand.Parameters.AddWithValue("@body", param.body);
                sqlDA.SelectCommand.Parameters.AddWithValue("@receiver", receiver);
                sqlDA.SelectCommand.Parameters.AddWithValue("@attachmentcount", param.attachmentcount);
                sqlDA.SelectCommand.Parameters.AddWithValue("@InfobipFlag", param.InfobipFlag);

                sqlDA.SelectCommand.Parameters.Add("@runningid", SqlDbType.BigInt);
                sqlDA.SelectCommand.Parameters["@runningid"].Direction = ParameterDirection.Output;

                DataSet ds = new DataSet();

                sqlDA.Fill(ds);

                Int64 runningid = System.Convert.ToInt64(sqlDA.SelectCommand.Parameters["@runningid"].Value.ToString());


                // end saving email log 

                // start save attachment if applicable 

                if (param.attachmentcount > 0)
                {

                    string[] arrfilename = param.CommaDelimeteredAttFileName.Split(',');
                    string[] arrfilecontent = param.CommaDelimeteredAttFileContent.Split(',');

                    for (int i = 0; i < arrfilename.Length; i++)
                    {
                        /*
                         create or alter procedure dbo.usp_EmailLogV2_AttachmentMapping_SaveLog
                        @runningid bigint = null ,
                        @filename nvarchar(max) = null, 
                        @Base64FileContent nvarchar(max) = null 
                         */
                        sqlDA = new SqlDataAdapter();
                        sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_AttachmentMapping_SaveLog  @runningid , @filename, @Base64FileContent ", conn);
                        sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);
                        sqlDA.SelectCommand.Parameters.AddWithValue("@filename", arrfilename[i]);
                        sqlDA.SelectCommand.Parameters.AddWithValue("@Base64FileContent", arrfilecontent[i]);

                        ds = new DataSet();

                        sqlDA.Fill(ds);
                    }
                    //string subfilename = arrstr[0];
                    //string subfiletype = arrstr[1];



                }


                // end save attachment if applicable 

                string error = "";
                // start call send mail function 
                if (param.InfobipFlag == 1)
                {
                    //ControllerExtension ce = new ControllerExtension();

                    Infobip_SendEmail(runningid, ref error);
                }
                else
                {
                    Internal_SendEmail(runningid, ref error);
                }

                // end call send mail function
            }
            catch (Exception ex)
            {
                //ControllerExtension ce = new ControllerExtension(Configuration);
                string log = Newtonsoft.Json.JsonConvert.SerializeObject(param);

                string error = "Infobip_SendEmail_Main failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: " + log;
                LogErrorToDB("Infobip_SendEmail_Main", "Exception", error, errorDetail);
            }


            return output;
        }
               
        public void Scheduller_Infobip_GetDeliveryReportData()
        {
            try
            {
                // start Get Check Result List

                string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
                string strDBName = clsGlobal.MG_SQL_DB_NAME;
                string strID = clsGlobal.MG_SQL_ID;
                string strPassword = clsGlobal.MG_SQL_PASSWORD;
                bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

                /*
                var Environment = Configuration["EnvironmentX"];
                var blnIsWinAuth = Configuration[Environment + ":MG_SQL_Auth_Mode"];
                var strDataSource = Configuration[Environment + ":MG_SQL_Server"];
                var strDBName = Configuration[Environment + ":MG_SQL_Database"];
                var strID = Configuration[Environment + ":MG_SQL_ID"];
                var strPassword = Configuration[Environment + ":MG_SQL_Pwd"];
                */

                string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
                if (blnIsWinAuth)
                {
                    connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
                }

                SqlConnection conn = new SqlConnection(connstr);

                SqlDataAdapter sqlDA = new SqlDataAdapter();

                //JsonSerializer.Serialize(rpt, WEbHookEmailReport, null);
                sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_GetCheckResultList", conn);

                DataSet ds = new DataSet();

                sqlDA.Fill(ds);

                //DataTable  dt = new DataTable();

                 //dt = ds.Tables[0];

                //if (ds.Tables.Count >0)
                // {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string messageid = ds.Tables[0].Rows[i]["MessageID"].ToString();
                        string runningid = ds.Tables[0].Rows[i]["EmailLogV2RunningID"].ToString();

                        string infobip_base64credentials = ConfigurationManager.AppSettings["infobip_base64credentials"].ToString();
                        string infobip_url = ConfigurationManager.AppSettings["infobip_url_getreport"].ToString();
                        string infobip_user = ConfigurationManager.AppSettings["infobip_user"].ToString();
                        string infobip_proxyserver = ConfigurationManager.AppSettings["infobip_proxyserver"].ToString();
                        Int32 infobip_proxyport = System.Convert.ToInt32(ConfigurationManager.AppSettings["infobip_proxyport"].ToString());
                        bool BypassProxyOnLocal = System.Convert.ToBoolean(ConfigurationManager.AppSettings["BypassProxyOnLocal"].ToString());

                        if (BypassProxyOnLocal)
                        {
                            // start call infobip api
                            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                            System.Net.ServicePointManager.Expect100Continue = true;
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                        }

                        //System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                        //System.Net.ServicePointManager.Expect100Continue = true;
                        //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                        //var Environment = Configuration["EnvironmentX"];



                        /*
                        var infobip_base64credentials = Configuration[Environment + ":infobip_base64credentials"];
                        var infobip_url = Configuration[Environment + ":infobip_url_getreport"];
                        var infobip_user = Configuration[Environment + ":infobip_user"];
                        */

                        var client = new RestClient(infobip_url);

                        if (!BypassProxyOnLocal)
                        {
                            client.ConfigureWebRequest(wr => wr.Proxy = new WebProxy(infobip_proxyserver, infobip_proxyport) { BypassProxyOnLocal = false });
                        }

                        client.Timeout = -1;

                        var request = new RestRequest();
                        request.Method = Method.GET;

                        request.AddHeader("Authorization", "Basic " + infobip_base64credentials);
                        request.AlwaysMultipartFormData = true;
                        request.AddParameter("bulkId", "");
                        request.AddParameter("messageId", messageid);
                        request.AddParameter("limit", 1);

                        IRestResponse response = client.Execute(request);

                        string IsSuccessful = response.IsSuccessful.ToString();

                        string StatusDescription = response.StatusDescription?.ToString() ?? "";

                        string ErrorMessage = response.ErrorMessage?.ToString() ?? "";

                        if (IsSuccessful == "True")
                        {
                            string status = response.Content.ToString();

                            InfobipAPI.WEbHookEmailReport report = System.Text.Json.JsonSerializer.Deserialize<InfobipAPI.WEbHookEmailReport>(status);

                            if (report.results.Count != 0)
                            {
                                InfobipAPI.Result rst = (InfobipAPI.Result)report.results[0];
                                string messageId = rst.messageId;
                                //string RunningId = rst.callbackData;

                                InfobipAPI.Status sts = (InfobipAPI.Status)report.results[0].status;

                                string StatusGroupID = sts.groupId.ToString();
                                string StatusGroupName = sts.groupName.ToString();

                                // start update email status 

                                if (StatusGroupID != "1")
                                {
                                    conn = new SqlConnection(connstr);

                                    sqlDA = new SqlDataAdapter();
                                    string log = Newtonsoft.Json.JsonConvert.SerializeObject(report);
                                    //JsonSerializer.Serialize(rpt, WEbHookEmailReport, null);
                                    sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_UpdateStatus @runningid, @MessageID, @StatusGroupID, @StatusGroupName,@Logs", conn);
                                    sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);
                                    sqlDA.SelectCommand.Parameters.AddWithValue("@MessageID", messageId);
                                    sqlDA.SelectCommand.Parameters.AddWithValue("@StatusGroupID", StatusGroupID);
                                    sqlDA.SelectCommand.Parameters.AddWithValue("@StatusGroupName", StatusGroupName);
                                    sqlDA.SelectCommand.Parameters.AddWithValue("@Logs", log);

                                DataSet ds1 = new DataSet();

                                    sqlDA.Fill(ds1);
                                    // end update email status 

                                    // start Set Result Obtained Flag 
                                    sqlDA = new SqlDataAdapter();

                                    sqlDA.SelectCommand = new SqlCommand("dbo.usp_EmailLogV2_SetResultObtainedFlag @runningid", conn);
                                    sqlDA.SelectCommand.Parameters.AddWithValue("@runningid", runningid);

                                DataSet ds2 = new DataSet();

                                    sqlDA.Fill(ds2);
                                    // end  Set Result Obtained Flag  
                                }
                            }
                        }
                        else
                        {
                            //throw Exception (StatusDescription.ToString());
                            throw new Exception("ErrorMessage:" + ErrorMessage.ToString() + ",StatusDescription:" + StatusDescription.ToString());
                        }



                    }
                //}
               
                // end Get Check Result List 


            }
            catch (Exception ex)
            {
                //ControllerExtension ce = new ControllerExtension(Configuration);


                string error = "Scheduller_Infobip_GetDeliveryReportData failed with exception: " + ex.Message.ToString();
                string errorDetail;
                errorDetail = "Input Param: N/A";
                LogErrorToDB("Scheduller_Infobip_GetDeliveryReportData", "Exception", error, errorDetail);
            }




        }

    }


}
