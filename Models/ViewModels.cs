using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomMembershipEF.Models
{
    public class InquiryViewModel
    {
        public bool? Inquiry_Final_Confirm { get; set; }
        public long Id { get; set; }

        [Display(Name = "")]
        public int Element_count { get; set; }

        [Display(Name = "تعداد درخواست")]
        public int Inquiry_count { get; set; }
        //public int? Inquiry_Related_Agent { get; set; }

        public bool? Inquiry_Element_Gate_Pass { get; set; }
        public bool? Inquiry_Element_Lab_Pass { get; set; }

        [StringLength(70)]
        public string Inquiry_Element_Lab_Pass_Date { get; set; }
        [StringLength(70)]
        public string Inquiry_Element_Gate_Pass_Date { get; set; }
        public string keyvalue { get; set; }
        public string Inquiry_RejectedDesc { get; set; }

        public long Inquiry_ID { get; set; }
        public int? intid { get; set; }

        public string Inquiry_Names { get; set; }
        public long Inquiry_IDs { get; set; }


        [Display(Name = "نام کاربری")]
        public string Inquiry_Admin { get; set; }

        [Display(Name = "نام درخواست کننده")]
        public string Inquiry_Name { get; set; }
        
        [Display(Name = "نوع درخواست")]
        public int? Inquiry_Type { get; set; }
        [Display(Name = "نام واحد")]
        public string Inquiry_Vahed { get; set; }
        [Display(Name = "تاریخ درخواست")]
        public string Inquiry_Date { get; set; }
        public string Inquiry_DateYear { get; set; }
        public string Inquiry_DateMonth { get; set; }


        [Display(Name = "زمان پیشنهادی مشتری")]
        public string Inquiry_NeededDate { get; set; }
        [Display(Name = "قطعه")]
        public string Inquiry_Element { get; set; }
        public string Inquiry_Element_Rahgiri { get; set; }
        [Display(Name = "شماره نقشه")]
        public string Inquiry_Map_Code { get; set; }

        [Display(Name = "نوع قطعه")]
        public int? Inquiry_Element_Type { get; set; }
        [Display(Name = "تعداد نمونه")]
        public string Inquiry_Count { get; set; }
        [Display(Name = "واحد اندازه گیری")]
        public string Inquiry_Scale { get; set; }

        [Display(Name = "کد کالا")]
        
        public string Inquiry_Element_Code { get; set; }

        [Display(Name = "خروج از نگهبانی")]

        public string Inquiry_Element_Gate_Pass_Count { get; set; }

        public string Inquiry_Acception_Description { get; set; }
        [Display(Name = "شماره فنی")]
        public string Inquiry_Tech_Code { get; set; }
        [Display(Name = "کد رهگیری")]
        public string Inquiry_Trace_Code { get; set; }
        [Display(Name = "توضیحات")]
        public string Inquiry_Client_Desc { get; set; }
        [Display(Name = "شماره درخواست")]
        public string Inquiry_Main_ID { get; set; }
        public int? Inquiry_Related_Agent { get; set; }
        public string status { get; set; }
        public string Inquiry_Confirm_Date { get; set; }
        public string Inquiry_Confirm_DateYear { get; set; }
        public string Inquiry_Confirm_DateMonth { get; set; }

        public bool Inquiry_Registered { get; set; }
        public bool Inquiry_OutSource { get; set; }



        public string Inquiry_Register_Date { get; set; }

        [Display(Name = "زمان تقریبی انجام درخواست")]
        public string Inquiry_Primary_Date { get; set; }


    }
    public  class tbl_HardwareViewmodel
    {
      
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
    public class ViewmodelApp_obj
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string ObjName { get; set; }

        public int? PageID { get; set; }

        [StringLength(100)]
        public string ObjNameFA { get; set; }
    }
    public class Manager_Viewmodel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string WorkSectionTitle { get; set; }
        public int? WorkSectionId { get; set; }
        public int? JobStageId { get; set; }

        public int staffId { get; set; }
        public string Manager_Username { get; set; }
        



    }

    public class Test_Inquiry_Viewmodel
    {
        public long Id { get; set; }
        public long Inquiry_TestId { get; set; }
        public long? Test_ID { get; set; }

        public long Inquiry_count { get; set; }
        public string Test_Subject { get; set; }
        public string Test_Standard_Code { get; set; }
        public string Test_UID { get; set; }
        public long Inquiry_ID { get; set; }
        public string Test_Inquiry_Coast { get; set; }
        public string Test_Inquiry_CoastSum { get; set; }

        public string Test_Inquiry_Desc { get; set; }
        public string _Inquiry_Date { get; set; }
        public string _Inquiry_DateYear { get; set; }

        public string _Inquiry_DateMonth { get; set; }


        public string Test_Inquiry_PreStart_Date { get; set; }
        public string Test_Inquiry_PreDone_Date { get; set; }
        public string Test_Inquiry_Start_Date { get; set; }
        public string Test_Inquiry_Done_Date { get; set; }
        public string Test_Inquiry_Done_DateYear { get; set; }
        public string Test_Inquiry_Done_DateMonth { get; set; }
        public string Inquiry_Element { get; set; }
        public string Inquiry_Trace_Code { get; set; }
        public string Inquiry_Tech_Code { get; set; }
        public string Inquiry_Main_ID { get; set; }
        public string Inquiry_Date { get; set; }

        public string Inquiry_Name { get; set; }
        public string Inquiry_Vahed { get; set; }



        public string Test_Ghatiat { get; set; }
        public int? Inquiry_Element_Alamat_Azmoon { get; set; }
        public string Test_NafarSaat { get; set; }
        public string Inquiry_Element_Rahgiri { get; set; }
        
        public string Test_Inquiry_Start_Time { get; set; }
        public string Test_Inquiry_Done_Time { get; set; }

        public string Test_Inquiry_Way_Desc { get; set; }
        public string Test_Acception_Description { get; set; }
        public string Test_Inquiry_Result { get; set; }
        public bool? Test_Inquiry_Final_Status { get; set; }



       



    }
    public class TblAdmin_Viewmodel
    {
        public int AdminID { get; set; }
        public string AdminUserName { get; set; }
        
        public string AdminDsc { get; set; }

        public bool? AdminType { get; set; }

        public int GroupID { get; set; }
    }
    public  class tbl_AdminGroupViewmodel
    {
     
        public int GroupID { get; set; }
        
        public string GroupName { get; set; }
        
    }
    public class TblPersonnelViemodel
    {
        public int Id { get; set; }

        public string PersonnelNo { get; set; }
        public string FullName { get; set; }
        public int? WorkSectionID { get; set; }
        public string WorkSectionTitle { get; set; }



    }
    public class TblTestViewmodel
    {
        public long Test_ID { get; set; }
        public string Test_Subject { get; set; }
        public string Test_UID { get; set; }
        public string Test_Standard_Code { get; set; }




    }
    public class SearchStringViewmodel
    {
        public string ElementCode { get; set; }
        public string AdminUsername { get; set; }
        public string Inquiry_Vahed { get; set; }
        public string Inquiry_Main_ID { get; set; }
        public string Inquiry_Name { get; set; }

    }

}