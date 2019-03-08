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
    public partial class DoctorReg : MetroFramework.Forms.MetroForm
    {
        public DoctorReg()
        {
            InitializeComponent();
        }

        private void DoctorReg_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DocDataDataContext MDC = new DocDataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\arbab\Downloads\UserHospital-20171213T080148Z-001\UserHospital\UserHospital\DB.mdf;Integrated Security=True;Connect Timeout=30");
            Doctor a = new Doctor();
            a.DregDate = dRegDate.Value.Date.ToString();
            a.DName = dName.Text;
            a.Dgender = dGender.Text;
            a.Ddepartment = dDepartment.Text;
            a.Ddob = dDob.Value.Date.ToString();
            a.Dage = dAge.Text;
            a.DbloodGroup = dBloodGroup.Text;
            a.DmaritialStatus = dMaritialstatus.Text;
            a.Daddress = dAddress.Text;
            a.Dcity = dCity.Text;
            a.Dcountry = dCountry.Text;
            a.DcontactNo = dContactNo.Text;
            a.DpatientList = DBNull.Value.ToString();
            a.DuserName = dUsername.Text;
            a.Dpassword = dPassword.Text;
            MDC.Doctors.InsertOnSubmit(a);
            MDC.SubmitChanges();



        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
