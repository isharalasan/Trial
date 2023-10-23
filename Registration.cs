using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using System.Data.SqlClient; // ADO.NET Library

namespace WindowsFormsApp11
{
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Registration()
        {
            InitializeComponent();
        }

        DBConnection obj = new DBConnection(); //once yoy create an object of the DBConnection class Defualt Constrauctor Automatically rune the program

        // SqlConnection con; // Initiate the pipeline.
        // SqlCommand cmd;

        private void Registration_Load(object sender, EventArgs e)
        {
            // con = new SqlConnection("Data Source=MILENEK-X;Initial Catalog=Bank;Integrated Security=True");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = "Insert into client values ('" + txt_reg_client_id.Text + "', '" + txt_reg_client_name.Text + "', '" + txt_reg_client_address.Text + "', '" + datetime_reg_client_dob.Value+ "', '" + txt_reg_client_age.Text + "', '" + txt_reg_client_telephone.Text + "')";
            
            int line = obj.Save_Update_Delete(query);

            if (line == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Data saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_clear_Click(sender, EventArgs.Empty);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Data cannot be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            /*
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert into Client values ('"+txt_reg_client_id.Text+ "', '"+txt_reg_client_name.Text+"', '"+ txt_reg_client_address.Text+"', '"+ datetime_reg_client_dob.Value + "', '"+ txt_reg_client_age.Text + "', '"+ txt_reg_client_telephone.Text + "')", con);
                
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_clear_Click(sender, EventArgs.Empty);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data cannot be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                con.Dispose();
            }
            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void datetime_reg_client_dob_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - datetime_reg_client_dob.Value.Year;

            if (DateTime.Now.Month < datetime_reg_client_dob.Value.Month)
                age -= 1;
            else if (DateTime.Now.Month == datetime_reg_client_dob.Value.Month && DateTime.Now.Date < datetime_reg_client_dob.Value.Date)
                age -= 1;
            txt_reg_client_age.Text = age.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_reg_client_id.Clear();
            txt_reg_client_name.Clear();
            txt_reg_client_address.Clear();
            datetime_reg_client_dob.Value = DateTime.Now;
            txt_reg_client_age.Clear();
            txt_reg_client_telephone.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
