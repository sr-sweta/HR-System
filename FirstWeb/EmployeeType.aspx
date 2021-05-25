<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EmployeeType.aspx.cs" Inherits="FirstWeb.EmployeeType" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeTypeContent">
<div>
    <asp:GridView ID="GridViewEmployeeType" runat="server" AlternatingRowStyle-BackColor="WhiteSmoke" BackColor="Yellow" Width="548px">
        <Columns>
            <asp:BoundField HeaderText="Employee Type" DataField="Description" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>

