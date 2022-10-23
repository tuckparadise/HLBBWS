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
    public class APPWS_BK2asmx : System.Web.Services.WebService
    {

        // DP_NewSolicitor_Attachment
        //[WebMethod]
        //public void DP_NewSolicitor_Attachment(ref string error)
        //{
        //    error = "";

        //    try
        //    {
        //        // log the result in db
        //        DataSet ds = null;
        //        DataTable dt = null;
        //        SqlConnection conn = null;
        //        SqlDataAdapter sqlDA = null;

        //        string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
        //        string strDBName = clsGlobal.MG_SQL_DB_NAME;
        //        string strID = clsGlobal.MG_SQL_ID;
        //        string strPassword = clsGlobal.MG_SQL_PASSWORD;
        //        bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

        //        string strDataSource2 = clsGlobal.MG_SQL_DATA_SOURCE2;
        //        string strDBName2 = clsGlobal.MG_SQL_DB_NAME2;
        //        string strID2 = clsGlobal.MG_SQL_ID2;
        //        string strPassword2 = clsGlobal.MG_SQL_PASSWORD2;
        //        bool blnIsWinAuth2 = clsGlobal.MG_SQL_IS_WIN_AUTH2;

        //        string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
        //        if (blnIsWinAuth)
        //        {
        //            connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
        //        }

        //        string connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Persist Security Info=True;User ID=" + strID2 + ";Password=" + strPassword2;
        //        if (blnIsWinAuth2)
        //        {
        //            connstr2 = @"Data Source=" + strDataSource2 + ";Initial Catalog=" + strDBName2 + ";Integrated Security=True;";
        //        }

        //        SqlConnection connPRE = null;
        //        SqlDataAdapter sqlDAPRE = null;

        //        connPRE = new SqlConnection(connstr);

        //        sqlDAPRE = new SqlDataAdapter();
        //        sqlDAPRE.SelectCommand = new SqlCommand("dbo.[usp_ws_getFireEyeFlag]", connPRE);

        //        string fireeye_flag;
        //        fireeye_flag = "";
        //        DataSet dsPRE = new DataSet("ds");
        //        sqlDAPRE.Fill(dsPRE);

        //        if (dsPRE.Tables.Count > 0)
        //        {
        //            DataTable dtPRE = dsPRE.Tables[0];
        //            fireeye_flag = dtPRE.Rows[0]["fireeye_flag"].ToString();
        //        }

        //        if (fireeye_flag == "1")
        //        {
        //            conn = new SqlConnection(connstr);

        //            sqlDA = new SqlDataAdapter();
        //            sqlDA.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_ListUploadedARN]", conn);

        //            string arn;
        //            ds = new DataSet("ds");
        //            sqlDA.Fill(ds);

        //            if (ds.Tables.Count > 0)
        //            {
        //                dt = ds.Tables[0];
        //                for (int i = 0; i < dt.Rows.Count; i++)
        //                {
        //                    arn = dt.Rows[i]["ARN"].ToString();
        //                    // start validate arn 
        //                    SqlConnection conn1 = null;
        //                    conn1 = new SqlConnection(connstr2);
        //                    SqlDataAdapter sqlDA1 = new SqlDataAdapter();
        //                    sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_CheckARN] @ARN", conn1);
        //                    sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);

        //                    DataSet ds1 = null;
        //                    DataTable dt1 = null;

        //                    ds1 = new DataSet("ds");

        //                    sqlDA1.Fill(ds1);

        //                    if (ds1.Tables.Count > 0)
        //                    {
        //                        /*
        //                        SqlConnection conn2 = null;
        //                        conn2 = new SqlConnection(connstr);
        //                        SqlDataAdapter sqlDA2 = new SqlDataAdapter();
        //                        sqlDA2.SelectCommand = new SqlCommand("dbo.[usp_SQLSolicitorDPSubmission_SelectAttachments] @ARN", conn2);
        //                        sqlDA2.SelectCommand.Parameters.AddWithValue("@arn", arn);

        //                        //SqlCommand sqlcommand0 = new SqlCommand("dbo.usp_SQLSolicitorDPSubmission_SelectAttachments @ARN", conn1);
        //                        //sqlcommand0.Parameters.AddWithValue("@ARN", arn);

        //                        DataSet ds2 = null;
        //                        DataTable dt2 = null;

        //                        ds2 = new DataSet("ds");
        //                        sqlDA2.Fill(ds2);

        //                        if (ds2.Tables.Count > 0)
        //                        {
        //                            dt2 = ds2.Tables[0];
        //                            for (int j = 0; j < dt2.Rows.Count; j++)
        //                            {
        //                                SqlConnection conn3 = null;
        //                                conn3 = new SqlConnection(connstr2);

        //                                SqlCommand sqlcommand1 = new SqlCommand("dbo.usp_solicitorattachment_upload @ARN, @attachmentfilename, @attachmentcontent, @attachmentfiletype, @attachmentuploaddate ", conn3);

        //                                sqlcommand1.Parameters.AddWithValue("@ARN", arn);
        //                                sqlcommand1.Parameters.AddWithValue("@attachmentfilename", dt2.Rows[j]["attachmentfilename"].ToString());
        //                                sqlcommand1.Parameters.AddWithValue("@attachmentcontent", dt2.Rows[j]["attachmentcontent"].ToString());
        //                                sqlcommand1.Parameters.AddWithValue("@attachmentfiletype", dt2.Rows[j]["attachmentfiletype"].ToString());
        //                                sqlcommand1.Parameters.AddWithValue("@attachmentuploaddate", dt2.Rows[j]["attachmentuploaddate"]);

        //                                conn3.Open();
        //                                int rowsAffected2 = sqlcommand1.ExecuteNonQuery();
        //                                conn3.Close();

        //                            }
        //                        }
        //                        conn2.Close();
        //                        */
        //SqlConnection conn4 = null;
        //                        conn4 = new SqlConnection(connstr2);

        //                        SqlCommand sqlcommand2 = new SqlCommand("dbo.usp_ws_solicitorattachment_create_master_data @ARN ", conn4);
        //                        sqlcommand2.Parameters.AddWithValue("@ARN", arn);

        //                        conn4.Open();
        //                        int rowsAffected3 = sqlcommand2.ExecuteNonQuery();
        //                        conn4.Close();
        //                    }
        //                    // end validate arn 
        //                    conn1.Close();

        //                }

        //            }
        //            conn.Close();
        //        }
        //        else
        //        {
        //            // fireeye flag is set to off, directly save attachment to eDMS

        //            // start get edms settings 
        //            SqlConnection connx = new SqlConnection(connstr);

        //            SqlDataAdapter sqlDAx = new SqlDataAdapter();
        //            sqlDAx.SelectCommand = new SqlCommand("dbo.[usp_ws_getEDMS_Solicitor_Setting] @error output", connx);
        //            sqlDAx.SelectCommand.Parameters.AddWithValue("@error", "");

        //            DataSet dsx = new DataSet("ds");
        //            DataTable dtx = null;

        //            sqlDAx.Fill(dsx);
        //            dtx = dsx.Tables[0];

        //            var EDMSDocType = dtx.Rows[0]["EDMSDocType"];
        //            var ProfileName = dtx.Rows[0]["ProfileName"];
        //            var LoginUser = dtx.Rows[0]["LoginUser"];
        //            var DefaultFileName = dtx.Rows[0]["DefaultFileName"];
        //            var EDMSUploadFolder = dtx.Rows[0]["EDMSUploadFolder"];
        //            var Category = dtx.Rows[0]["Category"];
        //            connx.Close();
        //            // end get edms settings


        //            // start get all arn from staging
        //            SqlConnection connALPHA = new SqlConnection(connstr);

        //            SqlDataAdapter sqlDAALPHA = new SqlDataAdapter();
        //            sqlDAALPHA.SelectCommand = new SqlCommand("dbo.[usp_ws_SolicitorSubmission_getallARNInStaging]", connALPHA);
        //            //sqlDAALPHA.SelectCommand.Parameters.AddWithValue("@error", "");

        //            DataSet dsAPLHA = new DataSet("ds");
        //            DataTable dtALPHA = null;

        //            sqlDAALPHA.Fill(dsAPLHA);
        //            dtALPHA = dsAPLHA.Tables[0];

        //            if (dsAPLHA.Tables.Count > 0)
        //            {
        //                dtALPHA = dsAPLHA.Tables[0];

        //                for (int s = 0; s < dtALPHA.Rows.Count; s++)
        //                {
        //                    var arn = dtALPHA.Rows[s]["arn"];

        //                    // start get customer name and id for the selected arn 
        //                    SqlConnection conny = new SqlConnection(connstr);

        //                    SqlDataAdapter sqlDAy = new SqlDataAdapter();
        //                    sqlDAy.SelectCommand = new SqlCommand("dbo.[usp_ws_getCustomerInfo_forARN] @arn, @error output", conny);
        //                    sqlDAy.SelectCommand.Parameters.AddWithValue("@arn", arn);
        //                    sqlDAy.SelectCommand.Parameters.AddWithValue("@error", "");

        //                    DataSet dsy = new DataSet("ds");
        //                    DataTable dty = null;

        //                    sqlDAy.Fill(dsy);
        //                    dty = dsy.Tables[0];
        //                    var CustomerID = dty.Rows[0]["CustomerID"].ToString();
        //                    if (CustomerID.ToString() == "")
        //                    {
        //                        CustomerID = "N/A";
        //                    }
        //                    var CustomerName = dty.Rows[0]["CustomerName"].ToString();
        //                    if (CustomerName.ToString() == "")
        //                    {
        //                        CustomerName = "N/A";
        //                    }
        //                    conny.Close();
        //                    // end get customer name and id for the selected arn 

        //                    // start get attachment detail 
        //                    SqlConnection conn1 = null;
        //                    conn1 = new SqlConnection(connstr);
        //                    SqlDataAdapter sqlDA1 = new SqlDataAdapter();

        //                    sqlDA1.SelectCommand = new SqlCommand("dbo.[usp_ws_list_SolicitorDocumentationSubmissionAttachmentInStaging] @ARN", conn1);
        //                    sqlDA1.SelectCommand.Parameters.AddWithValue("@arn", arn);


        //                    DataSet ds1 = null;
        //                    DataTable dt1 = null;

        //                    ds1 = new DataSet("ds");

        //                    sqlDA1.Fill(ds1);

        //                    if (ds1.Tables.Count > 0)
        //                    {
        //                        dt1 = ds1.Tables[0];

        //                        for (int j = 0; j < dt1.Rows.Count; j++)
        //                        {
        //                            var filename_original = dt1.Rows[j]["ItemFileName"];
        //                            var filename_new = dt1.Rows[j]["ItemFileName"];
        //                            var filecontent = dt1.Rows[j]["ItemContent"];
        //                            //byte[] byteFileContent = Convert.FromBase64String(filecontent);
        //                            var filetype = dt1.Rows[j]["ItemFileType"];
        //                            // var attachmentuploaddate = dt1.Rows[j]["attachmentuploaddate"];
        //                            //var fe_failed_description = dt1.Rows[j]["fe_failed_description"];
        //                            //var fe_failed_code = dt1.Rows[j]["fe_failed_code"];
        //                            //var d_result = dt1.Rows[j]["result"];

        //                            string DP_ExportK2FileToEDMS_error = "";
        //                            //ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original + "." + filetype, arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);
        //                            ExportFileResponseData response = DP_ExportK2FileToEDMS(ProfileName.ToString(), EDMSUploadFolder.ToString(), filecontent.ToString(), filename_original.ToString(), arn.ToString(), EDMSDocType.ToString(), Category.ToString(), CustomerID.ToString(), CustomerName.ToString(), ref DP_ExportK2FileToEDMS_error);

        //                        }
        //                    }
        //                    conn1.Close();
        //                    // end get attachment detail 

        //                    // start move arn from staging to main usp_SQLSolicitorDPSubmission_Main_MoveToMain
        //                    SqlConnection connz = new SqlConnection(connstr);

        //                    SqlDataAdapter sqlDAz = new SqlDataAdapter();
        //                    sqlDAz.SelectCommand = new SqlCommand("dbo.[usp_ws_SQLSolicitorDPSubmission_Main_MoveToMain] @arn, @error output", connz);
        //                    sqlDAz.SelectCommand.Parameters.AddWithValue("@arn", arn);
        //                    sqlDAz.SelectCommand.Parameters.AddWithValue("@error", "");

        //                    DataSet dsz = new DataSet("ds");
        //                    DataTable dtz = null;
        //                    //dtz = dsz.Tables[0];
        //                    sqlDAz.Fill(dsz);
        //                    connz.Close();
        //                    // start move arn from staging to main 

        //                    // start delete staging data in temp db 
        //                    SqlConnection connmeta = new SqlConnection(connstr);

        //                    SqlDataAdapter sqlDAmeta = new SqlDataAdapter();
        //                    sqlDAmeta.SelectCommand = new SqlCommand("dbo.[usp_ws_deleterecords] @arn, @workflow, @error output", connmeta);
        //                    sqlDAmeta.SelectCommand.Parameters.AddWithValue("@arn", arn);
        //                    sqlDAmeta.SelectCommand.Parameters.AddWithValue("@workflow", "SolicitorDPSubmission");
        //                    sqlDAmeta.SelectCommand.Parameters.AddWithValue("@error", "");

        //                    DataSet dsmeta = new DataSet("ds");
        //                    //DataTable dtz = null;
        //                    //dtz = dsz.Tables[0];
        //                    sqlDAmeta.Fill(dsmeta);
        //                    connmeta.Close();
        //                    // start  delete staging data in temp db 
        //                }
        //            }
        //            // end start get all arn in staging 
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        error = "DP_NewSolicitor_Attachment failed with exception: " + ex.Message.ToString();
        //        string errorDetail;
        //        errorDetail = "Input Param: N/A";
        //        LogErrorToDB("DP_NewSolicitor_Attachment", "Exception", error, errorDetail);
        //    }
        //}


        /* DP_ExportSolicitorSubmissionOtherDocumentsToEDMS
        //[WebMethod]
        //public void DP_ExportSolicitorSubmissionOtherDocumentsToEDMS(string solicitorcode, string strProfile, string strFolderName, string strARN, string strDocType, string strCategory, string strIDNumber, string Name, ref string error)
        //{
        //    error = "";
        //    //ExportFileResponseData response = new ExportFileResponseData();
        //    DataSet ds = null;
        //    DataTable dt = null;
        //    SqlConnection conn = null;
        //    SqlDataAdapter sqlDA = null;

        //    //System.ServiceModel.BasicHttpBinding binding = null;
        //    //EDMS_WSSDK.WSSDKSoapClient client = null;

        //    try
        //    {

        //        string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
        //        string strDBName = clsGlobal.MG_SQL_DB_NAME;
        //        string strID = clsGlobal.MG_SQL_ID;
        //        string strPassword = clsGlobal.MG_SQL_PASSWORD;
        //        bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

        //        string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
        //        if (blnIsWinAuth)
        //        {
        //            connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
        //        }
        //        conn = new SqlConnection(connstr);
        //        conn.Open();

        //        sqlDA = new SqlDataAdapter();
        //        sqlDA.SelectCommand = new SqlCommand("usp_ws_getSolicitorOtherDocumentsFromARN @arn, @solicitorcode", conn);
        //        //SqlCommand command = new SqlCommand(commandText, connection);
        //        sqlDA.SelectCommand.Parameters.AddWithValue("@arn", strARN);
        //        sqlDA.SelectCommand.Parameters.AddWithValue("@solicitorcode", solicitorcode);

        //        ds = new DataSet("ds");
        //        sqlDA.Fill(ds);
        //        dt = ds.Tables[0];

        //        conn.Close();

        //        //Specify the binding to be used for the client.
        //        //binding = new System.ServiceModel.BasicHttpBinding();
        //        //client = new EDMS_WSSDK.WSSDKSoapClient("WSSDKSoap", clsGlobal.EDMS_HOST_URL);
        //        if (dt.Rows.Count > 0)
        //        {
        //            string outputARN;
        //            string outputSolicitorCode;
        //            string outputAttachmentID;
        //            string outputAttachment;
        //            string outputAttachmentName;
        //            string outputImage;
        //            string outputImageName;
        //            string outputCustomerID;
        //            string outputCustomerName;

        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                outputARN = dt.Rows[i]["ARN"].ToString();
        //                outputSolicitorCode = dt.Rows[i]["SolicitorCode"].ToString();
        //                outputAttachmentID = dt.Rows[i]["AttachmentID"].ToString();
        //                outputAttachment = dt.Rows[i]["Attachment"].ToString();
        //                outputAttachmentName = dt.Rows[i]["AttachmentName"].ToString();
        //                outputImageName = dt.Rows[i]["ImageName"].ToString();
        //                outputImage = dt.Rows[i]["Image"].ToString();
        //                outputCustomerID = dt.Rows[i]["CustomerID"].ToString();
        //                outputCustomerName = dt.Rows[i]["CustomerName"].ToString();
        //                string DP_ExportK2FileToEDMS_error = "";
        //                ExportFileResponseData response = DP_ExportK2FileToEDMS(strProfile, strFolderName, outputImage, outputImageName, strARN, strDocType, strCategory, strIDNumber, Name, ref DP_ExportK2FileToEDMS_error);

        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        error = "DP_ExportSolicitorSubmissionOtherDocumentsToEDMS failed with exception: " + ex.Message.ToString();
        //        string errorDetail;
        //        errorDetail = "Input Param: " + solicitorcode.ToString() + "," + strProfile.ToString() + "," + strFolderName.ToString() + "," + strARN.ToString() + "," + strDocType.ToString() + "," + strCategory.ToString() + "," + strIDNumber.ToString() + "," + Name.ToString();
        //        LogErrorToDB("DP_ExportSolicitorSubmissionOtherDocumentsToEDMS", "Exception", error, errorDetail);
        //        //clsLog.WriteSystemLog(clsLog.MessageType.Error, "ExportSolicitorSubmissionOtherDocumentsToEDMS()", ex.Message + Environment.NewLine + ex.StackTrace);
        //    }
        //}
        */

        /* DP_SolicitorDPSubmissionAttachment_add_withattachment
        //[WebMethod]
        //public void DP_SolicitorDPSubmissionAttachment_add_withattachment(string arn, string k2fileattachment, string solicitorcode, ref string error)
        //{
        //    error = "";

        //    try
        //    {
        //        // log the result in db
        //        DataSet ds = null;
        //        DataTable dt = null;
        //        SqlConnection conn = null;
        //        SqlDataAdapter sqlDA = null;

        //        string strDataSource = clsGlobal.MG_SQL_DATA_SOURCE;
        //        string strDBName = clsGlobal.MG_SQL_DB_NAME;
        //        string strID = clsGlobal.MG_SQL_ID;
        //        string strPassword = clsGlobal.MG_SQL_PASSWORD;
        //        bool blnIsWinAuth = clsGlobal.MG_SQL_IS_WIN_AUTH;

        //        string connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Persist Security Info=True;User ID=" + strID + ";Password=" + strPassword;
        //        if (blnIsWinAuth)
        //        {
        //            connstr = @"Data Source=" + strDataSource + ";Initial Catalog=" + strDBName + ";Integrated Security=True;";
        //        }

        //        SqlConnection connPRE = null;
        //        SqlDataAdapter sqlDAPRE = null;

        //        connPRE = new SqlConnection(connstr);

        //        sqlDAPRE = new SqlDataAdapter();
        //        sqlDAPRE.SelectCommand = new SqlCommand("dbo.usp_ws_SQLSolicitorDPSubmissionAttachment_add_withattachment @solicitoremail, @arn, @attachment", connPRE);
        //        sqlDAPRE.SelectCommand.Parameters.AddWithValue("@solicitoremail", solicitorcode);
        //        sqlDAPRE.SelectCommand.Parameters.AddWithValue("@arn", arn);
        //        sqlDAPRE.SelectCommand.Parameters.AddWithValue("@attachment", k2fileattachment);

        //        DataSet dsPRE = new DataSet("ds");
        //        sqlDAPRE.Fill(dsPRE);

        //    }
        //    catch (Exception ex)
        //    {
        //        error = "DP_SolicitorDPSubmissionAttachment_add_withattachment failed with exception: " + ex.Message.ToString();
        //        string errorDetail;
        //        errorDetail = "Input Param:" + "arn:" + arn + ", solicitorcode:" + solicitorcode;
        //        LogErrorToDB("DP_SolicitorDPSubmissionAttachment_add_withattachment", "Exception", error, errorDetail);
        //    }
        //}
        */

        /*  DP_SQLSolicitorDPSubmission_Main
        [WebMethod]
        public void DP_SQLSolicitorDPSubmission_Main
            (
                string arn,
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

                SqlParameter p_arn = new SqlParameter("@arn", SqlDbType.NVarChar, -1);
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

                

                SqlParameter p_Completed = new SqlParameter("@Completed", SqlDbType.NVarChar, -1);
                //param.Direction = ParameterDirection.InputOutput;
                p_Completed.Value = Completed;
                command.Parameters.Add(p_Completed);

                SqlParameter p_error = new SqlParameter("@error", SqlDbType.NVarChar, -1);
                p_error.Direction = ParameterDirection.InputOutput;
                p_error.Value = error;
                command.Parameters.Add(p_error);

                sqlDAPRE = new SqlDataAdapter();

               

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
                errorDetail = "Input Param:" + "arn:" + arn;
                LogErrorToDB("usp_SQLSolicitorDPSubmission_Main", "Exception", error, errorDetail);
                //return outputValue;
            }
        }
        */

        /* DP_SQLValuerDPSubmission_Main
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
        */

        /* TBD_DP_UpdatePhaseCode
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
        */
    }
}
