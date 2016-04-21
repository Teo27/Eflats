using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Data;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.WcfEFlatsServiceClient client = new ServiceReference.WcfEFlatsServiceClient();

            ServiceReference.MdlStudent mdlStudentobj = GetStudentObj();

            //client.AddStudent(mdlStudentobj);

            //add 5000 users
            //Console.ReadLine();
            string startTime, endTime, result;
            //TimeSpan duration;
            //int counterT = 0, counterF = 0, counterE = 0, counterU = 0;

            //startTime = DateTime.Now.ToString("yyyy - MM - ddThh:mm:ss");
            for (int i = 0; i < 10; i++)
            {
                //if (i % 100 == 0)
                //    mdlStudentobj.Name = null;
                //else
                //    mdlStudentobj.Name = "Name";

                string emailName = DateTime.Now.ToString("mm:ss");
                mdlStudentobj.Email = "test" + i + "@gmail.com" + emailName;
                result = client.AddStudent(mdlStudentobj);
                //Console.WriteLine("Adding Student {0} added @{1}", mdlStudentobj.Email, DateTime.Now);
                //Console.WriteLine(result);

                //if (result.Trim().Equals("Registration successful."))
                //    counterT++;
                //else if (result.Trim().Equals("Registration has failed due to the existing Email."))
                //    counterF++;
                //else if (result.Trim().Equals("Error."))
                //    counterE++;
                //else
                //    counterU++;
                //Console.WriteLine(result);
            }
            //endTime = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
            //duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
            //Console.WriteLine("Successful registration: " + counterT);
            //Console.WriteLine("Failed registration: " + counterF);
            //Console.WriteLine("registration Error: " + counterE);
            //Console.WriteLine("Unknown Error: " + counterU);
            //Console.WriteLine("...out of 2000");
            //Console.WriteLine("Duration: " + duration);

            Console.WriteLine(client.MessageTestSecured());
            Console.WriteLine(client.MessageTest());

            Console.ReadLine();
        }

        private static ServiceReference.MdlStudent GetStudentObj()
        {
            ServiceReference.MdlStudent mdlStudentObj = new ServiceReference.MdlStudent();
            mdlStudentObj.Email = "miroslavpakanec10@gmail.com";
            mdlStudentObj.Password = "myPassword";
            mdlStudentObj.Name = "Miroslav";
            mdlStudentObj.Surname = "Pakanec";
            mdlStudentObj.Address = "Jernbanegade 12A";
            mdlStudentObj.PostCode = "9000";
            mdlStudentObj.City = "Aalborg";
            mdlStudentObj.Country = "Denmark";
            mdlStudentObj.Phone = "+421910245649";

            return mdlStudentObj;
        }
    }
}
