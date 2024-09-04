using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WebForms;
using CustomMembershipEF.Models;
using System.ComponentModel;
namespace CustomMembershipEF.Reports
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        public Models.Model1 db = new Models.Model1();
        public IEnumerable<Test_Inquiry_Viewmodel> Get_Inquiry_Tests(int? Inquiry_ID)
        {

            IEnumerable<Test_Inquiry_Viewmodel> selectjoin = (from e in db.tbl_Inquiry_Tests.AsEnumerable()
                                                              join j in db.tbl_InquiryNews.AsEnumerable()
                                                                     on e.Inquiry_ID equals j.InquiryID
                                                              join c in db.tbl_Test.AsEnumerable()
                                                                     on e.Test_ID equals c.Test_ID
                                                              where e.Inquiry_ID == Inquiry_ID
                                                              select new Test_Inquiry_Viewmodel()
                                                              {
                                                                  Test_Subject = c.Test_Subject,
                                                                  Test_Standard_Code = e.Test_Standard_Code,
                                                                  Test_UID = c.Test_UID,
                                                                  Test_Inquiry_PreStart_Date = e.Test_Inquiry_PreStart_Date,
                                                                  Test_Inquiry_PreDone_Date = e.Test_Inquiry_PreDone_Date,
                                                                  Inquiry_TestId = e.Inquiry_TestId,
                                                                  Test_Inquiry_Start_Date = e.Test_Inquiry_Start_Date,
                                                                  Inquiry_Element_Rahgiri = e.Inquiry_Element_Rahgiri,
                                                                  Test_Inquiry_Start_Time = e.Test_Inquiry_Start_Time,
                                                                  Test_Inquiry_Done_Time = e.Test_Inquiry_Done_Time,
                                                                  Test_Inquiry_Done_Date = e.Test_Inquiry_Done_Date,
                                                                  Test_Inquiry_Way_Desc = e.Test_Inquiry_Way_Desc,
                                                                  Test_Ghatiat = e.Test_Ghatiat,
                                                                  Test_Acception_Description = e.Test_Acception_Description,
                                                                  Test_Inquiry_Result = e.Test_Inquiry_Result,

                                                                  Inquiry_Element = j.Inquiry_Element,
                                                                  Inquiry_Name = j.Inquiry_Name,
                                                                  Inquiry_Trace_Code = j.Inquiry_Trace_Code,
                                                                  Inquiry_Tech_Code = j.Inquiry_Tech_Code,
                                                                  Inquiry_Vahed = j.Inquiry_Vahed,
                                                                  Inquiry_Main_ID = j.Inquiry_Main_ID,
                                                                  Inquiry_Date = j.Inquiry_Date
                                                              });
            return selectjoin;
        }
        public DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
        DataTable GetConvertedDataTable(string id)
        {
            DataTable dt = new DataTable();
            dt=ConvertToDataTable(Get_Inquiry_Tests(int.Parse(id)));
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);
            //SqlDataAdapter da = new SqlDataAdapter("Select *  from tbl_Test_Inquiry where Inquiry_ID=" + "'" + id + "'", con);
            // SqlDataAdapter da = new SqlDataAdapter("Select top(1)*  from users", con);
            
           // da.Fill(dt);
            return dt;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["ReportID"] != null)
                {
                    string reportID = Request.QueryString["ReportID"].ToString();
                    ReportViewer1.Reset();
                    DataTable dt = GetConvertedDataTable(reportID);
                    dt.Columns.Add();
                    ReportViewer1.LocalReport.ReportPath = "Reports/Report1.rdlc";
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    ReportViewer1.DataBind();
                    ReportViewer1.LocalReport.Refresh();
                }

            }
        }
    }
}