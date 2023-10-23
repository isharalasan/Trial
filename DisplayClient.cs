using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class DisplayClient : MetroFramework.Forms.MetroForm
    {
        public DisplayClient()
        {
            InitializeComponent();
        }
        // SqlConnection con; //Pipeline
        // SqlDataAdapter da; //Basket

        DBConnection obj = new DBConnection();

        private void DisplayClient_Load(object sender, EventArgs e)
        {
            
            // con = new SqlConnection("Data Source=MILENEK-X;Initial Catalog=Bank;Integrated Security=True");
        }

        private void btn_dis_search_Click(object sender, EventArgs e)
        {
            string query = "Select * from Client";
          
            dataGridView1.DataSource = obj.Display(query);

            /*
            try
            {   con.Open();
                /*
                SqlCommand cmd_name = new SqlCommand("Select ClientName from Client where ClientId = '" + txt_dis_client_id.Text + "'", con);
                cmd_name.ExecuteNonQuery();
                txt_dis_client_name.Text = cmd_name.ExecuteScalar().ToString();

                SqlCommand cmd_address = new SqlCommand("Select ClientAddress from Client where ClientId = '" + txt_dis_client_id.Text + "'", con);
                cmd_address.ExecuteNonQuery();
                txt_dis_client_address.Text = cmd_address.ExecuteScalar().ToString();

                SqlCommand cmd_dob = new SqlCommand("Select ClientDOB from Client where ClientId = '" + txt_dis_client_id.Text + "'", con);
                cmd_dob.ExecuteNonQuery();
                datetime_dis_client_dob.Value = Convert.ToDateTime(cmd_dob.ExecuteScalar());

                SqlCommand cmd_age = new SqlCommand("Select ClientAge from Client where ClientId = '" + txt_dis_client_id.Text + "'", con);
                cmd_age.ExecuteNonQuery();
                txt_dis_client_age.Text = cmd_age.ExecuteScalar().ToString();

                SqlCommand cmd_telephone = new SqlCommand("Select ClientTP from Client where ClientId = '" + txt_dis_client_id.Text + "'", con);
                cmd_telephone.ExecuteNonQuery();
                txt_dis_client_telephone.Text = cmd_telephone.ExecuteScalar().ToString();

                con.Close();
                con.Dispose();
                

                da = new SqlDataAdapter("Select * from Client where ClientId = '" + txt_dis_client_id.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
