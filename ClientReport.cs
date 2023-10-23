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
    public partial class ClientReport : MetroFramework.Forms.MetroForm
    {
        public ClientReport()
        {
            InitializeComponent();
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'static_Report.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.static_Report.Client);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
