namespace Clinica_Eva
{
    partial class MeniuPacienti
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSpecializari = new System.Windows.Forms.ComboBox();
            this.btnCautaDoc = new System.Windows.Forms.Button();
            this.btnIstoric = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewIstoricP = new System.Windows.Forms.DataGridView();
            this.pacientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investigatieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istoricIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istoricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdEvaDataSet2 = new Clinica_Eva.bdEvaDataSet2();
            this.istoricTableAdapter = new Clinica_Eva.bdEvaDataSet2TableAdapters.IstoricTableAdapter();
            this.dataGridViewMedicCauta = new System.Windows.Forms.DataGridView();
            this.medicIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnSolicitaProgramare = new System.Windows.Forms.Button();
            this.dateTimePickerSolicitaP = new System.Windows.Forms.DateTimePicker();
            this.cboInvestigatie = new System.Windows.Forms.ComboBox();
            this.btnBackPacient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstoricP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(414, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meniu Pacienti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboSpecializari
            // 
            this.cboSpecializari.FormattingEnabled = true;
            this.cboSpecializari.Location = new System.Drawing.Point(430, 149);
            this.cboSpecializari.Name = "cboSpecializari";
            this.cboSpecializari.Size = new System.Drawing.Size(216, 24);
            this.cboSpecializari.TabIndex = 1;
            this.cboSpecializari.SelectedIndexChanged += new System.EventHandler(this.cboSpecializari_SelectedIndexChanged);
            // 
            // btnCautaDoc
            // 
            this.btnCautaDoc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCautaDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCautaDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCautaDoc.Location = new System.Drawing.Point(288, 255);
            this.btnCautaDoc.Name = "btnCautaDoc";
            this.btnCautaDoc.Size = new System.Drawing.Size(144, 38);
            this.btnCautaDoc.TabIndex = 2;
            this.btnCautaDoc.Text = "Cauta doctor";
            this.btnCautaDoc.UseVisualStyleBackColor = false;
            this.btnCautaDoc.Click += new System.EventHandler(this.btnCautaDoc_Click);
            // 
            // btnIstoric
            // 
            this.btnIstoric.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnIstoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIstoric.Location = new System.Drawing.Point(495, 255);
            this.btnIstoric.Name = "btnIstoric";
            this.btnIstoric.Size = new System.Drawing.Size(114, 38);
            this.btnIstoric.TabIndex = 3;
            this.btnIstoric.Text = "Istoric ";
            this.btnIstoric.UseVisualStyleBackColor = false;
            this.btnIstoric.Click += new System.EventHandler(this.btnIstoric_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(206, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ce doctor cauti:";
            // 
            // dataGridViewIstoricP
            // 
            this.dataGridViewIstoricP.AutoGenerateColumns = false;
            this.dataGridViewIstoricP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIstoricP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacientIDDataGridViewTextBoxColumn,
            this.medicIDDataGridViewTextBoxColumn,
            this.investigatieIDDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn,
            this.tratamentDataGridViewTextBoxColumn,
            this.observatiiDataGridViewTextBoxColumn,
            this.istoricIDDataGridViewTextBoxColumn});
            this.dataGridViewIstoricP.DataSource = this.istoricBindingSource;
            this.dataGridViewIstoricP.Location = new System.Drawing.Point(12, 501);
            this.dataGridViewIstoricP.Name = "dataGridViewIstoricP";
            this.dataGridViewIstoricP.RowHeadersWidth = 51;
            this.dataGridViewIstoricP.RowTemplate.Height = 24;
            this.dataGridViewIstoricP.Size = new System.Drawing.Size(968, 150);
            this.dataGridViewIstoricP.TabIndex = 5;
            this.dataGridViewIstoricP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIstoricP_CellContentClick);
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
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            this.diagnosticDataGridViewTextBoxColumn.Width = 125;
            // 
            // tratamentDataGridViewTextBoxColumn
            // 
            this.tratamentDataGridViewTextBoxColumn.DataPropertyName = "Tratament";
            this.tratamentDataGridViewTextBoxColumn.HeaderText = "Tratament";
            this.tratamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tratamentDataGridViewTextBoxColumn.Name = "tratamentDataGridViewTextBoxColumn";
            this.tratamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // observatiiDataGridViewTextBoxColumn
            // 
            this.observatiiDataGridViewTextBoxColumn.DataPropertyName = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.HeaderText = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observatiiDataGridViewTextBoxColumn.Name = "observatiiDataGridViewTextBoxColumn";
            this.observatiiDataGridViewTextBoxColumn.Width = 125;
            // 
            // istoricIDDataGridViewTextBoxColumn
            // 
            this.istoricIDDataGridViewTextBoxColumn.DataPropertyName = "IstoricID";
            this.istoricIDDataGridViewTextBoxColumn.HeaderText = "IstoricID";
            this.istoricIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.istoricIDDataGridViewTextBoxColumn.Name = "istoricIDDataGridViewTextBoxColumn";
            this.istoricIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.istoricIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // istoricBindingSource
            // 
            this.istoricBindingSource.DataMember = "Istoric";
            this.istoricBindingSource.DataSource = this.bdEvaDataSet2;
            // 
            // bdEvaDataSet2
            // 
            this.bdEvaDataSet2.DataSetName = "bdEvaDataSet2";
            this.bdEvaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istoricTableAdapter
            // 
            this.istoricTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewMedicCauta
            // 
            this.dataGridViewMedicCauta.AutoGenerateColumns = false;
            this.dataGridViewMedicCauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicCauta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicIDDataGridViewTextBoxColumn1,
            this.specializareIDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.contIDDataGridViewTextBoxColumn});
            this.dataGridViewMedicCauta.DataSource = this.medicBindingSource;
            this.dataGridViewMedicCauta.Location = new System.Drawing.Point(12, 330);
            this.dataGridViewMedicCauta.Name = "dataGridViewMedicCauta";
            this.dataGridViewMedicCauta.RowHeadersWidth = 51;
            this.dataGridViewMedicCauta.RowTemplate.Height = 24;
            this.dataGridViewMedicCauta.Size = new System.Drawing.Size(968, 150);
            this.dataGridViewMedicCauta.TabIndex = 6;
            this.dataGridViewMedicCauta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicCauta_CellContentClick);
            // 
            // medicIDDataGridViewTextBoxColumn1
            // 
            this.medicIDDataGridViewTextBoxColumn1.DataPropertyName = "MedicID";
            this.medicIDDataGridViewTextBoxColumn1.HeaderText = "MedicID";
            this.medicIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.medicIDDataGridViewTextBoxColumn1.Name = "medicIDDataGridViewTextBoxColumn1";
            this.medicIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.medicIDDataGridViewTextBoxColumn1.Width = 125;
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
            // btnSolicitaProgramare
            // 
            this.btnSolicitaProgramare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSolicitaProgramare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSolicitaProgramare.Location = new System.Drawing.Point(704, 255);
            this.btnSolicitaProgramare.Name = "btnSolicitaProgramare";
            this.btnSolicitaProgramare.Size = new System.Drawing.Size(199, 38);
            this.btnSolicitaProgramare.TabIndex = 7;
            this.btnSolicitaProgramare.Text = "Solicita programare";
            this.btnSolicitaProgramare.UseVisualStyleBackColor = false;
            this.btnSolicitaProgramare.Click += new System.EventHandler(this.btnSolicitaProgramare_Click);
            // 
            // dateTimePickerSolicitaP
            // 
            this.dateTimePickerSolicitaP.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dateTimePickerSolicitaP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSolicitaP.Location = new System.Drawing.Point(751, 149);
            this.dateTimePickerSolicitaP.Name = "dateTimePickerSolicitaP";
            this.dateTimePickerSolicitaP.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSolicitaP.TabIndex = 8;
            this.dateTimePickerSolicitaP.ValueChanged += new System.EventHandler(this.dateTimePickerSolicitaP_ValueChanged);
            // 
            // cboInvestigatie
            // 
            this.cboInvestigatie.FormattingEnabled = true;
            this.cboInvestigatie.Location = new System.Drawing.Point(430, 206);
            this.cboInvestigatie.Name = "cboInvestigatie";
            this.cboInvestigatie.Size = new System.Drawing.Size(216, 24);
            this.cboInvestigatie.TabIndex = 9;
            this.cboInvestigatie.SelectedIndexChanged += new System.EventHandler(this.cboInvestigatie_SelectedIndexChanged);
            // 
            // btnBackPacient
            // 
            this.btnBackPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackPacient.Location = new System.Drawing.Point(35, 28);
            this.btnBackPacient.Name = "btnBackPacient";
            this.btnBackPacient.Size = new System.Drawing.Size(95, 35);
            this.btnBackPacient.TabIndex = 10;
            this.btnBackPacient.Text = "Back";
            this.btnBackPacient.UseVisualStyleBackColor = true;
            this.btnBackPacient.Click += new System.EventHandler(this.btnBackPacient_Click);
            // 
            // MeniuPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 664);
            this.Controls.Add(this.btnBackPacient);
            this.Controls.Add(this.cboInvestigatie);
            this.Controls.Add(this.dateTimePickerSolicitaP);
            this.Controls.Add(this.btnSolicitaProgramare);
            this.Controls.Add(this.dataGridViewMedicCauta);
            this.Controls.Add(this.dataGridViewIstoricP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIstoric);
            this.Controls.Add(this.btnCautaDoc);
            this.Controls.Add(this.cboSpecializari);
            this.Controls.Add(this.label1);
            this.Name = "MeniuPacienti";
            this.Text = "MeniuPacienti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuPacienti_FormClosing);
            this.Load += new System.EventHandler(this.MeniuPacienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstoricP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEvaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSpecializari;
        private System.Windows.Forms.Button btnCautaDoc;
        private System.Windows.Forms.Button btnIstoric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewIstoricP;
        private bdEvaDataSet2 bdEvaDataSet2;
        private System.Windows.Forms.BindingSource istoricBindingSource;
        private bdEvaDataSet2TableAdapters.IstoricTableAdapter istoricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investigatieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observatiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istoricIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewMedicCauta;
        private bdEvaDataSet bdEvaDataSet;
        private System.Windows.Forms.BindingSource medicBindingSource;
        private bdEvaDataSetTableAdapters.MedicTableAdapter medicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSolicitaProgramare;
        private System.Windows.Forms.DateTimePicker dateTimePickerSolicitaP;
        private System.Windows.Forms.ComboBox cboInvestigatie;
        private System.Windows.Forms.Button btnBackPacient;
    }
}