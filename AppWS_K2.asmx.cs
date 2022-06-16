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
    public class AppWS_K2 : System.Web.Services.WebService
    {

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

            string datafieldsToUpdateJSON = "{\"folio\": \"" + folio + "\"}";
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

            if (VariableName.Count > 0)
            {
                datafieldsToUpdateJSON = datafieldsToUpdateJSON + ",\"dataFields\": {";
            }

            for (int i = 0; i < VariableName.Count; i++)
            {
                datafieldsToUpdateJSON = datafieldsToUpdateJSON + "\"" + VariableName[i] + "\":\"" + VariableValue[i] + "\"";

                if (i != VariableName.Count - 1)
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

        /*
        [WebMethod]
        public void K2_RetryFailedWF_PDFDocSubmission()
        {


            // Connect to the K2 Management Server
            SourceCode.Workflow.Management.WorkflowManagementServer mngServer = new SourceCode.Workflow.Management.WorkflowManagementServer("kapps2", 5555);
            //mngServer.CreateConnection();
            mngServer.Open();

            //mngServer.Open();
            // Get all Process Instances
            SourceCode.Workflow.Management.ProcessInstances procInstances = mngServer.GetProcessInstances();
            // loop over the Process Instances
            foreach (SourceCode.Workflow.Management.ProcessInstance procInstance in procInstances)
            {
                // If the Instance is in Error State (Status '0') ...
                if (procInstance.Status == "0")
                {
                    //Console.WriteLine(procInstance.ID.ToString() + " - " + procInstance.Folio + " - " + procInstance.Status);

                    // Retry - I do not know what to use for the ErrorID as I did not find any information on:
                    // http://help.k2.com/helppages/K2blackpointDevRef4.6/Workflow.Management/topic1327.html
                    // if you have any helpful information please let me know!
                    mngServer.RetryError(procInstance.ID, 5, "Username");

                    // wait 20 sec and then process the next process instance
                    //Thread.Sleep(20000);
                }
            }
        }
        */
    }
}
