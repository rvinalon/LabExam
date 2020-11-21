CREATE PROCEDURE [dbo].SaveRecords
	@FirstName nvarchar(150),
	@LastName nvarchar(150),
	@EmailAdd nvarchar(150),
	@PassWord nvarchar(150)

AS
	INSERT INTO CustomerInfo (FirstName, LastName, EmailAdd, PassWord)
	VALUES (@FirstName, @LastName, @EmailAdd,@PassWord)
RETURN 0