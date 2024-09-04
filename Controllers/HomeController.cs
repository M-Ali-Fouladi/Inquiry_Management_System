
using CustomMembershipEF.Contexts;
using CustomMembershipEF.Entities;
using CustomMembershipEF.Interfaces;
using CustomMembershipEF.Models;
using CustomMembershipEF.Services;
using CustomMembershipEF.Providers_Methods;
using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System.Collections.Generic;



namespace CustomMembershipEF.Controllers
{
    public class HomeController : Controller
    {
        public IMembershipService MembershipService { get; set; }
        // public  UsersContext db = new UsersContext();
        public Models.Model1 db = new Models.Model1();
        public Models.Model3.Model1 db3 = new Models.Model3.Model1();
        public Models.Model2.Model1 db2 = new Models.Model2.Model1();
        public HttpContext context;
        // [Authorize(Roles = "Admin")]
        public ActionResult test()
        {
            var select = db.tbl_InquiryNews.Where(q => q.Inquiry_Admin == "h-yari").ToList();
            return View(select);
        }
        public ActionResult test1()
        {
            return View();
        }
        public ActionResult modal()
        {

            return View();
        }

        public static int? StaticDetectedUser=null;
        private static string StaticManager_Username = "";
        public static int? LoggedId = null;
        [HttpGet]
        public ActionResult FirstPage()
        {
            StaticElementCode = "";
            StaticAdminUsername = "";
            StaticInquiry_Vahed = "";
            StaticInquiry_Main_ID = "";
            StaticInquiry_Name = "";
            if(LoggedId == null)
            {
                StaticDetectedUser = DetectUser(User.Identity.Name);               
                StaticManager_Username = Get_Manager_Username(6, Get_Manager_Stage("s-parvaz").FirstOrDefault().WorkSectionId).FirstOrDefault().Manager_Username;
                //s-parvaz is an assumption =>should be change to 'user.identity.name'
                LoggedId = 1;
            }
              
            // var se = db.tbl_Admin.Where(q => q.AdminDsc.Contains("") && q.AdminUserName.Contains("m") && q.AdminType==null).ToList();
            // var select = db.tbl_Inquiry.Where(q=>q.Inquiry_Admin== "h-yari").ToList();
            return View(GetInquiry());
        }

        [HttpPost]
        public ActionResult FirstPage(int? id)
        {
            return View();
        }

       


        #region inquiry Actions

        [HttpGet]
        public ActionResult Manage_inquiry()
        {

            // var select = db.tbl_Inquiry.Where(q => q.Inquiry_Admin == "h-yari").ToList();

            return View(GetInquiry_Manage());
        }

