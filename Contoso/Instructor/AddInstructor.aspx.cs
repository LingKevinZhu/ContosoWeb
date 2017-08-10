using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;
using Contoso.Models;

namespace Contoso.Instructor
{
    public partial class AddInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var instructorID = Request.QueryString["ID"];
            if (!IsPostBack && instructorID == null)
            {
                ddlID.DataSource = Utility.Utility.GetAllPeople();
                ddlID.DataTextField = "ID";
                ddlID.DataValueField = "ID";
                ddlID.DataBind();
            }
            if (!IsPostBack && instructorID != null)
            {
                ddlID.DataSource = Utility.Utility.GetAllPeople();
                ddlID.DataTextField = "ID";
                ddlID.DataValueField = "ID";
                ddlID.DataBind();
                InstructorService instructorService = new InstructorService();
                Contoso.Models.Instructor instructor = instructorService.GetOneInstructor(Convert.ToInt32(instructorID));
                ddlID.SelectedValue = instructor.ID.ToString();
                txtHireDate.Text = instructor.HireDate.ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var instructorID = Request.QueryString["ID"];
            if (Page.IsValid && instructorID == null)
            {
                Contoso.Models.Instructor instructor = new Models.Instructor();
                instructor.ID = Convert.ToInt32(ddlID.SelectedValue);
                instructor.HireDate = Convert.ToDateTime(txtHireDate.Text);
                InstructorService instructorService = new InstructorService();
                instructorService.AddInstructor(instructor);
            }
            if (Page.IsValid && instructorID != null)
            {
                Contoso.Models.Instructor instructor = new Models.Instructor();
                instructor.ID = Convert.ToInt32(ddlID.SelectedValue);
                instructor.HireDate = Convert.ToDateTime(txtHireDate.Text);
                InstructorService instructorService = new InstructorService();
                instructorService.UpdateInstructor(instructor);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}