namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelReferencedLetters
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        [StringLength(1024)]
        public string LetterNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LetterDate { get; set; }
    }
}
