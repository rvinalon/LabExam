<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LabExam.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 86%;
        }
        .auto-style4 {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            color: #000000;
            font-size: small;
        }
        .auto-style5 {
            font-size: medium;
        }
        .auto-style6 {
            font-size: medium;
            width: 72px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div>
        <asp:Label runat="server" id="lblIncorrectLogin" ForeColor="Red" Visible="false">Incorrect password. Please try again or Register new account.</asp:Label>
        <table class="auto-style3">
            <tr class="auto-style4">
                <td class="auto-style6">Username</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="auto-style4">
                <td class="auto-style6">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr class="auto-style4">
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
                </td>
            </tr>
               <tr class="auto-style4">
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
