using CustomMembershipEF.Contexts;
using CustomMembershipEF.Entities;
using CustomMembershipEF.Interfaces;
using CustomMembershipEF.Models;
using CustomMembershipEF.Services;
using DataStreams.Csv;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;



namespace CustomMembershipEF.Providers_Methods
{
    public class Providers
    {
        #region Provider Database Code

        public void BuildFeedXML(HttpContext context, int channelId, string query)
        {

            //context.Response.OutputStream 
            using (XmlTextWriter writer = new XmlTextWriter(HttpContext.Current.Server.MapPath(@"~/XML Files/query1.xml"), Encoding.UTF8))
            {

                DataTable dt = GetData(query, channelId);// calling getdata for select from  table Channel.
                writer.WriteStartDocument(); // create RSS File and writing channel data and elements to it .
                writer.WriteStartElement("rss");
                writer.WriteAttributeString("version", "2.0");
                writer.WriteStartElement("channel");
                writer.WriteElementString("title", dt.Rows[0]["Title"].ToString());
                writer.WriteElementString("link", dt.Rows[0]["Link"].ToString());
                writer.WriteElementString("description", dt.Rows[0]["Description"].ToString());
                writer.WriteElementString("copyright", dt.Rows[0]["Copyright"].ToString());

                dt = GetData("SELECT * FROM Feeds WHERE ChannelId = @ChannelId", channelId); // calling getdata for select from another table Feeds
                foreach (DataRow dr in dt.Rows)
                {
                    writer.WriteStartElement("item"); //Append another data and elements RSS File which had created before and 
                    writer.WriteElementString("title", dr["Title"].ToString());

                    writer.WriteElementString("description", dr["Description"].ToString());
                    writer.WriteElementString("link", dr["Link"].ToString());
                    writer.WriteElementString("guid", dr["Id"].ToString());
                    writer.WriteElementString("pubDate", Convert.ToDateTime(dr["PublishedDate"]).ToString("R"));
                    writer.WriteEndElement();
                }
                // to save file with XML(RSS) format      
                XmlDocument doc = new XmlDocument();
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }

        public DataTable GetData(string query, int channelId)
        {

            DataTable dt = new DataTable(); // will fill with tables(feeds,channel) data later
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr)) // name of our connection string
            {
                using (SqlCommand cmd = new SqlCommand(query))//query is source field in our page
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ChannelId", channelId);
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            return dt;
        }
        #endregion


        #region CSVFile
        public void CsvWrite()
        {
           
            XmlTextWriter writer = new XmlTextWriter(HttpContext.Current.Server.MapPath(@"~/XML Files/csv.xml"), Encoding.UTF8); //info about Rss File which should created later for writing data from csv file

            writer.WriteStartDocument();
            writer.WriteStartElement("users");
           
            using (CsvReader reader = new CsvReader(HttpContext.Current.Server.MapPath(@"~/CSV File/users.csv"))) // info about CSV File which read data from that to XML File
            {
                reader.ReadHeaders();

                while (reader.ReadRecord()) // reading data and writing RSS file data and elements
                {
                    writer.WriteStartElement("user");

                    writer.WriteElementString("UserId", reader["UserId"]);
                    writer.WriteElementString("Name", reader["Name"]);
                    writer.WriteElementString("Family", reader["Family"]);

                    writer.WriteEndElement();
                }

                reader.Close();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
        #endregion
    }
}