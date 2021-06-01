using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using Entity;

namespace FirstWeb
{
	/// <summary>
	/// All main features of of the Presentation Layer
	/// </summary>
    public partial class EmployeeTypes : System.Web.UI.Page
    {
		#region Features

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{

				BindEmployeeType();
				BindEmployeeCategory();
				BindDocumentType();



				ButtonEmployeeTypes.CssClass = "Clicked";
				ButtonEmployeeCategories.CssClass = "Initial";
				ButtonDocumentTypes.CssClass = "Initial";
				MainView.ActiveViewIndex = 0;

			}
		}

		//Binds Employee Type Data to GridView
		private void BindEmployeeType()
		{
			ArrayList list = MasterLogic.GetAllEmployeeType();
			GridViewEmployeeType.DataSource = list;
			GridViewEmployeeType.DataBind();

		}

		//Binds Employee Category Data to GridView
		protected void BindEmployeeCategory()
		{
			ArrayList Categorylist = MasterLogic.GetAllEmployeeCategory();
			GridViewEmployeeCategory.DataSource = Categorylist;
			GridViewEmployeeCategory.DataBind();

		}

		//Binds Document Type Data to GridView
		private void BindDocumentType()
		{
			ArrayList list = MasterLogic.GetAllDocumentType();
			GridViewDocumentType.DataSource = list;
			GridViewDocumentType.DataBind();

		}

		//Handles EmployeeType menu button 
		protected void ButtonEmployeeTypes_Click(object sender, EventArgs e)
		{
			ButtonEmployeeTypes.CssClass = "Clicked";
			ButtonEmployeeCategories.CssClass = "Initial";
			ButtonDocumentTypes.CssClass = "Initial";
			MainView.ActiveViewIndex = 0;
		}

		//Handles EmployeeCategory menu button 
		protected void ButtonEmployeeCategories_Click(object sender, EventArgs e)
		{
			ButtonEmployeeTypes.CssClass = "Initial";
			ButtonEmployeeCategories.CssClass = "Clicked";
			ButtonDocumentTypes.CssClass = "Initial";
			MainView.ActiveViewIndex = 1;
		}

		//Handles DocumentType menu button 
		protected void ButtonDocumentTypes_Click(object sender, EventArgs e)
		{
			ButtonEmployeeTypes.CssClass = "Initial";
			ButtonEmployeeCategories.CssClass = "Initial";
			ButtonDocumentTypes.CssClass = "Clicked";
			MainView.ActiveViewIndex = 2;
		}

		//Handles RowCommand of GridView of Employee Type
		protected void GridViewEmployeeType_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Alter")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				GridViewEmployeeType.EditIndex = row.RowIndex;
				GridViewEmployeeType.ShowFooter = false;
				BindEmployeeType();
			}
			else if (e.CommandName == "AlterCancel")
			{
				GridViewEmployeeType.EditIndex = -1;
				GridViewEmployeeType.ShowFooter = true;
				BindEmployeeType();
			}
			else if (e.CommandName == "Save")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				int id = Convert.ToInt32(GridViewEmployeeType.DataKeys[row.RowIndex]["Id"].ToString());
				string description = ((TextBox)row.FindControl("TextDescription")).Text;
				bool isActive = ((CheckBox)row.FindControl("checkIsActive")).Checked;
				EmployeeType employeeType = new EmployeeType();
				employeeType.Id = id;
				employeeType.Description = description;
				employeeType.IsActive = isActive;
				MasterLogic.SaveEmployeeType(employeeType, (User)Session["User"]);
				GridViewEmployeeType.EditIndex = -1;
				GridViewEmployeeType.ShowFooter = true;
				BindEmployeeType();
			}
			else if (e.CommandName == "Insert")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				string description = ((TextBox)row.FindControl("TextDescriptionInsert")).Text;
				EmployeeType employeeType = new EmployeeType();
				employeeType.Description = description;
				MasterLogic.SaveEmployeeType(employeeType, (User)Session["User"]);
				GridViewEmployeeType.EditIndex = -1;
				GridViewEmployeeType.ShowFooter = true;
				BindEmployeeType();
			}
		}

		//Handles RowCommand of GridView of Employee Category
		protected void GridViewEmployeeCategory_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Alter")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				GridViewEmployeeCategory.EditIndex = row.RowIndex;
				GridViewEmployeeCategory.ShowFooter = false;
				BindEmployeeCategory();
			}
			else if (e.CommandName == "AlterCancel")
			{
				GridViewEmployeeCategory.EditIndex = -1;
				GridViewEmployeeCategory.ShowFooter = true;
				BindEmployeeCategory();
			}
			else if (e.CommandName == "Save")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				int id = Convert.ToInt32(GridViewEmployeeCategory.DataKeys[row.RowIndex]["Id"].ToString());
				string description = ((TextBox)row.FindControl("TextDescription")).Text;
				bool isActive = ((CheckBox)row.FindControl("checkIsActive")).Checked;
				EmployeeCategory employeeCategory = new EmployeeCategory();
				employeeCategory.Id = id;
				employeeCategory.Description = description;
				employeeCategory.IsActive = isActive;
				MasterLogic.SaveEmployeeCategory(employeeCategory, (User)Session["User"]);
				GridViewEmployeeCategory.EditIndex = -1;
				GridViewEmployeeCategory.ShowFooter = true;
				BindEmployeeCategory();
			}
			else if (e.CommandName == "Insert")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				string description = ((TextBox)row.FindControl("TextDescriptionInsert")).Text;
				EmployeeCategory employeeCategory = new EmployeeCategory();
				employeeCategory.Description = description;
				MasterLogic.SaveEmployeeCategory(employeeCategory, (User)Session["User"]);
				GridViewEmployeeCategory.EditIndex = -1;
				GridViewEmployeeCategory.ShowFooter = true;
				BindEmployeeType();
			}
		}

		//Handles RowCommand of GridView of DocumentType
		protected void GridViewDocumentType_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Alter")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				GridViewDocumentType.EditIndex = row.RowIndex;
				GridViewDocumentType.ShowFooter = false;
				BindDocumentType();
			}
			else if (e.CommandName == "AlterCancel")
			{
				GridViewDocumentType.EditIndex = -1;
				GridViewDocumentType.ShowFooter = true;
				BindDocumentType();
			}
			else if (e.CommandName == "Save")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				int id = Convert.ToInt32(GridViewDocumentType.DataKeys[row.RowIndex]["Id"].ToString());
				string description = ((TextBox)row.FindControl("TextDescription")).Text;
				bool isActive = ((CheckBox)row.FindControl("checkIsActive")).Checked;
				DocumentType documentType = new DocumentType();
				documentType.Id = id;
				documentType.Description = description;
				documentType.IsActive = isActive;
				MasterLogic.SaveDocumentType(documentType, (User)Session["User"]);
				GridViewDocumentType.EditIndex = -1;
				GridViewDocumentType.ShowFooter = true;
				BindDocumentType();
			}
			else if (e.CommandName == "Insert")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				string description = ((TextBox)row.FindControl("TextDescriptionInsert")).Text;
				DocumentType documentType = new DocumentType();
				documentType.Description = description;
				MasterLogic.SaveDocumentType(documentType, (User)Session["User"]);
				GridViewDocumentType.EditIndex = -1;
				GridViewEmployeeType.ShowFooter = true;
				BindEmployeeType();
			}
		}

		#endregion

	}
}