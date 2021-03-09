using PartyTTHK_K.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace PartyTTHK_K.Controllers
{
    public class HomeController : Controller
    {
        private const string V = ", guest.Name + ";

        public ActionResult Index()
        {
            int month = DateTime.Now.Month;
            if (month >= 01 && month < 04)
            {
                ViewBag.Message = "TehnoParty (09.01-11.04)";
            }
            else if (month >= 04 && month < 06)
            {
                ViewBag.Message = "Nimun! (15.05-11.06)";
            }
            else if (month >= 07 && month < 10)
            {
                ViewBag.Message = "Njau (26.07-09.10)";
            }
            else if (month == 10 && month < 12)
            {
                ViewBag.Message = "ChriZmas (28.11-28.12)";
            }

            int hour = DateTime.Now.Hour;
            if (hour >= 6 && hour < 12)
            {
                ViewBag.Greeting = "Morning";
            }
            else if (hour >= 12 && hour < 18)
            {
                ViewBag.Greeting = "Lunch";
            }
            else if (hour >= 18 && hour < 23)
            {
                ViewBag.Greeting = "Evening";
            }
            else if (hour == 23 && hour < 6)
            {
                ViewBag.Greeting = "Night";
            }
            return View();
        }
        [HttpGet]
        public ViewResult Questionary()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Questionary(Guest guest)
        {
            E_mail(guest);
            if (ModelState.IsValid)
            { return View("Thanks", guest); }
            else
            { return View(); }
        }
        [HttpGet]
        public ViewResult Events()
        {
            return View();
        }
        public void E_mail(Guest guest)
        {
            try
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 587;
                WebMail.EnableSsl = true;
                WebMail.UserName = "---";
                WebMail.Password = "---";
                WebMail.From = "---";
                WebMail.Send("---", "There your party invite, ",guest.Name + ((guest.WillAttend ?? false) ? ". You are comming! Yey =) " : "... And you are not comming :("));
            }
            catch (Exception)
            {
                ViewBag.Message = "Warning! Try again send your mail";
            }
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}