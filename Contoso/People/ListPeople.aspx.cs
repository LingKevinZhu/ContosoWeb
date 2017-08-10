using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace Contoso.People
{
    public partial class ListPeople : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PeopleService peopleService = new PeopleService();
                repeaterPeople.DataSource = peopleService.GetAllPeople();
                repeaterPeople.DataBind();
            }
        }

        protected void repeaterPeople_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            var personID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "edit")
            {
                Response.Redirect("AddPeople.aspx?id=" + personID);
            }
            if (e.CommandName == "delete")
            {
                PeopleService peopleService = new PeopleService();
                peopleService.DeletePeople(Convert.ToInt32(personID));
                Response.Redirect("ListPeople.aspx");
            }
            if (e.CommandName == "details")
            {
                Response.Redirect("DetailsPeople.aspx?id=" + personID);
            }
        }
    }
}