Use EFlats_v2
Go
Select * from dbo.Students
Select * from dbo.Landlords
select * from dbo.Admins
select * from dbo.Flats
select * from dbo.Applications

declare @FlatId int
select @FlatId = [Id] from dbo.Flats where [LandlordEmail] = 'defaultLandlord@default.com'
execute dbo.spGetApplications @StudentEmail = 'defaultStudent2@default.com', @FlatId = @FlatId

alter database EFlats_v2 set allow_snapshot_isolation off
/*Run before unit testing*/
Use EFlats_v2
delete from dbo.Applications
delete from dbo.Confirmed
Go
delete from dbo.Flats
Go
delete from dbo.Students
delete from dbo.Landlords
delete from dbo.Admins
Go
insert into dbo.Admins values('admin', 'admin', 'salt')
execute dbo.spExecuteInsertStudent 'defaultStudent@default.com',
 'password', 'salt', 'name', 'surname', 'address', 'postCode', 'city', 'country', 'phone', ''
execute dbo.spExecuteInsertStudent 'defaultStudent3@default.com',
 'password', 'salt', 'name', 'surname', 'address', 'postCode', 'city', 'country', 'phone', ''
execute dbo.spExecuteInsertLandlord 'defaultLandlord@default.com',
 'password', 'salt', 'name', 'address', 'postCode', 'city', 'country', 'contactPerson', 'phone', ''
execute dbo.spInsertNewFlat 'defaultLandlord@default.com', 
'type', 'Porthusgade', 'postCode', 'city', 1000, 1000, '2015-12-01', 'description', ''
Go
declare @FlatId int
select @FlatId = [Id] from dbo.Flats where [LandlordEmail] = 'defaultLandlord@default.com'
insert into dbo.Applications([StudentEmail], [FlatId], [DateOfCreation], [Score], [QueueNumber])
values('defaultStudent@default.com', @FlatId,  '2015-11-11', 10, 1)
insert into dbo.Applications([StudentEmail], [FlatId], [DateOfCreation], [Score], [QueueNumber])
values('defaultStudent3@default.com', @FlatId,  '2015-11-11', 100, 1)
select [FlatId], [StudentEmail] from dbo.Applications where [FlatId] = @FlatId
 /*delete*/

 execute dbo.spInsertNewFlat 'defaultLandlord@default.com', 
'type', 'Porthusgade1', '9000', 'city', 700, 5000, '2015-12-01', 'description', ''

execute dbo.spInsertNewFlat 'defaultLandlord@default.com', 
'type', 'Porthusgade2', '9000', 'city', 1000, 2500, '2015-12-01', 'description', ''

execute dbo.spInsertNewFlat 'defaultLandlord@default.com', 
'type', 'Porthusgade3', '9000', 'city', 10, 10, '2015-12-01', 'description', ''

execute dbo.spInsertNewFlat 'defaultLandlord@default.com', 
'type', 'Porthusgade4', '9000', 'city', 900, 1000, '2015-12-01', 'description', ''

execute dbo.spInsertNewFlat 'defaultLandlord@default.com', 
'type', 'Porthusgade5', '9000', 'city', 700, 3500, '2015-12-01', 'description', ''

 select Id from flats where LandlordEmail = 'defaultLandlord@default.com'

 Select Applications.FlatId, Applications.QueueNumber, Flats.[Address] FROM Applications INNER JOIN Flats ON Applications.FlatId = Flats.Id AND Applications.StudentEmail = 'defaultStudent@default.com'


Use EFlats_v2
delete from dbo.Applications
Go
delete from dbo.Flats
Go
delete from dbo.Students
delete from dbo.Landlords
Go
execute dbo.spExecuteInsertStudent 'a@a.com',
 'password', 'salt', 'name', 'surname', 'address', 'postCode', 'city', 'country', 'phone', ''

 Update Applications Set StudentEmail = 'a@a.a', FlatId = 75 Where Id = 2819296

 select * from applications
 select * from students

 delete from applications where id = 2819296

 SELECT Applications.FlatId, Applications.QueueNumber, Flats.Address, Flats.AvailableFrom FROM Applications INNER JOIN Flats ON Applications.FlatId = Flats.Id AND Applications.StudentEmail = 'defaultStudent@default.com'

 select Date_of_offer from dbo.Flats where Id = 17

 select * from confirmed
 delete from Confirmed

 UPDATE flats
SET date_of_offer = GetDate()
WHERE id= 17

select * from dbo.Confirmed