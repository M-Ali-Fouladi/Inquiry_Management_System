namespace CustomMembershipEF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CustomMembershipEF.Entities;
    using System.Collections.Generic;

    public partial class Model1 : DbContext
    {
        private static Model1 Instance;

        public Model1()
            : base("name=Model1")
        {
        }
        public static Model1 GetInstance()
        {
            if (Instance == null)
                Instance = new Model1();
            return Instance;
        }
        public virtual DbSet<Report_Test_Inquiry> Report_Test_Inquirys { get; set; }
        public virtual DbSet<tbl_InquiryNew> tbl_InquiryNews { get; set; }
       // public virtual DbSet<tbl_Test_InquiryNew> tbl_Test_InquiryNews { get; set; }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_App_Objs> tbl_App_Objs { get; set; }
        public virtual DbSet<tbl_App_Securable_Pages> tbl_App_Securable_Pages { get; set; }
        public virtual DbSet<tbl_Attachment> tbl_Attachment { get; set; }
        public virtual DbSet<tbl_Hardware> tbl_Hardware { get; set; }
        public virtual DbSet<tbl_Masraf> tbl_Masraf { get; set; }
        public virtual DbSet<tbl_Test> tbl_Test { get; set; }
        public virtual DbSet<tbl_Test_Inquiry_Hardware> tbl_Test_Inquiry_Hardware { get; set; }
        public virtual DbSet<tbl_Test_Inquiry_History> tbl_Test_Inquiry_History { get; set; }
        public virtual DbSet<tbl_Test_Inquiry_Masraf> tbl_Test_Inquiry_Masraf { get; set; }
        public virtual DbSet<tbl_AdminGroup> tbl_AdminGroup { get; set; }
        public virtual DbSet<tbl_App_Pages> tbl_App_Pages { get; set; }
        public virtual DbSet<tbl_App_Securables> tbl_App_Securables { get; set; }
        //public virtual DbSet<tbl_Inquiry> tbl_Inquiry { get; set; }
        public virtual DbSet<tbl_Inquiry950725> tbl_Inquiry950725 { get; set; }
        public virtual DbSet<tbl_Inquiry_kazemi> tbl_Inquiry_kazemi { get; set; }
        //public virtual DbSet<tbl_Test_InquiryMain> tbl_Test_InquiryMains { get; set; }
        public virtual DbSet<tbl_Inquiry_Test> tbl_Inquiry_Tests { get; set; }

        public virtual DbSet<tblTest> tblTests { get; set; }
        public virtual DbSet<tblTests1> tblTests1 { get; set; }


        public static string name_main { get; set; }
        public static string family_main { get; set; }
        public static string birthdate_main { get; set; }
        public static bool AdminType_main { get; set; }
        public static string AdminDsc_main { get; set; }

        public static string GroupID_main { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<tbl_Test_Inquiry_Masraf>()
            //    .Property(e => e.Masraf_Unit)
            //    .IsFixedLength();
        }

        public void AddUser(tbl_Admin user)
        {
            user.AdminUserName = name_main;
            user.AdminDsc = AdminDsc_main;
            user.AdminType = AdminType_main;
            user.GroupID = short.Parse(GroupID_main);
            tbl_Admin.Add(user);

             SaveChanges();
        }

        public tbl_Admin GetUser(string userName)
        {
            var user = tbl_Admin.SingleOrDefault(u => u.AdminUserName == userName);
            return user;
        }

        public IEnumerable<tbl_Admin> GetUsers(string userName)
        {

            var users = tbl_Admin.Select(q => q);
            return users;
        }
        public void AddUserRole(tbl_Admin Admin)
        {
            var roleEntry = tbl_Admin.Where(r => r.AdminID == Admin.AdminID).Select(q => q).FirstOrDefault();
            if (roleEntry != null)
            {
                tbl_Admin.Remove(roleEntry);
                   SaveChanges();

            }
            tbl_Admin.Add(Admin);
              SaveChanges();
        }

        public void UserRoleADDUpdate(tbl_Admin user, short role)
        {
            tbl_Admin isRole = tbl_Admin.Where(q => q.AdminID == user.AdminID).Select(q => q).FirstOrDefault();


            if (isRole != null)
            {
                //-------------if user had a roleId in userRole Table just update

                tbl_Admin roleEntry = tbl_Admin.Where(r => r.AdminID == user.AdminID).Select(q => q).FirstOrDefault();

                roleEntry.GroupID = role;

                 SaveChanges();
                return;
            }
            // ----------------------if user did`nt have any RoleId in UserRoles Table should insert
            tbl_Admin ur = new tbl_Admin();
            ur.AdminID = user.AdminID;
            ur.GroupID = role;
            tbl_Admin.Add(ur);
             SaveChanges();


        }
    }
}
