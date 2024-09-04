using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMembershipEF.Models
{
    public class tbl_Test_InquiryMaind
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Test_Inquiry_ID { get; set; }

        public string Test_Inquiry_Desc { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Coast { get; set; }


        public long? Test_ID { get; set; }
        //[ForeignKey("Test_ID")]
        //public tbl_Test tbl_Test { get; set; }

        public long? Inquiry_ID { get; set; }
        //[ForeignKey("Inquiry_ID")]
        //public tbl_InquiryNew tbl_InquiryNew { get; set; }

        [StringLength(200)]
        public string Test_Inquiry_Hardware_Desc { get; set; }

        public string Test_Inquiry_Way_Desc { get; set; }

        public string Test_Inquiry_Done_Desc { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_PreDone_Date { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Done_Date { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Done_Time { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_PreStart_Date { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Start_Date { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Start_Time { get; set; }

        public bool? Test_Inquiry_Final_Status { get; set; }

        [StringLength(50)]
        public string Test_NafarSaat { get; set; }

        [StringLength(50)]
        public string Test_NeededDate { get; set; }

        [StringLength(50)]
        public string Test_Ghatiat { get; set; }

        public int? Inquiry_Related_Agent { get; set; }

        [StringLength(50)]
        public string Inquiry_Assigned_Date { get; set; }

        public string Test_Inquiry_Result { get; set; }

        [StringLength(100)]
        public string Test_Standard_Code { get; set; }

        public string Test_Acception_Description { get; set; }

        public string Test_Inquiry_PreferedResult { get; set; }

        public bool? Inquiry_Final_Confirm { get; set; }

        [StringLength(50)]
        public string Inquiry_Final_Confirm_Date { get; set; }

        [StringLength(100)]
        public string Inquiry_Element_Rahgiri { get; set; }

        public bool? Inquiry_Element_Refer_Agent { get; set; }

        [StringLength(50)]
        public string Inquiry_Element_Refer_Agent_Date { get; set; }

        public int? Inquiry_Element_Alamat_Azmoon { get; set; }
    }
}