using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.Departments
{
    public partial class ListDepartments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DepartmentsService departmentsService = new DepartmentsService();
                repeaterDepartments.DataSource = departmentsService.GetAllDepartments();
                repeaterDepartments.DataBind();
            }
        }

        protected void repeaterDepartments_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            var departmentsID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "edit")
            {
                Response.Redirect("AddDepartments.aspx?id=" + departmentsID);
            }
            if (e.CommandName == "delete")
            {
                DepartmentsService departmentsService = new DepartmentsService();
                departmentsService.DeleteDepartments(Convert.ToInt32(departmentsID));
                Response.Redirect("ListDepartments.aspx");
            }
            if (e.CommandName == "details")
            {
                Response.Redirect("DetailsDepartments.aspx?id=" + departmentsID);
            }
        }
    }
}