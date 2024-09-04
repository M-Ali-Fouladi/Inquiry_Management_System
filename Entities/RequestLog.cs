using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMembershipEF.Entities
{
    public class RequestLog
    {

        [Key]
        public int LogId { get; set; }

     
        public string UserName { get; set; }
        public string date { get; set; }

        public string Provider { get; set; }
        public string Source { get; set; }
    }
}