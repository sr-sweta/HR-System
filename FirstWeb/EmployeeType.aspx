<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EmployeeType.aspx.cs" Inherits="FirstWeb.EmployeeType" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeTypeContent">
    <div>
        <asp:GridView ID="GridViewEmployeeType" runat="server" Visible="true" AlternatingRowStyle-BackColor="WhiteSmoke" AutoGenerateColumns="false" Width="774px" Font-Type="Helvetica" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
            <Columns>
                <asp:BoundField HeaderText="Employee Type" DataField="Description" />
                <asp:BoundField HeaderText="CreatedBy" DataField="CreatedBy" />
                <asp:BoundField HeaderText="CreatedDate" DataField="CreatedDate" />
                <asp:BoundField HeaderText="IsActive" DataField="IsActive" />
                <asp:BoundField HeaderText="LastUpdatedBy" DataField="LastUpdatedBy" />
                <asp:BoundField HeaderText="LastUpdatedDate" DataField="LastUpdatedDate" />
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
         <asp:Label runat="server" ID="NoRecordLabel" Visible="false" Text="You need to logi with right credentials to view Employee Types."></asp:Label>
        <asp:DropDownList ID="DropDownListEmployeeType" AutoPostBack="true" OnSelectedIndexChanged="DropDownListEmployeeType_SelectedIndexChanged" runat="server"></asp:DropDownList>
        <asp:CheckBoxList ID="CheckBoxListEmployeeType" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxListEmployeeType_SelectedIndexChanged" runat="server">
        </asp:CheckBoxList>
        <asp:CheckBox ID="CheckBoxEmployeeType"  AutoPostBack="true" OnCheckedChanged="CheckBoxEmployeeType_CheckedChanged" runat="server" />
    </div>
</asp:Content>

