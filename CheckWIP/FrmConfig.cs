using CheckWIP.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckWIP
{
    public partial class FrmConfig : Form
    {
        Config config = new Config();
        public FrmConfig()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text.Trim();
            string database = txtDatabase.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            config.SaveConfig(server, database, username, password);
        }


        private void LoadConfig()
        {
            string[] setting = config.LoadConfig();
            txtServer.Text = setting[0];
            txtDatabase.Text = setting[1];
            txtUsername.Text = setting[2];
            txtPassword.Text = setting[3];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
