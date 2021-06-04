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
				}
				else
				{
					employee.Category = new EmployeeCategory(Convert.ToInt32(DropDownCategories.SelectedValue), DropDownCategories.Text);
					employee.Category = new EmployeeCategory(Convert.ToInt32(DropDownCategories.SelectedValue), DropDownCategories.Text);
				}
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
	}
}