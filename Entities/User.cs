using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMembershipEF.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        [Required]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        
   
        [Display(Name = "نام")]
        public string Name { get; set; }


        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }
       

        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
       // [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "ایمیل")]
        public string UserEmailAddress { get; set; }

        [Required]
        [Display(Name = "تاریخ تولد")]
        public string Birthdate { get; set; }

        
        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "تحصیلات")]
        public string education { get; set; }
        public int MemId { get; set; }

        //public int UserRoleId { get; set; }
        //[ForeignKey("UserRoleId")]
        //public virtual UserRole UserRole { get; set; }





        public short RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role role { get; set; }
     
    }
}