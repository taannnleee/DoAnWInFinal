CREATE TABLE MortgageLoan(
	LoanID int,
	AccountNumber nvarchar(100),
	CustomerName nvarchar(100),
	LoanAmount nvarchar(100),
	LoanPeriod int,
	Collateral nvarchar(100),
	LoanPayable nvarchar(100),
	LoanStatus nvarchar(100),
	StartLoan datetime,
	EndLoan datetime
);