namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ShamimInsertionLogs
    {
        public int ID { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public int? DepartmentRecordsCount { get; set; }

        public int? StaffRecordsCount { get; set; }

        public DateTime? InsertionDate { get; set; }
    }
}
