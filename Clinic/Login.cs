using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Clinica_Eva
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True");
        SqlCommand cmd, cmdP,cmdM,cmdA;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAccount f2 = new CreateAccount();
            f2.Show();
            this.Hide();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True");
            con.Open();

            string query = "SELECT ContID  from Conturi WHERE Username = @username AND Parola = @Parola";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@Parola", txtParola.Text);
            int account = (int)cmd.ExecuteScalar();

            string qPacient = "select PacientID from Pacient where ContID = @account";
            cmdP = new SqlCommand(qPacient, con);
            cmdP.Parameters.AddWithValue("@account", account.ToString());
            // int isPacient = (int)cmdP.ExecuteScalar();
            object resP = cmdP.ExecuteScalar();
            int isPacient = resP != null ? (int)resP : 0;

            string qMedic = "select MedicID from Medic where ContID = @account";
            cmdM = new SqlCommand(qMedic, con);
            cmdM.Parameters.AddWithValue("@account", account.ToString());
            //int isMedic = (int)cmdM.ExecuteScalar();
            object resM = cmdM.ExecuteScalar();
            int isMedic = resM != null ? (int)resM : 0;

            string qAdministrator = "select AdministratorID from Administrator where ContID = @account";
            cmdA = new SqlCommand(qAdministrator, con);
            cmdA.Parameters.AddWithValue("@account", account.ToString());
            //int isAdministrator = (int)cmdM.ExecuteScalar();

            object resA = cmdA.ExecuteScalar();
            int isAdministrator = resA != null ? (int)resA : 0;

            con.Close();

            if (isPacient != 0)
            {
                MeniuPacienti f = new MeniuPacienti(isPacient);
                f.Show();
                this.Hide();
            }
            else if (isMedic != 0)
            {
                MeniuMedic f = new MeniuMedic(isMedic);
                f.Show();
                this.Hide();
            }
            else if (isAdministrator != 0)
            {
                MeniuAdministrator f = new MeniuAdministrator(isAdministrator);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eroare in logare");
            }
        }
        //private void Login_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
