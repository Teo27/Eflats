/*Create Procedures*/
Use EFlats_v2
Go
Create procedure spInsertNewStudent
(
	@Email				char(100),
	@Password			char(100),
	@Salt				char(50),
	/*add confirmation code*/
	@Name				char(50),
	@Surname			char(50),
	@Address			char(50),
	@PostCode			char(50),
	@City				char(50),
	@Country			char(50),
	@Phone				char(50)
)
With Encryption
As
Begin
	Insert Into dbo.Students
	(
		[Email],
		[Password],
		[Salt],
		[ConfirmationCode],
		[Confirmed],
		[Student],
		[Score],
		[NumberOfChildren],
		[Pet],
		[NumberOfCohabitors],
		[Disabled],
		[DateOfCreation],
		[Name],
		[Surname],
		[Address],
		[PostCode],
		[City],
		[Country],
		[Phone]
	)
	Values
	(
		@Email,
		@Password,
		@Salt,
		0, /*confirmation code*/
		0, /*confirmed*/
		0, /*student*/
		0, /*score*/
		0, /*number of children*/
		0, /*pet*/
		0, /*number of cohabitors*/
		0, /*disabled*/
		GetDate(),
		@Name,
		@Surname,
		@Address,
		@PostCode,
		@City,
		@Country,
		@Phone
	)
End

Go
Create procedure spInsertNewLandlord
(
	@Email				char(100),
	@Password			char(100),
	@Salt				char(50),
	@Name				char(50),
	@Address			char(50),
	@PostCode			char(50),
	@City				char(50),
	@Country			char(50),
	@ContactPerson		char(50),
	@Phone				char(50)
)
With Encryption
As
Begin
	Insert Into dbo.Landlords
	(
		[Email],
		[Password],
		[Salt],
		[Confirmed],
		[DateOfCreation],
		[Name],
		[Address],
		[PostCode],
		[City],
		[Country],
		[ContactPerson],
		[Phone]
	)
	Values
	(
		@Email,
		@Password,
		@Salt,
		0, /*confirmed*/
		GetDate(),
		@Name,
		@Address,
		@PostCode,
		@City,
		@Country,
		@ContactPerson,
		@Phone
	)
End


/*CHECK*/
Go
Create procedure spCheckExistingEmail
(
	@Email char(50),
	@UserCount int output	
)
With encryption
As
begin
	declare @UserCountStudent int
	declare @UserCountLandlord int
	select @UserCountStudent = Count(Email) from Students where email = @Email
	select @UserCountLandlord = Count(Email) from Landlords where email = @Email

	if @UserCountStudent = 0 AND @UserCountLandlord = 0
		begin
		select @UserCount = 0
		end
	else
		begin
		select @UserCount = 1
		end
end
Go
Create procedure spExecuteInsertStudent
(
	@EmailInput				char(50),
	@PasswordInput			char(100),
	@SaltInput				char(50),
	/*confirmation input*/
	@NameInput				char(50),
	@SurnameInput			char(50),
	@AddressInput			char(50),
	@PostCodeInput			char(50),
	@CityInput				char(50),
	@CountryInput			char(50),
	@PhoneInput				char(50),

	@MessageOutput			char(100)	output
)
with encryption
as
begin
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE 
	BEGIN TRY
	declare @TotalCount int
	execute spCheckExistingEmail @UserCount = @TotalCount output, @Email = @EmailInput
	if @TotalCount = 0
		begin
			execute spInsertNewStudent @Email = @EmailInput, @Password = @PasswordInput,@Salt = @SaltInput, @Name = @NameInput, @Surname = @SurnameInput, @Address = @AddressInput, @PostCode = @PostcodeInput, @City = @CityInput, @Country = @CountryInput, @Phone = @PhoneInput	
			select @MessageOutput = 'Registration successful.'
		end
	else
		begin
			select @MessageOutput = 'Registration has failed due to the existing Email.'
		end 
	END TRY
	BEGIN CATCH
		select @MessageOutput = 'Error.'
	END CATCH
end

Go
Create procedure spExecuteInsertLandlord
(
	@EmailInput				char(50),
	@PasswordInput			char(100),
	@SaltInput				char(50),
	/*confirmation input*/
	@NameInput				char(50),
	@AddressInput			char(50),
	@PostCodeInput			char(50),
	@CityInput				char(50),
	@CountryInput			char(50),
	@ContactPersonInput		char(50),
	@PhoneInput				char(50),

	@MessageOutput			char(100)	output
)
with encryption
as
begin
	BEGIN TRY
	declare @TotalCount int
	execute spCheckExistingEmail @UserCount = @TotalCount output, @Email = @EmailInput
	if @TotalCount = 0
		begin
			execute spInsertNewLandlord @Email = @EmailInput, @Password = @PasswordInput, @Salt = @SaltInput, @Name = @NameInput, @Address = @AddressInput, @PostCode = @PostcodeInput, @City = @CityInput, @Country = @CountryInput, @ContactPerson = @ContactPersonInput, @Phone = @PhoneInput	
			select @MessageOutput = 'Registration successful.'
		end
	else
		begin
			select @MessageOutput = 'Registration has failed due to the existing Email.'
		end 
	END TRY
	BEGIN CATCH
		select @MessageOutput = 'Error.'
	END CATCH
end

drop procedure spExecuteInsertLandlord
drop procedure spExecuteInsertStudent
drop procedure spInsertNewLandlord



