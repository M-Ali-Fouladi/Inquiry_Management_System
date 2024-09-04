using System.Data.Entity;
using System.Linq;
using CustomMembershipEF.Entities;
using System.Collections.Generic;


namespace CustomMembershipEF.Contexts
{
    
    public class UsersContext 
    {
        public static string name_main { get; set; }
        public static string family_main { get; set; }

        public static string birthdate_main { get; set; }
        public static string address_main { get; set; }
        public static string education_main { get; set; }

        public static string RoleId_main { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<product> Products { get; set; }






        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Project>().HasRequired(bm => bm.Users).WithMany().WillCascadeOnDelete(false);
        //    //base.OnModelCreating(modelBuilder);

        //}
      

        public void AddUser(User user)
        {
            user.Name = name_main;
            user.Family = family_main;
            user.Birthdate = birthdate_main;
            user.education = education_main;
            user.Address = address_main;
            user.RoleId = short.Parse(RoleId_main);
            Users.Add(user);

           // SaveChanges();
        }

        public User GetUser(string userName)
        {
            var user = Users.SingleOrDefault(u => u.UserName == userName);
            return user;
        }

        public IEnumerable<User> GetUsers(string userName)
        {

            var users = Users.Select(q=>q);
            return users;
        }
        public User GetUser(string userName, string password)
        {
            var user = Users.SingleOrDefault(u => u.UserName == userName && u.Password == password);

            return user;
        }

        public void AddUserRole(UserRole userRole)
        {
            var roleEntry = UserRoles.Where(r => r.UserId == userRole.UserId).Select(q=>q).FirstOrDefault();
            if (roleEntry != null)
            {
                UserRoles.Remove(roleEntry);
            //    SaveChanges();
                
            }
                UserRoles.Add(userRole);
             ///   SaveChanges();
        }

        public void UserRoleADDUpdate(User user,short role)
        {
            UserRole isRole = UserRoles.Where(q => q.UserId == user.UserId).Select(q => q).FirstOrDefault();
            
            
            if (isRole != null)
            {
                //-------------if user had a roleId in userRole Table just update
                
                UserRole roleEntry = UserRoles.Where(r => r.UserId == user.UserId).Select(q => q).FirstOrDefault();
                
                roleEntry.RoleId = role;
                
               // SaveChanges();
                return;
            }
            // ----------------------if user did`nt have any RoleId in UserRoles Table should insert
                UserRole ur = new UserRole();
                ur.UserId = user.UserId;
                ur.RoleId = role;
                UserRoles.Add(ur);
               // SaveChanges();
         
        
        }
    }
}
