<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Employee.aspx.cs" Inherits="FirstWeb.Employee" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="EmployeeLogin">
    <div style="font-family: Georgia;">
        <p style="margin:10px 10px 10px 10px; font-size:20px;"><strong>Details</strong></p>
        <asp:Label ID="UserLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
