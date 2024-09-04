namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Inquir
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Inquiry_ID { get; set; }

        [StringLength(50)]
        [Display(Name = "نام کاربری")]
        public string Inquiry_Admin { get; set; }

        [StringLength(100)]
        [Display(Name = "نام درخواست کننده")]
        public string Inquiry_Name { get; set; }

        [StringLength(50)]
        [Display(Name = "نام واحد")]
        public string Inquiry_Vahed { get; set; }

        [StringLength(50)]
        [Display(Name = "تاریخ درخواست")]
        public string Inquiry_Date { get; set; }

        [StringLength(50)]
        [Display(Name = "زمان پیشنهادی مشتری")]
        public string Inquiry_NeededDate { get; set; }

        [StringLength(200)]
        [Display(Name = "قطعه")]
        public string Inquiry_Element { get; set; }

        public bool? Inquiry_Element_Type1 { get; set; }

        [Display(Name = "نوع قطعه")]
        public int? Inquiry_Element_Type { get; set; }

        [StringLength(50)]
        public string Inquiry_Element_Rahgiri { get; set; }

        public bool? Inquiry_Element_Gate_Pass { get; set; }

        [StringLength(70)]
        public string Inquiry_Element_Gate_Pass_Date { get; set; }

        [StringLength(50)]
        public string Inquiry_Element_Gate_Pass_Count { get; set; }

        public bool? Inquiry_Element_Lab_Pass { get; set; }

        [StringLength(70)]
        public string Inquiry_Element_Lab_Pass_Date { get; set; }

        [StringLength(50)]
        public string Inquiry_Element_Lab_Pass_Count { get; set; }

        [StringLength(50)]
        [Display(Name = "شماره نقشه")]
        public string Inquiry_Map_Code { get; set; }

         [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        [Display(Name = "کد کالا")]
        public string Inquiry_Element_Code { get; set; }

        [Display(Name = "نوع درخواست")]
        public int? Inquiry_Type { get; set; }

        [StringLength(50)]
        [Display(Name = "شماره فنی")]
        public string Inquiry_Tech_Code { get; set; }

        [StringLength(50)]
        [Display(Name = "واحد اندازه گیری")]
        public string Inquiry_Scale { get; set; }

        [StringLength(50)]
        [Display(Name = "تعداد نمونه")]
        public string Inquiry_Count { get; set; }

        [StringLength(100)]
        [Display(Name = "کد رهگیری")]
        public string Inquiry_Trace_Code { get; set; }

        [Display(Name = "توضیحات")]
        public string Inquiry_Client_Desc { get; set; }

        public bool? Inquiry_Registered { get; set; }

        [StringLength(50)]
        public string Inquiry_Register_Date { get; set; }

        public bool? Inquiry_Confirmed_ManagerLab { get; set; }

        [Display(Name = "تایید درخواست")]
        public bool? Inquiry_Confirmed { get; set; }

        [StringLength(50)]
        public string Inquiry_Confirmed_ManagerLab_Date { get; set; }

        [StringLength(50)]
        public string Inquiry_Confirm_Date { get; set; }

        [Display(Name = "رد درخواست")]
        public bool? Inquiry_Rejected { get; set; }

        [StringLength(50)]
        public string Inquiry_Reject_Date { get; set; }

        [StringLength(200)]
        public string Inquiry_RejectedDesc { get; set; }

        public bool? Inquiry_Reserved { get; set; }

        public int? Inquiry_Related_Agent { get; set; }

        [StringLength(50)]
        public string Inquiry_Assigned_Date { get; set; }

        public string Inquiry_Acception_Description { get; set; }

        [StringLength(50)]
        public string Inquiry_Admin_Time { get; set; }

        public bool? Inquiry_Final_Confirm { get; set; }

        [StringLength(50)]
        public string Inquiry_Final_Confirm_Date { get; set; }
        [Display(Name = "شماره درخواست")]
        [StringLength(50)]
        public string Inquiry_Main_ID { get; set; }

        public bool? Inquiry_Manager_Confirm { get; set; }

        [StringLength(50)]
        [Display(Name = "زمان تقریبی انجام درخواست")]
       public string Inquiry_Primary_Date { get; set; }

        [StringLength(50)]
        public string Inquiry_Manager_UserName { get; set; }


        [Display(Name = "خارج از سازمان")]
        public bool? Inquiry_OutSource { get; set; }

        public string Inquiry_OutSource_Name { get; set; }

        [StringLength(50)]
        public string Inquiry_OutSource_Duration { get; set; }

        [StringLength(50)]
        public string Inquiry_OutSource_Cost { get; set; }

        public string Inquiry_Admin_History { get; set; }
        public string status { get; set; }
        public string Manager_Lab_Username { get; set; }

    }
}
