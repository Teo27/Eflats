use EFlats_v2
Go
Create procedure spCheckLoginInput
(
	@Email		char(50),
	@Password	char(100),

	@MessageOutput char(100) output
)
With Encryption
As
Begin
	declare @EmailCount int
	declare @EmailPasswordCountStudent  int
	declare @EmailPasswordCountLandlord int
	/*check email*/
	execute spCheckExistingEmail @UserCount = @EmailCount output, @Email = @Email
	if @EmailCount > 0
		begin
			select @EmailPasswordCountStudent = count(Email) from dbo.Students where [Email] = @Email And [Password] = @Password
			select @EmailPasswordCountLandlord = count(Email) from dbo.Landlords where [Email] = @Email And [Password] = @Password
			if @EmailPasswordCountStudent > 0 OR @EmailPasswordCountLandlord > 0
				select @MessageOutput = 'You have successfully logged in.'
			else
				select @MessageOutput = 'Incorrect Password.'			  
		end
	else
		select @MessageOutput = 'Incorrect Email.'
End
Go
Create procedure psGetUsersSalt
(
	@Email char(50),
	@Salt  char(50) output
)
With Encryption
As
Begin

	select @Salt = [Salt] from Students where [Email] = @Email
	if @Salt is null
		Select @Salt = [Salt] from Landlords where [Email] = @Email	
End

drop procedure spCheckLoginInput