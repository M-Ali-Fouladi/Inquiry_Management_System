namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_BasePostHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BaseGuid { get; set; }

        [Column("_EffectiveDate", TypeName = "smalldatetime")]
        public DateTime? C_EffectiveDate { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public int? Code { get; set; }

        public int? JobID { get; set; }

        public int? PostGradeID { get; set; }

        public int? PostTypeID { get; set; }

        public int? PostNatureID { get; set; }

        public int? PostOperationalNatureID { get; set; }

        public int? PostJobCategoryID { get; set; }

        public int? PostJobFieldID { get; set; }

        public bool? Active { get; set; }

        public bool? Ruling { get; set; }

        [StringLength(256)]
        public string MinimumWorkingDuration { get; set; }

        public string Comments { get; set; }

        [Column("_Comment")]
        public string C_Comment { get; set; }

        public bool? Deleted { get; set; }

        public int? MinimumTrainingHours { get; set; }

        public int? ExtraRecordID { get; set; }
    }
}
