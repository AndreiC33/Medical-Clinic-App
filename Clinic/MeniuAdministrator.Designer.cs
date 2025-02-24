namespace Clinica_Eva
{
    partial class MeniuAdministrator
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
            this.btnSaveM = new System.Windows.Forms.Button();
            this.btnUpdateM = new System.Windows.Forms.Button();
            this.btnDeleteM = new System.Windows.Forms.Button();
            this.dataGridViewMedic = new System.Windows.Forms.DataGridView();
            this.medicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdEvaDataSet = new Clinica_Eva.bdEvaDataSet();
            this.medicTableAdapter = new Clinica_Eva.bdEvaDataSetTableAdapters.MedicTableAdapter();
            this.dataGridViewPacienti = new System.Windows.Forms.DataGridView();
            this.pacientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiguratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicFamilieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdEvaDataSet1 = new Clinica_Eva.bdEvaDataSet1();
            this.bdEvaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientTableAdapter = new Clinica_Eva.bdEvaDataSet1TableAdapters.PacientTableAdapter();
            this.lblTitluMedic = new System.Windows.Forms.Label();
            this.lblTitluPacienti = new System.Windows.Forms.Label();
            this.btnBackAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveM
            // 
            this.btnSaveM.Location = new System.Drawing.Point(273, 265);
            this.btnSaveM.Name = "btnSaveM";
            this.btnSaveM.Size = new System.Drawing.Size(95, 35);
            this.btnSaveM.TabIndex = 0;
            this.btnSaveM.Text = "Insert";
            this.btnSaveM.UseVisualStyleBackColor = true;
            this.btnSaveM.Click += new System.EventHandler(this.btnSaveM_Click);
            // 
            // btnUpdateM
            // 
            this.btnUpdateM.Location = new System.Drawing.Point(447, 264);
            this.btnUpdateM.Name = "btnUpdateM";
            this.btnUpdateM.Size = new System.Drawing.Size(85, 35);
            this.btnUpdateM.TabIndex = 1;
            this.btnUpdateM.Text = "Update";
            this.btnUpdateM.UseVisualStyleBackColor = true;
            this.btnUpdateM.Click += new System.EventHandler(this.btnUpdateM_Click);
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.Location = new System.Drawing.Point(624, 265);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.Size = new System.Drawing.Size(84, 34);
            this.btnDeleteM.TabIndex = 2;
            this.btnDeleteM.Text = "Delete";
            this.btnDeleteM.UseVisualStyleBackColor = true;
            this.btnDeleteM.Click += new System.EventHandler(this.btnDeleteM_Click);
            // 
            // dataGridViewMedic
            // 
            this.dataGridViewMedic.AutoGenerateColumns = false;
            this.dataGridViewMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicIDDataGridViewTextBoxColumn,
            this.specializareIDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.contIDDataGridViewTextBoxColumn});
            this.dataGridViewMedic.DataSource = this.medicBindingSource;
            this.dataGridViewMedic.Location = new System.Drawing.Point(11, 79);
            this.dataGridViewMedic.Name = "dataGridViewMedic";
            this.dataGridViewMedic.RowHeadersWidth = 51;
            this.dataGridViewMedic.RowTemplate.Height = 24;
            this.dataGridViewMedic.Size = new System.Drawing.Size(1060, 150);
            this.dataGridViewMedic.TabIndex = 3;
            // 
            // medicIDDataGridViewTextBoxColumn
            // 
            this.medicIDDataGridViewTextBoxColumn.DataPropertyName = "MedicID";
            this.medicIDDataGridViewTextBoxColumn.HeaderText = "MedicID";
            this.medicIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicIDDataGridViewTextBoxColumn.Name = "medicIDDataGridViewTextBoxColumn";
            this.medicIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // specializareIDDataGridViewTextBoxColumn
            // 
            this.specializareIDDataGridViewTextBoxColumn.DataPropertyName = "SpecializareID";
            this.specializareIDDataGridViewTextBoxColumn.HeaderText = "SpecializareID";
            this.specializareIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specializareIDDataGridViewTextBoxColumn.Name = "specializareIDDataGridViewTextBoxColumn";
            this.specializareIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            this.dataNasteriiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.Width = 125;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.Width = 125;
            // 
            // contIDDataGridViewTextBoxColumn
            // 
            this.contIDDataGridViewTextBoxColumn.DataPropertyName = "ContID";
            this.contIDDataGridViewTextBoxColumn.HeaderText = "ContID";
            this.contIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contIDDataGridViewTextBoxColumn.Name = "contIDDataGridViewTextBoxColumn";
            this.contIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicBindingSource
            // 
            this.medicBindingSource.DataMember = "Medic";
            this.medicBindingSource.DataSource = this.bdEvaDataSet;
            // 
            // bdEvaDataSet
            // 
            this.bdEvaDataSet.DataSetName = "bdEvaDataSet";
            this.bdEvaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicTableAdapter
            // 
            this.medicTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewPacienti
            // 
            this.dataGridViewPacienti.AutoGenerateColumns = false;
            this.dataGridViewPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacientIDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn1,
            this.prenumeDataGridViewTextBoxColumn1,
            this.cNPDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn1,
            this.sexDataGridViewTextBoxColumn,
            this.asiguratDataGridViewTextBoxColumn,
            this.medicFamilieDataGridViewTextBoxColumn,
            this.contIDDataGridViewTextBoxColumn1});
            this.dataGridViewPacienti.DataSource = this.pacientBindingSource;
            this.dataGridViewPacienti.Location = new System.Drawing.Point(12, 470);
            this.dataGridViewPacienti.Name = "dataGridViewPacienti";
            this.dataGridViewPacienti.RowHeadersWidth = 51;
            this.dataGridViewPacienti.RowTemplate.Height = 24;
            this.dataGridViewPacienti.Size = new System.Drawing.Size(1059, 150);
            this.dataGridViewPacienti.TabIndex = 4;
            // 
            // pacientIDDataGridViewTextBoxColumn
            // 
            this.pacientIDDataGridViewTextBoxColumn.DataPropertyName = "PacientID";
            this.pacientIDDataGridViewTextBoxColumn.HeaderText = "PacientID";
            this.pacientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pacientIDDataGridViewTextBoxColumn.Name = "pacientIDDataGridViewTextBoxColumn";
            this.pacientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            this.numeDataGridViewTextBoxColumn1.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn1.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            this.numeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn1
            // 
            this.prenumeDataGridViewTextBoxColumn1.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn1.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn1.Name = "prenumeDataGridViewTextBoxColumn1";
            this.prenumeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNasteriiDataGridViewTextBoxColumn1
            // 
            this.dataNasteriiDataGridViewTextBoxColumn1.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn1.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataNasteriiDataGridViewTextBoxColumn1.Name = "dataNasteriiDataGridViewTextBoxColumn1";
            this.dataNasteriiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // asiguratDataGridViewTextBoxColumn
            // 
            this.asiguratDataGridViewTextBoxColumn.DataPropertyName = "Asigurat";
            this.asiguratDataGridViewTextBoxColumn.HeaderText = "Asigurat";
            this.asiguratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiguratDataGridViewTextBoxColumn.Name = "asiguratDataGridViewTextBoxColumn";
            this.asiguratDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicFamilieDataGridViewTextBoxColumn
            // 
            this.medicFamilieDataGridViewTextBoxColumn.DataPropertyName = "MedicFamilie";
            this.medicFamilieDataGridViewTextBoxColumn.HeaderText = "MedicFamilie";
            this.medicFamilieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicFamilieDataGridViewTextBoxColumn.Name = "medicFamilieDataGridViewTextBoxColumn";
            this.medicFamilieDataGridViewTextBoxColumn.Width = 125;
            // 
            // contIDDataGridViewTextBoxColumn1
            // 
            this.contIDDataGridViewTextBoxColumn1.DataPropertyName = "ContID";
            this.contIDDataGridViewTextBoxColumn1.HeaderText = "ContID";
            this.contIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.contIDDataGridViewTextBoxColumn1.Name = "contIDDataGridViewTextBoxColumn1";
            this.contIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.bdEvaDataSet1;
            // 
            // bdEvaDataSet1
            // 
            this.bdEvaDataSet1.DataSetName = "bdEvaDataSet1";
            this.bdEvaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdEvaDataSetBindingSource
            // 
            this.bdEvaDataSetBindingSource.DataSource = this.bdEvaDataSet;
            this.bdEvaDataSetBindingSource.Position = 0;
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitluMedic
            // 
            this.lblTitluMedic.AutoSize = true;
            this.lblTitluMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitluMedic.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitluMedic.Location = new System.Drawing.Point(57, 26);
            this.lblTitluMedic.Name = "lblTitluMedic";
            this.lblTitluMedic.Size = new System.Drawing.Size(92, 31);
            this.lblTitluMedic.TabIndex = 5;
            this.lblTitluMedic.Text = "Medici";
            // 
            // lblTitluPacienti
            // 
            this.lblTitluPacienti.AutoSize = true;
            this.lblTitluPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitluPacienti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitluPacienti.Location = new System.Drawing.Point(57, 405);
            this.lblTitluPacienti.Name = "lblTitluPacienti";
            this.lblTitluPacienti.Size = new System.Drawing.Size(111, 31);
            this.lblTitluPacienti.TabIndex = 6;
            this.lblTitluPacienti.Text = "Pacienti";
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.Location = new System.Drawing.Point(889, 12);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(88, 37);
            this.btnBackAdmin.TabIndex = 7;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // MeniuAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 632);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.lblTitluPacienti);
            this.Controls.Add(this.lblTitluMedic);
            this.Controls.Add(this.dataGridViewPacienti);
            this.Controls.Add(this.dataGridViewMedic);
            this.Controls.Add(this.btnDeleteM);
            this.Controls.Add(this.btnUpdateM);
            this.Controls.Add(this.btnSaveM);
            this.Name = "MeniuAdministrator";
            this.Text = "MeniuAdministrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuAdministrator_FormClosing);
            this.Load += new System.EventHandler(this.MeniuAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveM;
        private System.Windows.Forms.Button btnUpdateM;
        private System.Windows.Forms.Button btnDeleteM;
        private System.Windows.Forms.DataGridView dataGridViewMedic;
        private bdEvaDataSet bdEvaDataSet;
        private System.Windows.Forms.BindingSource medicBindingSource;
        private bdEvaDataSetTableAdapters.MedicTableAdapter medicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewPacienti;
        private System.Windows.Forms.BindingSource bdEvaDataSetBindingSource;
        private bdEvaDataSet1 bdEvaDataSet1;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private bdEvaDataSet1TableAdapters.PacientTableAdapter pacientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiguratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicFamilieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTitluMedic;
        private System.Windows.Forms.Label lblTitluPacienti;
        private System.Windows.Forms.Button btnBackAdmin;
    }
}