namespace EncrytpionDecryption
{
    partial class frmcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculator));
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDetailInfo = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnOneOverSix = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btn2Zero = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(375, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Button";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDetailInfo);
            this.groupBox1.Controls.Add(this.lblInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblDetailInfo
            // 
            this.lblDetailInfo.BackColor = System.Drawing.Color.White;
            this.lblDetailInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailInfo.Font = new System.Drawing.Font("Consolas", 14F);
            this.lblDetailInfo.ForeColor = System.Drawing.Color.Purple;
            this.lblDetailInfo.Location = new System.Drawing.Point(3, 16);
            this.lblDetailInfo.Name = "lblDetailInfo";
            this.lblDetailInfo.Size = new System.Drawing.Size(469, 33);
            this.lblDetailInfo.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInput.Font = new System.Drawing.Font("Consolas", 26F);
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(3, 47);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(469, 33);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "0";
            this.lblInput.TextChanged += new System.EventHandler(this.lblInput_TextChanged);
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(554, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 593);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Purple;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(455, 574);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.White;
            this.btnMR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMR.Location = new System.Drawing.Point(108, 85);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(95, 67);
            this.btnMR.TabIndex = 1;
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.White;
            this.btnMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMC.Location = new System.Drawing.Point(16, 85);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(95, 67);
            this.btnMC.TabIndex = 1;
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.White;

            this.btnMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMS.Location = new System.Drawing.Point(203, 85);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(95, 67);
            this.btnMS.TabIndex = 1;
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.Color.White;
            
            this.btnMPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMPlus.Location = new System.Drawing.Point(297, 85);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(95, 67);
            this.btnMPlus.TabIndex = 1;
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.Color.White;
            this.btnSquareRoot.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.square_root_2_256;
            this.btnSquareRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquareRoot.Location = new System.Drawing.Point(393, 215);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(95, 95);
            this.btnSquareRoot.TabIndex = 1;
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.White;
            this.btnPercentage.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.percentage_2_256;
            this.btnPercentage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPercentage.Location = new System.Drawing.Point(393, 310);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(95, 95);
            this.btnPercentage.TabIndex = 1;
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnOneOverSix
            // 
            this.btnOneOverSix.BackColor = System.Drawing.Color.White;
            this.btnOneOverSix.BackgroundImage = global::EncrytpionDecryption.Properties.Resources._1overx;
            this.btnOneOverSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOneOverSix.Location = new System.Drawing.Point(393, 405);
            this.btnOneOverSix.Name = "btnOneOverSix";
            this.btnOneOverSix.Size = new System.Drawing.Size(95, 95);
            this.btnOneOverSix.TabIndex = 1;
            this.btnOneOverSix.UseVisualStyleBackColor = false;
            this.btnOneOverSix.Click += new System.EventHandler(this.btnOneOverSix_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.White;
            this.btnDivision.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.divide_2_256;
            this.btnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivision.Location = new System.Drawing.Point(298, 215);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(95, 95);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.White;
            this.btnEqual.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.equal_sign_2_256;
            this.btnEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEqual.Location = new System.Drawing.Point(392, 500);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(95, 95);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.White;
            this.btnMultiply.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.multiply_2_256;
            this.btnMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiply.Location = new System.Drawing.Point(298, 310);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(95, 95);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.minus_2_256;
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinus.Location = new System.Drawing.Point(298, 405);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(95, 95);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.White;
            this.btnMod.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.mmode;
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMod.Location = new System.Drawing.Point(456, 151);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(95, 67);
            this.btnMod.TabIndex = 1;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackColor = System.Drawing.Color.White;
            
            this.btnMMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMMinus.Location = new System.Drawing.Point(392, 85);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(95, 67);
            this.btnMMinus.TabIndex = 1;
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.BackColor = System.Drawing.Color.White;
            this.btnClearText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearText.BackgroundImage")));
            this.btnClearText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearText.Location = new System.Drawing.Point(392, 151);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(95, 67);
            this.btnClearText.TabIndex = 1;
            this.btnClearText.UseVisualStyleBackColor = false;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.White;
            this.btnPlusMinus.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.plus_minus_2_256;
            this.btnPlusMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusMinus.Location = new System.Drawing.Point(297, 151);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(95, 67);
            this.btnPlusMinus.TabIndex = 1;
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.White;
            this.ButtonC.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.cnEW;
            this.ButtonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonC.Location = new System.Drawing.Point(203, 151);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(95, 67);
            this.ButtonC.TabIndex = 1;
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.White;
            this.btnNine.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_9_256;
            this.btnNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNine.Location = new System.Drawing.Point(203, 215);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(95, 95);
            this.btnNine.TabIndex = 1;
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            this.btnNine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNine_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.plus_2_256;
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlus.Location = new System.Drawing.Point(297, 500);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(95, 95);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.White;
            this.btnSix.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_6_256;
            this.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSix.Location = new System.Drawing.Point(203, 310);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(95, 95);
            this.btnSix.TabIndex = 1;
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            this.btnSix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSix_KeyPress);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.BackColor = System.Drawing.Color.White;
            this.btnRemoveLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveLast.BackgroundImage")));
            this.btnRemoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveLast.Location = new System.Drawing.Point(16, 151);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(95, 67);
            this.btnRemoveLast.TabIndex = 1;
            this.btnRemoveLast.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.White;
            this.btnCE.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.CECE;
            this.btnCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCE.Location = new System.Drawing.Point(108, 151);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(95, 67);
            this.btnCE.TabIndex = 1;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.White;
            this.btnThree.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_3_256;
            this.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThree.Location = new System.Drawing.Point(203, 405);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(95, 95);
            this.btnThree.TabIndex = 1;
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            this.btnThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnThree_KeyPress);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.White;
            this.btnEight.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_8_256;
            this.btnEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEight.Location = new System.Drawing.Point(108, 215);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(95, 95);
            this.btnEight.TabIndex = 1;
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            this.btnEight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnEight_KeyPress);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.White;
            this.btndot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndot.BackgroundImage")));
            this.btndot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndot.Location = new System.Drawing.Point(202, 500);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(95, 95);
            this.btndot.TabIndex = 1;
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            this.btndot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btndot_KeyPress);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.White;
            this.btnFive.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_5_256;
            this.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFive.Location = new System.Drawing.Point(108, 310);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(95, 95);
            this.btnFive.TabIndex = 1;
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            this.btnFive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnFive_KeyPress);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.White;
            this.btnTwo.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_2_256;
            this.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwo.Location = new System.Drawing.Point(108, 405);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(95, 95);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            this.btnTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnTwo_KeyPress);
            // 
            // btnSeven
            // 
            this.btnSeven.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeven.BackColor = System.Drawing.Color.White;
            this.btnSeven.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_7_256;
            this.btnSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeven.Location = new System.Drawing.Point(13, 215);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(95, 95);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            this.btnSeven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSeven_KeyPress);
            // 
            // btn2Zero
            // 
            this.btn2Zero.BackColor = System.Drawing.Color.White;
            this.btn2Zero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2Zero.BackgroundImage")));
            this.btn2Zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2Zero.Location = new System.Drawing.Point(107, 500);
            this.btn2Zero.Name = "btn2Zero";
            this.btn2Zero.Size = new System.Drawing.Size(95, 95);
            this.btn2Zero.TabIndex = 1;
            this.btn2Zero.UseVisualStyleBackColor = false;
            this.btn2Zero.Click += new System.EventHandler(this.btn2Zero_Click);
            this.btn2Zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn2Zero_KeyPress);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.White;
            this.btnFour.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_4_256;
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFour.Location = new System.Drawing.Point(13, 310);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(95, 95);
            this.btnFour.TabIndex = 1;
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            this.btnFour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnFour_KeyPress);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.White;
            this.btnOne.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_1_256;
            this.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOne.Location = new System.Drawing.Point(13, 405);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(95, 95);
            this.btnOne.TabIndex = 1;
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            this.btnOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOne_KeyPress);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.White;
            this.btnZero.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.number_0_256;
            this.btnZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZero.Location = new System.Drawing.Point(12, 500);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(95, 95);
            this.btnZero.TabIndex = 1;
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            this.btnZero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnZero_KeyPress);
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1016, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnOneOverSix);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btn2Zero);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnZero);
            this.Name = "frmcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcuLetra";
            this.Load += new System.EventHandler(this.frmcalculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcalculator_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btn2Zero;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnOneOverSix;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetailInfo;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
    }
}