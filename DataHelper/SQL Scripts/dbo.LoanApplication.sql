CREATE TABLE [dbo].[LoanApplication] (
    [EmailAdd]            NVARCHAR (150)  NULL,
    [LoanAmount]          DECIMAL (18, 2) NULL,
    [Interest]            DECIMAL (18, 2) NULL,
    [InterestRate]        DECIMAL (18, 4) NULL,
    [TakeHomeLoan]        DECIMAL (18, 2) NULL,
    [ServiceCharge]       DECIMAL (18, 2) NULL,
    [MonthlyAmortization] DECIMAL (18, 2) NULL
);

