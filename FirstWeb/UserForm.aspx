<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UserForm.aspx.cs" Inherits="FirstWeb.UserForm" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="UserLogin">
    <div style="background-color: aqua; height: 250px; width: 300px;">
        <table style="width: 100%">
            <tr>
                <td colspan="2" style="font-weight: bold; text-align: center">Login Credentials</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">Username:</td>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxUsername"></asp:TextBox>
                    <asp:RequiredFieldValidator Style="font-size: small" ID="RequiredFieldValidatorUsername" ControlToValidate="TextBoxUsername" runat="server" ErrorMessage="Please enter correct username."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">Password:</td>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxPassword" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator Style="font-size: small" ID="RequiredFieldValidatorPassword" ControlToValidate="TextBoxPassword" runat="server" ErrorMessage="Please enter correct password."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: center;">
                    <asp:Button runat="server" ID="buttonCancel" CausesValidation="false" Text="Cancel"></asp:Button></td>
                <td style="text-align: center;">
                    <asp:Button runat="server" ID="buttonSave" Text="Save" OnClick="ButtonSave_Click"></asp:Button></td>
            </tr>
        </table>
    </div>
</asp:Content>
