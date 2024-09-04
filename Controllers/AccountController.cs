using System;
using System.Globalization;
using System.Web;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using CustomMembershipEF.Contexts;
using CustomMembershipEF.Entities;
using CustomMembershipEF.Interfaces;
using CustomMembershipEF.Models;
using CustomMembershipEF.Services;
using System.Linq;
using System.DirectoryServices;

namespace CustomMembershipEF.Controllers
{
    public class AccountController : Controller
    {
        public IMembershipService MembershipService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (MembershipService == null) { MembershipService = new AccountMembershipService(); }
            
            base.Initialize(requestContext);
        }

        //
        // GET: /Account/LogOn

        //public ActionResult LogOn()
        //{
        //    return View();
        //}

        //  this part is for
        
        // POST: /Account/LogOn
       private CustomMembershipEF.Contexts.UsersContext db = new CustomMembershipEF.Contexts.UsersContext();
        private CustomMembershipEF.Models.Model1 db2 = new Model1();
       // [HttpPost]
        public static string ErrorMsg = "";

        [HttpGet]
        public ActionResult LogOn()

        {

            return View();
        }


        [HttpPost]
        public ActionResult LogOn(string username,string password, string returnUrl)
        { //                          model
           // HomeController.Public_time = (DateTime.Now.Hour).ToString() + ":" + (DateTime.Now.Minute).ToString(); //set time to static variable first page
            if (username == "" && password == "")
            {
                ViewBag.message = "error";
                ErrorMsg = "please enter username and password";
            }
            if (username != null && password != null)
            {
                if (ModelState.IsValid)
                {//          LogOnModel model                             model.UserName    model.Password
                    try
                    {
                        if (MembershipService.ValidateUser(username, password))
                        {
                            bool RememberMe = false;
                            SetupFormsAuthTicket(username, RememberMe);
                            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                            {
                                return Redirect(returnUrl);
                            }


                            tbl_Admin LoginUser = db2.tbl_Admin.Where(q => q.AdminUserName == username).FirstOrDefault();
                            Session["User"] = LoginUser;
                            return RedirectToAction("FirstPage", "Home");
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.error = "نام کاربری یا کلمه عبور اشتباه است";
                    }
                  }
               }
            return View();
        }
        public PartialViewResult Athenticate(string username, string password)
        {
            ViewBag.error = ErrorMsg;
            return PartialView();
        }

        public PartialViewResult AjaxBegin()
        {
            ViewBag.error = ErrorMsg;
            return PartialView();
        }

        public PartialViewResult AjaxComplete()
        {
            ViewBag.error = ErrorMsg;
            return PartialView();
        }


       
        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogOn", "Account");
        }

        //
        // GET: /Account/Register
        
        public ActionResult Register()
        {
            RoleDropDownList();
           
            return View();
        }

        //
        // POST: /Account/Register
        
        [HttpPost]

        public ActionResult Register(RegisterModel model, string TypeText)
        {
          
            //var selectAdmin = db.Users.Select(q => q).ToList();
            //if (selectAdmin.Count == 0)  {  model.RoleId = 1; }  else { model.RoleId = 2; }
            try
            {
                RoleDropDownList();


                //---for inserting  in Users Table---
                //UsersContext.name_main = model.Name;
                //UsersContext.family_main = model.Family;
                //UsersContext.address_main = model.Address;
                //UsersContext.birthdate_main = model.Birthdate;
                //UsersContext.education_main = model.education;
                //UsersContext.RoleId_main = model.RoleId.ToString();

                if (ModelState.IsValid)
                {
                    if (model.Password == model.ConfirmPassword)
                    {
                        // Attempt to register the user
                        var createStatus = MembershipService.CreateUser(model.UserName, model.Password, model.UserEmailAddress);


                        User SelUser = db.Users.Where(q => q.UserName == model.UserName).Select(q => q).FirstOrDefault();
                        short inputRoleId = (short)(model.GroupID);

                        //---my function to insert UserId and RoleId into Table UserRole
                        db.UserRoleADDUpdate(SelUser, inputRoleId);


                        if (createStatus == MembershipCreateStatus.Success)
                        {
                            return RedirectToAction("LogOn", "Account");
                        }
                        ModelState.AddModelError("", ErrorCodeToString(createStatus));
                    }
                    ViewBag.error = "کلمه عبور تکرار شده با کلمه عبور همخوانی ندارد";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }

        #region DropDown
        public  void RoleDropDownList(object selectedType = null)
        {
            var ut = db2.tbl_AdminGroup.OrderBy(q => q.GroupName);
            ViewBag.RegisterGroupID = new SelectList(ut, "GroupID", "GroupName", selectedType);
           
        }

       

        #endregion



        //
        // GET: /Account/ChangePassword

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        // ChangePassword method not implemented in CustomMembershipProvider.cs
        // Feel free to update!

        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {

                // ChangePassword will throw an exception rather
                // than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true /* userIsOnline */);
                    changePasswordSucceeded = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        private tbl_Admin SetupFormsAuthTicket(string userName, bool persistanceFlag)
        {
            tbl_Admin user;
            using (var LabEntities = new Model1())
            {
                user = LabEntities.GetUser(userName);
            }
            var userId = user.AdminID;
            var userData = userId.ToString(CultureInfo.InvariantCulture);
            var authTicket = new FormsAuthenticationTicket(1, //version
                                                        userName, // user name
                                                        DateTime.Now,             //creation
                                                        DateTime.Now.AddMinutes(30), //Expiration
                                                        persistanceFlag, //Persistent
                                                        userData);

            var encTicket = FormsAuthentication.Encrypt(authTicket);
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
            return user;
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion

        public string Name { get; set; }

        public string Family { get; set; }
    }
}
