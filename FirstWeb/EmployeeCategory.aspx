<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EmployeeCategory.aspx.cs" Inherits="FirstWeb.EmployeeCategory" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeCategoryContent">
    <div>
    <asp:GridView ID="GridViewEmployeeCategory" runat="server" AlternatingRowStyle-BackColor="WhiteSmoke" Width="548px" Font-Type="Helvetica" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
        <Columns>
            <asp:BoundField HeaderText="Employee Category" DataField="Description" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC"/>
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</div>
</asp:Content>
