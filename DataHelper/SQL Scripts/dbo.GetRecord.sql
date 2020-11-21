CREATE PROCEDURE [dbo].[GetRecord]
	@Username nvarchar(150),
	@Password nvarchar(150)
AS
	SELECT * FROM dbo.CustomerInfo WHERE EmailAdd = @Username AND PassWord = @Password
RETURN 0