<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewRecords.aspx.cs" Inherits="LabExam.ViewRecords" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        color: #000000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3 class="auto-style3">Loan Applications</h3>
    <asp:GridView ID="gridService" runat="server"  AutoGenerateColumns="true" ></asp:GridView>
</asp:Content>
