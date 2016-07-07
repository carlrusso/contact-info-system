using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignInSystem.Models;
using SignInSystem.DataAccess;

namespace SignInSystem.Controllers
{
    public class SignInController : Controller
    {
        private IAttendeeInfoDAL attendeeFileDAL = new AttendeeFileDAL();
        private const string SessionKey = "current_sign_in";
        // GET: SignIn
        public ActionResult Main()
        {
            return View("Main");
        }

        [HttpPost]
        public ActionResult Main(Attendee guest)
        {
            if (!ModelState.IsValid)
            {
                return View("Main");
            }          

           

            attendeeFileDAL.SaveInfo(guest);

            return RedirectToAction("Confirmation", "SignIn");
        }

        public ActionResult Confirmation()
        {
           

           
            return View("Confirmation");
        }

        public ActionResult Report()
        {
            List<Attendee> model = attendeeFileDAL.GetAllInfo();
            return View("Report", model);
        }


    }
}