use EFlats_v2
Go
Create procedure spGetUserType
(
	@Email char(50),
	@MessageOutput char(100) output
)
With Encryption
As
Begin
	declare @UserCountStudent int
	declare @UserCountLandlord int
	select @UserCountStudent = Count(Email) from Students where Email = @Email
	select @UserCountLandlord = Count(Email) from Landlords where Email = @Email
	If @UserCountStudent > 0
		select @MessageOutput = 'Student'
	else if @UserCountLandlord > 0
		select @MessageOutput = 'Landlord'
	else
		select @MessageOutput = 'User type not found'
End
Go
Create procedure spGetStudentData
(
	@Email char(50)
)
With Encryption
As
Begin
	select [Email], [Confirmed], [Student], [Score], [NumberOfChildren], [Pet], [NumberOfCohabitors], [Disabled],
			[DateOfCreation], [Name], [Surname], [Address], [PostCode], [City], [Country], [Phone] 
	from Students 
	where [Email] = @Email
End
Go
Create procedure spGetLandlordData
(
	@Email char(50)
)
With Encryption
As
Begin
	select [Email], [Confirmed], [DateOfCreation], [Name], [Address], [PostCode], [City], [Country], [ContactPerson], [Phone] 
	from Landlords 
	where [Email] = @Email
End
Go
Create procedure spGetAllFlatsData
With Encryption
As
Begin
	select * from Flats
End
Go
Create procedure spGetApplications
(	
	@StudentEmail char(50),
	@FlatId int
)
With Encryption
As
Begin
	declare @StudentCount int
	declare @FlatCount int
	declare @ApplicationCount int
	/*checks*/
	select @StudentCount = Count([Email]) from dbo.Students where [Email] = @StudentEmail
	select @FlatCount = Count([Id]) from dbo.Flats where [Id] = @FlatId
	select @ApplicationCount = Count([Id]) from dbo.Applications where [StudentEmail] = @StudentEmail And [FlatId] = @FlatId

	if @StudentCount > 0 And @FlatCount > 0 And @ApplicationCount = 0
		Select * from Applications where [FlatId] = @FlatId
End
Go
Create procedure spGetApplicationsToRemove
(	
	@StudentEmail char(50),
	@FlatId int
)
With Encryption
As
Begin
	declare @FlatCount int
	declare @ApplicationCount int
	/*checks*/
	select @FlatCount = Count([Id]) from dbo.Flats where [Id] = @FlatId

	if @FlatCount > 0
		Select * from Applications where [FlatId] = @FlatId
End
Go
Create procedure psGetWishListTableStudent
(
	@StudentEmail char(50)
)
With Encryption
As
Begin
	Select Applications.FlatId, Applications.QueueNumber, Flats.[Address] FROM Applications INNER JOIN Flats ON Applications.FlatId = Flats.Id AND Applications.StudentEmail = @StudentEmail
End
Go
Create procedure spGetAllApplications
With Encryption
As
Begin
	Select * from Applications;
End
Go
Create procedure spGetFlatsLandlord
(
	@LandlordEmail	char(50)
)
With Encryption 
As
Begin
	select * from dbo.Landlords where email = @LandlordEmail
End
Go
Create Procedure spUpdateApplication
(
	@QueueNumber int,
	@Id			 int
)
With Encryption
As
Begin
	Update dbo.Applications set QueueNumber = @QueueNumber where Id = @Id;
End


