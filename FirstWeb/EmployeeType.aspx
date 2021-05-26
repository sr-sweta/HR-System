﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EmployeeType.aspx.cs" Inherits="FirstWeb.EmployeeType" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeTypeContent">
    <div>
    <asp:GridView ID="GridViewEmployeeType" runat="server" AlternatingRowStyle-BackColor="WhiteSmoke" Width="548px" Font-Type="Helvetica" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
        <Columns>
            <asp:BoundField HeaderText="Employee Type" DataField="Description" />
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

