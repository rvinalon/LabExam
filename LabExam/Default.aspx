<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LabExam.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style3 {
			margin-left: 80px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
	<div>
		<h4>Enter Required Information</h4>
		<table width="100%">
			<tr>
				<td>Basic Salary</td>
				<td>
					<asp:TextBox ID="txtBasicSalary" runat="server"></asp:TextBox><br />
					<asp:CompareValidator ID="CompareValidator" runat="server" Display="Dynamic" ControlToValidate="txtBasicSalary" Operator="DataTypeCheck" Type="Double" ErrorMessage="Provide a basic salary." ForeColor="Red"></asp:CompareValidator>
				</td>
				
			</tr>
			<tr>
				<td>Number of months to pay</td>
				<td>
					<asp:TextBox ID="txtNumberOfMonths" runat="server"></asp:TextBox><br />
					<asp:RangeValidator ID="MaxValidator" runat="server" Display="Dynamic" ControlToValidate="txtNumberOfMonths" MinimumValue="1" MaximumValue="25" ErrorMessage="Choose from 0 to 25 only." ForeColor="Red"></asp:RangeValidator>
				</td>
			</tr>
		</table>
		<br />
		<asp:Button ID="CalculateBtn" runat="server" Text="Calculate Loan" OnClick="CalculateBtn_Click"/>
	</div>
</asp:Content>
