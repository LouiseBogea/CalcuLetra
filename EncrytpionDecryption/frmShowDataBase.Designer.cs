namespace EncrytpionDecryption
{
    partial class frmShowDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowingProbabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notknowingProbabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.communicationEntropyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblWordsPbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.probabilityCalculatorDataSet = new EncrytpionDecryption.ProbabilityCalculatorDataSet();
            this.tblWordsPbTableAdapter = new EncrytpionDecryption.ProbabilityCalculatorDataSetTableAdapters.tblWordsPbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWordsPbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityCalculatorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.wordDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.probabilityDataGridViewTextBoxColumn,
            this.knowingProbabilityDataGridViewTextBoxColumn,
            this.notknowingProbabilityDataGridViewTextBoxColumn,
            this.informationQuantityDataGridViewTextBoxColumn,
            this.communicationEntropyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblWordsPbBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            // 
            // probabilityDataGridViewTextBoxColumn
            // 
            this.probabilityDataGridViewTextBoxColumn.DataPropertyName = "Probability";
            this.probabilityDataGridViewTextBoxColumn.HeaderText = "Probability";
            this.probabilityDataGridViewTextBoxColumn.Name = "probabilityDataGridViewTextBoxColumn";
            // 
            // knowingProbabilityDataGridViewTextBoxColumn
            // 
            this.knowingProbabilityDataGridViewTextBoxColumn.DataPropertyName = "KnowingProbability";
            this.knowingProbabilityDataGridViewTextBoxColumn.HeaderText = "KnowingProbability";
            this.knowingProbabilityDataGridViewTextBoxColumn.Name = "knowingProbabilityDataGridViewTextBoxColumn";
            // 
            // notknowingProbabilityDataGridViewTextBoxColumn
            // 
            this.notknowingProbabilityDataGridViewTextBoxColumn.DataPropertyName = "NotknowingProbability";
            this.notknowingProbabilityDataGridViewTextBoxColumn.HeaderText = "NotknowingProbability";
            this.notknowingProbabilityDataGridViewTextBoxColumn.Name = "notknowingProbabilityDataGridViewTextBoxColumn";
            // 
            // informationQuantityDataGridViewTextBoxColumn
            // 
            this.informationQuantityDataGridViewTextBoxColumn.DataPropertyName = "InformationQuantity";
            this.informationQuantityDataGridViewTextBoxColumn.HeaderText = "InformationQuantity";
            this.informationQuantityDataGridViewTextBoxColumn.Name = "informationQuantityDataGridViewTextBoxColumn";
            // 
            // communicationEntropyDataGridViewTextBoxColumn
            // 
            this.communicationEntropyDataGridViewTextBoxColumn.DataPropertyName = "CommunicationEntropy";
            this.communicationEntropyDataGridViewTextBoxColumn.HeaderText = "CommunicationEntropy";
            this.communicationEntropyDataGridViewTextBoxColumn.Name = "communicationEntropyDataGridViewTextBoxColumn";
            // 
            // tblWordsPbBindingSource
            // 
            this.tblWordsPbBindingSource.DataMember = "tblWordsPb";
            this.tblWordsPbBindingSource.DataSource = this.probabilityCalculatorDataSet;
            // 
            // probabilityCalculatorDataSet
            // 
            this.probabilityCalculatorDataSet.DataSetName = "ProbabilityCalculatorDataSet";
            this.probabilityCalculatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWordsPbTableAdapter
            // 
            this.tblWordsPbTableAdapter.ClearBeforeFill = true;
            // 
            // frmShowDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmShowDataBase";
            this.Text = "Nosso banco de dados";
            this.Load += new System.EventHandler(this.frmShowDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWordsPbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityCalculatorDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProbabilityCalculatorDataSet probabilityCalculatorDataSet;
        private System.Windows.Forms.BindingSource tblWordsPbBindingSource;
        private ProbabilityCalculatorDataSetTableAdapters.tblWordsPbTableAdapter tblWordsPbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowingProbabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notknowingProbabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn communicationEntropyDataGridViewTextBoxColumn;
    }
}