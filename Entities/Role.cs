using System.ComponentModel.DataAnnotations;

namespace CustomMembershipEF.Entities
{
  
    public class Role
    {
        [Key]
        public short RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string RoleDescription { get; set; }
    }
}