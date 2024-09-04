using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomMembershipEF.Models
{
    public class Report_Test_Inquiry
    {

        public long Id { get; set; }
        public long Test_Inquiry_ID { get; set; }

        public long Inquiry_count { get; set; }
        public string Test_Subject { get; set; }
        public string Test_Standard_Code { get; set; }
        public string Test_UID { get; set; }
        public long Inquiry_ID { get; set; }
        public string Test_Inquiry_Coast { get; set; }
        public string Test_Inquiry_CoastSum { get; set; }
        public string Inquiry_Element { get; set; }
        public string Inquiry_Trace_Code { get; set; }
        public string Inquiry_Tech_Code { get; set; }
        public string Inquiry_Main_ID { get; set; }
        public string Inquiry_Date { get; set; }

        public string Inquiry_Name { get; set; }
        public string Inquiry_Vahed { get; set; }
        public string Test_Inquiry_Desc { get; set; }
        public string InquiryDate { get; set; }
        public string InquiryDateYear { get; set; }

        public string Inquiry_DateMonth { get; set; }


        public string Test_Inquiry_PreStart_Date { get; set; }
        public string Test_Inquiry_PreDone_Date { get; set; }
        public string Test_Inquiry_Start_Date { get; set; }
        public string Test_Inquiry_Done_Date { get; set; }
        public string Test_Inquiry_Done_DateYear { get; set; }
        public string Test_Inquiry_Done_DateMonth { get; set; }

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



        public long? Test_ID { get; set; }
    }
}