using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contoso
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["FirstName"] = "Kevin";
        }

        protected void btnSumit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}