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

namespace Clinica_Eva
{
    public partial class MeniuPacienti : Form
    {
        private int PacientID;
        private SqlCommand cmd;
        private int selectedDoctorID = -1;
       

        public MeniuPacienti(int account)
        {
            InitializeComponent();
            PacientID = account;
            dataGridViewIstoricP.Visible = false;
            cboInvestigatie.Items.AddRange(new string[] { "Consultatie", "Ecografie" });
        }

        SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PopulateSpecializariComboBox()
        {
            string query = "SELECT SpecializareID, Nume FROM Specializare"; // Include SpecializareID
            using (SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboSpecializari.DisplayMember = "Nume";
                    cboSpecializari.ValueMember = "SpecializareID"; // Correct ValueMember
                    cboSpecializari.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error populating specializations: {ex.Message}");
                }
            }
        }

        //private void PopulateInvestigatiiComboBox()
        //{
            
        //    string query = "SELECT InvestigatieID, Nume FROM Investigatii";
        //    using (SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True"))
        //    using (SqlCommand cmd = new SqlCommand(query, con))
        //    {
        //        try
        //        {
        //            con.Open();
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);

        //            cboInvestigatie.DisplayMember = "Nume";
        //            cboInvestigatie.ValueMember = "InvestigatieID"; // Correct ValueMember
        //            cboInvestigatie.DataSource = dt;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error populating investigations: {ex.Message}");
        //        }
        //    }
        //}
        private void MeniuPacienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdEvaDataSet.Medic' table. You can move, or remove it, as needed.
            this.medicTableAdapter.Fill(this.bdEvaDataSet.Medic);
            // TODO: This line of code loads data into the 'bdEvaDataSet2.Istoric' table. You can move, or remove it, as needed.
            this.istoricTableAdapter.Fill(this.bdEvaDataSet2.Istoric);

            PopulateSpecializariComboBox(); // Populate specializations
            //PopulateInvestigatiiComboBox(); // Populate investigations


        }

        private void MeniuPacienti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCautaDoc_Click(object sender, EventArgs e)
        {
            if (cboSpecializari.SelectedItem == null)
            {
                MessageBox.Show("Please select a specialization.");
                return;
            }

            int selectedSpecializareID = (int)cboSpecializari.SelectedValue;// Get the selected SpecializareID
            string query = "SELECT M.MedicID, M.SpecializareID, M.Nume, M.Prenume, M.DataNasterii, M.Grad, M.Titlu " +
                            "FROM Medic M " +
                            "INNER JOIN Specializare S ON M.SpecializareID = S.SpecializareID " +
                            "WHERE S.SpecializareID = @SpecializareID"; // Use SpecializareID in the query

            using (SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SpecializareID", selectedSpecializareID); // Use the correct ID parameter
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewMedicCauta.DataSource = dt;
                con.Close();
            }
        }

        private int GetSpecializationId(string specializationName)
        {
            string query = "SELECT SpecializareID FROM Specializare WHERE Nume = @Specializare";
            using (SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True")) // Use your connection string
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Specializare", specializationName);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    return id;
                }
                else
                {
                    // Handle invalid specialization
                    return -1;
                }
            }
        }

        private void btnIstoric_Click(object sender, EventArgs e)
        {
            //IstoricPacient f5 = new IstoricPacient();
            //f5.Show();
            //this.Hide();

            //dataGridViewIstoricP.Visible = true;

            string query = "select M.Titlu + M.Nume +' '+ M.Prenume as 'Nume Medic', S.Nume as 'Nume Specializare', Inv.Nume as 'Nume Investigatie', I.Diagnostic, I.Tratament, I.Observatii from Medic M inner join Istoric I on M.MedicID = I.MedicID inner join Investigatii Inv on I.InvestigatieID = Inv.InvestigatieID inner join Specializare S on S.SpecializareID = Inv.SpecializareID where I.PacientID = @PacientID;";

            try
            {
                con.Open();

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PacientID", PacientID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewIstoricP.DataSource = dt;
                dataGridViewIstoricP.Visible = true; // Make the DataGridView visible after data retrieval
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dataGridViewMedicCauta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("CellClick Event Fired!"); // Check if event is firing

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if valid cell is clicked
            {
                MessageBox.Show($"Row: {e.RowIndex}, Column: {e.ColumnIndex}"); // Display row and column index

                DataGridViewCell cell = dataGridViewMedicCauta.Rows[e.RowIndex].Cells[0]; // Access the first cell (MedicID)
                if (cell.Value != null && cell.Value != DBNull.Value)
                {
                    string medicIDValue = cell.Value.ToString();
                    if (int.TryParse(medicIDValue, out selectedDoctorID))
                    {
                        MessageBox.Show("MedicID: " + selectedDoctorID); // Confirm MedicID extraction
                        ScheduleAppointment();
                    }
                    else
                    {
                        MessageBox.Show("Invalid MedicID format.");
                    }
                }
                else
                {
                    MessageBox.Show("MedicID cell is null or DBNull.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Row or Column Index");
            }
        }


        private void ScheduleAppointment()
        {
            if (selectedDoctorID == -1)
            {
                MessageBox.Show("Please select a doctor from the table before scheduling.");
                return;
            }

            if (cboInvestigatie.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an investigation.");
                return;
            }

            string selectedInvestigation = cboInvestigatie.SelectedItem.ToString();
            int investigationID;

            // Map investigation name to ID (adjust IDs as per your database)
            switch (selectedInvestigation)
            {
                case "Consultatie":
                    investigationID = 1;
                    break;
                case "Ecografie":
                    investigationID = 2;
                    break;
                default:
                    investigationID = -1;
                    MessageBox.Show("Invalid investigation selected.");
                    return;
            }

            try
            {
                string query = @"INSERT INTO Programare (PacientID, MedicID, InvestigatieID, Data, Ora)
                                 VALUES (@PacientID, @MedicID, @InvestigatieID, @Data, @Ora);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True"))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PacientID", PacientID);
                    cmd.Parameters.AddWithValue("@MedicID", selectedDoctorID);
                    cmd.Parameters.AddWithValue("@InvestigatieID", investigationID);
                    cmd.Parameters.AddWithValue("@Data", dateTimePickerSolicitaP.Value.Date);
                    cmd.Parameters.AddWithValue("@Ora", dateTimePickerSolicitaP.Value.TimeOfDay);

                    con.Open();
                    int newProgramareID = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show($"Appointment scheduled successfully! Appointment ID: {newProgramareID}");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error scheduling appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show($"Invalid investigation ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewIstoricP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboSpecializari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSolicitaProgramare_Click(object sender, EventArgs e)
        {
            //if (selectedDoctorID == -1)
            //{
            //    MessageBox.Show("Va rugam selectati un doctor din tabel inainte de a solicita programarea.");
            //}
            //else
            //{
            //    // Doctor is selected, proceed with inserting programare
            //    try
            //    {
            //        string query = @"
            //    INSERT INTO Programare (ProgramareID, PacientID, MedicID, InvestigatieID, Data, Ora)
            //    VALUES (SELECT IDENT_CURRENT('Programare'), @PacientID, @MedicID, SELECT IDENT_CURRENT('Programare'), @Data, @Ora);
            //";

            //        using (SqlConnection con = new SqlConnection(@"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True"))
            //        using (SqlCommand cmd = new SqlCommand(query, con))
            //        {
            //            cmd.Parameters.AddWithValue("@PacientID", PacientID);
            //            cmd.Parameters.AddWithValue("@MedicID", selectedDoctorID);
            //            cmd.Parameters.AddWithValue("@Data", dateTimePickerSolicitaP.Value.Date);
            //            cmd.Parameters.AddWithValue("@Ora", dateTimePickerSolicitaP.Value.TimeOfDay);

            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            con.Close();

            //            MessageBox.Show("Programarea a fost solicitata cu succes!");
            //        }
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show($"A apărut o eroare la solicitarea programării: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void dateTimePickerSolicitaP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboInvestigatie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBackPacient_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}