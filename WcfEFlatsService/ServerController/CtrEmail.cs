using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using ServerDatabase;
using ServerModel;
using System.Transactions;

namespace ServerController
{
    public class CtrEmail
    {
        private string code = "";
        private bool visited = false;
        private static MailAddress fromAddress = new MailAddress("nenaujojamas@gmail.com", "Roofy community");
        const string fromPassword = "Krokodilas";
        const string subject = "Confirm account";
        private string body;
        private MailAddress toAddress;
        //config
        private SmtpClient smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        };

        //must be sure that user is already created
        public bool formatMail(string email)
        {
            generateCode();
            visited = true;

            if (code != null)
            {
                toAddress = new MailAddress(email);
                body = "Confirm your account by clicking on this link: http://localhost:59656/Confirmation.aspx?" + code;
            }
            return false;
        }

        public bool send()
        {
            try
            {

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);

                    Console.WriteLine("email sent");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        private void generateCode()
        {
            Random rnd = new Random();
            int half1 = rnd.Next(1000000, 10000000);
            int half2 = rnd.Next(1000000, 10000000);
            code = half1.ToString() + half2.ToString();
        }
        public string getCode()
        {
            if (visited)
                return code;
            return null;
        }
        public bool checkCodeExist(string code)
        {
            //DB find, student update confirmed
            MdlStudent studentObj = new MdlStudent();
            studentObj.ConfirmationCode = code;
            DbStudent dbStudent = new DbStudent();
            using (TransactionScope scope = new TransactionScope())
            {
                //get student by confirmation code
                studentObj = dbStudent.GetStudentData(studentObj.ConfirmationCode, "code");

                scope.Complete();
            }

            if (studentObj != null)
                return confirm(studentObj);
            else
                return false;
        }
        private bool confirm(MdlStudent student)
        {
            student.Confirmed = true;
            DbStudent dbStudentObj = new DbStudent();
            return dbStudentObj.UpdateProfile(student);
        }
    }
}