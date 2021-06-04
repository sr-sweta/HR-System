<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Employees.aspx.cs" Inherits="FirstWeb.Employees" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeLogin">
	<div style="font-family: Georgia; min-width:500px; text-align:left;">
		<asp:Label runat="server">Name:</asp:Label>&nbsp;&nbsp;&nbsp;<asp:TextBox runat="server" ID="TextBoxName"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
		<asp:Label runat="server">Type:</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList runat="server" ID="DropDownTypes"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
		<asp:Label runat="server">Category:</asp:Label>&nbsp;&nbsp;&nbsp;<asp:DropDownList runat="server" ID="DropDownCategories"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
		<asp:CheckBox ID="CheckDeleted" runat="server" Text="Include Delete" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="ButtonSearch" Text="Search" runat="server" OnClick="ButtonSearch_Click" />
		<br />
		<br />
		<asp:GridView ID="GridViewEmployees" DataKeyNames="Id" OnRowEditing="GridViewEmployees_RowEditing" EmptyDataText="No data available" runat="server" Visible="true" 
			AlternatingRowStyle-BackColor="WhiteSmoke" AutoGenerateColumns="false" Width="811px" Font-Type="Helvetica" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC"
			BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
					<Columns>
						<asp:TemplateField HeaderText="FirstName">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelFirstName" Text=<%#Eval("FirstName")%>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox runat="server" ID="TextFirstName" Text=<%#Eval("FirstName")%>></asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="CreatedBy">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelCreatedBy" Text=<%#Eval("CreatedBy") %>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:Label runat="server" ID="LabelCreatedByEdit" Text=<%#Eval("CreatedBy") %>></asp:Label>
							</EditItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="CreatedDate">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelCreatedDate" Text=<%#Eval("CreatedDate") %>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:Label runat="server" ID="LabelCreatedDateEdit" Text=<%#Eval("CreatedDate") %>></asp:Label>
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
						<asp:TemplateField HeaderText="LastUpdatedBy">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelLastUpdatedBy" Text=<%#Eval("LastUpdatedBy") %>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:Label runat="server" ID="LabelLastUpdatedByEdit" Text=<%#Eval("LastUpdatedBy") %>></asp:Label>
							</EditItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="LastUpdatedDate">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelLastUpdatedDate" Text=<%#Eval("LastUpdatedDate") %>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:Label runat="server" ID="LabelLastUpdatedDateEdit" Text=<%#Eval("LastUpdatedDate") %>></asp:Label>
							</EditItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField>
							<ItemTemplate>
								<asp:LinkButton ID="Edit" CommandName="Edit" Text="Edit" runat="server"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateField>
					</Columns>
					<FooterStyle BackColor="#CCCCCC" />
					<HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
					<PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
					<RowStyle BackColor="White" />
					<SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
					<SortedAscendingCellStyle BackColor="#F1F1F1" />
					<SortedAscendingHeaderStyle BackColor="#808080" />
					<SortedDescendingCellStyle BackColor="#CAC9C9" />
					<SortedDescendingHeaderStyle BackColor="#383838" />
				</asp:GridView>
		<asp:Button Style="padding-top:10px; background-color:black; color:white;text-align:center;" ID="ButtonNew" runat="server" OnClick="ButtonNew_Click" Text="New Employee" />
	</div>
</asp:Content>
