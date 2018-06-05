namespace EncrytpionDecryption
{
    partial class frmMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.rtbINput = new System.Windows.Forms.RichTextBox();
            this.CTMSPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvWordsProbability = new System.Windows.Forms.DataGridView();
            this.coldgvWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvOccurrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgvProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvLettersProbability = new System.Windows.Forms.DataGridView();
            this.colLetters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveDistinctWords = new RoundButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblParaghraph = new System.Windows.Forms.Label();
            this.btnScale = new RoundButton();
            this.btnEntropy = new RoundButton();
            this.btnResultDetail = new RoundButton();
            this.btnLettersProbability = new RoundButton();
            this.ImportFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripImportData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripResetData = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMSPaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordsProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersProbability)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbINput
            // 
            this.rtbINput.BackColor = System.Drawing.Color.White;
            this.rtbINput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbINput.ContextMenuStrip = this.CTMSPaste;
            this.rtbINput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbINput.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbINput.ForeColor = System.Drawing.Color.Purple;
            this.rtbINput.Location = new System.Drawing.Point(0, 0);
            this.rtbINput.Name = "rtbINput";
            this.rtbINput.Size = new System.Drawing.Size(647, 259);
            this.rtbINput.TabIndex = 0;
            this.rtbINput.Text = "";
            this.rtbINput.TextChanged += new System.EventHandler(this.rtbINput_TextChanged);
            this.rtbINput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbINput_KeyPress);
            this.rtbINput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtbINput_MouseMove);
            // 
            // CTMSPaste
            // 
            this.CTMSPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSPaste,
            this.resetToolStripMenuItem,
            this.cLoseToolStripMenuItem});
            this.CTMSPaste.Name = "CTMSPaste";
            this.CTMSPaste.Size = new System.Drawing.Size(113, 70);
            // 
            // CMSPaste
            // 
            this.CMSPaste.Name = "CMSPaste";
            this.CMSPaste.Size = new System.Drawing.Size(112, 22);
            this.CMSPaste.Text = "Colar";
            this.CMSPaste.Click += new System.EventHandler(this.CMSPaste_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.resetToolStripMenuItem.Text = "Apagar";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // cLoseToolStripMenuItem
            // 
            this.cLoseToolStripMenuItem.Name = "cLoseToolStripMenuItem";
            this.cLoseToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cLoseToolStripMenuItem.Text = "Fechar";
            this.cLoseToolStripMenuItem.Click += new System.EventHandler(this.cLoseToolStripMenuItem_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetInfo.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.o1;
            this.btnGetInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInfo.Location = new System.Drawing.Point(520, 7);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(40, 40);
            this.btnGetInfo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnGetInfo, "Aperte para ver o resultado.");
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lblLetters
            // 
            this.lblLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLetters.AutoSize = true;
            this.lblLetters.BackColor = System.Drawing.Color.Transparent;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(29)))));
            this.lblLetters.Location = new System.Drawing.Point(223, 1);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(61, 25);
            this.lblLetters.TabIndex = 4;
            this.lblLetters.Text = "Letter";
            this.lblLetters.Visible = false;
            // 
            // lblWords
            // 
            this.lblWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWords.AutoSize = true;
            this.lblWords.BackColor = System.Drawing.Color.Transparent;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(29)))));
            this.lblWords.Location = new System.Drawing.Point(223, 51);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(96, 25);
            this.lblWords.TabIndex = 4;
            this.lblWords.Text = "Sentence";
            this.lblWords.Visible = false;
            // 
            // lblSentences
            // 
            this.lblSentences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSentences.AutoSize = true;
            this.lblSentences.BackColor = System.Drawing.Color.Transparent;
            this.lblSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(29)))));
            this.lblSentences.Location = new System.Drawing.Point(223, 26);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(54, 25);
            this.lblSentences.TabIndex = 4;
            this.lblSentences.Text = "word";
            this.lblSentences.Visible = false;
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLose.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.cLose;
            this.btnCLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCLose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Location = new System.Drawing.Point(605, 7);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(40, 40);
            this.btnCLose.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnCLose, "Aperte para fechar o programa.");
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.r3;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(563, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnClear, "Aperte para apagar o texto e recomeçar.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvWordsProbability
            // 
            this.dgvWordsProbability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWordsProbability.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWordsProbability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWordsProbability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWordsProbability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldgvWords,
            this.coldgvOccurrence,
            this.coldgvProbability});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWordsProbability.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWordsProbability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWordsProbability.EnableHeadersVisualStyles = false;
            this.dgvWordsProbability.GridColor = System.Drawing.Color.Blue;
            this.dgvWordsProbability.Location = new System.Drawing.Point(0, 29);
            this.dgvWordsProbability.Name = "dgvWordsProbability";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWordsProbability.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWordsProbability.RowHeadersVisible = false;
            this.dgvWordsProbability.RowHeadersWidth = 20;
            this.dgvWordsProbability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWordsProbability.Size = new System.Drawing.Size(377, 438);
            this.dgvWordsProbability.TabIndex = 9;
            // 
            // coldgvWords
            // 
            this.coldgvWords.DataPropertyName = "Palavras";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.coldgvWords.DefaultCellStyle = dataGridViewCellStyle2;
            this.coldgvWords.HeaderText = "Palavras";
            this.coldgvWords.Name = "coldgvWords";
            this.coldgvWords.ReadOnly = true;
            // 
            // coldgvOccurrence
            // 
            this.coldgvOccurrence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coldgvOccurrence.DataPropertyName = "Frequência";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.coldgvOccurrence.DefaultCellStyle = dataGridViewCellStyle3;
            this.coldgvOccurrence.HeaderText = "Frequência";
            this.coldgvOccurrence.Name = "coldgvOccurrence";
            this.coldgvOccurrence.ReadOnly = true;
            // 
            // coldgvProbability
            // 
            this.coldgvProbability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coldgvProbability.DataPropertyName = "Probabilidade";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.coldgvProbability.DefaultCellStyle = dataGridViewCellStyle4;
            this.coldgvProbability.HeaderText = "Probabilidade";
            this.coldgvProbability.Name = "coldgvProbability";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.Laboratório_de_Neuroengenharia_Logo_Oficial_sem_fundo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 156);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 29);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvLettersProbability
            // 
            this.dgvLettersProbability.AllowUserToOrderColumns = true;
            this.dgvLettersProbability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLettersProbability.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLettersProbability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLettersProbability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLettersProbability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLetters,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLettersProbability.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLettersProbability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLettersProbability.EnableHeadersVisualStyles = false;
            this.dgvLettersProbability.GridColor = System.Drawing.Color.Blue;
            this.dgvLettersProbability.Location = new System.Drawing.Point(0, 29);
            this.dgvLettersProbability.Name = "dgvLettersProbability";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLettersProbability.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLettersProbability.RowHeadersVisible = false;
            this.dgvLettersProbability.RowHeadersWidth = 25;
            this.dgvLettersProbability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLettersProbability.Size = new System.Drawing.Size(377, 438);
            this.dgvLettersProbability.TabIndex = 12;
            this.dgvLettersProbability.Visible = false;
            // 
            // colLetters
            // 
            this.colLetters.DataPropertyName = "Letras";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.colLetters.DefaultCellStyle = dataGridViewCellStyle8;
            this.colLetters.HeaderText = "Letras";
            this.colLetters.Name = "colLetters";
            this.colLetters.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Frequência";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Frequência";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Probablidade";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Probablidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvWordsProbability);
            this.panel2.Controls.Add(this.dgvLettersProbability);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(649, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 469);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.search_button;
            this.button1.Location = new System.Drawing.Point(347, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rtbINput);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 311);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveDistinctWords);
            this.panel4.Controls.Add(this.btnGetInfo);
            this.panel4.Controls.Add(this.btnCLose);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 50);
            this.panel4.TabIndex = 1;
            // 
            // btnSaveDistinctWords
            // 
            this.btnSaveDistinctWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDistinctWords.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDistinctWords.Location = new System.Drawing.Point(-10, 0);
            this.btnSaveDistinctWords.Name = "btnSaveDistinctWords";
            this.btnSaveDistinctWords.Size = new System.Drawing.Size(181, 46);
            this.btnSaveDistinctWords.TabIndex = 15;
            this.btnSaveDistinctWords.Text = "Save Into DB";
            this.btnSaveDistinctWords.UseVisualStyleBackColor = true;
            this.btnSaveDistinctWords.Visible = false;
            this.btnSaveDistinctWords.Click += new System.EventHandler(this.btnSaveDistinctWords_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblParaghraph);
            this.panel5.Controls.Add(this.btnScale);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.lblLetters);
            this.panel5.Controls.Add(this.lblSentences);
            this.panel5.Controls.Add(this.lblWords);
            this.panel5.Controls.Add(this.btnEntropy);
            this.panel5.Controls.Add(this.btnResultDetail);
            this.panel5.Controls.Add(this.btnLettersProbability);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(649, 158);
            this.panel5.TabIndex = 21;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblParaghraph
            // 
            this.lblParaghraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblParaghraph.AutoSize = true;
            this.lblParaghraph.BackColor = System.Drawing.Color.Transparent;
            this.lblParaghraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaghraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(29)))));
            this.lblParaghraph.Location = new System.Drawing.Point(223, 76);
            this.lblParaghraph.Name = "lblParaghraph";
            this.lblParaghraph.Size = new System.Drawing.Size(114, 25);
            this.lblParaghraph.TabIndex = 17;
            this.lblParaghraph.Text = "Paraghraph";
            this.lblParaghraph.Visible = false;
            // 
            // btnScale
            // 
            this.btnScale.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnScale.Location = new System.Drawing.Point(453, 115);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(91, 40);
            this.btnScale.TabIndex = 16;
            this.btnScale.Text = "Escala";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnEntropy
            // 
            this.btnEntropy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntropy.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntropy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntropy.Location = new System.Drawing.Point(550, 115);
            this.btnEntropy.Name = "btnEntropy";
            this.btnEntropy.Size = new System.Drawing.Size(91, 40);
            this.btnEntropy.TabIndex = 14;
            this.btnEntropy.Text = "Entropia";
            this.btnEntropy.UseVisualStyleBackColor = true;
            this.btnEntropy.Visible = false;
            this.btnEntropy.Click += new System.EventHandler(this.btnEntropy_Click);
            // 
            // btnResultDetail
            // 
            this.btnResultDetail.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultDetail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnResultDetail.Location = new System.Drawing.Point(221, 113);
            this.btnResultDetail.Name = "btnResultDetail";
            this.btnResultDetail.Size = new System.Drawing.Size(91, 40);
            this.btnResultDetail.TabIndex = 2;
            this.btnResultDetail.Text = "palavras";
            this.btnResultDetail.UseVisualStyleBackColor = true;
            this.btnResultDetail.Visible = false;
            this.btnResultDetail.Click += new System.EventHandler(this.btnResultDetail_Click);
            // 
            // btnLettersProbability
            // 
            this.btnLettersProbability.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLettersProbability.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLettersProbability.Location = new System.Drawing.Point(308, 113);
            this.btnLettersProbability.Name = "btnLettersProbability";
            this.btnLettersProbability.Size = new System.Drawing.Size(91, 40);
            this.btnLettersProbability.TabIndex = 3;
            this.btnLettersProbability.Text = "letras";
            this.btnLettersProbability.UseVisualStyleBackColor = true;
            this.btnLettersProbability.Visible = false;
            this.btnLettersProbability.Click += new System.EventHandler(this.btnLettersProbability_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripImportData,
            this.menuStripResetData});
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.importDataToolStripMenuItem.Text = "Menu";
            // 
            // menuStripImportData
            // 
            this.menuStripImportData.Name = "menuStripImportData";
            this.menuStripImportData.Size = new System.Drawing.Size(209, 22);
            this.menuStripImportData.Text = "Importar palavra";
            this.menuStripImportData.Click += new System.EventHandler(this.menuStripImportData_Click);
            // 
            // menuStripResetData
            // 
            this.menuStripResetData.Name = "menuStripResetData";
            this.menuStripResetData.Size = new System.Drawing.Size(209, 22);
            this.menuStripResetData.Text = "Resetar o banco de dados";
            this.menuStripResetData.Click += new System.EventHandler(this.menuStripResetData_Click);
            // 
            // frmMainForm
            // 
            this.AcceptButton = this.btnGetInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCLose;
            this.ClientSize = new System.Drawing.Size(1028, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calcuLetra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainForm_FormClosed);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.CTMSPaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordsProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersProbability)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbINput;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private RoundButton btnResultDetail;
        private System.Windows.Forms.DataGridView dgvWordsProbability;
        private RoundButton btnLettersProbability;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvLettersProbability;
        private System.Windows.Forms.ContextMenuStrip CTMSPaste;
        private System.Windows.Forms.ToolStripMenuItem CMSPaste;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLoseToolStripMenuItem;
        private RoundButton btnEntropy;
        private RoundButton btnSaveDistinctWords;
        private RoundButton btnScale;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.OpenFileDialog ImportFileDialogue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripImportData;
        private System.Windows.Forms.ToolStripMenuItem menuStripResetData;
        private System.Windows.Forms.Label lblParaghraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvOccurrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgvProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}