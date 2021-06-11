<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="FirstWeb.EmployeeDetails" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeLogin">
	<div style="font-family: Georgia;text-align:right; margin-right:10px;">
		<table >
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3" >
					First Name :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2" >
					<asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="TextBoxFirstName_TextChanged" ID ="TextBoxFirstName" style="width:80%"></asp:TextBox>
					<asp:RequiredFieldValidator Style="font-size: large; font-family:Helvetica;" ID="RequiredFieldValidatorFirstName" ControlToValidate="TextBoxFirstName" runat="server" ErrorMessage="Compulsory detail"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3" >
					Middle Name :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2">
					<asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="TextBoxMiddleName_TextChanged" ID ="TextBoxMiddleName" style="width:80%"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3">
					Last Name :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2" >
					<asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="TextBoxLastName_TextChanged" ID ="TextBoxLastName" style="width:80%"></asp:TextBox>
					<asp:RequiredFieldValidator Style="font-size: large; font-family:Helvetica;" ID="RequiredFieldValidatorLastName" ControlToValidate="TextBoxLastName" runat="server" ErrorMessage="Compulsory Detail"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3">
					Date of Birth :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2" >
					<asp:TextBox runat="server" ID ="TextBoxDOB" style="width:75%"></asp:TextBox>					
					<asp:ImageButton runat="server" ImageUrl="~/images/CalendarIcon.jpg" CausesValidation="false" ID="CalendarButton" Height="20px" style="padding-left:5px;" OnClick="CalendarButtonDOB_Click" />
					<asp:Calendar runat="server" OnSelectionChanged="DOBCalendar_SelectionChanged" ID="DOBCalendar" Visible="false"></asp:Calendar>

				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3" >
					Date of Joining :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2" >
					<asp:TextBox runat="server" ID ="TextBoxDOJ" style="width:75%"></asp:TextBox>
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
				<td class="auto-style3">
					Employee Type :
				</td>
				<td>
					&nbsp;&nbsp;&nbsp;
				</td>
				<td class="auto-style2">
					<asp:DropDownList runat="server" ID="DropDownTypes" OnSelectedIndexChanged="DropDownTypes_SelectedIndexChanged" style="width:80%"></asp:DropDownList>
					<asp:RequiredFieldValidator Style="font-size: large; font-family:Helvetica;" ID="RequiredFieldValidatorType" ControlToValidate="DropDownTypes" runat="server" ErrorMessage="Compulsory detail"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3">
					Employee Category :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2" >
					<asp:DropDownList runat="server" ID="DropDownCategories" style="width:80%"></asp:DropDownList>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3">
					IsActive :
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2" style="text-align:left;" >
					<asp:CheckBox runat="server" ID="CheckBoxIsActive" style="margin-left:90px;" checked=<%#Eval("IsActive") %> OnCheckedChanged="CheckBoxIsActive_CheckedChanged"></asp:CheckBox>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td style="text-align:center;" colspan="3">
					Document Type : &nbsp;&nbsp;<asp:DropDownList runat="server" ID="DropDownListDocumentType"></asp:DropDownList>
					<asp:FileUpload runat="server" style="margin-left:30%;margin-top:10px;" ID="FileUploadDocument"/>&nbsp;&nbsp;
					<asp:Button ID="ButtonUpload" runat="server" Text="Upload" OnClick="ButtonUpload_Click"/>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td colspan="3" style="text-align:right;margin-left:10%;">
					<asp:GridView OnRowCommand="GridViewDocuments_RowCommand" DataKeyNames="Id" runat="server" AutoGenerateColumns="false" ID="GridViewDocuments" Width="100%">
						<Columns>
							<asp:TemplateField HeaderText="Document Type">
								<ItemTemplate>
									<asp:Label runat="server" ID="LabelDocumentType" Text=<%#Eval("DocumentTypeText") %>></asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:Label runat="server" ID="LabelDocumentTypeEdit" Text=<%#Eval("DocumentTypeText") %>></asp:Label>
								</EditItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="FileName">
								<ItemTemplate>
									<asp:Label runat="server" ID="LabelFileName" Text=<%#Eval("FileName") %>></asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:Label runat="server" ID="LabelFileNameEdit" Text=<%#Eval("FileName") %>></asp:Label>
								</EditItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="IsActive">
								<ItemTemplate>
									<asp:Label runat="server" ID="LabelIsActive" Text=<%#Eval("IsActiveText") %>></asp:Label>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:CheckBox runat="server" Style="text-align:center;" ID="CheckIsActive" checked=<%#Eval("IsActive") %>></asp:CheckBox>
								</EditItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField>
								<ItemTemplate>
									<asp:LinkButton ID="ButtonDelete" runat="server" CommandName="Remove" Text="Delete"></asp:LinkButton>
									<asp:LinkButton ID="ButtonDownload" runat="server" CommandName="Download" Text="Download"></asp:LinkButton>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:LinkButton runat="server" ID="ButtonSave" CommandName="Save" Text="Save"></asp:LinkButton>
									<asp:LinkButton runat="server" ID="ButtonCancel" CommandName="AlterCancel" Text="Cancel"></asp:LinkButton>
								</EditItemTemplate>
							</asp:TemplateField>
						</Columns>
					</asp:GridView>
				</td>
			</tr>
			<tr>
				<td colspan="3">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td class="auto-style3">
					<asp:Button ID="ButtonSave" runat="server" style="background-color:royalblue;" Text="Save" OnClick="ButtonSave_Click" Width="63px"/>
				</td>
				<td>
					&nbsp;&nbsp;
				</td>
				<td class="auto-style2">
					<asp:Button ID="ButtonCancel" runat="server" style="background-color:royalblue;margin-left:50px;" Text="Cancel" OnClick="ButtonCancel_Click" CssClass="auto-style4" Width="67px"/>
				</td>
			</tr>
		</table>
		
	</div>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
	<style type="text/css">
		.auto-style1 {
			width: 304px;
		}
		.auto-style2 {
			width: 458px;
		}
		.auto-style3 {
			width: 383px;
		}
		.auto-style4 {
			margin-left: 78px;
		}
	</style>
</asp:Content>


