using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Models;
using Contoso.Service;

namespace ContosoWeb.People
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) //user can disable the js control
            {
                Contoso.Models.People people = new Contoso.Models.People();
                people.LastName = txtLastName.Text;
                people.FirstName = txtFirstName.Text;
                people.MiddleName = txtMiddleName.Text;
                people.Age = Convert.ToInt32(txtAge.Text);
                people.Email = txtEmail.Text;
                people.Phone = txtPhone.Text;
                people.AddressLine1 = txtAddress1.Text;
                people.AddressLine2 = txtAddress2.Text;
                people.UnitOrApartmentNumber = Convert.ToInt32(txtUnitOrApartmentNumber.Text);
                people.City = txtCity.Text;
                people.State = ddlStates.SelectedValue;
                people.ZipCode = txtZipCode.Text;
                people.CreatedDate = Convert.ToDateTime(txtCreatedDate.Text);
                people.CreatedBy = txtCreatedBy.Text;
                people.UpdatedDate = Convert.ToDateTime(txtUpdatedDate.Text);
                people.UpdatedBy = txtUpdatedBy.Text;
                people.Password = txtPassword.Text;
                people.Salt = txtSalt.Text;
                if (ddlIsLocked.SelectedValue == "Yes") people.IsLocked = true;
                if (ddlIsLocked.SelectedValue == "No") people.IsLocked = false;
                people.LastLockedDateTime = Convert.ToDateTime(txtLastLockedDateTime.Text);
                people.FailedAttempts = Convert.ToInt32(txtFailedAttempts.Text);
                PeopleService peopleService = new PeopleService();
                peopleService.AddPeople(people);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        { 
        }
    }
}