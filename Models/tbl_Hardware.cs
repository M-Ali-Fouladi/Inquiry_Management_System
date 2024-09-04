namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Hardware
    {
        [Key]
        public long Hardware_ID { get; set; }

        public string Hardware_Name { get; set; }

        public string Hardware_Code { get; set; }

        public string Hardware_Serial { get; set; }

        public string Hardware_Site { get; set; }

        public bool? Hardware_Using { get; set; }

        public bool? Hardware_NotUsing { get; set; }

        public bool? Hardware_NCR { get; set; }

        public bool? Hardware_Calibration_External { get; set; }

        public bool? Hardware_Calibration_Internal { get; set; }

        public bool? Hardware_Programable { get; set; }
    }
}
