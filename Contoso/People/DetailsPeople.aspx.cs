using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.People
{
    public partial class DetailsPeople : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var personID = Request.QueryString["ID"];
                PeopleService peopleService = new PeopleService();
                var people = peopleService.GetOnePeople(Convert.ToInt32(personID));
                firstNameLabel.Text = people.FirstName;
                LastNameLabel.Text = people.LastName;
                MiddleNameLabel.Text = people.MiddleName;
                AgeLabel.Text = people.Age.ToString();
                EmailLabel.Text = people.Email;
                PhoneLabel.Text = people.Phone;
                AddressLine1Label.Text = people.AddressLine1;
                AddressLine2Label.Text = people.AddressLine2;
                UnitOrApartmentNumberLabel.Text = people.UnitOrApartmentNumber.ToString();
                CityLabel.Text = people.City;
                StateLabel.Text = people.State;
                ZipCodeLabel.Text = people.ZipCode;
                CreatedDateLabel.Text = people.CreatedDate.ToString();
                CreatedByLabel.Text = people.CreatedBy;
                UpdatedDateLabel.Text = people.UpdatedDate.ToString();
                UpdatedByLabel.Text = people.UpdatedBy;
                PasswordLabel.Text = people.Password;
                SaltLabel.Text = people.Salt;
                IsLockedLabel.Text = people.IsLocked.ToString();
                LastLockedDateTimeLabel.Text = people.LastLockedDateTime.ToString();
                FailedAttemptsLabel.Text = people.FailedAttempts.ToString();
            }
        }
    }
}