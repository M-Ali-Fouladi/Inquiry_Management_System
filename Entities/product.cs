using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMembershipEF.Entities
{
    public class product
    {
        [Key]
        public int Pid { get; set; }
        
        public string Pname { get; set; }

        public int Pcount { get; set; }
        public string Description { get; set; }  

    }
}