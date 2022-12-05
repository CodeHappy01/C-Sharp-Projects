using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //Used to access connection string
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //represents record in DB
                var signups = db.SignUps;
                //new list of VM
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    //Wraps VM from the VM
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }
    }
}