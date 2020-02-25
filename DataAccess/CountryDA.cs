using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DataAccess
{
    public class CountryDA
    {
        static string CS = ConfigurationManager.ConnectionStrings["UMRRecruitmentDBConnectionString"].ConnectionString;
        //static CountryDA()
        //{
        //    var connection = ConfigurationManager.ConnectionStrings["UMRRecruitmentDBConnectionString"];
            
        //}
        
        public static DataTable GetCountries()
        {
            DataTable tbl = new DataTable();
            
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_FetchData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tbl);
                }
                catch (SqlException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            return tbl;
        }


        // checking duplicate country

        public static bool CountryNameCheck(string CountryName)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Country WHERE CountryName ='" + CountryName + "'", con);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Country WHERE CountryName ='" + CountryName + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    //MessageBox.Show($"Country Name {textName.Text} Already Exsist");
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


        // getting country byId
        public static DataTable GetCountryById(int countryId)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Country WHERE CountryId ='" + countryId + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];
            }

            return dt;
        }
        // checking duplicate country during update
        public static bool DuplicateCheck(string countryName, int countryId)
        {

            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Country WHERE CountryName='" + countryName + "' AND CountryId !=" + countryId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }


        // insertion of data
        public static void Insert(string countryName, string description, DateTime createDate)
        {

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO Country(CountryName, Description, CreatedBy, CreatedDate) VALUES (@CountryName,@Description,@CreatedBy,@CreatedDate)", con);

                SqlCommand cmd = new SqlCommand("sp_InsertData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CountryName", SqlDbType.NVarChar, 50).Value = countryName;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = description;

                cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = 5034;
                if (createDate == null || createDate == DateTime.MinValue )
                {
                    SqlParameter prmCreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
                    cmd.Parameters.Add(prmCreatedDate).Value = DateTime.Today;
                }
                else
                {
                    SqlParameter prmCreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
                    cmd.Parameters.Add(prmCreatedDate).Value = createDate;
                }
                
                cmd.ExecuteNonQuery();
            }

        }


        // update data :

        public static void Update(string countryName, string description, DateTime createDate, int countryId)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                //SqlCommand cmd = new SqlCommand("UPDATE Country SET CountryName=@CountryName, Description=@Description WHERE CountryId = @ID", con);
                SqlCommand cmd = new SqlCommand("sp_UpdateData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CountryName", SqlDbType.NVarChar, 50).Value = countryName;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = description;

                //cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = 5034;
                //SqlParameter prmCreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime);
                //cmd.Parameters.Add(prmCreatedDate).Value = createDate;
                if (createDate == null || createDate == DateTime.MinValue)
                {

                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@createDate", createDate);
                }
                //cmd.Parameters.AddWithValue("@createDate", createDate);
                cmd.Parameters.AddWithValue("@ID", countryId);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Data 
        public static void Delete(int countryId)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                //SqlCommand cmd = new SqlCommand("DELETE  FROM  Country WHERE CountryId = @ID", con);
                SqlCommand cmd = new SqlCommand("sp_DeleteData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", countryId);
                cmd.ExecuteNonQuery();
            }

        }


       

        
       
    }

}

