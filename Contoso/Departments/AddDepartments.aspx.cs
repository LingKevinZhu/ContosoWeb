using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Service;

namespace Contoso.Departments
{
    public partial class AddDepartments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var departmentsID = Request.QueryString["ID"];
            if (!IsPostBack && departmentsID == null)
            {
                ddlInstructorID.DataSource = Utility.Utility.GetAllInstructor();
                ddlInstructorID.DataTextField = "ID";
                ddlInstructorID.DataValueField = "ID";
                ddlInstructorID.DataBind();
            }
            if (!IsPostBack && departmentsID != null)
            {
                ddlInstructorID.DataSource = Utility.Utility.GetAllInstructor();
                ddlInstructorID.DataTextField = "ID";
                ddlInstructorID.DataValueField = "ID";
                ddlInstructorID.DataBind();
                DepartmentsService departmentsService = new DepartmentsService();
                var departments = departmentsService.GetOneDepartments(Convert.ToInt32(departmentsID));
                departments.ID = Convert.ToInt32(departmentsID);
                txtName.Text = departments.Name.Trim();
                txtBudget.Text = departments.Budget.ToString();
                txtStartDate.Text = departments.StartDate.ToString();
                ddlInstructorID.SelectedValue = departments.InstructorID.ToString();
                txtRowVersion.Text = departments.RowVersion.ToString();
                txtCreatedDate.Text = departments.CreatedDate.ToString();
                txtCreatedBy.Text = departments.CreatedBy.Trim();
                txtUpdatedDate.Text = departments.UpdatedDate.ToString();
                txtUpdatedBy.Text = departments.UpdatedBy.Trim();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var departmentsID = Request.QueryString["ID"];
            if (departmentsID == null)
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
            if (departmentsID != null)
            {
                Contoso.Models.Departments departments = new Models.Departments();
                departments.ID = Convert.ToInt32(departmentsID);
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
                departmentsService.UpdateDepartments(departments);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}