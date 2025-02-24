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

namespace Clinica_Eva
{
    public partial class MeniuAdministrator : Form
    {
        private SqlConnection con;
        private SqlDataAdapter medicDataAdapter;
        private DataTable medicDataTable;

        public MeniuAdministrator(int account)
        {
            InitializeComponent();

            // Connection String
            string connectionString = @"Data Source=COBZARU27\SQLEXPRESS;Initial Catalog=bdEva;Integrated Security=True";

            // Create SqlConnection object
            con = new SqlConnection(connectionString);

            // Create SqlCommand for SELECT statement (assuming table name is 'Medic')
            string selectCommand = "SELECT * FROM Medic";
            SqlCommand selectCmd = new SqlCommand(selectCommand, con);

            // Create SqlDataAdapter
            medicDataAdapter = new SqlDataAdapter(selectCmd);

            // Create SqlCommandBuilder (to handle inserts)
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(medicDataAdapter);

            // Create DataTable
            medicDataTable = new DataTable();

            // Fill DataTable with data from 'Medic' table
            medicDataAdapter.Fill(medicDataTable);

            // Bind DataGridView to DataTable
            dataGridViewMedic.DataSource = medicDataTable;
        }

        private void MeniuAdministrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdEvaDataSet1.Pacient' table. You can move, or remove it, as needed.
            this.pacientTableAdapter.Fill(this.bdEvaDataSet1.Pacient);
            // This line is no longer needed as data is loaded in the constructor
            // this.medicTableAdapter.Fill(this.bdEvaDataSet.Medic);
        }

        private void MeniuAdministrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveM_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have enabled editing in dataGridViewMedic (e.g., EditMode = EditOnEnter)
                medicDataAdapter.Update(medicDataTable);
                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void btnUpdateM_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the changed rows (if any)
                DataTable changedRows = medicDataTable.GetChanges();

                if (changedRows != null && changedRows.Rows.Count > 0)
                {
                    medicDataAdapter.Update(changedRows);
                    MessageBox.Show("Selected data updated successfully!");
                }
                else
                {
                    MessageBox.Show("No changes detected. Please make some edits.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedic.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the index of the selected row
                    int selectedRowIndex = dataGridViewMedic.SelectedRows[0].Index;

                    // Get the corresponding DataRow from the DataTable
                    DataRow selectedRow = medicDataTable.Rows[selectedRowIndex];

                    // Confirmation message
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            // Delete the row from the DataTable
                            selectedRow.Delete();

                            // Update the database 
                            medicDataAdapter.Update(medicDataTable);

                            // Refresh the DataGridView to reflect the changes
                            dataGridViewMedic.Refresh();

                            MessageBox.Show("Row deleted successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting data: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accessing selected row: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}