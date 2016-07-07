Create Database EFlats_v2
Go
Use EFlats_v2
Go
Create Table Students
(
	Email				char(100)	NOT NULL	UNIQUE,
	[Password]			char(100)	NOT NULL,
	Salt				char(50)	NOT NULL,
	ConfirmationCode	char(50)	NOT NULL,
	Confirmed			bit			NOT NULL,
	Student				bit			NOT NULL,

	Score				int			NOT NULL,
	NumberOfChildren	int			NOT NULL,
	Pet					bit			NOT NULL,
	NumberOfCohabitors	int			NOT NULL,
	[Disabled]			bit			NOT NULL,
	DateOfCreation		date		NOT NULL,

	Name				char(30)	NOT NULL,
	Surname				char(30)	NOT NULL,
	[Address]			char(50)	NOT NULL,
	PostCode			char(10)	NOT NULL,
	City				char(50)	NOT NULL,
	Country				char(50)	NOT NULL,
	Phone				char(50)	NOT NULL,


	CONSTRAINT Students_Pk
		PRIMARY KEY (Email)	
)
Go
Create Table Landlords
(
	Email				char(100)	NOT NULL	UNIQUE,
	[Password]			char(100)	NOT NULL,
	Salt				char(50)	NOT NULL,
	Confirmed			bit			NOT NULL,
	DateOfCreation		date		NOT NULL,
	
	Name				char(30)	NOT NULL,
	[Address]			char(50)	NOT NULL,
	PostCode			char(10)	NOT NULL,
	City				char(50)	NOT NULL,
	Country				char(50)	NOT NULL,
	ContactPerson		char(50)	NOT NULL,
	Phone				char(50)	NOT NULL,

	CONSTRAINT Landlords_Pk
		PRIMARY KEY (Email)	
)
Go

Create Table Flats
(
	Id					int			NOT NULL	Unique Identity(1,1),
	LandlordEmail		char(100)	NOT NULL,
	[Type]				char(20)	NOT NULL,
	[Address]			char(50)	NOT NULL,
	PostCode			char(10)	NOT NULL,
	City				char(50)	NOT NULL, 
	Rent				float  		NOT NULL,
	Deposit				float 		NOT NULL,
	AvailableFrom		char(50)	NOT NULL,		
	DateOfCreation		date 		NOT NULL,
	[Description]		char(500)	NOT NULL,
	[Status]			char(20)	NOT NULL	Default 'Open',
	DateOfOffer			char(50)	NOT NULL	Default 'None',

	Constraint FlatsPK
		Primary key (Id),

	Constraint FlatLandlordFk
		Foreign key (LandlordEmail) references Landlords(Email)
)
Go
Create Table Applications
(
	Id					int			not null unique identity(1,1),
	StudentEmail		char(100)	not null, 
	FlatId				int			not null, 
	DateOfCreation		date		not null,
	Score				int			not null,
	QueueNumber			int			not null,

	Constraint ApplicationsPk
		Primary key (Id),
	Constraint ApplicationsStudentsFk
		Foreign key (StudentEmail) references Students(Email),
	Constraint ApplicationsFlatsFk
		Foreign key	(FlatId) references Flats(Id),
)
Go
Create Table Admins
(
	Username		char(50)		not null	Unique,
	[Password]		char(100)		not null,
	Salt			char(50)		not null,

	Constraint AdminsPk
		Primary key (Username)
)
Go
Create Table Confirmed
(
	Id					int				not null		unique		identity(1,1),
	FlatId				int				not null,
	StudentEmail		char(100)		not null,
	LandlordEmail		char(100)		not null,
	DateOfOffer			char(50)		not null,
	DateOfConfirmation	date			not null		default GetDate(),

	Constraint ConfirmedPk
		Primary key (id),
	Constraint ConfirmedFlatsFk
		Foreign key (FlatId) references dbo.Flats(Id),
	Constraint ConfrimedStudentsFk
		Foreign key (StudentEmail) references dbo.Students(Email),
	Constraint ConfirmedLandlordsFk
		Foreign key (LandlordEmail) references dbo.Landlords(Email)
)



drop table Confirmed



