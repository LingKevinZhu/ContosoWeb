using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;
using Contoso.Models;

namespace Contoso.Instructor
{
    public partial class DetailsInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var instructorID = Request.QueryString["ID"];
                InstructorService instructorService = new InstructorService();
                var instructor = instructorService.GetOneInstructor(Convert.ToInt32(instructorID));
                InstructorIDLabel.Text = instructor.ID.ToString();
                HireDateLabel.Text = instructor.HireDate.ToString();
            }
        }
    }
}