        [HttpPost]
        public ActionResult Manage_inquiry(int? id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Manage_Payeh()
        {

            // var select = db.tbl_Inquiry.Where(q => q.Inquiry_Admin == "h-yari").ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Manage_Payeh(int? id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Manage_Operation()
        {

            var select = db.tbl_InquiryNews.Where(q => q.Inquiry_Admin == "h-yari").ToList();

            return View(GetInquiry());
        }

        [HttpPost]
        public ActionResult Manage_Operation(int? id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Manage_Report()
        {

            var select = db.tbl_InquiryNews.Where(q => q.Inquiry_Admin == "h-yari").ToList();

            return View(GetInquiry());
        }

        [HttpPost]
        public ActionResult Manage_Report(int? id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Manage_Users()
        {

            var select = db.tbl_Admin.ToList();

            return View(select);
        }

        [HttpPost]
        public ActionResult Manage_Users(int? id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Manage_taradod()
        {

            // var select = db.tbl_Inquiry.ToList();

            return View(Get_Taradod().ToList());
        }

        [HttpPost]
        public ActionResult Manage_taradod(int? id)
        {
            return View();
        }
        [HttpGet]

        public ActionResult Manage_ResultOperation()
        {
            var select = db.tbl_InquiryNews.Where(q => q.Inquiry_Admin == "h-yari").ToList();
            return View(GetInquiry());
        }
        [HttpPost]
        public ActionResult Manage_ResultOperation(int? id)
        {
            return View();
        }

        private static string StaticElementCode = "";
        private static string StaticAdminUsername = "";
        private static string StaticInquiry_Vahed = "";
        private static string StaticInquiry_Main_ID = "";
        private static string StaticInquiry_Name = "";

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Kartable_Search(SearchStringViewmodel model)
        {
            StaticElementCode = model.ElementCode;
            StaticAdminUsername = model.AdminUsername;
            StaticInquiry_Vahed = model.Inquiry_Vahed;
            StaticInquiry_Main_ID = model.Inquiry_Main_ID;
            StaticInquiry_Name = model.Inquiry_Name;
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        //[HttpPost]
        public JsonResult Update_Operation_Partial([DataSourceRequest] DataSourceRequest request, tbl_Inquiry_Test model)
        {
            try
            {
                model.Inquiry_ID = ModalStaticInquiryId;
                var select = db.tbl_Inquiry_Tests.Where(q => q.Inquiry_ID == ModalStaticInquiryId && q.Inquiry_TestId == model.Inquiry_TestId).FirstOrDefault();
                select.Test_Inquiry_Start_Date = model.Test_Inquiry_Start_Date;
                select.Test_Inquiry_Done_Date = model.Test_Inquiry_Done_Date;
                select.Test_Inquiry_Start_Time = model.Test_Inquiry_Start_Time;
                select.Test_Inquiry_Done_Time = model.Test_Inquiry_Done_Time;
                select.Test_Ghatiat = model.Test_Ghatiat;
                select.Inquiry_Element_Alamat_Azmoon = model.Inquiry_Element_Alamat_Azmoon;
                select.Test_NafarSaat = model.Test_NafarSaat;
                select.Inquiry_Element_Rahgiri = model.Inquiry_Element_Rahgiri;
                select.Test_Inquiry_Way_Desc = model.Test_Inquiry_Way_Desc;
                select.Test_Acception_Description = model.Test_Acception_Description;
                select.Test_Inquiry_Result = model.Test_Inquiry_Result;
                select.Test_Inquiry_Desc = model.Test_Inquiry_Desc;


                db.Entry(select).State = EntityState.Modified;
                db.SaveChanges();
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Update_Confirm_Inquiry([DataSourceRequest] DataSourceRequest request, Test_Inquiry_Viewmodel Test_Inquiry)
        {
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == ModalStaticInquiryId).FirstOrDefault();

            if (Test_Inquiry.Test_Inquiry_Desc != null)//true rejected 
            {
                // var model = db.tbl_Inquiry.Where(q => q.Inquiry_ID == ModalStaticInquiryId).FirstOrDefault();
                model.Inquiry_Rejected = true;
                model.Inquiry_RejectedDesc = Test_Inquiry.Test_Inquiry_Desc;
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return Json(Url.Action("Firstpage", "Home"));
               // return Json(new[] { Test_Inquiry }.ToDataSourceResult(request, ModelState));
            }
            else if (model.Inquiry_Confirmed != true) // confirm
            {
                // var model = db.tbl_Inquiry.Where(q => q.Inquiry_ID == ModalStaticInquiryId).FirstOrDefault();
                model.Inquiry_Confirmed = true;
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                //return Json(new[] { Test_Inquiry }.ToDataSourceResult(request, ModelState));
                return Json(Url.Action("Firstpage", "Home"));
            }
            else
            {
                return View();
            }
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KartablePopup_Create([DataSourceRequest] DataSourceRequest request, Test_Inquiry_Viewmodel Test_Inquiry)
        {
            if (Test_Inquiry != null && ModelState.IsValid)
            {
                tbl_Inquiry_Test u = new tbl_Inquiry_Test();
                u.Inquiry_ID = ModalStaticInquiryId;
                u.Test_ID = Test_Inquiry.Test_ID;
                u.Test_Inquiry_Coast = Test_Inquiry.Test_Inquiry_Coast;
                u.Test_Inquiry_Desc = Test_Inquiry.Test_Inquiry_Desc;

                db.tbl_Inquiry_Tests.Add(u);
                db.SaveChanges();
            }
            return Json(new[] { Test_Inquiry }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TestInquiryPopup_Create([DataSourceRequest] DataSourceRequest request, Test_Inquiry_Viewmodel Test_Inquiry)
        {
            if (Test_Inquiry != null && ModelState.IsValid)
            {
                tbl_Inquiry_Test u = new tbl_Inquiry_Test();
                u.Inquiry_ID = ModalStaticInquiryId;
                u.Test_ID = Test_Inquiry.Test_ID;
                u.Test_Inquiry_Coast = Test_Inquiry.Test_Inquiry_Coast;
                u.Test_Inquiry_Desc = Test_Inquiry.Test_Inquiry_Desc;

                db.tbl_Inquiry_Tests.Add(u);
                db.SaveChanges();
            }
            return Json(new[] { Test_Inquiry }.ToDataSourceResult(request, ModelState));
        }
        public ActionResult Popup_Read_Kartable([DataSourceRequest] DataSourceRequest request)
        {
            return Json(Get_Inquiry_Tests(ModalStaticInquiryId).ToDataSourceResult(request));
        }
        public ActionResult Popup_Read_Test([DataSourceRequest] DataSourceRequest request)
        {
            return Json(Get_Tests().ToDataSourceResult(request));
        }

        public ActionResult Popup_Read([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Inquiry_Tests(ModalStaticInquiryId).ToDataSourceResult(request));
        }




        public IEnumerable<Test_Inquiry_Viewmodel> Get_Inquiry_Tests(long Inquiry_ID)
        {

            IEnumerable<Test_Inquiry_Viewmodel> selectjoin = (from e in db.tbl_Inquiry_Tests.AsEnumerable()
                                                              join j in db.tbl_InquiryNews.AsEnumerable()
                                                                     on e.Inquiry_ID equals j.InquiryID
                                                              join c in db.tbl_Test.AsEnumerable()
                                                                     on e.Test_ID equals c.Test_ID
                                                              where e.Inquiry_ID == ModalStaticInquiryId
                                                              select new Test_Inquiry_Viewmodel()
                                                              {
                                                                  Test_Subject = c.Test_Subject,
                                                                  Test_Standard_Code = e.Test_Standard_Code,
                                                                  Test_UID = c.Test_UID,
                                                                  Test_Inquiry_PreStart_Date = e.Test_Inquiry_PreStart_Date,
                                                                  Test_Inquiry_PreDone_Date = e.Test_Inquiry_PreDone_Date,
                                                                  Inquiry_TestId = e.Inquiry_TestId,
                                                                  Test_ID=e.Test_ID,
                                                                  Test_Inquiry_Start_Date = e.Test_Inquiry_Start_Date,
                                                                  Inquiry_Element_Rahgiri = e.Inquiry_Element_Rahgiri,
                                                                  Test_Inquiry_Start_Time = e.Test_Inquiry_Start_Time,
                                                                  Test_Inquiry_Done_Time = e.Test_Inquiry_Done_Time,
                                                                  Test_Inquiry_Done_Date = e.Test_Inquiry_Done_Date,
                                                                  Test_Inquiry_Way_Desc = e.Test_Inquiry_Way_Desc,
                                                                  Test_Ghatiat = e.Test_Ghatiat,
                                                                  Test_Acception_Description = e.Test_Acception_Description,
                                                                  Test_Inquiry_Result = e.Test_Inquiry_Result
                                                                  
                                                              });
            return selectjoin;
        }
        public IEnumerable<Manager_Viewmodel> Get_Manager_Stage(string username)
        {

            IEnumerable<Manager_Viewmodel> selectjoin = (from e in db2.prs_Personnel.AsEnumerable()
                                                         join j in db3.com_Staff.AsEnumerable()
                                                                on e.StaffID equals j.Id
                                                         join c in db3.com_StaffUsers.AsEnumerable()
                                                                on j.Id equals c.StaffId
                                                         join d in db3.com_Users.AsEnumerable()
                                                         on c.UserId equals d.Id
                                                         where d.Username == "s-parvaz"
                                                         select new Manager_Viewmodel()
                                                         {
                                                             WorkSectionTitle = e.WorkSectionTitle,
                                                             WorkSectionId = e.WorkSectionID,
                                                             JobStageId = e.JobStageID
                                                         });
            return selectjoin;
        }

        public IEnumerable<Manager_Viewmodel> Get_Manager_Username(int? jobStageId, int? WorksectionId)
        {

            Models.Model3.Model1 db3 = Models.Model3.Model1.GetInstance();
            Models.Model2.Model1 db2 = Models.Model2.Model1.GetInstance();
            IEnumerable<Manager_Viewmodel> selectjoin = (from e in db2.prs_Personnel.AsEnumerable()
                                                         join j in db3.com_StaffUsers.AsEnumerable()
                                                                on e.StaffID equals j.StaffId
                                                         join c in db3.com_Users.AsEnumerable()
                                                                on j.UserId equals c.Id
                                                         where e.JobStageID == jobStageId &&
                                                         e.WorkSectionID == WorksectionId
                                                         select new Manager_Viewmodel()
                                                         {
                                                             Manager_Username = c.Username
                                                         });
            return selectjoin;
        }
        public IList<Manager_Viewmodel> Get_Manager()
        {

            Models.Model3.Model1 db3 = Models.Model3.Model1.GetInstance();
            Models.Model2.Model1 db2 = Models.Model2.Model1.GetInstance();
            IEnumerable<Manager_Viewmodel> selectjoin = (from e in db2.prs_Personnel.AsEnumerable()
                                                         join j in db3.com_Staff.AsEnumerable()
                                                                on e.StaffID equals j.Id
                                                         join c in db3.com_StaffUsers.AsEnumerable()
                                                                on j.Id equals c.StaffId
                                                         join d in db3.com_Users.AsEnumerable()
                                                         on c.UserId equals d.Id
                                                         //where d.Username == "s-parvaz"
                                                         select new Manager_Viewmodel()
                                                         {
                                                             Manager_Username = d.Username,
                                                             JobStageId = e.JobStageID,
                                                             WorkSectionId = e.WorkSectionID

                                                         });
            return selectjoin.ToList();
        }
        public int DetectUser(string username)
        {
            var selectUser = Get_Manager_Stage(username).FirstOrDefault();
            int? jobstageId = selectUser.JobStageId;
            int? WorksectionId = selectUser.WorkSectionId;
            if (username == "m-rakhshanfar") { return 2; }//Manage_lab =>(jobstageId=6,worksectionId=38)
            else if (jobstageId == 6) { return 1; }//manager
            else { return 3; }//other
        }
        public IEnumerable<TblAdmin_Viewmodel> Get_Users()
        {

            IEnumerable<TblAdmin_Viewmodel> selectjoin = (from e in db.tbl_Admin.AsEnumerable()
                                                          select new TblAdmin_Viewmodel()
                                                          {
                                                              AdminID = e.AdminID,
                                                              GroupID = e.GroupID,
                                                              AdminUserName = e.AdminUserName,
                                                              AdminDsc = e.AdminDsc
                                                          });
            return selectjoin;
        }
        public IEnumerable<TblTestViewmodel> Get_Tests()
        {

            IEnumerable<TblTestViewmodel> selectjoin = (from e in db.tbl_Test.AsEnumerable()
                                                        select new TblTestViewmodel()
                                                        {
                                                            Test_ID = e.Test_ID,
                                                            Test_UID = e.Test_UID,
                                                            Test_Subject = e.Test_Subject,
                                                            Test_Standard_Code = e.Test_Standard_Code
                                                        });
            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Taradod()
        {
            
            IEnumerable<InquiryViewModel> selectAll = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                       //where p.Inquiry_Registered == null
                                                       select new InquiryViewModel
                                                       {
                                                           Inquiry_ID = p.InquiryID,
                                                           Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                           Inquiry_Admin = p.Inquiry_Admin,
                                                           Inquiry_Name = p.Inquiry_Name,
                                                           Inquiry_Type = p.Inquiry_Type,
                                                           Inquiry_Vahed = p.Inquiry_Vahed,
                                                           Inquiry_Date = p.Inquiry_Date,
                                                           Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                           Inquiry_Element = p.Inquiry_Element,
                                                           Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                           Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                           Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                           Inquiry_Count = p.Inquiry_Count,
                                                           Inquiry_Scale = p.Inquiry_Scale,
                                                           Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                           Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                           Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                           Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                           Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                           Inquiry_Related_Agent = p.Inquiry_Related_Agent
                                                       });
            return selectAll;
        }
        public IEnumerable<InquiryViewModel> GetInquiry()
        {
            var db = new Model1();
            // int DetectedUser = DetectUser(User.Identity.Name);
            if (StaticDetectedUser == 1)
            {
                //select manager query
                if (StaticInquiry_Name == null && StaticInquiry_Vahed == null && StaticInquiry_Main_ID == null && StaticElementCode == null && StaticAdminUsername == null)
                {
                    IEnumerable<InquiryViewModel> selectAll = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                               where p.Inquiry_Manager_UserName == User.Identity.Name

                                                               select new InquiryViewModel

                                                               {
                                                                   Id = p.InquiryID,
                                                                   Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                                   Inquiry_Admin = p.Inquiry_Admin,
                                                                   Inquiry_Name = p.Inquiry_Name,
                                                                   Inquiry_Type = p.Inquiry_Type,
                                                                   Inquiry_Vahed = p.Inquiry_Vahed,
                                                                   Inquiry_Date = p.Inquiry_Date,
                                                                   Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                                   Inquiry_Element = p.Inquiry_Element,
                                                                   Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                                   Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                                   Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                                   Inquiry_Count = p.Inquiry_Count,
                                                                   Inquiry_Scale = p.Inquiry_Scale,
                                                                   Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                                   Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                                   Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                                   Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                                   Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                                   Inquiry_Related_Agent = p.Inquiry_Related_Agent
                                                               });

                    return selectAll;
                }

                if (StaticInquiry_Name != "" || StaticInquiry_Vahed != "" || StaticInquiry_Main_ID != "" || StaticElementCode != "" || StaticAdminUsername != "")
                {
                    IEnumerable<InquiryViewModel> search = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                            where p.Inquiry_Manager_UserName == User.Identity.Name
                                                            select new InquiryViewModel
                                                            {
                                                                Id = p.InquiryID,
                                                                Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                                Inquiry_Admin = p.Inquiry_Admin,
                                                                Inquiry_Name = p.Inquiry_Name,
                                                                Inquiry_Type = p.Inquiry_Type,
                                                                Inquiry_Vahed = p.Inquiry_Vahed,
                                                                Inquiry_Date = p.Inquiry_Date,
                                                                Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                                Inquiry_Element = p.Inquiry_Element,
                                                                Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                                Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                                Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                                Inquiry_Count = p.Inquiry_Count,
                                                                Inquiry_Scale = p.Inquiry_Scale,
                                                                Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                                Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                                Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                                Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                                Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                                Inquiry_Related_Agent = p.Inquiry_Related_Agent

                                                            }).Where(q => q.Inquiry_Name == (StaticInquiry_Name) ||
                                                            q.Inquiry_Vahed == (StaticInquiry_Vahed) ||
                                                            q.Inquiry_Main_ID == (StaticInquiry_Main_ID) ||
                                                            q.Inquiry_Element_Code == (StaticElementCode) ||
                                                            q.Inquiry_Admin == (StaticAdminUsername));

                    return search;
                }

            }
            else if (StaticDetectedUser == 2)
            { //select manager_lab query
                if (StaticInquiry_Name == null && StaticInquiry_Vahed == null && StaticInquiry_Main_ID == null && StaticElementCode == null && StaticAdminUsername == null)
                {
                    IEnumerable<InquiryViewModel> selectAll = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                               where p.Inquiry_Manager_UserName == User.Identity.Name

                                                               select new InquiryViewModel

                                                               {
                                                                   Id = p.InquiryID,
                                                                   Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                                   Inquiry_Admin = p.Inquiry_Admin,
                                                                   Inquiry_Name = p.Inquiry_Name,
                                                                   Inquiry_Type = p.Inquiry_Type,
                                                                   Inquiry_Vahed = p.Inquiry_Vahed,
                                                                   Inquiry_Date = p.Inquiry_Date,
                                                                   Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                                   Inquiry_Element = p.Inquiry_Element,
                                                                   Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                                   Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                                   Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                                   Inquiry_Count = p.Inquiry_Count,
                                                                   Inquiry_Scale = p.Inquiry_Scale,
                                                                   Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                                   Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                                   Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                                   Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                                   Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                                   Inquiry_Related_Agent = p.Inquiry_Related_Agent
                                                               });

                    return selectAll;
                }
                
                if (StaticInquiry_Name != "" || StaticInquiry_Vahed != "" || StaticInquiry_Main_ID != "" || StaticElementCode != "" || StaticAdminUsername != "")
                {
                    IEnumerable<InquiryViewModel> search = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                            where p.Manager_Lab_Username == User.Identity.Name
                                                            select new InquiryViewModel
                                                            {
                                                                Id = p.InquiryID,
                                                                Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                                Inquiry_Admin = p.Inquiry_Admin,
                                                                Inquiry_Name = p.Inquiry_Name,
                                                                Inquiry_Type = p.Inquiry_Type,
                                                                Inquiry_Vahed = p.Inquiry_Vahed,
                                                                Inquiry_Date = p.Inquiry_Date,
                                                                Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                                Inquiry_Element = p.Inquiry_Element,
                                                                Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                                Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                                Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                                Inquiry_Count = p.Inquiry_Count,
                                                                Inquiry_Scale = p.Inquiry_Scale,
                                                                Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                                Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                                Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                                Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                                Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                                Inquiry_Related_Agent = p.Inquiry_Related_Agent

                                                            }).Where(q => q.Inquiry_Name == (StaticInquiry_Name) ||
                                                            q.Inquiry_Vahed == (StaticInquiry_Vahed) ||
                                                            q.Inquiry_Main_ID == (StaticInquiry_Main_ID) ||
                                                            q.Inquiry_Element_Code == (StaticElementCode) ||
                                                            q.Inquiry_Admin == (StaticAdminUsername));

                    return search;
                }
            }
            
            //select other users query
                if (StaticInquiry_Name == null && StaticInquiry_Vahed == null && StaticInquiry_Main_ID == null && StaticElementCode == null && StaticAdminUsername == null)
                {
                    IEnumerable<InquiryViewModel> selectAll = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                               select new InquiryViewModel
                                                               {
                                                                   Id = p.InquiryID,
                                                                   Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                                   Inquiry_Admin = p.Inquiry_Admin,
                                                                   Inquiry_Name = p.Inquiry_Name,
                                                                   Inquiry_Type = p.Inquiry_Type,
                                                                   Inquiry_Vahed = p.Inquiry_Vahed,
                                                                   Inquiry_Date = p.Inquiry_Date,
                                                                   Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                                   Inquiry_Element = p.Inquiry_Element,
                                                                   Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                                   Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                                   Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                                   Inquiry_Count = p.Inquiry_Count,
                                                                   Inquiry_Scale = p.Inquiry_Scale,
                                                                   Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                                   Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                                   Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                                   Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                                   Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                                   Inquiry_Related_Agent = p.Inquiry_Related_Agent
                                                               });

                    return selectAll;
                }

                if (StaticInquiry_Name != "" || StaticInquiry_Vahed != "" || StaticInquiry_Main_ID != "" || StaticElementCode != "" || StaticAdminUsername != "")
                {
                    IEnumerable<InquiryViewModel> search = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                            select new InquiryViewModel
                                                            {
                                                                Id = p.InquiryID,
                                                                Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                                Inquiry_Admin = p.Inquiry_Admin,
                                                                Inquiry_Name = p.Inquiry_Name,
                                                                Inquiry_Type = p.Inquiry_Type,
                                                                Inquiry_Vahed = p.Inquiry_Vahed,
                                                                Inquiry_Date = p.Inquiry_Date,
                                                                Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                                Inquiry_Element = p.Inquiry_Element,
                                                                Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                                Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                                Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                                Inquiry_Count = p.Inquiry_Count,
                                                                Inquiry_Scale = p.Inquiry_Scale,
                                                                Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                                Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                                Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                                Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                                Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                                Inquiry_Related_Agent = p.Inquiry_Related_Agent

                                                            }).Where(q => q.Inquiry_Name == (StaticInquiry_Name) ||
                                                            q.Inquiry_Vahed == (StaticInquiry_Vahed) ||
                                                            q.Inquiry_Main_ID == (StaticInquiry_Main_ID) ||
                                                            q.Inquiry_Element_Code == (StaticElementCode) ||
                                                            q.Inquiry_Admin == (StaticAdminUsername));

                    return search;
                }
                IEnumerable<InquiryViewModel> select = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                        select new InquiryViewModel
                                                        {
                                                            Id = p.InquiryID,
                                                            Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                            Inquiry_Admin = p.Inquiry_Admin,
                                                            Inquiry_Name = p.Inquiry_Name,
                                                            Inquiry_Type = p.Inquiry_Type,
                                                            Inquiry_Vahed = p.Inquiry_Vahed,
                                                            Inquiry_Date = p.Inquiry_Date,
                                                            Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                            Inquiry_Element = p.Inquiry_Element,
                                                            Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                            Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                            Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                            Inquiry_Count = p.Inquiry_Count,
                                                            Inquiry_Scale = p.Inquiry_Scale,
                                                            Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                            Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                            Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                            Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                            Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                            Inquiry_Related_Agent = p.Inquiry_Related_Agent
                                                        });
                return select;
        }
        public IEnumerable<InquiryViewModel> GetInquiry_Manage()
        {
            var db = new Model1();

            //select manager query
            if (StaticInquiry_Name == null && StaticInquiry_Vahed == null && StaticInquiry_Main_ID == null && StaticElementCode == null && StaticAdminUsername == null)
            {
                IEnumerable<InquiryViewModel> selectAll = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                           where p.Inquiry_Manager_UserName == "m-kakavand"//User.Identity.Name

                                                           select new InquiryViewModel

                                                           {
                                                               Id = p.InquiryID,
                                                               Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                               Inquiry_Admin = p.Inquiry_Admin,
                                                               Inquiry_Name = p.Inquiry_Name,
                                                               Inquiry_Type = p.Inquiry_Type,
                                                               Inquiry_Vahed = p.Inquiry_Vahed,
                                                               Inquiry_Date = p.Inquiry_Date,
                                                               Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                               Inquiry_Element = p.Inquiry_Element,
                                                               Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                               Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                               Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                               Inquiry_Count = p.Inquiry_Count,
                                                               Inquiry_Scale = p.Inquiry_Scale,
                                                               Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                               Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                               Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                               Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                               Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                               Inquiry_Related_Agent = p.Inquiry_Related_Agent
                                                           });

                return selectAll;
            }

            if (StaticInquiry_Name != "" || StaticInquiry_Vahed != "" || StaticInquiry_Main_ID != "" || StaticElementCode != "" || StaticAdminUsername != "")
            {
                IEnumerable<InquiryViewModel> search = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                        where p.Inquiry_Manager_UserName == "m-kakavand"//User.Identity.Name
                                                        select new InquiryViewModel
                                                        {
                                                            Id = p.InquiryID,
                                                            Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                            Inquiry_Admin = p.Inquiry_Admin,
                                                            Inquiry_Name = p.Inquiry_Name,
                                                            Inquiry_Type = p.Inquiry_Type,
                                                            Inquiry_Vahed = p.Inquiry_Vahed,
                                                            Inquiry_Date = p.Inquiry_Date,
                                                            Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                            Inquiry_Element = p.Inquiry_Element,
                                                            Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                            Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                            Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                            Inquiry_Count = p.Inquiry_Count,
                                                            Inquiry_Scale = p.Inquiry_Scale,
                                                            Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                            Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                            Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                            Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                            Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                            Inquiry_Related_Agent = p.Inquiry_Related_Agent

                                                        }).Where(q => q.Inquiry_Name == (StaticInquiry_Name) ||
                                                        q.Inquiry_Vahed == (StaticInquiry_Vahed) ||
                                                        q.Inquiry_Main_ID == (StaticInquiry_Main_ID) ||
                                                        q.Inquiry_Element_Code == (StaticElementCode) ||
                                                        q.Inquiry_Admin == (StaticAdminUsername));

                return search;
            }
            else
            {
                IEnumerable<InquiryViewModel> select = (from p in db.tbl_InquiryNews.AsEnumerable()
                                                        select new InquiryViewModel
                                                        {
                                                            Id = p.InquiryID,
                                                            Inquiry_Main_ID = p.Inquiry_Main_ID,
                                                            Inquiry_Admin = p.Inquiry_Admin,
                                                            Inquiry_Name = p.Inquiry_Name,
                                                            Inquiry_Type = p.Inquiry_Type,
                                                            Inquiry_Vahed = p.Inquiry_Vahed,
                                                            Inquiry_Date = p.Inquiry_Date,
                                                            Inquiry_NeededDate = p.Inquiry_NeededDate,
                                                            Inquiry_Element = p.Inquiry_Element,
                                                            Inquiry_Element_Rahgiri = p.Inquiry_Element_Rahgiri,
                                                            Inquiry_Map_Code = p.Inquiry_Map_Code,
                                                            Inquiry_Element_Type = p.Inquiry_Element_Type,
                                                            Inquiry_Count = p.Inquiry_Count,
                                                            Inquiry_Scale = p.Inquiry_Scale,
                                                            Inquiry_Element_Code = p.Inquiry_Element_Code,
                                                            Inquiry_Acception_Description = p.Inquiry_Acception_Description,
                                                            Inquiry_Tech_Code = p.Inquiry_Tech_Code,
                                                            Inquiry_Trace_Code = p.Inquiry_Trace_Code,
                                                            Inquiry_Client_Desc = p.Inquiry_Client_Desc,
                                                            Inquiry_Related_Agent = p.Inquiry_Related_Agent

                                                        });
                return select;

            }
        
        }

    
        

    

    
        public ActionResult Select_Report_kala([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_kala().ToDataSourceResult(request));
        }
        public IEnumerable<InquiryViewModel> Get_Report_kala()
        {

            //IEnumerable<InquiryViewModel> selectjoin = (from e in db.tbl_Inquiry.AsEnumerable()

            //                                                  select new InquiryViewModel()
            //                                                  {
            //                                                      Inquiry_ID = e.Inquiry_ID,
            //                                                      Inquiry_Element_Code = e.Inquiry_Element_Code,
            //                                                      Inquiry_Element = e.Inquiry_Element
            //                                                  });

            //var counts = db.tbl_Inquiry.GroupBy(x => x.Inquiry_Element_Code).AsEnumerable()
            //             .Select(g => new { g.Key, Count = g.Count() });
            //      var Grp = db.tbl_Inquiry.GroupBy(item => item.Inquiry_Element_Code)
            //.Select(group => new
            //{
            //    Customer = db.tbl_Inquiry.Count(),
            //    CustomerId = group.Key,
            //    Orders = group.ToList()
            //})
            //.ToList();


            //db.tbl_Inquiry.Select(a => a.Inquiry_Element)
            //                 .GroupBy()
            //                 .Select(g => new { g.Key.StateId, Count = g.Count() });
         
            var tmp = from x in db.tbl_InquiryNews
                      group x by x.Inquiry_Element_Code;

            IEnumerable<InquiryViewModel> selectjoin = from y in tmp
                                                       select new InquiryViewModel()
                         {
                             Id =1,
                             Inquiry_Element_Code = y.Key,
                             Element_count = y.Count(),
                             Inquiry_Element = y.FirstOrDefault().Inquiry_Element
                         };
            return selectjoin;
        }
        public ActionResult Select_Report_Inserted_Inquiry([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Inserted_Inquiry().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Final_Result([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Final_Result().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Test_Count([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Test_Count().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Saraneh([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Saraneh().ToList().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Salary([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Salary().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_AllInquiry([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_AllInquiry().ToList().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Taradod([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Taradod().ToList().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Inquiry_deny([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Inquiry_deny().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Outsource([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_OutSource().ToDataSourceResult(request));
        }
        public ActionResult Select_Report_Inquiry_Status([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Report_Inquiry_Status().ToDataSourceResult(request));
        }
        public ActionResult Select_Users([DataSourceRequest] DataSourceRequest request)
        {

            return Json(Get_Users().ToDataSourceResult(request));
        }
        public IEnumerable<InquiryViewModel> Get_Report_Inserted_Inquiry()
        {
            var tmp = from x in db.tbl_InquiryNews
                      group x by x.Inquiry_Confirm_Date;

            IEnumerable<InquiryViewModel> selectjoin = from y in tmp
                                                            where y.FirstOrDefault().Inquiry_Confirm_Date != "NULL"
                                                       select new InquiryViewModel()
                                                       {
                                                           Id = y.FirstOrDefault().InquiryID,
                                                          // Inquiry_Confirm_Date = y.Key,
                                                           Inquiry_Confirm_DateYear = y.FirstOrDefault().Inquiry_Confirm_Date.Substring(0, 4),
                                                           Inquiry_Confirm_DateMonth = y.FirstOrDefault().Inquiry_Confirm_Date.Substring(5, 2),
                                                           Inquiry_count = y.Count()
                                                           // Inquiry_Confirm_DateYear = y.FirstOrDefault().Inquiry_Confirm_Date.Substring(0, 4)

                                                           // Inquiry_Confirm_DateYear = y.FirstOrDefault().Inquiry_Confirm_Date.Substring(1,4)
                                                           //Inquiry_Confirm_DateMonth =
                                                       };
            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Report_OutSource()
        {
            IEnumerable<InquiryViewModel> selectjoin = from y in db.tbl_InquiryNews
                                                       select new InquiryViewModel()
                                                       {
                                                           Id = y.InquiryID,
                                                           Inquiry_Main_ID = y.Inquiry_Main_ID,
                                                           Inquiry_Name=y.Inquiry_Name,
                                                           Inquiry_Element=y.Inquiry_Element,
                                                           Inquiry_Element_Code=y.Inquiry_Element_Code,
                                                           Inquiry_Element_Gate_Pass_Count=y.Inquiry_Element_Gate_Pass_Count,
                                                           Inquiry_Element_Gate_Pass_Date=y.Inquiry_Element_Gate_Pass_Date,
                                                           Inquiry_Element_Lab_Pass_Date=y.Inquiry_Element_Lab_Pass_Date
                                                           
                                                       };
            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Report_Inquiry_Status()
        {
            var tmp = from x in db.tbl_InquiryNews
                      group x by x.Inquiry_Related_Agent;

            IEnumerable<InquiryViewModel> selectjoin = from y in tmp
                                                       
                                                       select new InquiryViewModel()
                                                       {
                                                           Inquiry_Related_Agent = y.Key,
                                                           Inquiry_count = y.Count()
                                                       };
            return selectjoin;
        }
        public IEnumerable<Test_Inquiry_Viewmodel> Get_Report_Salary()
        {
           
            IEnumerable<Test_Inquiry_Viewmodel> selectjoin = (from y in db.tbl_InquiryNews
                                                              join j in db.tbl_Inquiry_Tests.AsEnumerable()
                                                              on y.InquiryID equals j.Inquiry_ID
                                                              //where y.Inquiry_Confirm_Date != "" && j.Test_Inquiry_Coast!=""
                                                              select new Test_Inquiry_Viewmodel()
                                                              {
                                                                  Id = 1,
                                                                  Test_Inquiry_Coast = j.Test_Inquiry_Coast,
                                                                  _Inquiry_Date = y.Inquiry_Confirm_Date,
                                                                  _Inquiry_DateYear = y.Inquiry_Confirm_Date.Substring(0, 4),
                                                                  _Inquiry_DateMonth = y.Inquiry_Confirm_Date.Substring(5, 2),
                                                                  
                                                              });
            //var results = from x in db.tbl_Inquiry
            //              join j in db.tbl_Test_Inquiry.AsEnumerable()
            //              on x.Inquiry_ID equals j.Inquiry_ID
            //                group x by x.Inquiry_Date into g
            //              select new Test_Inquiry_Viewmodel()
            //              {
            //                  Id = 1,
            //                  Test_Inquiry_Coast = jj.
            //                  Cars = g.ToList()
            //              };

            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Report_AllInquiry()
        {
            var tmp = from x in db.tbl_InquiryNews
                      group x by x.status;
            IEnumerable<InquiryViewModel> selectjoin = (from y in tmp
                                                              //where e.Inquiry_ID == ModalStaticInquiryId
                                                              select new InquiryViewModel()
                                                              {
                                                                  Id = 1,
                                                                   status= y.Key,
                                                                  Inquiry_count = y.Count(),

                                                              });

            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Report_Inquiry_deny()
        {
            var tmp = from x in db.tbl_InquiryNews
                      group x by x.Inquiry_RejectedDesc;
            IEnumerable<InquiryViewModel> selectjoin = (from y in tmp
                                                           
                                                        select new InquiryViewModel()
                                                        {
                                                            Id = y.FirstOrDefault().InquiryID,
                                                            Inquiry_RejectedDesc = y.Key,
                                                            Inquiry_count = y.Count()
                                                        });

            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Report_Taradod()
        {
          
            IEnumerable<InquiryViewModel> selectjoin = (from y in db.tbl_InquiryNews
                                                        where y.Inquiry_Element_Gate_Pass!=null
                                                        select new InquiryViewModel()
                                                        {
                                                            Id = y.InquiryID,
                                                            Inquiry_Main_ID = y.Inquiry_Main_ID,
                                                            Inquiry_Admin = y.Inquiry_Admin,
                                                            Inquiry_Name = y.Inquiry_Name,
                                                            Inquiry_Element = y.Inquiry_Element,
                                                            Inquiry_Element_Code = y.Inquiry_Element_Code,
                                                            Inquiry_Count = y.Inquiry_Count,
                                                            Inquiry_Scale = y.Inquiry_Scale,
                                                            Inquiry_Element_Gate_Pass = y.Inquiry_Element_Gate_Pass,
                                                            Inquiry_Element_Gate_Pass_Date = y.Inquiry_Element_Gate_Pass_Date,
                                                            Inquiry_Element_Lab_Pass = y.Inquiry_Element_Lab_Pass,
                                                            Inquiry_Element_Lab_Pass_Date = y.Inquiry_Element_Lab_Pass_Date,
                                                        });

            return selectjoin;
        }
        public IEnumerable<InquiryViewModel> Get_Report_Saraneh()
        {
            var tmp = from x in db.tbl_InquiryNews
                      group x by x.Inquiry_Date;

            IEnumerable<InquiryViewModel> selectjoin = from y in tmp
                                                       where y.FirstOrDefault().Inquiry_Date != null
                                                       select new InquiryViewModel()
                                                       {
                                                           Id = y.FirstOrDefault().InquiryID,
                                                           Inquiry_Date = y.Key,
                                                           Inquiry_DateYear = y.FirstOrDefault().Inquiry_Date.Substring(0, 4),
                                                           Inquiry_DateMonth = y.FirstOrDefault().Inquiry_Date.Substring(5, 2),
                                                           Inquiry_count = y.Count(),
                                                       };
            return selectjoin;
        }
        public IEnumerable<Test_Inquiry_Viewmodel> Get_Report_Final_Result()
        {
            var tmp = from x in db.tbl_Inquiry_Tests
                      group x by x.Test_Inquiry_Final_Status;

            IEnumerable<Test_Inquiry_Viewmodel> selectjoin = from y in tmp
                                                       
                                                       select new Test_Inquiry_Viewmodel()
                                                       {
                                                           Id = y.FirstOrDefault().Inquiry_TestId,
                                                           Test_Inquiry_Final_Status = y.Key,
                                                           Inquiry_count = y.Count()
                                                       };
            return selectjoin;
        }
        public IEnumerable<Test_Inquiry_Viewmodel> Get_Report_Test_Count()
        {
            var tmp = from x in db.tbl_Inquiry_Tests
                      group x by x.Test_Inquiry_Done_Date;

            IEnumerable<Test_Inquiry_Viewmodel> selectjoin = from y in tmp
                                                             //where y.FirstOrDefault().Test_Inquiry_Done_Date != ""
                                                             select new Test_Inquiry_Viewmodel()
                                                             {
                                                                 Id = 1,//y.FirstOrDefault().Test_Inquiry_ID,
                                                                 Test_Inquiry_Done_Date = y.Key,
                                                                 Test_Inquiry_Done_DateMonth=y.FirstOrDefault().Test_Inquiry_Done_Date.Substring(5,2),
                                                                 Test_Inquiry_Done_DateYear=y.FirstOrDefault().Test_Inquiry_Done_Date.Substring(0,4),
                                                                 Inquiry_count = y.Count()

                                                             };
         
            //foreach(var item in selectjoin)
            //{

            //}
            return selectjoin ;
        }

        public ActionResult ManageOperationPopup_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetInquiry().ToDataSourceResult(request));
        }
        public ActionResult ManageOperationResultPopup_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetInquiry().ToDataSourceResult(request));
        }
        public ActionResult KartablePopup_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetInquiry().ToDataSourceResult(request));
        }
        public ActionResult InquiryPopup_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetInquiry_Manage().ToDataSourceResult(request));
        }
        public ActionResult TaradodPopup_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(Get_Taradod().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult InquiryPopup_Create([DataSourceRequest] DataSourceRequest request, InquiryViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                tbl_InquiryNew ti = new tbl_InquiryNew();
                //-------------------insert fields------------------------------- 
                ti.Inquiry_Name = model.Inquiry_Name;
                ti.Inquiry_Vahed = model.Inquiry_Vahed;
                ti.Inquiry_Date = model.Inquiry_Date;
                ti.Inquiry_NeededDate = model.Inquiry_NeededDate;
                ti.Inquiry_Type = model.Inquiry_Type;
                ti.Inquiry_Element = model.Inquiry_Element;
                ti.Inquiry_Element_Rahgiri = model.Inquiry_Element_Rahgiri;
                ti.Inquiry_Map_Code = model.Inquiry_Map_Code;
                ti.Inquiry_Element_Type = model.Inquiry_Element_Type;
                ti.Inquiry_Count = model.Inquiry_Count;
                ti.Inquiry_Scale = model.Inquiry_Scale;
                ti.Inquiry_Element_Code = model.Inquiry_Element_Code;
                ti.Inquiry_Acception_Description = model.Inquiry_Acception_Description;
                ti.Inquiry_Tech_Code = model.Inquiry_Tech_Code; //shomareh fani
                ti.Inquiry_Trace_Code = model.Inquiry_Trace_Code;//code rahgiri
                ti.Inquiry_Client_Desc = model.Inquiry_Client_Desc;//tozihat
                ti.Inquiry_Main_ID = model.Inquiry_Main_ID;
                             // ---------------------insert indicators--------------------------------------------------------
                ti.Inquiry_Admin = User.Identity.Name;
                ti.Inquiry_Manager_UserName = "";
                ti.Inquiry_Manager_Confirm = false;
                ti.Inquiry_Confirmed_ManagerLab = false;
                ti.Inquiry_Confirmed_ManagerLab_Date = "";
                ti.Inquiry_Confirmed = false;
                ti.Inquiry_Confirm_Date = model.Inquiry_Confirm_Date;
                ti.Inquiry_Final_Confirm = false;
                ti.Inquiry_Final_Confirm_Date = "";
                ti.Inquiry_Registered = model.Inquiry_Registered;
                ti.Inquiry_Register_Date = model.Inquiry_Register_Date;
                ti.Inquiry_Rejected = false;
                ti.Inquiry_Reject_Date = "";
                ti.Inquiry_RejectedDesc = "";
                ti.Inquiry_Related_Agent = model.Inquiry_Related_Agent; //name karshenas
                ti.status = model.status;
                db.tbl_InquiryNews.Add(ti);
                db.SaveChanges();
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult InquiryPopup_Update([DataSourceRequest] DataSourceRequest request, tbl_InquiryNew model)
        {
            if (model != null && ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Manage_inquiry");
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult InquiryPopup_Destroy([DataSourceRequest] DataSourceRequest request, tbl_InquiryNew product)
        {
            if (product != null)
            {

            }
            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [HttpGet]
        public ActionResult create_inquiry()
        {
         return View();
        }

        [HttpPost]
        public ActionResult create_inquiry(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    tbl_InquiryNew ti = new tbl_InquiryNew();
                  
                    //-------------------insert fields------------------------------- 
                    ti.Inquiry_Name = model.Inquiry_Name;
                    ti.Inquiry_Vahed = model.Inquiry_Vahed;
                    ti.Inquiry_Date = model.Inquiry_Date;
                    ti.Inquiry_NeededDate = model.Inquiry_NeededDate;
                    ti.Inquiry_Type = model.Inquiry_Type;
                    ti.Inquiry_Element = model.Inquiry_Element;
                    ti.Inquiry_Element_Rahgiri = model.Inquiry_Element_Rahgiri;
                    ti.Inquiry_Map_Code = model.Inquiry_Map_Code;
                    ti.Inquiry_Element_Type = model.Inquiry_Element_Type;
                    ti.Inquiry_Count = model.Inquiry_Count;
                    ti.Inquiry_Scale = model.Inquiry_Scale;
                    ti.Inquiry_Element_Code = model.Inquiry_Element_Code;
                    ti.Inquiry_Acception_Description = model.Inquiry_Acception_Description;
                    ti.Inquiry_Tech_Code = model.Inquiry_Tech_Code; //shomareh fani
                    ti.Inquiry_Trace_Code = model.Inquiry_Trace_Code;//code rahgiri
                    ti.Inquiry_Client_Desc = model.Inquiry_Client_Desc;//tozihat
                                       // ---------------------insert indicators--------------------------------------------------------
                    ti.Inquiry_Admin = User.Identity.Name;
                    ti.Inquiry_Manager_UserName = "";
                    ti.Inquiry_Manager_Confirm = false;
                    ti.Inquiry_Confirmed_ManagerLab = false;
                    ti.Inquiry_Confirmed_ManagerLab_Date = "";
                    ti.Inquiry_Confirmed = false;
                    ti.Inquiry_Confirm_Date = "";
                    ti.Inquiry_Final_Confirm = false;
                    ti.Inquiry_Final_Confirm_Date = "";
                    ti.Inquiry_Registered = model.Inquiry_Registered;
                    ti.Inquiry_Register_Date = model.Inquiry_Register_Date;
                    ti.Inquiry_Rejected = false;
                    ti.Inquiry_Reject_Date = "";
                    ti.Inquiry_RejectedDesc = "";
                    ti.Inquiry_Related_Agent = 0; //name karshenas
                   
                    db.tbl_InquiryNews.Add(ti);
                    db.SaveChanges();
                    return RedirectToAction("Manage_inquiry");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return View(model);
        }
        private static int ModalStaticInquiryId;


        [HttpGet]
        public ActionResult _Update_inquiry(int Id)
        {
            ModalStaticInquiryId = Id;
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == Id).FirstOrDefault();
            return PartialView("_Update_inquiry", model);
        }

        [HttpPost]
        public ActionResult _Update_inquiry(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Inquiry_Admin = "s-parvaz";//change to User.Identity.Name
                    model.Inquiry_Manager_UserName = StaticManager_Username;
                    model.Manager_Lab_Username = "m-rakhshanfar";
                    //---------------------------------------------------------------------
                    model.Inquiry_Manager_Confirm = false;
                    model.Inquiry_Confirmed_ManagerLab = false;
                    model.Inquiry_Confirmed_ManagerLab_Date = "";
                    model.Inquiry_Confirmed = false;
                    model.Inquiry_Confirm_Date = "";
                    model.Inquiry_Final_Confirm = false;
                    model.Inquiry_Final_Confirm_Date = "";
                    model.Inquiry_Registered = model.Inquiry_Registered;
                    model.Inquiry_Register_Date = model.Inquiry_Register_Date;
                    model.Inquiry_Rejected = false;
                    model.Inquiry_Reject_Date = "";
                    model.Inquiry_RejectedDesc = "";
                    model.Inquiry_Related_Agent = 0; //name karshenas  

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Manage_inquiry");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("_Update_inquiry");
        }

        [HttpGet]
        public ActionResult _Delete_inquiry(int Id)
        {
            ModalStaticInquiryId = Id;
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == Id).FirstOrDefault();
            return PartialView("_Delete_inquiry",model);
        }

        [HttpPost]
        public ActionResult _Delete_inquiry(tbl_InquiryNew model)
        {
            try
            {
               
                if (ModelState.IsValid)
                {
                    tbl_InquiryNew inq_model = new tbl_InquiryNew();
                    var selectForDel = db.tbl_Inquiry_Tests.Where(q => q.Inquiry_ID == model.InquiryID).ToList();
                    if (selectForDel.Count != 0)
                    {
                        foreach (var item in selectForDel)
                        {
                            item.Inquiry_ID = null;
                        }
                    }
                    inq_model.Inquiry_Admin="s-parvaz";//User.Identity.Name
                    inq_model.Inquiry_Manager_UserName = Get_Manager_Username(6, Get_Manager_Stage("s-parvaz").FirstOrDefault().WorkSectionId).FirstOrDefault().Manager_Username;
                    inq_model.Manager_Lab_Username = "m-rakhshanfar";
                    //---------------------------------------------------------------------
                    inq_model.Inquiry_Manager_Confirm = false;
                    inq_model.Inquiry_Confirmed_ManagerLab = false;
                    inq_model.Inquiry_Confirmed_ManagerLab_Date = "";
                    inq_model.Inquiry_Confirmed = false;
                    inq_model.Inquiry_Confirm_Date = "";
                    inq_model.Inquiry_Final_Confirm = false;
                    inq_model.Inquiry_Final_Confirm_Date = "";
                    inq_model.Inquiry_Registered = model.Inquiry_Registered;
                    inq_model.Inquiry_Register_Date = model.Inquiry_Register_Date;
                    inq_model.Inquiry_Rejected = false;
                    inq_model.Inquiry_Reject_Date = "";
                    inq_model.Inquiry_RejectedDesc = "";
                    inq_model.Inquiry_Related_Agent = 0; //name kars
                    db.Entry(inq_model).State = EntityState.Deleted;
                    //db.tbl_InquiryNews.Remove(inq_model);
                    db.SaveChanges();
                    return RedirectToAction("Manage_inquiry");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("_Delete_inquiry");
        }
        [HttpGet]
        public ActionResult _Create_inquiry()
        {
            
            return PartialView("_Create_inquiry");
        }

        [HttpPost]
        public ActionResult _Create_inquiry(tbl_InquiryNew model)
            {
            try
            {
                model.Inquiry_Admin = "s-parvaz";//User.Identity.Name
                model.Inquiry_Manager_UserName=Get_Manager_Username(6, Get_Manager_Stage("s-parvaz").FirstOrDefault().WorkSectionId).FirstOrDefault().Manager_Username;
                model.Manager_Lab_Username = "m-rakhshanfar";
                //---------------------------------------------------------------------
                    model.Inquiry_Manager_Confirm = false;
                    model.Inquiry_Confirmed_ManagerLab = false;
                    model.Inquiry_Confirmed_ManagerLab_Date = "";
                    model.Inquiry_Confirmed = false;
                    model.Inquiry_Confirm_Date = "";
                    model.Inquiry_Final_Confirm = false;
                    model.Inquiry_Final_Confirm_Date = "";
                    model.Inquiry_Registered = model.Inquiry_Registered;
                    model.Inquiry_Register_Date = model.Inquiry_Register_Date;
                    model.Inquiry_Rejected = false;
                    model.Inquiry_Reject_Date = "";
                    model.Inquiry_RejectedDesc = "";
                    model.Inquiry_Related_Agent = 0; //name karshenas  
                     db.tbl_InquiryNews.Add(model);
                     db.SaveChanges();
                    return RedirectToAction("Manage_inquiry");
              
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return View("Manage_inquiry");
        }
        [HttpGet]
        public ActionResult _Update_Kartable(int Id)
        {
            ModalStaticInquiryId = Id;
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == Id).FirstOrDefault();
            return PartialView("_Update_Kartable", model);
            
        }

        [HttpPost]
        public ActionResult _Update_Kartable(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("FirstPage");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("_Update_Kartable", model);
        }
        [HttpGet]
        public ActionResult _Update_Operation(int Id)
        {
            ModalStaticInquiryId = Id; //send inquiryId for partial views
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == Id).FirstOrDefault();
            return PartialView("_Update_Operation", model);
        }

        [HttpPost]
        public ActionResult _Update_Operation(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Manage_Operation");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("_Update_inquiry", model);
        }

        [HttpGet]
        public ActionResult _Update_ResultOperation(int Id)
        {
            string next = "";

            if (Id !=null)
            {

            }
            ViewBag.next = next;
            ViewBag.Id = Id;
            ModalStaticInquiryId = Id;
            IEnumerable<Test_Inquiry_Viewmodel> list;
            list= Get_Inquiry_Tests(ModalStaticInquiryId);
            foreach(var item in list)
            {
               // ViewBag.= item.Test_UID;

            }
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == Id).FirstOrDefault();
            return PartialView("_Update_ResultOperation", model);
        }

        [HttpPost]
        public ActionResult _Update_ResultOperation(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Manage_ResultOperation");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("_Update_ResultOperation", model);
        }
        private static int ModalStaticAdminId;
        [HttpGet]
        public ActionResult _Update_Users(int Id)
        {
            ModalStaticAdminId = Id;
            var model = db.tbl_Admin.Where(q => q.AdminID == Id).FirstOrDefault();
            return PartialView("_Update_Users",model);
        }

        [HttpPost]
        public ActionResult _Update_Users(tbl_Admin model)
        {
            try
            {
                    var SelForUpdate=db.tbl_Admin.Where(q => q.AdminID == ModalStaticAdminId).FirstOrDefault();
                    SelForUpdate.GroupID = model.GroupID;
                    db.Entry(SelForUpdate).State = EntityState.Modified;
                    db.SaveChanges();
                        return Json(Url.Action("Manage_Users", "Home"));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("Manage_Users", model);
        }
        [HttpGet]
        public ActionResult _Insert_payeh_Test()
        {
            // ModalStaticAdminId = Id;
            //var model = db.tbl_Admin.Where(q => q.AdminID == Id).FirstOrDefault();
            tbl_Test model = new tbl_Test();
            return PartialView("_Insert_payeh_Test", model);
        }

        [HttpPost]
        public ActionResult _Insert_payeh_Test(tbl_Test model)
        {
            try
            {
                // var SelForUpdate = db.tbl_Test.Where(q => q.Test_ID == model.Test_ID).FirstOrDefault();

                // db.Entry(model).State = EntityState.Modified;
                db.tbl_Test.Add(model);
                db.SaveChanges();
                return Json(model, JsonRequestBehavior.AllowGet);
                //return Json(Url.Action("Manage_Payeh", "Home"));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult _Update_Taradod(int Id)
        {
            ModalStaticInquiryId = Id;
            var model = db.tbl_InquiryNews.Where(q => q.InquiryID == Id).FirstOrDefault();
            return PartialView("_Update_Taradod", model);
        }

        [HttpPost]
        public ActionResult _Update_Taradod(tbl_InquiryNew model)
        {
            try
            {
                   
                var SelForUpdate = db.tbl_InquiryNews.Where(q => q.InquiryID == ModalStaticInquiryId).FirstOrDefault();
                SelForUpdate.Inquiry_Count = model.Inquiry_Count;
                if (model.Inquiry_Registered != true)
                    SelForUpdate.Inquiry_Registered = false;

                    SelForUpdate.Inquiry_Registered = model.Inquiry_Registered;
                SelForUpdate.Inquiry_Manager_UserName = model.Inquiry_Manager_UserName;
                SelForUpdate.Manager_Lab_Username = model.Manager_Lab_Username;
                db.Entry(SelForUpdate).State = EntityState.Modified;
                db.SaveChanges();
                return Json(Url.Action("Manage_taradod", "Home"));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return PartialView("Manage_taradod", model);
        }
        [HttpGet]
        public ActionResult Update_inquiry(int? id)
        {
            tbl_InquiryNew model = db.tbl_InquiryNews.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Update_inquiry(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Manage_inquiry");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete_inquiry(int? id)
        {
            tbl_InquiryNew model = db.tbl_InquiryNews.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete_inquiry(tbl_InquiryNew model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tbl_InquiryNews.Remove(model);
                    db.SaveChanges();
                    return RedirectToAction("Manage_inquiry");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return View(model);
        }



        #endregion
















        #region Users Authentication Actions
        [Authorize]
        public ActionResult Protected()
        {
            var user = (UserIdentity) User.Identity;
            return View((object)user.UserId);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult SuperAdmin()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View();
        }

        [Authorize]
        public ActionResult AdminOrSuperAdmin()
        {
            if (!User.IsInRole("SuperAdmin") && !User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [Authorize(Roles = "Admin, Author")]
        public ActionResult AdminOrAuthor()
        {
            return View();
        }
        
        [Authorize(Users = "karthik,testuser")]
        public ActionResult SelectedUsersOnly()
        {

            return View();
        }

        #region Get DropDownLists
        public JsonResult GetAdminDropdown(string text)
        {
            var northwind = new Model1();


            var Users = northwind.tbl_Admin.Select(User => new TblAdmin_Viewmodel
            {
                AdminID = User.AdminID,
                AdminUserName = User.AdminUserName
            });

            if (!string.IsNullOrEmpty(text))
            {
                Users = Users.Where(p => p.AdminUserName.Contains(text));
            }

            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetAdminGroupDropdown(string text)
        {
            var northwind = new Model1();


            var Users = northwind.tbl_AdminGroup.Select(User => new tbl_AdminGroupViewmodel
            {
                GroupID = User.GroupID,
                GroupName = User.GroupName
            });

            if (!string.IsNullOrEmpty(text))
            {
                Users = Users.Where(p => p.GroupName.Contains(text));
            }

            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        //public JsonResult GetTestDropdown(string text)
        //{
        //    var northwind = new Model1();
        //    var Users = northwind.tbl_Test.Select(User => new TblTestViewmodel
        //    {
        //        GroupID = User.GroupID,
        //        GroupName = User.GroupName
        //    });

        //    if (!string.IsNullOrEmpty(text))
        //    {
        //        Users = Users.Where(p => p.GroupName.Contains(text));
        //    }

        //    return Json(Users, JsonRequestBehavior.AllowGet);
        //}
        public JsonResult GetHardwareDropdown(string text)
        {
            var northwind = new Model1();
            var Users = northwind.tbl_Hardware.Select(User => new tbl_HardwareViewmodel
            {
                Hardware_ID = User.Hardware_ID,
                Hardware_Name = User.Hardware_Name
            });

            if (!string.IsNullOrEmpty(text))
            {
                Users = Users.Where(p => p.Hardware_Name.Contains(text));
            }

            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetInquiryNameDropdown(string text)
        {
            var northwind = new Models.Model2.Model1();


            var Users = northwind.prs_Personnel.Select(User => new TblPersonnelViemodel

            {
                Id = User.ID,
                FullName = User.FirstName + "" + User.LastName
                
            });

            if (!string.IsNullOrEmpty(text))
            {
                Users = Users.Where(p => p.FullName.Contains(text));
            }
            //String Result="";
            //SqlCommand sqlQuery = new SqlCommand();
            //sqlQuery.CommandText = "Select NameFamily from (select ROW_NUMBER() over (order by EmpId) as RowNum ,EmpId as PersonelID,Name + ' ' + Fmly as NameFamily";
            //sqlQuery.CommandText += " FROM [172.21.0.11].[raivarz].[ray].[Emp]";
            //sqlQuery.CommandText += " where Empid = '" + 206 + "'";
            //sqlQuery.CommandText += " group by EmpId,Name + ' ' + Fmly) as tbResult1";
            //Result = RunQuery(sqlQuery).Tables[0].Rows[0][0].ToString();
            //return Result;
            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetTblInquiry_NameDropdown(string text)
        {
            var northwind = new Model1();
            var Users2 = northwind.tbl_InquiryNews.Select(User => new InquiryViewModel

            {
                Inquiry_IDs = User.InquiryID,
                Inquiry_Names = User.Inquiry_Name
            });

            if (!string.IsNullOrEmpty(text))
            {
                Users2 = Users2.Where(p => p.Inquiry_Names.Contains(text));
            }
            return Json(Users2, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetInquiryTestDropdown(string text)
        {
            var northwind = new Model1();
            var Users = northwind.tbl_Test.Select(User => new TblTestViewmodel
            {
                Test_ID = User.Test_ID,
                Test_Subject = User.Test_Subject
            });

            return Json(Users, JsonRequestBehavior.AllowGet);
        }

        public static int LastItem=1;
   
        public JsonResult GetInquiryElementDropdown(string text)
        {
            var northwind = new Model1();
            var Users = northwind.tbl_InquiryNews.Select(User => new InquiryViewModel
            {
                Inquiry_ID = User.InquiryID,
                Inquiry_Element = User.Inquiry_Element
            });
            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetInquiryVahedDropdown(string text)
        {
            var northwind = new Models.Model2.Model1();
            var Users = northwind.prs_Personnel.Select(User => new TblPersonnelViemodel
            {
                WorkSectionID = User.WorkSectionID,
                WorkSectionTitle = User.WorkSectionTitle
            });

            return Json(Users, JsonRequestBehavior.AllowGet);
        }
        private DataSet RunQuery(SqlCommand sqlQuery)
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
            SqlConnection dbConnection = new SqlConnection();
            dbConnection.ConnectionString = connectionString;
            SqlDataAdapter dbAdapter = new SqlDataAdapter();
            dbAdapter.SelectCommand = sqlQuery;
            sqlQuery.Connection = dbConnection;
            DataSet resultsDataSet = new DataSet();
            try
            {
                dbAdapter.Fill(resultsDataSet);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return resultsDataSet;
        }
        #endregion

        #endregion










    }
}
