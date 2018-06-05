namespace EncrytpionDecryption
{
    partial class frmProbabilityScale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProbabilityScale));
            this.dgvLettersEntropy = new System.Windows.Forms.DataGridView();
            this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKnowingProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotKnowingProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInformationQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalEntropia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowDetail = new Glass.GlassButton();
            this.lblMinProbability = new System.Windows.Forms.Label();
            this.lblMaxProbability = new System.Windows.Forms.Label();
            this.lblAverageProbaility = new System.Windows.Forms.Label();
            this.lblMinEntropy = new System.Windows.Forms.Label();
            this.lblMaxEntropy = new System.Windows.Forms.Label();
            this.lblAverageEntropy = new System.Windows.Forms.Label();
            this.dgvDetailLetterEntropy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersEntropy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailLetterEntropy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLettersEntropy
            // 
            this.dgvLettersEntropy.AllowUserToAddRows = false;
            this.dgvLettersEntropy.AllowUserToDeleteRows = false;
            this.dgvLettersEntropy.AllowUserToOrderColumns = true;
            this.dgvLettersEntropy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLettersEntropy.BackgroundColor = System.Drawing.Color.White;
            this.dgvLettersEntropy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLettersEntropy.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLettersEntropy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLettersEntropy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLettersEntropy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWord,
            this.colFrequency,
            this.colProbability,
            this.colKnowingProbability,
            this.colNotKnowingProbability,
            this.colInformationQuantity,
            this.colFinalEntropia,
            this.colId});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLettersEntropy.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLettersEntropy.EnableHeadersVisualStyles = false;
            this.dgvLettersEntropy.GridColor = System.Drawing.Color.Blue;
            this.dgvLettersEntropy.Location = new System.Drawing.Point(44, 23);
            this.dgvLettersEntropy.Name = "dgvLettersEntropy";
            this.dgvLettersEntropy.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLettersEntropy.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLettersEntropy.RowHeadersVisible = false;
            this.dgvLettersEntropy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLettersEntropy.Size = new System.Drawing.Size(873, 284);
            this.dgvLettersEntropy.TabIndex = 17;
            // 
            // colWord
            // 
            this.colWord.DataPropertyName = "Word";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.colWord.DefaultCellStyle = dataGridViewCellStyle2;
            this.colWord.FillWeight = 355.3299F;
            this.colWord.HeaderText = "Palavra";
            this.colWord.Name = "colWord";
            this.colWord.ReadOnly = true;
            this.colWord.Width = 150;
            // 
            // colFrequency
            // 
            this.colFrequency.DataPropertyName = "Frequency";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.colFrequency.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFrequency.FillWeight = 12.90738F;
            this.colFrequency.HeaderText = "Frequência";
            this.colFrequency.Name = "colFrequency";
            this.colFrequency.ReadOnly = true;
            this.colFrequency.Width = 85;
            // 
            // colProbability
            // 
            this.colProbability.DataPropertyName = "Probability";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.colProbability.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProbability.FillWeight = 12.90738F;
            this.colProbability.HeaderText = "Probabilidade";
            this.colProbability.Name = "colProbability";
            this.colProbability.ReadOnly = true;
            this.colProbability.Width = 85;
            // 
            // colKnowingProbability
            // 
            this.colKnowingProbability.DataPropertyName = "KnowingProbability";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.colKnowingProbability.DefaultCellStyle = dataGridViewCellStyle5;
            this.colKnowingProbability.FillWeight = 12.90738F;
            this.colKnowingProbability.HeaderText = "Probabilidade do Conhecimento ";
            this.colKnowingProbability.Name = "colKnowingProbability";
            this.colKnowingProbability.ReadOnly = true;
            this.colKnowingProbability.Width = 160;
            // 
            // colNotKnowingProbability
            // 
            this.colNotKnowingProbability.DataPropertyName = "NotKnowingProbability";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.colNotKnowingProbability.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNotKnowingProbability.FillWeight = 12.90738F;
            this.colNotKnowingProbability.HeaderText = "Probabilidade do Desconhecimento";
            this.colNotKnowingProbability.Name = "colNotKnowingProbability";
            this.colNotKnowingProbability.ReadOnly = true;
            this.colNotKnowingProbability.Width = 150;
            // 
            // colInformationQuantity
            // 
            this.colInformationQuantity.DataPropertyName = "InformationQuantity";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.colInformationQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.colInformationQuantity.FillWeight = 280.1332F;
            this.colInformationQuantity.HeaderText = "Quantidade de Informação";
            this.colInformationQuantity.Name = "colInformationQuantity";
            this.colInformationQuantity.ReadOnly = true;
            this.colInformationQuantity.Width = 170;
            // 
            // colFinalEntropia
            // 
            this.colFinalEntropia.DataPropertyName = "FinalEntropia";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.colFinalEntropia.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFinalEntropia.FillWeight = 12.90738F;
            this.colFinalEntropia.HeaderText = "Entropia";
            this.colFinalEntropia.Name = "colFinalEntropia";
            this.colFinalEntropia.ReadOnly = true;
            this.colFinalEntropia.Width = 130;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.colId.DefaultCellStyle = dataGridViewCellStyle9;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.btnShowDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetail.ForeColor = System.Drawing.Color.Black;
            this.btnShowDetail.Location = new System.Drawing.Point(47, 311);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(129, 28);
            this.btnShowDetail.TabIndex = 18;
            this.btnShowDetail.Text = "Dados do Texto";
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // lblMinProbability
            // 
            this.lblMinProbability.AutoSize = true;
            this.lblMinProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinProbability.ForeColor = System.Drawing.Color.White;
            this.lblMinProbability.Location = new System.Drawing.Point(12, 570);
            this.lblMinProbability.Name = "lblMinProbability";
            this.lblMinProbability.Size = new System.Drawing.Size(51, 20);
            this.lblMinProbability.TabIndex = 19;
            this.lblMinProbability.Text = "label1";
            this.lblMinProbability.Visible = false;
            // 
            // lblMaxProbability
            // 
            this.lblMaxProbability.AutoSize = true;
            this.lblMaxProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxProbability.ForeColor = System.Drawing.Color.White;
            this.lblMaxProbability.Location = new System.Drawing.Point(12, 570);
            this.lblMaxProbability.Name = "lblMaxProbability";
            this.lblMaxProbability.Size = new System.Drawing.Size(51, 20);
            this.lblMaxProbability.TabIndex = 19;
            this.lblMaxProbability.Text = "label1";
            this.lblMaxProbability.Visible = false;
            // 
            // lblAverageProbaility
            // 
            this.lblAverageProbaility.AutoSize = true;
            this.lblAverageProbaility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageProbaility.ForeColor = System.Drawing.Color.White;
            this.lblAverageProbaility.Location = new System.Drawing.Point(12, 570);
            this.lblAverageProbaility.Name = "lblAverageProbaility";
            this.lblAverageProbaility.Size = new System.Drawing.Size(51, 20);
            this.lblAverageProbaility.TabIndex = 19;
            this.lblAverageProbaility.Text = "label1";
            this.lblAverageProbaility.Visible = false;
            // 
            // lblMinEntropy
            // 
            this.lblMinEntropy.AutoSize = true;
            this.lblMinEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinEntropy.ForeColor = System.Drawing.Color.White;
            this.lblMinEntropy.Location = new System.Drawing.Point(12, 559);
            this.lblMinEntropy.Name = "lblMinEntropy";
            this.lblMinEntropy.Size = new System.Drawing.Size(51, 20);
            this.lblMinEntropy.TabIndex = 19;
            this.lblMinEntropy.Text = "label1";
            this.lblMinEntropy.Visible = false;
            // 
            // lblMaxEntropy
            // 
            this.lblMaxEntropy.AutoSize = true;
            this.lblMaxEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxEntropy.ForeColor = System.Drawing.Color.White;
            this.lblMaxEntropy.Location = new System.Drawing.Point(12, 570);
            this.lblMaxEntropy.Name = "lblMaxEntropy";
            this.lblMaxEntropy.Size = new System.Drawing.Size(51, 20);
            this.lblMaxEntropy.TabIndex = 19;
            this.lblMaxEntropy.Text = "label1";
            this.lblMaxEntropy.Visible = false;
            // 
            // lblAverageEntropy
            // 
            this.lblAverageEntropy.AutoSize = true;
            this.lblAverageEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageEntropy.ForeColor = System.Drawing.Color.White;
            this.lblAverageEntropy.Location = new System.Drawing.Point(12, 570);
            this.lblAverageEntropy.Name = "lblAverageEntropy";
            this.lblAverageEntropy.Size = new System.Drawing.Size(51, 20);
            this.lblAverageEntropy.TabIndex = 19;
            this.lblAverageEntropy.Text = "label1";
            this.lblAverageEntropy.Visible = false;
            // 
            // dgvDetailLetterEntropy
            // 
            this.dgvDetailLetterEntropy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailLetterEntropy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailLetterEntropy.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetailLetterEntropy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailLetterEntropy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetailLetterEntropy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailLetterEntropy.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDetailLetterEntropy.EnableHeadersVisualStyles = false;
            this.dgvDetailLetterEntropy.GridColor = System.Drawing.Color.Blue;
            this.dgvDetailLetterEntropy.Location = new System.Drawing.Point(44, 345);
            this.dgvDetailLetterEntropy.Name = "dgvDetailLetterEntropy";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailLetterEntropy.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetailLetterEntropy.RowHeadersVisible = false;
            this.dgvDetailLetterEntropy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailLetterEntropy.Size = new System.Drawing.Size(873, 231);
            this.dgvDetailLetterEntropy.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dados das Palavras";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(125, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 1);
            this.label2.TabIndex = 22;
            // 
            // frmProbabilityScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetailLetterEntropy);
            this.Controls.Add(this.lblMinEntropy);
            this.Controls.Add(this.lblAverageEntropy);
            this.Controls.Add(this.lblAverageProbaility);
            this.Controls.Add(this.lblMaxEntropy);
            this.Controls.Add(this.lblMaxProbability);
            this.Controls.Add(this.lblMinProbability);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.dgvLettersEntropy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProbabilityScale";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escala da Probabilidade";
            this.Load += new System.EventHandler(this.frmProbabilityScale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersEntropy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailLetterEntropy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLettersEntropy;
        private Glass.GlassButton btnShowDetail;
        private System.Windows.Forms.Label lblMinProbability;
        private System.Windows.Forms.Label lblMaxProbability;
        private System.Windows.Forms.Label lblAverageProbaility;
        private System.Windows.Forms.Label lblMinEntropy;
        private System.Windows.Forms.Label lblMaxEntropy;
        private System.Windows.Forms.Label lblAverageEntropy;
        private System.Windows.Forms.DataGridView dgvDetailLetterEntropy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKnowingProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotKnowingProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformationQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalEntropia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}