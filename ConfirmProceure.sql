Use EFlats_v2
Go
Create procedure spConfirmTenants
(
	@FlatId			int,
	@StudentEmail	char(100),

	@Output bit output
)
With Encryption
As
Begin
	declare @LandlordEmail char(100)
	declare @DateOfOffer   date
	declare @FlatIdCount   int
	declare @StudentEmailCount char(50)

	select @StudentEmailCount = Count(Email) from dbo.Students where Email = @StudentEmail
	select @FlatIdCount = Count(Id) from dbo.Flats where Id = @FlatId

	if(@StudentEmailCount is not null AND @FlatIdCount > 0)
		begin
			select @LandlordEmail = LandlordEmail from dbo.Flats where Id = @FlatId
			select @DateOfOffer = Date_of_offer from dbo.Flats where Id = @FlatId

			Insert into dbo.Confirmed values(@FlatId, @StudentEmail, @LandlordEmail, @DateOfOffer, GetDate()) 
			select @Output = 1
		end
	else
		select @Output = 0

End
Go
Create procedure spGetConfirmedFlats
(
	@LandlordEmail		char(100)
)
With Encryption
As
Begin
	select * from dbo.Confirmed where LandlordEmail = @LandlordEmail
End