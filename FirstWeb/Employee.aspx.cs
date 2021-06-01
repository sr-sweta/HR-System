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
                if( user == null)
                {
                    UserLabel.Text = "Please login to get info.";
                }
                else
                {
                    UserLabel.Text = "Welcome " + user.FirstName + " " + user.LastName;

                }

            }
        }

		protected void DOBImageButton_Click(object sender, ImageClickEventArgs e)
		{
            DOBCalendar.Visible = true;

        }

		protected void DOBCalendar_SelectionChanged(object sender, EventArgs e)
		{
            DOB.Text = DOBCalendar.SelectedDate.ToString("dd/mm/yyyy");
            DOBCalendar.Visible = false;
        }

		protected void ButtonSave_Click(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                //It took Employee object from session from UserForm class
                User user = (User)Session["User"];
                UserLogic.EditUser(user.Username, user.Password, TextBoxFirstName.Text.Trim(), TextBoxLastName.Text.Trim());

            }
                
   //         if (user == null)
   //         {
   //             UserLabel.Text = "Please login to get info.";
   //             FirstNameLabel.Visible = false;
   //             TextBoxFirstName.Visible = false;
   //             TextBoxLastName.Visible = false;
   //             LastNameLabel.Visible = false;
   //         }
			//else
			//{
   //             UserLabel.Visible = false;
   //             FirstNameLabel.Visible = true;
   //             TextBoxFirstName.Visible = true;
   //             TextBoxLastName.Visible = true;
   //             LastNameLabel.Visible = true;
               
    //        }
        }
	}
}