using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BusinessLogic;

namespace FirstWeb
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //It took Employee object from session from UserForm class
                User user = (User)Session["User"];

                UserLabel.Text = "Welcome " + user.FirstName + " " + user.LastName;
            }
        }
    }
}