namespace Clinica_Eva
{
    partial class MeniuMedic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProgramare = new System.Windows.Forms.DataGridView();
            this.bdEvaDataSet3 = new Clinica_Eva.bdEvaDataSet3();
            this.programareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programareTableAdapter = new Clinica_Eva.bdEvaDataSet3TableAdapters.ProgramareTableAdapter();
            this.programareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investigatieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackMedic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgramare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProgramare
            // 
            this.dataGridViewProgramare.AutoGenerateColumns = false;
            this.dataGridViewProgramare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgramare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programareIDDataGridViewTextBoxColumn,
            this.pacientIDDataGridViewTextBoxColumn,
            this.medicIDDataGridViewTextBoxColumn,
            this.investigatieIDDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.oraDataGridViewTextBoxColumn});
            this.dataGridViewProgramare.DataSource = this.programareBindingSource;
            this.dataGridViewProgramare.Location = new System.Drawing.Point(12, 250);
            this.dataGridViewProgramare.Name = "dataGridViewProgramare";
            this.dataGridViewProgramare.RowHeadersWidth = 51;
            this.dataGridViewProgramare.RowTemplate.Height = 24;
            this.dataGridViewProgramare.Size = new System.Drawing.Size(953, 150);
            this.dataGridViewProgramare.TabIndex = 0;
            this.dataGridViewProgramare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProgramare_CellContentClick);
            // 
            // bdEvaDataSet3
            // 
            this.bdEvaDataSet3.DataSetName = "bdEvaDataSet3";
            this.bdEvaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programareBindingSource
            // 
            this.programareBindingSource.DataMember = "Programare";
            this.programareBindingSource.DataSource = this.bdEvaDataSet3;
            // 
            // programareTableAdapter
            // 
            this.programareTableAdapter.ClearBeforeFill = true;
            // 
            // programareIDDataGridViewTextBoxColumn
            // 
            this.programareIDDataGridViewTextBoxColumn.DataPropertyName = "ProgramareID";
            this.programareIDDataGridViewTextBoxColumn.HeaderText = "ProgramareID";
            this.programareIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programareIDDataGridViewTextBoxColumn.Name = "programareIDDataGridViewTextBoxColumn";
            this.programareIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.programareIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pacientIDDataGridViewTextBoxColumn
            // 
            this.pacientIDDataGridViewTextBoxColumn.DataPropertyName = "PacientID";
            this.pacientIDDataGridViewTextBoxColumn.HeaderText = "PacientID";
            this.pacientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pacientIDDataGridViewTextBoxColumn.Name = "pacientIDDataGridViewTextBoxColumn";
            this.pacientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicIDDataGridViewTextBoxColumn
            // 
            this.medicIDDataGridViewTextBoxColumn.DataPropertyName = "MedicID";
            this.medicIDDataGridViewTextBoxColumn.HeaderText = "MedicID";
            this.medicIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicIDDataGridViewTextBoxColumn.Name = "medicIDDataGridViewTextBoxColumn";
            this.medicIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // investigatieIDDataGridViewTextBoxColumn
            // 
            this.investigatieIDDataGridViewTextBoxColumn.DataPropertyName = "InvestigatieID";
            this.investigatieIDDataGridViewTextBoxColumn.HeaderText = "InvestigatieID";
            this.investigatieIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.investigatieIDDataGridViewTextBoxColumn.Name = "investigatieIDDataGridViewTextBoxColumn";
            this.investigatieIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // oraDataGridViewTextBoxColumn
            // 
            this.oraDataGridViewTextBoxColumn.DataPropertyName = "Ora";
            this.oraDataGridViewTextBoxColumn.HeaderText = "Ora";
            this.oraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oraDataGridViewTextBoxColumn.Name = "oraDataGridViewTextBoxColumn";
            this.oraDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnBackMedic
            // 
            this.btnBackMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackMedic.Location = new System.Drawing.Point(47, 61);
            this.btnBackMedic.Name = "btnBackMedic";
            this.btnBackMedic.Size = new System.Drawing.Size(93, 37);
            this.btnBackMedic.TabIndex = 1;
            this.btnBackMedic.Text = "Back";
            this.btnBackMedic.UseVisualStyleBackColor = true;
            this.btnBackMedic.Click += new System.EventHandler(this.btnBackMedic_Click);
            // 
            // MeniuMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 597);
            this.Controls.Add(this.btnBackMedic);
            this.Controls.Add(this.dataGridViewProgramare);
            this.Name = "MeniuMedic";
            this.Text = "MeniuMedic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuMedic_FormClosing);
            this.Load += new System.EventHandler(this.MeniuMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgramare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProgramare;
        private bdEvaDataSet3 bdEvaDataSet3;
        private System.Windows.Forms.BindingSource programareBindingSource;
        private bdEvaDataSet3TableAdapters.ProgramareTableAdapter programareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn programareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investigatieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBackMedic;
    }
}