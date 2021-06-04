using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Entity;
using BusinessLogic;

namespace FirstWeb
{
    /// <summary>
    /// Login related functions
    /// </summary>
    public partial class UserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            User user = UserLogic.ValidateUser(TextBoxUsername.Text.Trim(), TextBoxPassword.Text.Trim());
            if(user == null)
            {

            }
            else
            {
                Session["User"] = user;
                Response.Redirect("Employees.aspx");
            }
        }


    }
}