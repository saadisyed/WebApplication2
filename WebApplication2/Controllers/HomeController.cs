using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    
    public class HomeController : Controller
    {
        
        RegMVCEntities db = new RegMVCEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Models.tblRegistration Lgn)
            
        {

            if (ModelState.IsValid)
            {
              if (IsValid(Lgn.UserName, Lgn.Password))
                
                    {
                      //  Session["UserID"] = obj.UserID.ToString();
                     //   Session["UserName"] = obj.UserName.ToString();
                        FormsAuthentication.SetAuthCookie(Lgn.UserName, true);
                        return RedirectToAction("About", "Home");
                        
                    }
                   
                else
                {
                    ModelState.AddModelError("", "Login details are wrong.");
                }
            }
            
            return View(Lgn);

        }


        [HttpGet]
        public ActionResult Register()
        {
            //return View(new tblRegistration());
            return View();

        }
        [HttpPost]
        public ActionResult Register(tblRegistration reg)
        {
           
            if (ModelState.IsValid)
            {
                //  RegMVCEntities db = new RegMVCEntities();
                //  tblRegistration reg = new tblRegistration();

                // reg.Comment = "";

                var crypto = new SimpleCrypto.PBKDF2();
                var encrypPass = crypto.Compute(reg.Password);



                reg.Password = encrypPass;
                reg.PasswordSalt = crypto.Salt;
                reg.IsApproved = true;
                reg.IsAnonymous = false;
                reg.LastActivityDate = DateTime.Now;
                reg.CreateDate = DateTime.Now;

                db.tblRegistrations.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
           // return View(reg);
            return View();
            


        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult About()
        {

            return View();
        }

        private bool IsValid(String Uname, String password)
     
        {
            var crypto = new SimpleCrypto.PBKDF2();
            bool IsValid = false;

            {
                var user = db.tblRegistrations.FirstOrDefault(u => u.UserName == Uname);
                if (user != null)
                {
                    if (user.Password == crypto.Compute(password, user.PasswordSalt))
                    {
                        IsValid = true;
                    }
                    

                }
            }
            return IsValid;
        }







    }
}