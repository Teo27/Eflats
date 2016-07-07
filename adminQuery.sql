Use EFlats_v2
Go
Create procedure psGetAdminsSalt
(
	@Username	 char(50),
	@Salt		 char(50) output
)
With Encryption
As
Begin

	select @Salt = [Salt] from dbo.Admins where [Username] = @Username
End
Go
Create procedure spCheckAdminLoginInput
(
	@Username	char(50),
	@Password	char(100),

	@MessageOutput int output
)
With Encryption
As
Begin
	declare @UsernameCount int
	declare @PasswordCount int
	select @UsernameCount = Count([Username]) from dbo.Admins where [Username] = @Username
	if @UsernameCount > 0
		begin
			select @PasswordCount = count([Username]) from dbo.Admins where [Username] = @Username And [Password] = @Password
			if @PasswordCount > 0
				select @MessageOutput = 1
			else
				select @MessageOutput = 2			  
		end
	else
		select @MessageOutput = 3
End
Go
Create procedure spGetTableData
(
	@SelectedTable	char(50)
)
With Encryption
As
Begin
	if @SelectedTable = 'Students'
		Select * from dbo.Students
	else if @SelectedTable = 'Landlords'
		Select * from dbo.Landlords
	else if @SelectedTable = 'Admins'
		Select * from dbo.Admins
	else if @SelectedTable = 'Flats'
		Select * from dbo.Flats
	else if @SelectedTable = 'Applications'
		Select * from dbo.Applications
End

