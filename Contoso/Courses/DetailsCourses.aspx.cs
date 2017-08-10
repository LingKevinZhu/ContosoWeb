using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.Courses
{
    public partial class DetailsCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var coursesID = Request.QueryString["ID"];
                CoursesService coursesService = new CoursesService();
                var courses = coursesService.GetOneCourses(Convert.ToInt32(coursesID));
                TitleLabel.Text = courses.Title;
                CreditsLabel.Text = courses.Credits.ToString();
                DepartmentIDLabel.Text = courses.DepartmentID.ToString();
                CreatedDateLabel.Text = courses.CreatedDate.ToString();
                CreatedByLabel.Text = courses.CreatedBy;
                UpdatedDateLabel.Text = courses.UpdatedDate.ToString();
                UpdatedByLabel.Text = courses.UpdatedBy;
            }
        }
    }
}