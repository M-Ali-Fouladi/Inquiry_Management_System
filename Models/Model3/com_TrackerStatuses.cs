namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_TrackerStatuses
    {
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? TableKey { get; set; }

        public int? DepartmentID { get; set; }

        public bool Deleted { get; set; }

        public bool? Primary { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool? SubDepartmentsUsable { get; set; }
    }
}
