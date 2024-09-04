namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_TemplateStyles
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? ReportGuid { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(8)]
        public string PaperKind { get; set; }

        public int? PageOrientation { get; set; }

        public decimal? MarginTop { get; set; }

        public decimal? MarginRight { get; set; }

        public decimal? MarginBottom { get; set; }

        public decimal? MarginLeft { get; set; }

        public decimal? CellHeight { get; set; }

        public decimal? CellDefaultWidth { get; set; }

        [StringLength(32)]
        public string HeaderFontName { get; set; }

        public int? HeaderFontSize { get; set; }

        public bool? HeaderFontBold { get; set; }

        [StringLength(32)]
        public string RowFontName { get; set; }

        public int? RowFontSize { get; set; }

        public bool? RowFontBold { get; set; }

        [StringLength(16)]
        public string HeaderColor { get; set; }

        [StringLength(16)]
        public string EvenRowColor { get; set; }

        [StringLength(16)]
        public string OddRowColor { get; set; }

        [StringLength(16)]
        public string TotalSumColor { get; set; }

        [StringLength(16)]
        public string PageSumColor { get; set; }

        [StringLength(16)]
        public string SumFromFirstColor { get; set; }

        [StringLength(16)]
        public string PreviousPageSumColor { get; set; }

        public bool? DisplayPersianNumber { get; set; }

        public bool? DisplayPageNumber { get; set; }

        public bool? DisplayReportDate { get; set; }

        public bool? DisplayReportHeader { get; set; }

        public bool? DisplayTotalSum { get; set; }

        public bool? DisplayPageSum { get; set; }

        public bool? DisplaySumFromFirst { get; set; }

        public bool? DisplayPreviousPageSumInTop { get; set; }

        public bool? DisplayPreviousPageSumInBottom { get; set; }

        [StringLength(64)]
        public string HeaderPrintOn { get; set; }

        [StringLength(64)]
        public string SignaturPrintOn { get; set; }

        [StringLength(16)]
        public string CrossTabDetailColor { get; set; }

        [StringLength(16)]
        public string CrossTabTotalColor { get; set; }
    }
}
