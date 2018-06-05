namespace EncrytpionDecryption
{
    partial class frmEntropy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntropy));
            this.dgvLettersEntropy = new System.Windows.Forms.DataGridView();
            this.colLetters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterQuantityInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWordsProbability = new System.Windows.Forms.DataGridView();
            this.coldgvWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsQuantityInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvOccurrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalENtropy = new System.Windows.Forms.Label();
            this.lblEntropIAverage = new System.Windows.Forms.Label();
            this.lblMinEntropi = new System.Windows.Forms.Label();
            this.lblMaxEntropia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersEntropy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordsProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLettersEntropy
            // 
            this.dgvLettersEntropy.AllowUserToAddRows = false;
            this.dgvLettersEntropy.AllowUserToDeleteRows = false;
            this.dgvLettersEntropy.AllowUserToOrderColumns = true;
            this.dgvLettersEntropy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLettersEntropy.BackgroundColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLettersEntropy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLettersEntropy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLettersEntropy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLetters,
            this.LetterQuantityInformation,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLettersEntropy.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvLettersEntropy.GridColor = System.Drawing.Color.Blue;
            this.dgvLettersEntropy.Location = new System.Drawing.Point(43, 12);
            this.dgvLettersEntropy.Name = "dgvLettersEntropy";
            this.dgvLettersEntropy.ReadOnly = true;
            this.dgvLettersEntropy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLettersEntropy.Size = new System.Drawing.Size(607, 331);
            this.dgvLettersEntropy.TabIndex = 16;
            this.dgvLettersEntropy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLettersEntropy_CellContentClick);
            // 
            // colLetters
            // 
            this.colLetters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLetters.DataPropertyName = "LetterName";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe Print", 15.25F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Purple;
            this.colLetters.DefaultCellStyle = dataGridViewCellStyle22;
            this.colLetters.HeaderText = "Letras";
            this.colLetters.Name = "colLetters";
            this.colLetters.ReadOnly = true;
            // 
            // LetterQuantityInformation
            // 
            this.LetterQuantityInformation.DataPropertyName = "LetterQuantityInformation";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.LetterQuantityInformation.DefaultCellStyle = dataGridViewCellStyle23;
            this.LetterQuantityInformation.HeaderText = "Q.I";
            this.LetterQuantityInformation.Name = "LetterQuantityInformation";
            this.LetterQuantityInformation.ReadOnly = true;
            this.LetterQuantityInformation.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LetterEntropy";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Consolas", 15.25F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Purple;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn2.HeaderText = "Entropy";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dgvWordsProbability
            // 
            this.dgvWordsProbability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvWordsProbability.BackgroundColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWordsProbability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvWordsProbability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWordsProbability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldgvWords,
            this.WordsQuantityInformation,
            this.coldgvOccurrence});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWordsProbability.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvWordsProbability.GridColor = System.Drawing.Color.Blue;
            this.dgvWordsProbability.Location = new System.Drawing.Point(43, 12);
            this.dgvWordsProbability.Name = "dgvWordsProbability";
            this.dgvWordsProbability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWordsProbability.Size = new System.Drawing.Size(607, 331);
            this.dgvWordsProbability.TabIndex = 15;
            // 
            // coldgvWords
            // 
            this.coldgvWords.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldgvWords.DataPropertyName = "WordsName";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe Print", 13.25F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Purple;
            this.coldgvWords.DefaultCellStyle = dataGridViewCellStyle27;
            this.coldgvWords.HeaderText = "Palavras";
            this.coldgvWords.Name = "coldgvWords";
            this.coldgvWords.ReadOnly = true;
            // 
            // WordsQuantityInformation
            // 
            this.WordsQuantityInformation.DataPropertyName = "WordsQuantityInformation";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.WordsQuantityInformation.DefaultCellStyle = dataGridViewCellStyle28;
            this.WordsQuantityInformation.HeaderText = "Q.I";
            this.WordsQuantityInformation.Name = "WordsQuantityInformation";
            this.WordsQuantityInformation.Width = 120;
            // 
            // coldgvOccurrence
            // 
            this.coldgvOccurrence.DataPropertyName = "WordsEntropy";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Purple;
            this.coldgvOccurrence.DefaultCellStyle = dataGridViewCellStyle29;
            this.coldgvOccurrence.HeaderText = "Entropy";
            this.coldgvOccurrence.Name = "coldgvOccurrence";
            this.coldgvOccurrence.ReadOnly = true;
            this.coldgvOccurrence.Width = 130;
            // 
            // lblTotalENtropy
            // 
            this.lblTotalENtropy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalENtropy.AutoSize = true;
            this.lblTotalENtropy.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalENtropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalENtropy.ForeColor = System.Drawing.Color.White;
            this.lblTotalENtropy.Location = new System.Drawing.Point(38, 360);
            this.lblTotalENtropy.Name = "lblTotalENtropy";
            this.lblTotalENtropy.Size = new System.Drawing.Size(116, 25);
            this.lblTotalENtropy.TabIndex = 17;
            this.lblTotalENtropy.Text = "No of Chars";
            this.lblTotalENtropy.Click += new System.EventHandler(this.lblLetters_Click);
            // 
            // lblEntropIAverage
            // 
            this.lblEntropIAverage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEntropIAverage.AutoSize = true;
            this.lblEntropIAverage.BackColor = System.Drawing.Color.Transparent;
            this.lblEntropIAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntropIAverage.ForeColor = System.Drawing.Color.White;
            this.lblEntropIAverage.Location = new System.Drawing.Point(38, 393);
            this.lblEntropIAverage.Name = "lblEntropIAverage";
            this.lblEntropIAverage.Size = new System.Drawing.Size(128, 25);
            this.lblEntropIAverage.TabIndex = 18;
            this.lblEntropIAverage.Text = "Total Entropy";
            // 
            // lblMinEntropi
            // 
            this.lblMinEntropi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinEntropi.AutoSize = true;
            this.lblMinEntropi.BackColor = System.Drawing.Color.Transparent;
            this.lblMinEntropi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinEntropi.ForeColor = System.Drawing.Color.White;
            this.lblMinEntropi.Location = new System.Drawing.Point(322, 360);
            this.lblMinEntropi.Name = "lblMinEntropi";
            this.lblMinEntropi.Size = new System.Drawing.Size(116, 25);
            this.lblMinEntropi.TabIndex = 19;
            this.lblMinEntropi.Text = "Min Entropy";
            // 
            // lblMaxEntropia
            // 
            this.lblMaxEntropia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMaxEntropia.AutoSize = true;
            this.lblMaxEntropia.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxEntropia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxEntropia.ForeColor = System.Drawing.Color.White;
            this.lblMaxEntropia.Location = new System.Drawing.Point(331, 393);
            this.lblMaxEntropia.Name = "lblMaxEntropia";
            this.lblMaxEntropia.Size = new System.Drawing.Size(122, 25);
            this.lblMaxEntropia.TabIndex = 20;
            this.lblMaxEntropia.Text = "Max Entropy";
            // 
            // frmEntropy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.bk_entropy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 474);
            this.Controls.Add(this.lblMaxEntropia);
            this.Controls.Add(this.lblMinEntropi);
            this.Controls.Add(this.lblEntropIAverage);
            this.Controls.Add(this.lblTotalENtropy);
            this.Controls.Add(this.dgvLettersEntropy);
            this.Controls.Add(this.dgvWordsProbability);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntropy";
            this.Text = "Formulário da Entropia";
            this.Load += new System.EventHandler(this.frmEntropy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersEntropy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordsProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLettersEntropy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterQuantityInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvWordsProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordsQuantityInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvOccurrence;
        private System.Windows.Forms.Label lblTotalENtropy;
        private System.Windows.Forms.Label lblEntropIAverage;
        private System.Windows.Forms.Label lblMinEntropi;
        private System.Windows.Forms.Label lblMaxEntropia;
    }
}