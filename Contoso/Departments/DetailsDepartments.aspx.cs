using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.Departments
{
    public partial class DetailsDepartments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var departmentsID = Request.QueryString["ID"];
                DepartmentsService departmentsService = new DepartmentsService();
                var departments = departmentsService.GetOneDepartments(Convert.ToInt32(departmentsID));
                NameLabel.Text = departments.Name;
                BudgetLabel.Text = departments.Budget.ToString();
                StartDateLabel.Text = departments.StartDate.ToString();
                InstructorIDLabel.Text = departments.InstructorID.ToString();
                RowVersionLabel.Text = departments.RowVersion.ToString();
                CreatedDateLabel.Text = departments.CreatedDate.ToString();
                CreatedByLabel.Text = departments.CreatedBy;
                UpdatedDateLabel.Text = departments.UpdatedDate.ToString();
                UpdatedByLabel.Text = departments.UpdatedBy;
            }
        }
    }
}