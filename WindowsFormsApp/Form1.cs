using DataAccess;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using static DataAccess.CountryDA;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        static string CS = ConfigurationManager.ConnectionStrings["UMRRecruitmentDBConnectionString"].ConnectionString;
        public int COUNTRYID;

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }


        // Reset Section
        private void Reset()
        {
            dgvCountry.DataSource = CountryDA.GetCountries();
            textName.Clear();
            textDes.Clear();
            textName.Focus();
        }

        // Cancel Button
        private void cancel_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            viewPanel.Visible = false;

        }



        private void dgvCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            COUNTRYID = Convert.ToInt32(dgvCountry.SelectedRows[0].Cells[0].Value);

            viewPanel.Visible = true;
            label6.Text = dgvCountry.SelectedRows[0].Cells[1].Value.ToString();
            label7.Text = dgvCountry.SelectedRows[0].Cells[2].Value.ToString();
        }







        // Insert New item Section
        private void insertMenu_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;
            viewPanel.Visible = false;
            saveInfo.Text = "INSERT";
            Reset();
        }

        private void saveInfo_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                try
                {
                    if (saveInfo.Text == "INSERT")
                    {

                        if (!CountryDA.CountryNameCheck(textName.Text))
                        {

                            CountryDA.Insert(textName.Text, textDes.Text, dateTimePicker.Value);
                            MessageBox.Show("Data inserted Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                            EditPanel.Visible = false;
                            viewPanel.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show($"Country Name {textName.Text} Already Exsist");
                        }


                    }
                    else if (saveInfo.Text == "UPDATE")
                    {
                        if (COUNTRYID > 0)
                        {
                            if (!CountryDA.DuplicateCheck(textName.Text, COUNTRYID))
                            {
                                CountryDA.Update(textName.Text,textDes.Text, dateTimePicker.Value, this.COUNTRYID);
                                MessageBox.Show("Data Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Reset();
                                EditPanel.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show($"Country Name {textName.Text} Already Exsist");
                            }
                        }
                        else
                        {

                            MessageBox.Show("Please Select a Country to update the info", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (SqlException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        


        // Edit New Item
        private void editMenu_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                try
                {
                    Reset();
                    EditPanel.Visible = true;
                    viewPanel.Visible = false;
                    saveInfo.Text = "UPDATE";

                    //COUNTRYID = Convert.ToInt32(dgvCountry.SelectedRows[0].Cells[0].Value);

                    textName.Text = dgvCountry.SelectedRows[0].Cells[1].Value.ToString();
                    textDes.Text = dgvCountry.SelectedRows[0].Cells[2].Value.ToString();

                }
                catch (SqlException ex)
                {

                    Console.WriteLine(ex.Message);

                }
            }
            DataTable dt = CountryDA.GetCountryById(COUNTRYID);
            if (dt != null && dt.Rows.Count > 0)
            {
                textName.Text = dt.Rows[0]["CountryName"].ToString();
                textDes.Text = dt.Rows[0]["Description"].ToString();
            }
        }


        // Delete Item
        private void deleteMenu_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                try
                {
                    if (COUNTRYID > 0)
                    {

                        EditPanel.Visible = false;
                        CountryDA.Delete(this.COUNTRYID);
                        MessageBox.Show("Row Deleted successfully", "Deletd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewPanel.Visible = false;
                        Reset();
                    }
                    else
                    {

                        MessageBox.Show("Please Select a Row to Delete the info", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (SqlException ex)
                {

                    Console.WriteLine(ex.Message);

                }


            }
        }

    }
}

