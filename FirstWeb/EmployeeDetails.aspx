<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="FirstWeb.EmployeeDetails" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeLogin">
	<div style="font-family: Georgia;">
		<table style="width:500px;">
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					First Name :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="TextBoxFirstName_TextChanged" ID ="TextBoxFirstName" style="width:100%"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					Middle Name :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="TextBoxMiddleName_TextChanged" ID ="TextBoxMiddleName" style="width:100%"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					Last Name :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="TextBoxLastName_TextChanged" ID ="TextBoxLastName" style="width:100%"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					Date of Birth :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:TextBox runat="server" ID ="TextBoxDOB" style="width:90%"></asp:TextBox>
					<asp:ImageButton runat="server" ImageUrl="~/images/CalendarIcon.jpg" ID="CalendarButton" Height="20px" style="padding-left:5px;" OnClick="CalendarButtonDOB_Click" />
					<asp:Calendar runat="server" OnSelectionChanged="DOBCalendar_SelectionChanged" ID="DOBCalendar" Visible="false"></asp:Calendar>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					Date of Joining :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:TextBox runat="server" ID ="TextBoxDOJ" style="width:90%"></asp:TextBox>
					<asp:ImageButton runat="server" ImageUrl="~/images/CalendarIcon.jpg" ID="ImageButton1" Height="20px" style="padding-left:5px;" OnClick="CalendarButtonDOJ_Click" />
					<asp:Calendar runat="server" OnSelectionChanged="CalendarDOJ_SelectionChanged" ID="DOJCalendar" Visible="false"></asp:Calendar>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					Employee Type :
				</td>
				<td>
					&nbsp;&nbsp;&nbsp;
				</td>
				<td>
					<asp:DropDownList runat="server" ID="DropDownTypes" OnSelectedIndexChanged="DropDownTypes_SelectedIndexChanged" style="width:100%"></asp:DropDownList>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td>
					Employee Category :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:DropDownList runat="server" ID="DropDownCategories" OnSelectedIndexChanged="DropDownCategories_SelectedIndexChanged" style="width:100%"></asp:DropDownList>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td style="text-align:center;">
					<asp:Button ID="ButtonSave" runat="server" Text="Save" style="width:50px;" OnClick="ButtonSave_Click"/>
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td>
					<asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
				</td>
			</tr>
		</table>
		
	</div>
</asp:Content>
