namespace ScreenSaver
{
    partial class frmSettings
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
            this.tkbMinimumTextSpeedOne = new System.Windows.Forms.TrackBar();
            this.nudAmountTextOne = new System.Windows.Forms.NumericUpDown();
            this.cldColor = new System.Windows.Forms.ColorDialog();
            this.tkbMaximumTextSpeedTwo = new System.Windows.Forms.TrackBar();
            this.tkbMaximumTextSpeedOne = new System.Windows.Forms.TrackBar();
            this.tkbMinimumTextSpeedTwo = new System.Windows.Forms.TrackBar();
            this.lblnummax2 = new System.Windows.Forms.Label();
            this.lblnummax1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnummin2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnummin1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextTwo = new System.Windows.Forms.TextBox();
            this.txtTextOne = new System.Windows.Forms.TextBox();
            this.lblTextTwo = new System.Windows.Forms.Label();
            this.lblTextOne = new System.Windows.Forms.Label();
            this.btnFontTwo = new System.Windows.Forms.Button();
            this.btnColorTwo = new System.Windows.Forms.Button();
            this.btnFontOne = new System.Windows.Forms.Button();
            this.btnColorOne = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ftdFont = new System.Windows.Forms.FontDialog();
            this.nudAmountTextTwo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoUpwardsTwo = new System.Windows.Forms.RadioButton();
            this.rdoTopToBottomTwo = new System.Windows.Forms.RadioButton();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdoUpwardsOne = new System.Windows.Forms.RadioButton();
            this.rdoTopToBottomOne = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMinimumTextSpeedOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTextOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMaximumTextSpeedTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMaximumTextSpeedOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMinimumTextSpeedTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTextTwo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tkbMinimumTextSpeedOne
            // 
            this.tkbMinimumTextSpeedOne.Location = new System.Drawing.Point(160, 209);
            this.tkbMinimumTextSpeedOne.Maximum = 99;
            this.tkbMinimumTextSpeedOne.Minimum = 1;
            this.tkbMinimumTextSpeedOne.Name = "tkbMinimumTextSpeedOne";
            this.tkbMinimumTextSpeedOne.Size = new System.Drawing.Size(149, 45);
            this.tkbMinimumTextSpeedOne.TabIndex = 1;
            this.tkbMinimumTextSpeedOne.Value = 99;
            this.tkbMinimumTextSpeedOne.ValueChanged += new System.EventHandler(this.tkbMinimumTextSpeedOne_ValueChanged);
            // 
            // nudAmountTextOne
            // 
            this.nudAmountTextOne.Location = new System.Drawing.Point(128, 132);
            this.nudAmountTextOne.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmountTextOne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountTextOne.Name = "nudAmountTextOne";
            this.nudAmountTextOne.Size = new System.Drawing.Size(72, 20);
            this.nudAmountTextOne.TabIndex = 3;
            this.nudAmountTextOne.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmountTextOne.ValueChanged += new System.EventHandler(this.nudAmountTextOne_ValueChanged);
            // 
            // cldColor
            // 
            this.cldColor.AnyColor = true;
            this.cldColor.FullOpen = true;
            // 
            // tkbMaximumTextSpeedTwo
            // 
            this.tkbMaximumTextSpeedTwo.Location = new System.Drawing.Point(164, 158);
            this.tkbMaximumTextSpeedTwo.Maximum = 100;
            this.tkbMaximumTextSpeedTwo.Minimum = 1;
            this.tkbMaximumTextSpeedTwo.Name = "tkbMaximumTextSpeedTwo";
            this.tkbMaximumTextSpeedTwo.Size = new System.Drawing.Size(146, 45);
            this.tkbMaximumTextSpeedTwo.TabIndex = 10;
            this.tkbMaximumTextSpeedTwo.Value = 100;
            this.tkbMaximumTextSpeedTwo.ValueChanged += new System.EventHandler(this.tkbMaximumTextSpeedTwo_ValueChanged);
            // 
            // tkbMaximumTextSpeedOne
            // 
            this.tkbMaximumTextSpeedOne.Location = new System.Drawing.Point(163, 158);
            this.tkbMaximumTextSpeedOne.Maximum = 100;
            this.tkbMaximumTextSpeedOne.Minimum = 1;
            this.tkbMaximumTextSpeedOne.Name = "tkbMaximumTextSpeedOne";
            this.tkbMaximumTextSpeedOne.Size = new System.Drawing.Size(146, 45);
            this.tkbMaximumTextSpeedOne.TabIndex = 4;
            this.tkbMaximumTextSpeedOne.Value = 100;
            this.tkbMaximumTextSpeedOne.ValueChanged += new System.EventHandler(this.tkbMaximumTextSpeedOne_ValueChanged);
            // 
            // tkbMinimumTextSpeedTwo
            // 
            this.tkbMinimumTextSpeedTwo.Location = new System.Drawing.Point(161, 209);
            this.tkbMinimumTextSpeedTwo.Maximum = 99;
            this.tkbMinimumTextSpeedTwo.Minimum = 1;
            this.tkbMinimumTextSpeedTwo.Name = "tkbMinimumTextSpeedTwo";
            this.tkbMinimumTextSpeedTwo.Size = new System.Drawing.Size(146, 45);
            this.tkbMinimumTextSpeedTwo.TabIndex = 7;
            this.tkbMinimumTextSpeedTwo.Value = 99;
            this.tkbMinimumTextSpeedTwo.ValueChanged += new System.EventHandler(this.tkbMinimumTextSpeedTwo_ValueChanged);
            // 
            // lblnummax2
            // 
            this.lblnummax2.AutoSize = true;
            this.lblnummax2.Location = new System.Drawing.Point(316, 169);
            this.lblnummax2.Name = "lblnummax2";
            this.lblnummax2.Size = new System.Drawing.Size(25, 13);
            this.lblnummax2.TabIndex = 11;
            this.lblnummax2.Text = "100";
            // 
            // lblnummax1
            // 
            this.lblnummax1.AutoSize = true;
            this.lblnummax1.Location = new System.Drawing.Point(318, 168);
            this.lblnummax1.Name = "lblnummax1";
            this.lblnummax1.Size = new System.Drawing.Size(25, 13);
            this.lblnummax1.TabIndex = 5;
            this.lblnummax1.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Velocidade maxima do Texto : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Velocidade minima do Texto : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Velocidade maxima do Texto : ";
            // 
            // lblnummin2
            // 
            this.lblnummin2.AutoSize = true;
            this.lblnummin2.Location = new System.Drawing.Point(313, 221);
            this.lblnummin2.Name = "lblnummin2";
            this.lblnummin2.Size = new System.Drawing.Size(19, 13);
            this.lblnummin2.TabIndex = 8;
            this.lblnummin2.Text = "99";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Velocidade minima do Texto : ";
            // 
            // lblnummin1
            // 
            this.lblnummin1.AutoSize = true;
            this.lblnummin1.Location = new System.Drawing.Point(315, 221);
            this.lblnummin1.Name = "lblnummin1";
            this.lblnummin1.Size = new System.Drawing.Size(19, 13);
            this.lblnummin1.TabIndex = 2;
            this.lblnummin1.Text = "99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Texto 2 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto : ";
            // 
            // txtTextTwo
            // 
            this.txtTextTwo.Location = new System.Drawing.Point(61, 77);
            this.txtTextTwo.Name = "txtTextTwo";
            this.txtTextTwo.Size = new System.Drawing.Size(136, 20);
            this.txtTextTwo.TabIndex = 9;
            this.txtTextTwo.Text = "1";
            this.txtTextTwo.TextChanged += new System.EventHandler(this.txtTextTwo_TextChanged);
            // 
            // txtTextOne
            // 
            this.txtTextOne.Location = new System.Drawing.Point(55, 77);
            this.txtTextOne.Name = "txtTextOne";
            this.txtTextOne.Size = new System.Drawing.Size(136, 20);
            this.txtTextOne.TabIndex = 6;
            this.txtTextOne.Text = "0";
            this.txtTextOne.TextChanged += new System.EventHandler(this.txtTextOne_TextChanged);
            // 
            // lblTextTwo
            // 
            this.lblTextTwo.AutoSize = true;
            this.lblTextTwo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTwo.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTextTwo.Location = new System.Drawing.Point(257, 46);
            this.lblTextTwo.Name = "lblTextTwo";
            this.lblTextTwo.Size = new System.Drawing.Size(78, 22);
            this.lblTextTwo.TabIndex = 7;
            this.lblTextTwo.Text = "Texto 2";
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTextOne.Location = new System.Drawing.Point(253, 46);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(78, 22);
            this.lblTextOne.TabIndex = 2;
            this.lblTextOne.Text = "Texto 1";
            // 
            // btnFontTwo
            // 
            this.btnFontTwo.Location = new System.Drawing.Point(6, 19);
            this.btnFontTwo.Name = "btnFontTwo";
            this.btnFontTwo.Size = new System.Drawing.Size(103, 23);
            this.btnFontTwo.TabIndex = 3;
            this.btnFontTwo.Text = "Fonte do Texto";
            this.btnFontTwo.UseVisualStyleBackColor = true;
            this.btnFontTwo.Click += new System.EventHandler(this.btnFontTwo_Click);
            // 
            // btnColorTwo
            // 
            this.btnColorTwo.Location = new System.Drawing.Point(6, 48);
            this.btnColorTwo.Name = "btnColorTwo";
            this.btnColorTwo.Size = new System.Drawing.Size(85, 23);
            this.btnColorTwo.TabIndex = 4;
            this.btnColorTwo.Text = "Cor do Texto";
            this.btnColorTwo.UseVisualStyleBackColor = true;
            this.btnColorTwo.Click += new System.EventHandler(this.btnColorTwo_Click);
            // 
            // btnFontOne
            // 
            this.btnFontOne.Location = new System.Drawing.Point(6, 19);
            this.btnFontOne.Name = "btnFontOne";
            this.btnFontOne.Size = new System.Drawing.Size(103, 23);
            this.btnFontOne.TabIndex = 0;
            this.btnFontOne.Text = "Fonte do Texto";
            this.btnFontOne.UseVisualStyleBackColor = true;
            this.btnFontOne.Click += new System.EventHandler(this.btnFontOne_Click);
            // 
            // btnColorOne
            // 
            this.btnColorOne.Location = new System.Drawing.Point(6, 48);
            this.btnColorOne.Name = "btnColorOne";
            this.btnColorOne.Size = new System.Drawing.Size(85, 23);
            this.btnColorOne.TabIndex = 1;
            this.btnColorOne.Text = "Cor do Texto";
            this.btnColorOne.UseVisualStyleBackColor = true;
            this.btnColorOne.Click += new System.EventHandler(this.btnColorOne_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(435, 325);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(243, 325);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade de Texto : ";
            // 
            // nudAmountTextTwo
            // 
            this.nudAmountTextTwo.Location = new System.Drawing.Point(125, 132);
            this.nudAmountTextTwo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmountTextTwo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountTextTwo.Name = "nudAmountTextTwo";
            this.nudAmountTextTwo.Size = new System.Drawing.Size(72, 20);
            this.nudAmountTextTwo.TabIndex = 5;
            this.nudAmountTextTwo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmountTextTwo.ValueChanged += new System.EventHandler(this.nudAmountTextTwo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de Texto :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoUpwardsTwo);
            this.groupBox2.Controls.Add(this.rdoTopToBottomTwo);
            this.groupBox2.Location = new System.Drawing.Point(6, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 37);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem ";
            // 
            // rdoUpwardsTwo
            // 
            this.rdoUpwardsTwo.AutoSize = true;
            this.rdoUpwardsTwo.Location = new System.Drawing.Point(225, 14);
            this.rdoUpwardsTwo.Name = "rdoUpwardsTwo";
            this.rdoUpwardsTwo.Size = new System.Drawing.Size(116, 17);
            this.rdoUpwardsTwo.TabIndex = 1;
            this.rdoUpwardsTwo.Text = "De baixo para cima";
            this.rdoUpwardsTwo.UseVisualStyleBackColor = true;
            // 
            // rdoTopToBottomTwo
            // 
            this.rdoTopToBottomTwo.AutoSize = true;
            this.rdoTopToBottomTwo.Checked = true;
            this.rdoTopToBottomTwo.Location = new System.Drawing.Point(6, 14);
            this.rdoTopToBottomTwo.Name = "rdoTopToBottomTwo";
            this.rdoTopToBottomTwo.Size = new System.Drawing.Size(116, 17);
            this.rdoTopToBottomTwo.TabIndex = 0;
            this.rdoTopToBottomTwo.TabStop = true;
            this.rdoTopToBottomTwo.Text = "De cima para baixo";
            this.rdoTopToBottomTwo.UseVisualStyleBackColor = true;
            this.rdoTopToBottomTwo.CheckedChanged += new System.EventHandler(this.rdoTopToBottomTwo_CheckedChanged);
            // 
            // btnVisualize
            // 
            this.btnVisualize.Location = new System.Drawing.Point(336, 325);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(75, 23);
            this.btnVisualize.TabIndex = 9;
            this.btnVisualize.Text = "Visualizar";
            this.btnVisualize.UseVisualStyleBackColor = true;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tkbMaximumTextSpeedOne);
            this.groupBox4.Controls.Add(this.nudAmountTextOne);
            this.groupBox4.Controls.Add(this.tkbMinimumTextSpeedOne);
            this.groupBox4.Controls.Add(this.lblnummax1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblnummin1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 307);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Texto 1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdoUpwardsOne);
            this.groupBox6.Controls.Add(this.rdoTopToBottomOne);
            this.groupBox6.Location = new System.Drawing.Point(8, 260);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 37);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ordem ";
            // 
            // rdoUpwardsOne
            // 
            this.rdoUpwardsOne.AutoSize = true;
            this.rdoUpwardsOne.Location = new System.Drawing.Point(217, 14);
            this.rdoUpwardsOne.Name = "rdoUpwardsOne";
            this.rdoUpwardsOne.Size = new System.Drawing.Size(116, 17);
            this.rdoUpwardsOne.TabIndex = 1;
            this.rdoUpwardsOne.Text = "De baixo para cima";
            this.rdoUpwardsOne.UseVisualStyleBackColor = true;
            // 
            // rdoTopToBottomOne
            // 
            this.rdoTopToBottomOne.AutoSize = true;
            this.rdoTopToBottomOne.Checked = true;
            this.rdoTopToBottomOne.Location = new System.Drawing.Point(6, 14);
            this.rdoTopToBottomOne.Name = "rdoTopToBottomOne";
            this.rdoTopToBottomOne.Size = new System.Drawing.Size(116, 17);
            this.rdoTopToBottomOne.TabIndex = 0;
            this.rdoTopToBottomOne.TabStop = true;
            this.rdoTopToBottomOne.Text = "De cima para baixo";
            this.rdoTopToBottomOne.UseVisualStyleBackColor = true;
            this.rdoTopToBottomOne.CheckedChanged += new System.EventHandler(this.rdoTopToBottomOne_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFontOne);
            this.groupBox1.Controls.Add(this.btnColorOne);
            this.groupBox1.Controls.Add(this.txtTextOne);
            this.groupBox1.Controls.Add(this.lblTextOne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonte ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.tkbMaximumTextSpeedTwo);
            this.groupBox5.Controls.Add(this.tkbMinimumTextSpeedTwo);
            this.groupBox5.Controls.Add(this.lblnummax2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.lblnummin2);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.nudAmountTextTwo);
            this.groupBox5.Location = new System.Drawing.Point(371, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 307);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Texto 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFontTwo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblTextTwo);
            this.groupBox3.Controls.Add(this.btnColorTwo);
            this.groupBox3.Controls.Add(this.txtTextTwo);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 107);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fonte ";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 361);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.tkbMinimumTextSpeedOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTextOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMaximumTextSpeedTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMaximumTextSpeedOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMinimumTextSpeedTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTextTwo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbMinimumTextSpeedOne;
        private System.Windows.Forms.NumericUpDown nudAmountTextOne;
        private System.Windows.Forms.ColorDialog cldColor;
        private System.Windows.Forms.Label lblnummin1;
        private System.Windows.Forms.Button btnColorTwo;
        private System.Windows.Forms.Button btnColorOne;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tkbMaximumTextSpeedOne;
        private System.Windows.Forms.Label lblnummax1;
        private System.Windows.Forms.Button btnFontTwo;
        private System.Windows.Forms.Button btnFontOne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTextTwo;
        private System.Windows.Forms.Label lblTextOne;
        private System.Windows.Forms.TrackBar tkbMaximumTextSpeedTwo;
        private System.Windows.Forms.TrackBar tkbMinimumTextSpeedTwo;
        private System.Windows.Forms.Label lblnummax2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblnummin2;
        private System.Windows.Forms.FontDialog ftdFont;
        private System.Windows.Forms.NumericUpDown nudAmountTextTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoUpwardsTwo;
        private System.Windows.Forms.RadioButton rdoTopToBottomTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextTwo;
        private System.Windows.Forms.TextBox txtTextOne;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdoUpwardsOne;
        private System.Windows.Forms.RadioButton rdoTopToBottomOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}