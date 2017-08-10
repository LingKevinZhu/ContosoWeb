using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;
using Contoso.Models;

namespace ContosoWeb.People
{
    public partial class DetailsPerson : System.Web.UI.Page
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
            }
        }
    }
}