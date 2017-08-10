using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Service;
using Contoso.Models;

namespace Contoso.People
{
    public partial class AddPeople : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var personID = Request.QueryString["ID"];
            if ((!IsPostBack) && (personID==null))
            {
                ddlStates.DataSource = Utility.Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }
            if ((!IsPostBack) && (personID != null))
            {
                ddlStates.DataSource = Utility.Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
                PeopleService peopleService = new PeopleService();
                Contoso.Models.People people = peopleService.GetOnePeople(Convert.ToInt32(personID));
                people.ID = Convert.ToInt32(personID);
                txtLastName.Text = people.LastName.Trim();
                txtFirstName.Text = people.FirstName.Trim();
                txtMiddleName.Text = people.MiddleName.Trim();
                txtAge.Text = people.Age.ToString();
                txtEmail.Text = people.Email.Trim();
                txtPhone.Text = people.Phone.Trim();
                txtAddress1.Text = people.AddressLine1.Trim();
                txtAddress2.Text = people.AddressLine2.Trim();
                txtUnitOrApartmentNumber.Text = people.UnitOrApartmentNumber.ToString();
                txtCity.Text = people.City.Trim();
                ddlStates.SelectedValue = people.State.Trim();
                txtZipCode.Text = people.ZipCode.Trim();
                txtCreatedDate.Text = people.CreatedDate.ToString();
                txtCreatedBy.Text = people.CreatedBy.Trim();
                txtUpdatedDate.Text = people.UpdatedDate.ToString();
                txtUpdatedBy.Text = people.UpdatedBy.Trim();
                txtPassword.Text = people.Password.Trim();
                txtSalt.Text = people.Salt.Trim();
                if (people.IsLocked == true) ddlIsLocked.SelectedValue = "Yes";
                if (people.IsLocked == false) ddlIsLocked.SelectedValue = "No";
                txtLastLockedDateTime.Text = people.LastLockedDateTime.ToString();
                txtFailedAttempts.Text = people.FailedAttempts.ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var personID = Request.QueryString["ID"];
            if ((Page.IsValid) && (personID == null)) //user can disable the js control
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
            if ((Page.IsValid) && (personID != null)) //user can disable the js control
            {
                Contoso.Models.People people = new Contoso.Models.People();
                people.ID = Convert.ToInt32(personID);
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
                peopleService.UpdatePeople(people);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}