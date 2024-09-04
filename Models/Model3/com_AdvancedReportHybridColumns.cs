namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_AdvancedReportHybridColumns
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public com_AdvancedReportHybridColumns()
        {
            com_AdvancedReportHybridColumnElements = new HashSet<com_AdvancedReportHybridColumnElements>();
        }

        public int Id { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? TableKey { get; set; }

        public int? Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(256)]
        public string Caption { get; set; }

        public string SelectExpression { get; set; }

        public int? DataType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_AdvancedReportHybridColumnElements> com_AdvancedReportHybridColumnElements { get; set; }
    }
}
