using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Service;
using Contoso.Models;

namespace Contoso.Courses
{
    public partial class AddCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var coursesID = Request.QueryString["ID"];
            if (!IsPostBack && coursesID==null)
            {
                ddlDepartmentID.DataSource = Utility.Utility.GetAllDepartments();
                ddlDepartmentID.DataTextField = "Name";
                ddlDepartmentID.DataValueField = "ID";
                ddlDepartmentID.DataBind();
            }
            if (!IsPostBack && coursesID != null)
            {
                ddlDepartmentID.DataSource = Utility.Utility.GetAllDepartments();
                ddlDepartmentID.DataTextField = "Name";
                ddlDepartmentID.DataValueField = "ID";
                ddlDepartmentID.DataBind();
                CoursesService coursesService = new CoursesService();
                var courses = coursesService.GetOneCourses(Convert.ToInt32(coursesID));
                courses.ID = Convert.ToInt32(coursesID);
                txtTitle.Text = courses.Title.Trim();
                txtCredits.Text = courses.Credits.ToString();
                ddlDepartmentID.SelectedValue = courses.DepartmentID.ToString();
                txtCreatedDate.Text = courses.CreatedDate.ToString();
                txtCreatedBy.Text = courses.CreatedBy.Trim();
                txtUpdatedDate.Text = courses.UpdatedDate.ToString();
                txtUpdatedBy.Text = courses.UpdatedBy.Trim();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var coursesID = Request.QueryString["ID"];
            if (coursesID == null)
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
            if (coursesID != null)
            {
                Contoso.Models.Courses courses = new Models.Courses();
                courses.ID = Convert.ToInt32(coursesID);
                courses.Title = txtTitle.Text;
                courses.Credits = Convert.ToInt32(txtCredits.Text);
                courses.DepartmentID = Convert.ToInt32(ddlDepartmentID.SelectedValue);
                courses.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
                courses.CreatedBy = txtCreatedBy.Text;
                courses.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
                courses.UpdatedBy = txtUpdatedBy.Text;

                CoursesService coursesService = new CoursesService();
                coursesService.UpdateCourses(courses);
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}