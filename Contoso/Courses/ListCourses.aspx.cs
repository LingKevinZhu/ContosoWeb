using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.Courses
{
    public partial class ListCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CoursesService coursesService = new CoursesService();
                repeaterCourses.DataSource = coursesService.GetAllCourses();
                repeaterCourses.DataBind();
            }
        }

        protected void repeaterCourses_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            var coursesID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "edit")
            {
                Response.Redirect("AddCourses.aspx?id=" + coursesID);
            }
            if (e.CommandName == "delete")
            {
                CoursesService coursesService = new CoursesService();
                coursesService.DeleteCourses(Convert.ToInt32(coursesID));
                Response.Redirect("ListCourses.aspx");
            }
            if (e.CommandName == "details")
            {
                Response.Redirect("DetailsCourses.aspx?id=" + coursesID);
            }
        }
    }
}