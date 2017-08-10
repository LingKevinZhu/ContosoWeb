using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.Instructor
{
    public partial class ListInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InstructorService instructorService = new InstructorService();
                repeaterInstructor.DataSource = instructorService.GetAllInstructor();
                repeaterInstructor.DataBind();
            }
        }

        protected void repeaterInstructor_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            var instructorID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "edit")
            {
                Response.Redirect("AddInstructor.aspx?id=" + instructorID);
            }
            if (e.CommandName == "delete")
            {
                InstructorService instructorService = new InstructorService();
                instructorService.DeleteInstructor(Convert.ToInt32(instructorID));
                Response.Redirect("ListInstructor.aspx");
            }
            if (e.CommandName == "details")
            {
                Response.Redirect("DetailsInstructor.aspx?id=" + instructorID);
            }
        }
    }
}