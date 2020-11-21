<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LabExam.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 113%;
    }
    .auto-style4 {
        font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        font-size: medium;
        color: #000000;
    }
    .auto-style5 {
        width: 128px;
    }
</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style3">
    <tr class="auto-style4">
        <td class="auto-style5">First Name</td>
        <td>
            <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="auto-style4">
        <td class="auto-style5">Last Name</td>
        <td>
            <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="auto-style4">
        <td class="auto-style5">E-Mail Address</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="auto-style4">
        <td class="auto-style5">Password</td>
        <td>
            <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr class="auto-style4">
        <td class="auto-style5">Confirm Password</td>
        <td>
            <asp:TextBox ID="txtConPass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassWord" ControlToValidate="txtConPass" ErrorMessage="Confirm Password does not match to Password" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr class="auto-style4">
        <td class="auto-style5">&nbsp;</td>
        <td>
            <asp:Button ID="btnSave" runat="server" Text="Save" Width="128px" OnClick="BtnSave_Click" />
        </td>
    </tr>
</table>
</asp:Content>
