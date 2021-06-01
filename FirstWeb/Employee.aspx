<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Employee.aspx.cs" Inherits="FirstWeb.Employee" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeLogin">
	<div style="font-family: Georgia;">
		<p style="margin: 10px 10px 10px 10px; font-size: 20px;"><strong>Details</strong></p>
		<asp:Label ID="UserLabel" runat="server" Text=""></asp:Label><br />

		<!--<asp:Label ID="UsernameLabel" runat="server" Text="Username" Style="margin: 10px 10px 10px 10px; font-size: 20px;"></asp:Label><br />
		<asp:TextBox ID="TextBoxUsername" runat="server" Text=""></asp:TextBox>
		<asp:RequiredFieldValidator Style="font-size: large; font-family:Helvetica;" ID="RequiredFieldValidatorUsername" ControlToValidate="TextBoxUsername" runat="server" ErrorMessage="Correct username required to edit"></asp:RequiredFieldValidator><br />

		<asp:Label ID="PasswordLabel" runat="server" Text="Password" Style="margin: 10px 10px 10px 10px; font-size: 20px;"></asp:Label><br />
		<asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Text=""></asp:TextBox>
		<asp:RequiredFieldValidator Style="font-size: large; font-family:Helvetica;" ID="RequiredFieldValidator1" ControlToValidate="TextBoxPassword" runat="server" ErrorMessage="Correct password required to edit"></asp:RequiredFieldValidator><br />
		-->
		<asp:Label ID="FirstNameLabel" Visible="true" runat="server" Text="First Name" Style="margin: 10px 10px 10px 10px; font-size: 20px;"></asp:Label><br />
		<asp:TextBox ID="TextBoxFirstName" Visible="true" runat="server" Text=""></asp:TextBox><br />

		<asp:Label ID="LastNameLabel" Visible="true" runat="server" Text="Last Name" Style="margin: 10px 10px 10px 10px; font-size: 20px;"></asp:Label><br />
		<asp:TextBox ID="TextBoxLastName" Visible="true" runat="server" Text=""></asp:TextBox><br />

		<asp:Button runat="server" ID="buttonCancel" CausesValidation="false" Text="Cancel"></asp:Button>
		<asp:Button runat="server" ID="buttonSave" Text="Save" OnClick="ButtonSave_Click"></asp:Button><br/>

		<asp:Label ID="LabelDOB" runat="server" Text="DOB" Style="margin: 10px 10px 10px 10px; font-size: 20px;"></asp:Label><br />
		<asp:TextBox Enabled="false" ID="DOB" runat="server"></asp:TextBox>
		<asp:ImageButton ID="DOBImageButton" Height="25px" OnClick="DOBImageButton_Click" ImageUrl="~/images/CalendarIcon.jpg" runat="server" />
		<asp:Calendar Visible="false" ID="DOBCalendar" OnSelectionChanged="DOBCalendar_SelectionChanged" runat="server"></asp:Calendar>
	</div>
</asp:Content>
