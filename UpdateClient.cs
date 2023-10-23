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
    public partial class UpdateClient : MetroFramework.Forms.MetroForm
    {
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {

        }

        private void btn_upd_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
