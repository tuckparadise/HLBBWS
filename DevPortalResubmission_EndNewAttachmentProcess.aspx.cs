using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HLBBWS
{
    public partial class DevPortalResubmission_EndNewAttachmentProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string error = "";
            HLBBWS.AppWS ws = new AppWS();

            ws.DP_CompletedProjectResubmit_Attachment(ref error);
        }
    }
}