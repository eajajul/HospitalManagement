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
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PatientInformationDataContext MDC = new PatientInformationDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\eajajul\Documents\Visual Studio 2012\Projects\UserHospital\UserHospital\DB.mdf;Integrated Security=True;Connect Timeout=30");
            PatientData a = new PatientData();
            a.PregDate = PRegDate.Value.Date.ToString();
            a.Pname = PName.Text;
            a.Pgender = PGender.SelectedItem.ToString();
            a.Pdob = PDob.Value.Date.ToString();
            a.Poccupation = POccupation.Text;
            a.PmaritialStatus = PMaritialstatus.SelectedItem.ToString();
            a.Page = metroTextBox1.Text;

            a.PbloodGroup = PBloodGroup.SelectedItem.ToString();
            a.Paddress = PAddress.Text;
            a.Pcity = PCity.Text;
            a.PcontactNo = PContactNo.Text;
            a.Pcountry = PContactNo.Text;
            a.Pdepartment = PDepartment.SelectedItem.ToString();
            a.PconsultantName = PConsulant.SelectedItem.ToString();
            MDC.PatientDatas.InsertOnSubmit(a);
            MDC.SubmitChanges(); 





        }

        private void PDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PDepartment.Text == "Neurology")
            {
                PConsulant.Items.Clear();
                PConsulant.Items.AddRange(new string[]{"Dr Spot","Dr Rash"});
            }

            if(PDepartment.Text=="Ear nose and throat (ENT)")
            {
                PConsulant.Items.Clear();
                PConsulant.Items.AddRange(new string[]{"Dr Pulse", "Dr Borer"});

            }

            if (PDepartment.Text == "Orthopaedics")
            {
                PConsulant.Items.Clear();
                PConsulant.Items.AddRange(new string[] { "Dr Cure", "Dr Gore" });

            }

            if (PDepartment.Text == "General surgery")
            {
                PConsulant.Items.Clear();
                PConsulant.Items.AddRange(new string[] { "Dr Cheek", "Dr Frye" });

            }

            if (PDepartment.Text == "Cardiology")
            {
                PConsulant.Items.Clear();
                PConsulant.Items.AddRange(new string[] { "Dr Tanner", "Dr Pitts" });

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void PAge_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
