using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace FirstWeb
{
    public partial class EmployeeType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArrayList list = MasterLogic.GetAllEmployeeType();
                GridViewEmployeeType.DataSource = list;
                GridViewEmployeeType.DataBind();

                if (GridViewEmployeeType.Rows.Count == 0)
                {
                    GridViewEmployeeType.Visible = false;
                    NoRecordLabel.Visible = true;
                }
                else
                {
                    GridViewEmployeeType.Visible = true;
                    NoRecordLabel.Visible = false;
                }

                ArrayList activeList = MasterLogic.GetAllActiveEmployeeType();
                DropDownListEmployeeType.DataSource = activeList;
                DropDownListEmployeeType.DataTextField = "Description";
                DropDownListEmployeeType.DataValueField = "Id";
                DropDownListEmployeeType.DataBind();

                ArrayList checkboxList = MasterLogic.GetAllActiveEmployeeType();
                CheckBoxListEmployeeType.DataSource = checkboxList;
                CheckBoxListEmployeeType.DataTextField = "Description";
                CheckBoxListEmployeeType.DataValueField = "Id";
                CheckBoxListEmployeeType.DataBind();

                

            }
        }

        protected void DropDownListEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxListEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxEmployeeType_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}