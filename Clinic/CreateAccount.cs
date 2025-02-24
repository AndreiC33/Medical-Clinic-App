using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Clinica_Eva
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        //string constring = "Data Source=COBZARU27\\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True");
        SqlCommand cmd1, cmd2, cmd3, cmd4;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            //  cmd1 = new SqlCommand("insert into Conturi values('" + txtUserCreate.Text + "','" + txtParolaCreate.Text + "')", con);
            string q1 = "INSERT INTO Conturi values(@Username, @Parola)";
            cmd1 = new SqlCommand(q1, con);
            cmd1.Parameters.AddWithValue("@Username", txtUserCreate.Text);
            cmd1.Parameters.AddWithValue("@Parola", txtParolaCreate.Text);
            //int count = (int)cmd1.ExecuteScalar();

            cmd1.ExecuteNonQuery();


            string q2 = "SELECT ContID from Conturi WHERE Username = @Username AND Parola = @Parola";
            cmd2 = new SqlCommand(q2, con);
            cmd2.Parameters.AddWithValue("@Username", txtUserCreate.Text);
            cmd2.Parameters.AddWithValue("@Parola", txtParolaCreate.Text);
            //cmd2 = new SqlCommand(q, con);
            //cmd2.ExecuteNonQuery();
            int contID = (int)cmd2.ExecuteScalar();
            // int contID = Convert.ToInt32(cmd2.ExecuteScalar());


            string q3 = "insert into Pacient values( @Nume, @Prenume, @CNP, @DataNasterii, @Sex, @Asigurat, @MedicFamilie, @ContID)";
            cmd3 = new SqlCommand(q3, con);
            cmd3.Parameters.AddWithValue("@Nume", txtNumeCreate.Text);
            cmd3.Parameters.AddWithValue("@Prenume", txtPrenumeCreate.Text);
            cmd3.Parameters.AddWithValue("@CNP", txtCnpCreate.Text);
            cmd3.Parameters.AddWithValue("@DataNasterii", dateTimePicker1.Text);
            cmd3.Parameters.AddWithValue("@Sex", cboSex.Text);
            cmd3.Parameters.AddWithValue("@Asigurat", cboAsigurat.Text);
            cmd3.Parameters.AddWithValue("@MedicFamilie", txtMedicFamCreate.Text);
            cmd3.Parameters.AddWithValue("@ContID", contID);
            _ = cmd3.ExecuteNonQuery();

            //string q4 = "Select PacientID from Pacient where ContID = @ContID";
            //cmd4 = new SqlCommand(q4, con);
            //cmd4.Parameters.AddWithValue("@ContID", contID);
            //int PacientID = (int)cmd4.ExecuteScalar();

            con.Close();

            if (contID > 0)
            {
                MeniuPacienti f3 = new MeniuPacienti(contID);
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eroare in Creere");
            }
            //MeniuPacienti f3 = new MeniuPacienti();
            //f3.Show();
            //this.Hide();


        }
    }
}
