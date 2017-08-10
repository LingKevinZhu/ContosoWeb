using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Service;

namespace ContosoWeb.Departments
{
    public partial class AddDepartments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlInstructorID.DataSource = Utility.GetAllInstructor();
                ddlInstructorID.DataTextField = "ID";
                ddlInstructorID.DataValueField = "ID";
                ddlInstructorID.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contoso.Models.Departments departments = new Contoso.Models.Departments();
            departments.Name = txtName.Text;
            departments.Budget = Convert.ToDouble(txtBudget.Text);
            departments.StartDate = Convert.ToDateTime(txtStartDate.Text);
            departments.InstructorID = Convert.ToInt32(ddlInstructorID.SelectedValue);
            departments.RowVersion = Convert.ToInt32(txtRowVersion.Text);
            departments.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
            departments.CreatedBy = txtCreatedBy.Text;
            departments.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
            departments.UpdatedBy = txtUpdatedBy.Text;

            DepartmentsService departmentsService = new DepartmentsService();
            departmentsService.AddDepartments(departments);
        }
    }
}