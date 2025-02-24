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
using Clinica_Eva.bdEvaDataSet3TableAdapters;


namespace Clinica_Eva
{
    public partial class MeniuMedic : Form
    {
        private int MedicID;
        public MeniuMedic(int account)
        {
            MedicID = account;
            InitializeComponent();
        }

        private void MeniuMedic_Load(object sender, EventArgs e)
        {
            // Filter data based on logged-in doctor's medicID
            string connectionString = "Data Source=COBZARU27\\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True"; // Replace with your connection string
            string sql = "SELECT  * FROM Programare WHERE medicID = @medicID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@medicID", MedicID);

                    // Access the underlying SqlDataAdapter 
                    programareTableAdapter.Adapter.SelectCommand = command;
                    programareTableAdapter.Adapter.Fill(this.bdEvaDataSet3.Programare);
                }
            }
        }


        private void MeniuMedic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewProgramare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBackMedic_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
