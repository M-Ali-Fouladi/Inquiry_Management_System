using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using CustomMembershipEF.Entities;
using System.Collections.Generic;
namespace CustomMembershipEF.Entities
{
    public class UserRole
    {
        [
        Key]
        public int UserRoleId { get; set; }
        
        
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        

        public short? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        
    }
}