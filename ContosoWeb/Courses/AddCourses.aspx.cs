using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Service;

namespace ContosoWeb.Courses
{
    public partial class AddCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDepartmentID.DataSource = Utility.GetAllDepartments();
                ddlDepartmentID.DataTextField = "Name";
                ddlDepartmentID.DataValueField = "ID";
                ddlDepartmentID.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contoso.Models.Courses courses = new Contoso.Models.Courses();
            courses.Title = txtTitle.Text;
            courses.Credits = Convert.ToInt32(txtCredits.Text);
            courses.DepartmentID = Convert.ToInt32(ddlDepartmentID.SelectedValue);
            courses.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
            courses.CreatedBy = txtCreatedBy.Text;
            courses.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
            courses.UpdatedBy = txtUpdatedBy.Text;

            CoursesService coursesService = new CoursesService();
            coursesService.AddCourses(courses);
        }
    }
}