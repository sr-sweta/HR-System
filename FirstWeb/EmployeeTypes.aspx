<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EmployeeTypes.aspx.cs" Inherits="FirstWeb.EmployeeTypes" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeTypeContent">
	<style>
		.Initial{
			display:block;
			float:left;
			background-color:aquamarine;
			color:black;
			font-weight:bold;
		}
		.Clicked{
			display:block;
			float:left;
			background-color:antiquewhite;
			color:white;
			font-weight:bold;
		}
	</style>
	<div>
		<asp:Button Text="Employee Types" OnClick="ButtonEmployeeTypes_Click" BorderStyle="Solid" ID="ButtonEmployeeTypes" runat="server"/>
		<asp:Button Text="Employee Categories" OnClick="ButtonEmployeeCategories_Click" BorderStyle="Solid" ID="ButtonEmployeeCategories" runat="server" />
		<asp:Button Text="Document Type" OnClick="ButtonDocumentTypes_Click" BorderStyle="Solid" ID="ButtonDocumentTypes" runat="server" />
		<br />
		<br />
		<asp:MultiView ID="MainView" runat="server">
			<asp:View ID="ViewType" runat="server">
				<asp:GridView ShowFooter="true" OnRowCommand="GridViewEmployeeType_RowCommand" ID="GridViewEmployeeType" DataKeyNames="Id"
					EmptyDataText="No data available" runat="server" Visible="true" AlternatingRowStyle-BackColor="WhiteSmoke" AutoGenerateColumns="false" Width="774px" Font-Type="Helvetica" CellPadding="4"
					ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
					<Columns>
						<asp:TemplateField HeaderText="Employee Type">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelDescription" Text=<%#Eval("Description")%>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox runat="server" ID="TextDescription" Text=<%#Eval("Description")%>></asp:TextBox>
							</EditItemTemplate>
							<FooterTemplate>
								<asp:TextBox runat="server" ID="TextDescriptionInsert" Text=<%#Eval("Description")%>></asp:TextBox>
							</FooterTemplate>
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
								<asp:LinkButton runat="server" ID="ButtonEdit" CommandName="Alter" Text="Alter"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton runat="server" ID="ButtonSave" CommandName="Save" Text="Save"></asp:LinkButton>
								<asp:LinkButton runat="server" ID="ButtonCancel" CommandName="AlterCancel" Text="Cancel"></asp:LinkButton>
							</EditItemTemplate>
							<FooterTemplate>
								<asp:LinkButton runat="server" ID="ButtonInsert" CommandName="Insert" Text="Insert"></asp:LinkButton>
							</FooterTemplate>
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
			</asp:View>
			<asp:View ID="ViewCategory" runat="server">
				<asp:GridView ShowFooter="true" OnRowCommand="GridViewEmployeeCategory_RowCommand" ID="GridViewEmployeeCategory"  DataKeyNames="Id" EmptyDataText="No data available" runat="server" Visible="true" AlternatingRowStyle-BackColor="WhiteSmoke" AutoGenerateColumns="false" Width="774px" Font-Type="Helvetica" CellPadding="4"
					ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
					<Columns>
						<asp:TemplateField HeaderText=" Employee Category">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelDescription" Text=<%#Eval("Description")%>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox runat="server" ID="TextDescription" Text=<%#Eval("Description")%>></asp:TextBox>
							</EditItemTemplate>
							<FooterTemplate>
								<asp:TextBox runat="server" ID="TextDescriptionInsert" Text=<%#Eval("Description")%>></asp:TextBox>
							</FooterTemplate>
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
								<asp:LinkButton runat="server" ID="ButtonEdit" CommandName="Alter" Text="Alter"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton runat="server" ID="ButtonSave" CommandName="Save" Text="Save"></asp:LinkButton>
								<asp:LinkButton runat="server" ID="ButtonCancel" CommandName="AlterCancel" Text="Cancel"></asp:LinkButton>
							</EditItemTemplate>
							<FooterTemplate>
								<asp:LinkButton runat="server" ID="ButtonInsert" CommandName="Insert" Text="Insert"></asp:LinkButton>
							</FooterTemplate>
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
			</asp:View>
			<asp:View ID="ViewDocument" runat="server">
				<asp:GridView ShowFooter="true" OnRowCommand="GridViewDocumentType_RowCommand" ID="GridViewDocumentType" DataKeyNames="Id" EmptyDataText="No data available" runat="server" Visible="true" AlternatingRowStyle-BackColor="WhiteSmoke" AutoGenerateColumns="false" Width="774px" Font-Type="Helvetica" CellPadding="4"
					ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
					<Columns>
						<asp:TemplateField HeaderText="Document Type">
							<ItemTemplate>
								<asp:Label runat="server" ID="LabelDescription" Text=<%#Eval("Description")%>></asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox runat="server" ID="TextDescription" Text=<%#Eval("Description")%>></asp:TextBox>
							</EditItemTemplate>
							<FooterTemplate>
								<asp:TextBox runat="server" ID="TextDescriptionInsert" Text=<%#Eval("Description")%>></asp:TextBox>
							</FooterTemplate>
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
								<asp:LinkButton runat="server" ID="ButtonEdit" CommandName="Alter" Text="Alter"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton runat="server" ID="ButtonSave" CommandName="Save" Text="Save"></asp:LinkButton>
								<asp:LinkButton runat="server" ID="ButtonCancel" CommandName="AlterCancel" Text="Cancel"></asp:LinkButton>
							</EditItemTemplate>
							<FooterTemplate>
								<asp:LinkButton runat="server" ID="ButtonInsert" CommandName="Insert" Text="Insert"></asp:LinkButton>
							</FooterTemplate>
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
			</asp:View>
		</asp:MultiView>
	</div>
</asp:Content>

