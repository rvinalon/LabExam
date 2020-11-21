<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SalaryLoanOutput.aspx.cs" Inherits="LabExam.SalaryLoanOutput" %>

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
	<div runat="server" id="divNoLoanDatExist" visible="false">
		<asp:Label runat="server" ID="lblNoDetails" ForeColor="Red">No available information to display.</asp:Label><br />
		<asp:Button ID="EnterDetailsBtn" runat="server" Text="Enter loan details." OnClick="EnterDetailsBtn_Click"/>
	</div> 

	<div runat="server" id="divLoanOutput">
		<table>
			<tr>
				<td>Loan Amount</td>
				<td><asp:Label runat="server" ID="lblLoanAmount"></asp:Label></td>
			</tr>
			<tr>
				<td>Interest</td>
				<td><asp:Label runat="server" ID="lblInterest"></asp:Label></td>
			</tr>
			<tr>
				<td>Take Home Loan</td>
				<td><asp:Label runat="server" ID="lblTakeHomeLoan"></asp:Label></td>
			</tr>
			<tr>
				<td>Service Charge</td>
				<td><asp:Label runat="server" ID="lblServiceCharge"></asp:Label></td>
			</tr>
			<tr>
				<td>Monthly Amortization</td>
				<td><asp:Label runat="server" ID="lblMonthlyAmortization"></asp:Label></td>
			</tr>
		</table>

		<br />
		<br />
		<asp:Button ID="saveLoanBtn" runat="server" Text="Save Loan" OnClick="saveLoanBtn_Click"/><br />
		<asp:Label runat="server" Id="lblApplicationSaved" Visible="false">Loan application saved.</asp:Label><br />
		<br />
	</div>
</asp:Content>
