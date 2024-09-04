using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMembershipEF.Entities
{
    public class ManageRssEntities
    {
        [Required]
        public string Provider { get; set; }


        [Required]
        public string Source { get; set; }



        public string picAddress { get; set; }

    }
}