using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace webFormF
{
    public partial class web : System.Web.UI.Page
    {
        static string CS = ConfigurationManager.ConnectionStrings["UMRRecruitmentDBConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            viewPanel.Visible = false;
            editPanel.Visible = false;
           
            Reset();
        }
        
        public void Reset()
        {
            
            gdvCountry.DataSource = CountryDA.GetCountries();
            gdvCountry.DataBind();
        }

        
        protected void gdvCountry_SelectedIndexChanged1(object sender, EventArgs e)
        {
            viewPanel.Visible = true;
            editPanel.Visible = false;
            lblMessage.Text = "";
            foreach (GridViewRow row in gdvCountry.Rows)
            {
                if (row.RowIndex == gdvCountry.SelectedIndex)
                {
                    

                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }

            }

            
            lblCountryName.Text =gdvCountry.SelectedRow.Cells[1].Text;
            lblCountryDes.Text = gdvCountry.SelectedRow.Cells[2].Text;

            txtCountryName.Text = gdvCountry.SelectedRow.Cells[1].Text;
            txtDescription.Text = gdvCountry.SelectedRow.Cells[2].Text;
            datepicker.Value = gdvCountry.SelectedRow.Cells[4].Text;


        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            datepicker.Value= "";
            viewPanel.Visible = false;
            editPanel.Visible = true;
            txtCountryName.Text = "";
            txtDescription.Text = "";
            btnSave.Text = "INSERT";

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            viewPanel.Visible = false;
            editPanel.Visible = true;
            btnSave.Text = "UPDATE";
            //ValidationSummary1.Visible = false;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();


                try
                {
                    int COUNTRYID;
                    COUNTRYID = Convert.ToInt32(gdvCountry.SelectedRow.Cells[0].Text);
                    if (COUNTRYID > 0)
                    {

                        editPanel.Visible = false;
                        CountryDA.Delete(COUNTRYID);
                        lblMessage.Text = "Row Deleted successfully";
                        
                        viewPanel.Visible = false;
                        Reset();
                    }
                    else
                    {
                       
                        lblMessage.Text = "Please Select a Row to Delete the info";
                        
                    }

                }
                catch (SqlException ex)
                {

                    if (ex.Number ==547)
                    {
                        
                        lblMessage.Text = $"{ex.Number} occured.Sorry, You can't delete this row because it has associated row that you need to delete first.";
                    }
                    
                }


            }
        }

        //protected void btnImg_Click(object sender, ImageClickEventArgs e)
        //{
        
        //    editPanel.Visible = true;
        //    if (Calendar1.Visible)
        //    {
        //        Calendar1.Visible = false;

        //    }
        //    else
        //    {
        //        Calendar1.Visible = true;
        //    }
        //}

        //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        //{
        //    editPanel.Visible = true;
        //    //Calendar1.Visible = false;
        //    txtCreateDate.Text = Calendar1.SelectedDate.ToShortDateString();
        //}



        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                try
                {
                    if (btnSave.Text == "INSERT")
                    {
                        DateTime dateTime = DateTime.Parse(datepicker.Value);
                       
                        if (Page.IsValid)
                        {
                            if (!CountryDA.CountryNameCheck(txtCountryName.Text))
                            {
                                CountryDA.Insert(txtCountryName.Text, txtDescription.Text, dateTime);
                                lblMessage.Text = "Data Inserted successfully";
                                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Insert is successfull')", true);
                                Reset();
                                editPanel.Visible = false;
                                viewPanel.Visible = false;
                            }
                            else
                            {
                                lblMessage.Text = $"Country Name {txtCountryName.Text} Already Exists.  Data Can not be inserted!";
                                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Country name already exists.Data Can not be inserted!')", true);
                            }
                        }

                        


                    }
                    else if (btnSave.Text == "UPDATE")
                    {
                        DateTime dateTime = DateTime.Parse(datepicker.Value);
                        int COUNTRYID;

                        COUNTRYID = Convert.ToInt32(gdvCountry.SelectedRow.Cells[0].Text);

                        if (COUNTRYID > 0)
                        {
                            if (!CountryDA.DuplicateCheck(txtCountryName.Text, COUNTRYID))
                            {
                                if (Page.IsValid)
                                {
                                    CountryDA.Update(txtCountryName.Text, txtDescription.Text, dateTime, COUNTRYID);
                                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data updated successfully')", true);
                                    lblMessage.Text = "Data Updated successfully";
                                    editPanel.Visible = false;
                                    Reset();
                                }
                               
                            }
                            else
                            {
                                lblMessage.Text = $"Country Name {txtCountryName.Text} Already Exists. Data Can not be updated!";
                                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Country name already exists.Data Can not be inserted!')", true);
                            }
                        }
                        else
                        {

                            
                            lblMessage.Text = "Please Select a Country to update the info ";
                        }
                    }

                }
                catch (SqlException ex)
                {
                   
                  
                    Console.WriteLine(ex.Message);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            viewPanel.Visible = false;
            editPanel.Visible = false;
        }


        // paging
        protected void gdvCountry_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvCountry.PageIndex = e.NewPageIndex;
            Reset();
        }

        protected void gdvCountry_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gdvCountry, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

    }
}