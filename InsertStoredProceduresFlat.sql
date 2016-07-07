Use EFlats_v2
Go
Create procedure spInsertNewFlat
(
	@LandlordEmail char(50),
	@Type char(50),
	@Address char(50),
	@PostCode char(50),
	@City char(50),
	@Rent float,
	@Deposit float, 
	@AvailableFrom char(50),
	@Description char(500),

	@MessageOutput char(100) output
)
With Encryption
As
Begin

	declare @UserCount int
	/*check if landlord email exists*/
	select @UserCount = Count(Email) from Landlords where Email = @LandlordEmail
	if @UserCount > 0
		begin
			Insert into dbo.Flats
				([LandlordEmail], [Type], [Address], [PostCode], [City],
				[Rent], [Deposit], [AvailableFrom], [DateOfCreation], [Description])
			values
				(@LandlordEmail, @Type, @Address, @PostCode, @City, 
				@Rent, @Deposit, @AvailableFrom, GetDate(), @Description)
			select @MessageOutput = 'Successfully added.'
		end
	else
		select @MessageOutput = 'Unable to add flat due to nonexisting landlord email.'
End
Go
Create procedure spUpdateFlat
(
	@FlatId			int,
	@Status			char(20),
	@AvailableFrom	char(20),
	@DateOfOffer	date		
)
With encryption
As
Begin	
	if LEN(@AvailableFrom) > 1
		Update dbo.Flats set [Status] = @Status, [Date_of_offer] = @DateOfOffer, [AvailableFrom] = @AvailableFrom where [Id] = @FlatId
	else
		Update dbo.Flats set [Status] = @Status, [Date_of_offer] = @DateOfOffer where [Id] = @FlatId
End

Go
Create procedure spUpdateFlatAttributes
(
	@FlatId			int,
	@Rent			float, 
	@Deposit		float,
	@Description	char(500)
)
With Encryption
As
Begin
	if @Rent > 0
	Update dbo.[Flats] set Rent = @Rent where [Id] = @FlatId
	
	if @Deposit > 0
	Update dbo.[Flats] set Deposit = @Deposit where [Id] = @FlatId

	if Len(@Description) > 1
	Update dbo.[Flats] set [Description] = @Description where [Id] = @FlatId
End




