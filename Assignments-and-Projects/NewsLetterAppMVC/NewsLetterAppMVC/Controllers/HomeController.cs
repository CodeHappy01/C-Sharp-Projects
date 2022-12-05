using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly string connectionString = @"Data Source=DESKTOP-L8N1MI0\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }
        //Simple Server Validation
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else 
            {

                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

                    //string connectionString = @"Data Source=DESKTOP-L8N1MI0\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                    //string queryString = @"INSERT INTO SignUp (FirstName, LastName, EmailAddress) VALUES
                    //                        (@FirstName, @LastName, @EmailAddress)";

                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                    //    SqlCommand command = new SqlCommand(queryString, connection);
                    //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    //    command.Parameters["@FirstName"].Value = firstName;
                    //    command.Parameters["@LastName"].Value = lastName;
                    //    command.Parameters["@EmailAddress"].Value = emailAddress;


                    //    connection.Open();
                    //    command.ExecuteNonQuery();
                    //    connection.Close();
                    //}
                    return View("Success");
            }
        }

        //public ActionResult Admin()
        //{
            //Below is same as above but fewer lines (Entity Framwork/ADO.NET)

                //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUp";
                //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);

                //    connection.Open();

                //    SqlDataReader reader = command.ExecuteReader();

                //    while (reader.Read())
                //    {
                //        var signup = new NewsletterSignUp();

                //        signup.Id = Convert.ToInt32(reader["Id"]);
                //        signup.FirstName = reader["FirstName"].ToString();
                //        signup.LastName = reader["LastName"].ToString();
                //        signup.EmailAddress= reader["EmailAddress"].ToString();
                //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

                //        signups.Add(signup);
                //    }
                //}
    }
}