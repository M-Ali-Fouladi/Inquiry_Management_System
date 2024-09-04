namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FlowNodes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? FlowId { get; set; }

        public int? ParentId { get; set; }

        public int? OwnerId { get; set; }

        [Column(TypeName = "ntext")]
        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public int? StatusId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Deadline { get; set; }

        public int? OwningFlag { get; set; }

        [StringLength(50)]
        public string AlertIconFileName { get; set; }

        public int? FolderId { get; set; }

        public bool? Terminated { get; set; }

        public bool? Unread { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ViewDate { get; set; }

        public bool? Passed { get; set; }

        public int? PhaseId { get; set; }

        [StringLength(50)]
        public string StatusCaption { get; set; }

        [StringLength(50)]
        public string PhaseCaption { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }
    }
}
