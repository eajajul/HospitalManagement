using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserHospital
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SignUp u = new SignUp();
            u.Show();
            //this.Hide();
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            DoctorReg u = new DoctorReg();
             u.Show();
            //this.Hide();
        }
    }
}
