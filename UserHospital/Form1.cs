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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       // private bool IsvalidUser(string userName, string password)
        //{
            //officeUsersLoginDataContext mdb = new officeUsersLoginDataContext();
            //var q = from a in mdb.UserTables
            //        where a.userName == metroTextBox2.Text
            //        && a.password == metroTextBox3.Text
            //        select a;

            //if (q.Any())
            //{
            //    return true;
            //}
            //else
            //{
            //   metroLabel4.Text= "Invalid Information please use correct information";
            //    return false;
            //}



        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void login_Click(object sender, EventArgs e)
        {
            //if (IsvalidUser(metroTextBox2.Text, metroTextBox3.Text))
            //{
            //    DashBoard u = new DashBoard();
            //    u.Show();
            //    this.Hide();
            //}

            if (metroComboBox1.Text == "OfficeUser")
            {
                officeUsersLoginDataContext mdb = new officeUsersLoginDataContext();
                var q = from a in mdb.UserTables
                        where a.userName == metroTextBox2.Text
                        && a.password == metroTextBox3.Text
                        select a;

                if (q.Any())
                   {
                        DashBoard u = new DashBoard();
                        
                        
                        u.Show();
                        
                        this.Hide();
                   }
                else
                {
                    metroLabel4.Text = "Invalid Information please use correct information";
                    //return false;
                }
            
              }
            if (metroComboBox1.Text == "Doctor")
            {
                DocDataDataContext mdb=new DocDataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\arbab\Downloads\UserHospital-20171213T080148Z-001\UserHospital\UserHospital\DB.mdf;Integrated Security=True;Connect Timeout=30");
                var q = from a in mdb.Doctors
                        where a.DuserName == metroTextBox2.Text
                        && a.Dpassword == metroTextBox3.Text
                        select a;
                if (q.Any())
                {
                    DocDash u = new DocDash();
                    DocDataDataContext mdt = new DocDataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\arbab\Downloads\UserHospital-20171213T080148Z-001\UserHospital\UserHospital\DB.mdf;Integrated Security=True;Connect Timeout=30");
                    var c = from a in mdt.Doctors
                            where a.DuserName == metroTextBox2.Text
                            select a;

                    u.Show();
                    this.Hide();
                    u.DDage.Text = c.First().Dage;
                    u.DDbloodgroup.Text = c.First().DbloodGroup;
                    u.DDdepartment.Text = c.First().Ddepartment;
                    u.DDdob.Text = c.First().Ddob;
                    u.DDgender.Text = c.First().Dgender;
                    u.DDname.Text = c.First().DName;
                    u.DDregDate.Text = c.First().DregDate;
                    u.DDmaritialSattus.Text = c.First().DmaritialStatus;

                    //this.Hide();
                }
                else
                {
                    metroLabel4.Text = "Invalid Information please use correct information";
                }
                    
            }

            
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SignUp z = new SignUp();
            z.Show();
            this.Hide();
        }
    }
}
