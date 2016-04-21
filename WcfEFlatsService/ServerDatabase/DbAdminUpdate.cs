using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ServerDatabase
{
    public class DbAdminUpdate
    {
        public bool UpdateApplications(DataSet ds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    //declare adapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Applications", conn);

                    //set commands
                    dataAdapter.UpdateCommand = new SqlCommand("Update Applications Set" +
                        " StudentEmail = @StudentEmail, FlatId = @FlatId " +
                        " Where Id = @Id", conn);
                    dataAdapter.DeleteCommand = new SqlCommand("delete from applications where Id = @Id", conn);

                    //add parameters
                    dataAdapter.UpdateCommand.Parameters.Add("@StudentEmail", SqlDbType.Char, 50, "StudentEmail");
                    dataAdapter.UpdateCommand.Parameters.Add("@FlatId", SqlDbType.Int, 0, "FlatId");

                    //add sql parameters
                    SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int);
                    parameter.SourceColumn = "Id";
                    parameter.SourceVersion = DataRowVersion.Original;

                    SqlParameter parameter2 = dataAdapter.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int);
                    parameter2.SourceColumn = "Id";
                    parameter2.SourceVersion = DataRowVersion.Original;

                    //execute delete and update
                    int deleted = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Deleted));
                    int updated = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent));
                    //int added =   dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Added));

                    if (deleted == 0 && updated == 0)
                        return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateFlats(DataSet ds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    //declare adapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Flats", conn);

                    //set commands
                    dataAdapter.UpdateCommand = new SqlCommand("Update Flats Set" +
                        " LandlordEmail = @LandlordEmail, Type = @Type, Address = @Address, PostCode = @PostCode, City = @City, Rent = @Rent," +
                        " Deposit = @Deposit, AvailableFrom = @AvailableFrom, DateOfCreation = @DateOfCreation, Description = @Description, @Status = Status, DateOfOffer = @DateOfOffer" +
                        " Where Id = @Id", conn);

                    dataAdapter.DeleteCommand = new SqlCommand("delete from Flats where Id = @Id", conn);

                    //add parameters
                    dataAdapter.UpdateCommand.Parameters.Add("@LandlordEmail", SqlDbType.Char, 50, "LandlordEmail");
                    dataAdapter.UpdateCommand.Parameters.Add("@Type", SqlDbType.Char, 50, "Type");
                    dataAdapter.UpdateCommand.Parameters.Add("@Address", SqlDbType.Char, 50, "Address");
                    dataAdapter.UpdateCommand.Parameters.Add("@PostCode", SqlDbType.Char, 50, "PostCode");
                    dataAdapter.UpdateCommand.Parameters.Add("@City", SqlDbType.Char, 50, "City");
                    dataAdapter.UpdateCommand.Parameters.Add("@Rent", SqlDbType.Char, 50, "Rent");
                    dataAdapter.UpdateCommand.Parameters.Add("@Deposit", SqlDbType.Char, 50, "Deposit");
                    dataAdapter.UpdateCommand.Parameters.Add("@AvailableFrom", SqlDbType.Char, 50, "AvailableFrom");
                    dataAdapter.UpdateCommand.Parameters.Add("@DateOfCreation", SqlDbType.Char, 50, "DateOfCreation");
                    dataAdapter.UpdateCommand.Parameters.Add("@Description", SqlDbType.Char, 50, "Description");
                    dataAdapter.UpdateCommand.Parameters.Add("@Status", SqlDbType.Char, 50, "Status");
                    dataAdapter.UpdateCommand.Parameters.Add("@DateOfOffer", SqlDbType.Char, 50, "DateOfOffer");


                    //add sql parameters
                    SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int);
                    parameter.SourceColumn = "Id";
                    parameter.SourceVersion = DataRowVersion.Original;

                    SqlParameter parameter2 = dataAdapter.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int);
                    parameter2.SourceColumn = "Id";
                    parameter2.SourceVersion = DataRowVersion.Original;

                    //execute delete and update
                    int deleted = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Deleted));
                    int updated = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent));

                    //if nothing was updated return false
                    if (deleted == 0 && updated == 0)
                        return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateStudents(DataSet ds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    //declare adapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Students", conn);
                    //set commands
                    dataAdapter.UpdateCommand = new SqlCommand("Update Students Set" +
                        " Password = @Password, Salt = @Salt, ConfirmationCode = @ConfirmationCode, Confirmed = @Confirmed, Student = @Student," +
                        " Score = @Score, NumberOfChildren = @NumberOfChildren, Pet = @Pet, NumberOfCohabitors = @NumberOfCohabitors, @Disabled = Disabled," +
                        " DateOfCreation = @DateOfCreation, Name = @Name, Surname = @Surname, Address = @Address, PostCode = @PostCode, City = @City, Country = @Country, Phone = @Phone" +
                        " Where Email = @Email", conn);

                    dataAdapter.DeleteCommand = new SqlCommand("delete from Students where Email = @Email", conn);

                    dataAdapter.InsertCommand = new SqlCommand("insert into Students values(@Email, @password, @Salt, @ConfirmationCode, @Confirmed, @Student," +
                        " @Score, @NumberOfChildren, @Pet, @NumberOfCohabitors, @Disabled, @DateOfCreation, @Name, @Surname, @Address, @PostCode, @City, @Country, @Phone)", conn);

                    //add parameters
                    dataAdapter.UpdateCommand.Parameters.Add("@Password", SqlDbType.Char, 100, "Password");
                    dataAdapter.UpdateCommand.Parameters.Add("@Salt", SqlDbType.Char, 50, "Salt");
                    dataAdapter.UpdateCommand.Parameters.Add("@ConfirmationCode", SqlDbType.Char, 50, "ConfirmationCode");
                    dataAdapter.UpdateCommand.Parameters.Add("@Confirmed", SqlDbType.Bit, 0, "Confirmed");
                    dataAdapter.UpdateCommand.Parameters.Add("@Student", SqlDbType.Bit, 0, "Student");
                    dataAdapter.UpdateCommand.Parameters.Add("@Score", SqlDbType.Int, 0, "Score");
                    dataAdapter.UpdateCommand.Parameters.Add("@NumberOfChildren", SqlDbType.Int, 0, "NumberOfChildren");
                    dataAdapter.UpdateCommand.Parameters.Add("@Pet", SqlDbType.Bit, 0, "Pet");
                    dataAdapter.UpdateCommand.Parameters.Add("@NumberOfCohabitors", SqlDbType.Int, 0, "NumberOfCohabitors");
                    dataAdapter.UpdateCommand.Parameters.Add("@Disabled", SqlDbType.Bit, 0, "Disabled");
                    dataAdapter.UpdateCommand.Parameters.Add("@DateOfCreation", SqlDbType.Date, 50, "DateOfCreation");
                    dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.Char, 50, "Name");
                    dataAdapter.UpdateCommand.Parameters.Add("@Surname", SqlDbType.Char, 50, "Surname");
                    dataAdapter.UpdateCommand.Parameters.Add("@Address", SqlDbType.Char, 50, "Address");
                    dataAdapter.UpdateCommand.Parameters.Add("@PostCode", SqlDbType.Char, 50, "PostCode");
                    dataAdapter.UpdateCommand.Parameters.Add("@City", SqlDbType.Char, 50, "City");
                    dataAdapter.UpdateCommand.Parameters.Add("@Country", SqlDbType.Char, 50, "Country");
                    dataAdapter.UpdateCommand.Parameters.Add("@Phone", SqlDbType.Char, 50, "Phone");

                    dataAdapter.InsertCommand.Parameters.Add("@Email", SqlDbType.Char, 50, "Email");
                    dataAdapter.InsertCommand.Parameters.Add("@Password", SqlDbType.Char, 100, "Password");
                    dataAdapter.InsertCommand.Parameters.Add("@Salt", SqlDbType.Char, 50, "Salt");
                    dataAdapter.InsertCommand.Parameters.Add("@ConfirmationCode", SqlDbType.Char, 50, "ConfirmationCode");
                    dataAdapter.InsertCommand.Parameters.Add("@Confirmed", SqlDbType.Bit, 0, "Confirmed");
                    dataAdapter.InsertCommand.Parameters.Add("@Student", SqlDbType.Bit, 0, "Student");
                    dataAdapter.InsertCommand.Parameters.Add("@Score", SqlDbType.Int, 0, "Score");
                    dataAdapter.InsertCommand.Parameters.Add("@NumberOfChildren", SqlDbType.Int, 0, "NumberOfChildren");
                    dataAdapter.InsertCommand.Parameters.Add("@Pet", SqlDbType.Bit, 0, "Pet");
                    dataAdapter.InsertCommand.Parameters.Add("@NumberOfCohabitors", SqlDbType.Int, 0, "NumberOfCohabitors");
                    dataAdapter.InsertCommand.Parameters.Add("@Disabled", SqlDbType.Bit, 0, "Disabled");
                    dataAdapter.InsertCommand.Parameters.Add("@DateOfCreation", SqlDbType.Date, 50, "DateOfCreation");
                    dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.Char, 50, "Name");
                    dataAdapter.InsertCommand.Parameters.Add("@Surname", SqlDbType.Char, 50, "Surname");
                    dataAdapter.InsertCommand.Parameters.Add("@Address", SqlDbType.Char, 50, "Address");
                    dataAdapter.InsertCommand.Parameters.Add("@PostCode", SqlDbType.Char, 50, "PostCode");
                    dataAdapter.InsertCommand.Parameters.Add("@City", SqlDbType.Char, 50, "City");
                    dataAdapter.InsertCommand.Parameters.Add("@Country", SqlDbType.Char, 50, "Country");
                    dataAdapter.InsertCommand.Parameters.Add("@Phone", SqlDbType.Char, 50, "Phone");

                    //add sql parameters
                    SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add("@Email", SqlDbType.Char);
                    parameter.SourceColumn = "Email";
                    parameter.SourceVersion = DataRowVersion.Original;

                    SqlParameter parameter2 = dataAdapter.DeleteCommand.Parameters.Add("@Email", SqlDbType.Char);
                    parameter2.SourceColumn = "Email";
                    parameter2.SourceVersion = DataRowVersion.Original;

                    //execute delete, update and insert
                    int deleted = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Deleted));
                    int updated = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent));
                    int added = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Added));

                    //if nothing was updated return false
                    if (deleted == 0 && updated == 0 && added == 0)
                        return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateLandlords(DataSet ds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    //declare adapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Landlords", conn);
                    //set commands
                    dataAdapter.UpdateCommand = new SqlCommand("Update Landlords Set" +
                        " Password = @Password, Salt = @Salt, Confirmed = @Confirmed," +
                        " DateOfCreation = @DateOfCreation, Name = @Name, Address = @Address, PostCode = @PostCode, City = @City, Country = @Country, ContactPerson = @ContactPerson, Phone = @Phone" +
                        " Where Email = @Email", conn);

                    dataAdapter.DeleteCommand = new SqlCommand("delete from Landlords where Email = @Email", conn);

                    dataAdapter.InsertCommand = new SqlCommand("insert into Landlords values(@Email, @password, @Salt, @Confirmed," +
                        " @DateOfCreation, @Name, @Address, @PostCode, @City, @Country, @ContactPerson, @Phone)", conn);

                    //add parameters
                    dataAdapter.UpdateCommand.Parameters.Add("@Password", SqlDbType.Char, 100, "Password");
                    dataAdapter.UpdateCommand.Parameters.Add("@Salt", SqlDbType.Char, 50, "Salt");
                    dataAdapter.UpdateCommand.Parameters.Add("@Confirmed", SqlDbType.Bit, 0, "Confirmed");
                    dataAdapter.UpdateCommand.Parameters.Add("@DateOfCreation", SqlDbType.Date, 50, "DateOfCreation");
                    dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.Char, 50, "Name");
                    dataAdapter.UpdateCommand.Parameters.Add("@Address", SqlDbType.Char, 50, "Address");
                    dataAdapter.UpdateCommand.Parameters.Add("@PostCode", SqlDbType.Char, 50, "PostCode");
                    dataAdapter.UpdateCommand.Parameters.Add("@City", SqlDbType.Char, 50, "City");
                    dataAdapter.UpdateCommand.Parameters.Add("@Country", SqlDbType.Char, 50, "Country");
                    dataAdapter.UpdateCommand.Parameters.Add("@ContactPerson", SqlDbType.Char, 50, "ContactPerson");
                    dataAdapter.UpdateCommand.Parameters.Add("@Phone", SqlDbType.Char, 50, "Phone");

                    dataAdapter.InsertCommand.Parameters.Add("@Email", SqlDbType.Char, 50, "Email");
                    dataAdapter.InsertCommand.Parameters.Add("@Password", SqlDbType.Char, 100, "Password");
                    dataAdapter.InsertCommand.Parameters.Add("@Salt", SqlDbType.Char, 50, "Salt");
                    dataAdapter.InsertCommand.Parameters.Add("@Confirmed", SqlDbType.Bit, 0, "Confirmed");
                    dataAdapter.InsertCommand.Parameters.Add("@DateOfCreation", SqlDbType.Date, 50, "DateOfCreation");
                    dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.Char, 50, "Name");
                    dataAdapter.InsertCommand.Parameters.Add("@Address", SqlDbType.Char, 50, "Address");
                    dataAdapter.InsertCommand.Parameters.Add("@PostCode", SqlDbType.Char, 50, "PostCode");
                    dataAdapter.InsertCommand.Parameters.Add("@City", SqlDbType.Char, 50, "City");
                    dataAdapter.InsertCommand.Parameters.Add("@Country", SqlDbType.Char, 50, "Country");
                    dataAdapter.InsertCommand.Parameters.Add("@ContactPerson", SqlDbType.Char, 50, "ContactPerson");
                    dataAdapter.InsertCommand.Parameters.Add("@Phone", SqlDbType.Char, 50, "Phone");

                    //add sql parameters
                    SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add("@Email", SqlDbType.Char);
                    parameter.SourceColumn = "Email";
                    parameter.SourceVersion = DataRowVersion.Original;

                    SqlParameter parameter2 = dataAdapter.DeleteCommand.Parameters.Add("@Email", SqlDbType.Char);
                    parameter2.SourceColumn = "Email";
                    parameter2.SourceVersion = DataRowVersion.Original;

                    //execute delete and update
                    int deleted = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Deleted));
                    int updated = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent));
                    int added = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Added));

                    //if nothing was updated return false
                    if (deleted == 0 && updated == 0 && added == 0)
                        return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateAdmins(DataSet ds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    //declare adapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Admins", conn);
                    //set commands
                    dataAdapter.UpdateCommand = new SqlCommand("Update Admins Set" +
                        " Password = @Password, Salt = @Salt" +
                        " Where Username = @Username", conn);

                    dataAdapter.DeleteCommand = new SqlCommand("delete from Admins where Username = @Username", conn);

                    dataAdapter.InsertCommand = new SqlCommand("insert into Admins values(@Username, @password, @Salt)", conn);

                    //add parameters
                    dataAdapter.UpdateCommand.Parameters.Add("@Password", SqlDbType.Char, 100, "Password");
                    dataAdapter.UpdateCommand.Parameters.Add("@Salt", SqlDbType.Char, 50, "Salt");

                    dataAdapter.InsertCommand.Parameters.Add("@Username", SqlDbType.Char, 50, "Username");
                    dataAdapter.InsertCommand.Parameters.Add("@Password", SqlDbType.Char, 100, "Password");
                    dataAdapter.InsertCommand.Parameters.Add("@Salt", SqlDbType.Char, 50, "Salt");

                    //add sql parameters
                    SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add("@Username", SqlDbType.Char);
                    parameter.SourceColumn = "Username";
                    parameter.SourceVersion = DataRowVersion.Original;

                    SqlParameter parameter2 = dataAdapter.DeleteCommand.Parameters.Add("@Username", SqlDbType.Char);
                    parameter2.SourceColumn = "Username";
                    parameter2.SourceVersion = DataRowVersion.Original;

                    //execute delete and update
                    int deleted = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Deleted));
                    int updated = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent));
                    int added = dataAdapter.Update(ds.Tables[0].Select(null, null, DataViewRowState.Added));

                    //if nothing was updated return false
                    if (deleted == 0 && updated == 0 && added == 0)
                        return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
