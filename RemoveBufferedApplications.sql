Use EFlats_v2
Go
Create procedure spRemoveBufferedApplications
(
	@FlatId int
)
With Encryption
As
Begin
	Delete from applications where FlatId = @FlatId
End