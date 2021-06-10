using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BusinessLogic;


namespace FirstWeb
{
	public partial class EmployeeDetails : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string id = Request.QueryString["Id"].ToString();
				Employee employee = id == "-1" ? new Employee() : EmployeeLogic.SearchEmployeesById(Convert.ToInt32(id));
				Session["SelectedEmployee"] = employee;

				PageHelper.BindListToDropDown(MasterLogic.GetAllActiveEmployeeType(), DropDownTypes, "Description", "Id");
				PageHelper.BindListToDropDown(MasterLogic.GetAllActiveEmployeeCategory(), DropDownCategories, "Description", "Id");

				TextBoxFirstName.Text = employee.FirstName;
				TextBoxMiddleName.Text = employee.MiddleName;
				TextBoxLastName.Text = employee.LastName;

				if (employee.Id > -1)
				{
					ListItem itemType = DropDownTypes.Items.FindByValue(employee.EmployeeType.Id.ToString());
					itemType.Selected = true;

					ListItem itemCategory = DropDownCategories.Items.FindByValue(employee.Category.Id.ToString());
					itemCategory.Selected = true;

					TextBoxDOB.Text = employee.DateOfBirth.ToString("dd/MM/yy");
					TextBoxDOJ.Text = employee.DateOfJoining.ToString("dd/MM/yy");
					CheckBoxIsActive.Checked = employee.IsActive;

					//bool isActive = ((CheckBox)row.FindControl("checkIsActive")).Checked;

					GridViewDocuments.DataSource = employee.EmployeeDocument;
					GridViewDocuments.DataBind();
				}
				else
				{
					employee.Category = new EmployeeCategory(Convert.ToInt32(DropDownCategories.SelectedValue), DropDownCategories.Text);
					employee.EmployeeType = new EmployeeType(Convert.ToInt32(DropDownTypes.SelectedValue), DropDownTypes.Text);
				}
				GridViewDocuments.DataSource = employee.EmployeeDocument;
				GridViewDocuments.DataBind();
				PageHelper.BindListToDropDown(MasterLogic.GetAllActiveDocumentType(), DropDownListDocumentType, "Description", "Id");
			}
		}

		protected void ButtonCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("Employees.aspx");
		}

		protected void ButtonSave_Click(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			if(employee.Id < 0)
			{
				EmployeeLogic.InsertEmployee(employee, (User)Session["User"]);
			}
			else if(employee.IsDirty)
			{
				EmployeeLogic.UpdateEmployee(employee, (User)Session["User"]);
			}
			Response.Redirect("Employees.aspx");
		}

		protected void TextBoxFirstName_TextChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			employee.FirstName = TextBoxFirstName.Text;
		}

		protected void TextBoxMiddleName_TextChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			employee.MiddleName = TextBoxMiddleName.Text;
		}

		protected void TextBoxLastName_TextChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			employee.LastName = TextBoxLastName.Text;
		}

		protected void DropDownTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			employee.EmployeeType = new EmployeeType(Convert.ToInt32(DropDownTypes.SelectedValue), DropDownTypes.Text);
		}

		protected void DropDownCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			employee.Category = new EmployeeCategory(Convert.ToInt32(DropDownCategories.SelectedValue), DropDownCategories.Text);
		}

		protected void CalendarButtonDOB_Click(object sender, ImageClickEventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			DOBCalendar.SelectedDate = employee.Id > 0 ? employee.DateOfBirth : DateTime.Today.AddYears(-18);
			DOBCalendar.VisibleDate = employee.Id > 0 ? employee.DateOfBirth : DateTime.Today.AddYears(-18);
			DOBCalendar.Visible = true;

		}

		protected void CalendarDOJ_SelectionChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			TextBoxDOJ.Text = DOJCalendar.SelectedDate.ToString("dd/MM/yy");
			employee.DateOfJoining = DOJCalendar.SelectedDate;
			DOJCalendar.Visible = false;
		}

		protected void DOBCalendar_SelectionChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			TextBoxDOB.Text = DOBCalendar.SelectedDate.ToString("dd/MM/yy");
			employee.DateOfBirth = DOBCalendar.SelectedDate;
			DOBCalendar.Visible = false;
		}

		protected void CalendarButtonDOJ_Click(object sender, ImageClickEventArgs e)
		{
			DOJCalendar.Visible = true;
		}

		protected void ButtonUpload_Click(object sender, EventArgs e)
		{
			if(FileUploadDocument.PostedFile.ContentLength > 0 && FileUploadDocument.FileName.Trim() != string.Empty)
			{
				Employee employee = (Employee)Session["SelectedEmployee"];
				employee.EmployeeDocument.Add(new EmployeeDocument(-1, FileUploadDocument.PostedFile.FileName, new DocumentType(Convert.ToInt32(DropDownListDocumentType.SelectedValue), DropDownListDocumentType.SelectedItem.Text), FileUploadDocument.PostedFile, true));
				GridViewDocuments.DataSource = employee.EmployeeDocument;
				GridViewDocuments.DataBind();
			}
		}

		protected void GridViewDocuments_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if(e.CommandName == "Download")
			{
				GridViewRow row = (GridViewRow)((Control)e.CommandSource).DataItemContainer;
				int id = Convert.ToInt32(GridViewDocuments.DataKeys[row.RowIndex]["Id"].ToString());
				Employee employee = (Employee)Session["SelectedEmployee"];
				EmployeeDocument document = null;
				foreach(EmployeeDocument employeeDocument in employee.EmployeeDocument)
				{
					if(employeeDocument.Id == id)
					{
						document = employeeDocument;
						break;
					}
				}
				string folderPath = HttpContext.Current.Server.MapPath(".") + @"\bin\EmployeeDocuments\" + employee.Id.ToString() + @"\" + document.Document.Id + @"\" +
								document.Id + @"\" + document.FileName;
				Response.AppendHeader("Content-Disposition", "attachment; filename=" + folderPath);
				Response.TransmitFile(folderPath);
				Response.End();
			}
			
		}

		protected void CheckBoxIsActive_CheckedChanged(object sender, EventArgs e)
		{
			Employee employee = (Employee)Session["SelectedEmployee"];
			employee.IsActive = CheckBoxIsActive.Checked;
		}
	}
}