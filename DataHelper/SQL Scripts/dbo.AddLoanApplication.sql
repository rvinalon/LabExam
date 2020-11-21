CREATE PROCEDURE [dbo].[AddLoanApplication]
	@EmailAdd nvarchar(150),
	@LoanAmount decimal(18,2),
	@Interest decimal(18,2),
	@InterestRate decimal(18,4),
	@TakeHomeLoan decimal(18,2),
	@ServiceCharge decimal(18,2),
	@MonthlyAmortization decimal(18,2)
AS BEGIN
	INSERT INTO LoanApplication (EmailAdd, LoanAmount, Interest, InterestRate, TakeHomeLoan, ServiceCharge, MonthlyAmortization)
	VALUES (@EmailAdd, @LoanAmount, @Interest, @InterestRate, @TakeHomeLoan, @ServiceCharge, @MonthlyAmortization)
END