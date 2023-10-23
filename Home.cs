using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tile_registration_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.ShowDialog();
        }

        private void tile_update_client_Click(object sender, EventArgs e)
        {
            UpdateClient obj = new UpdateClient();
            obj.ShowDialog();
        }

        private void tile_delete_client_Click(object sender, EventArgs e)
        {
            DeleteClient obj = new DeleteClient();
            obj.ShowDialog();
        }

        private void tile_display_client_Click(object sender, EventArgs e)
        {
            DisplayClient obj = new DisplayClient();
            obj.ShowDialog();
        }

        private void tile_client_report_Click(object sender, EventArgs e)
        {
            ClientReport obj = new ClientReport();
            obj.ShowDialog();
        }
    }
}
