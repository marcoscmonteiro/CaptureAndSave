
namespace CaptureAndSave
{
    partial class FormMain
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
            this.buttonSendkeys = new System.Windows.Forms.Button();
            this.textDir = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.cboWindows = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableMouseClick = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCaptures = new System.Windows.Forms.Label();
            this.timerCapture = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownTimeBeforeCapture = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeBeforeCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSendkeys
            // 
            this.buttonSendkeys.Location = new System.Drawing.Point(4, 244);
            this.buttonSendkeys.Name = "buttonSendkeys";
            this.buttonSendkeys.Size = new System.Drawing.Size(374, 92);
            this.buttonSendkeys.TabIndex = 0;
            this.buttonSendkeys.Text = "Sendkeys Commands";
            this.buttonSendkeys.UseVisualStyleBackColor = true;
            this.buttonSendkeys.Click += new System.EventHandler(this.buttonSendkeys_Click);
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(106, 98);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(425, 20);
            this.textDir.TabIndex = 4;
            this.textDir.Text = "c:\\users\\marco\\Downloads";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(106, 72);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(35, 20);
            this.textNumber.TabIndex = 3;
            this.textNumber.Text = "1";
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(106, 46);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(162, 20);
            this.textFilename.TabIndex = 2;
            this.textFilename.Text = "Imagem-";
            // 
            // cboWindows
            // 
            this.cboWindows.FormattingEnabled = true;
            this.cboWindows.Location = new System.Drawing.Point(106, 19);
            this.cboWindows.Name = "cboWindows";
            this.cboWindows.Size = new System.Drawing.Size(425, 21);
            this.cboWindows.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(537, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(77, 21);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 181);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Repeat:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(106, 207);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tick Interval (ms):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Window Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Image name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Initial Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Directory Destiny:";
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Location = new System.Drawing.Point(106, 155);
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(425, 20);
            this.textBoxCommands.TabIndex = 7;
            this.textBoxCommands.Text = "%{PRTSC}{RIGHT}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Commands:";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(384, 244);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(98, 29);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownTimeBeforeCapture);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBoxEnableMouseClick);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textY);
            this.groupBox1.Controls.Add(this.textX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelCaptures);
            this.groupBox1.Controls.Add(this.cboWindows);
            this.groupBox1.Controls.Add(this.textDir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textNumber);
            this.groupBox1.Controls.Add(this.textBoxCommands);
            this.groupBox1.Controls.Add(this.textFilename);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 236);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxEnableMouseClick
            // 
            this.checkBoxEnableMouseClick.AutoSize = true;
            this.checkBoxEnableMouseClick.Checked = true;
            this.checkBoxEnableMouseClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableMouseClick.Location = new System.Drawing.Point(251, 129);
            this.checkBoxEnableMouseClick.Name = "checkBoxEnableMouseClick";
            this.checkBoxEnableMouseClick.Size = new System.Drawing.Size(199, 17);
            this.checkBoxEnableMouseClick.TabIndex = 31;
            this.checkBoxEnableMouseClick.Text = "Enable mouse click before sendkeys";
            this.checkBoxEnableMouseClick.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "X";
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(186, 127);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(59, 20);
            this.textY.TabIndex = 6;
            this.textY.Text = "200";
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(105, 127);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(55, 20);
            this.textX.TabIndex = 5;
            this.textX.Text = "200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mouse Point Click:";
            // 
            // labelCaptures
            // 
            this.labelCaptures.AutoSize = true;
            this.labelCaptures.Location = new System.Drawing.Point(232, 183);
            this.labelCaptures.Name = "labelCaptures";
            this.labelCaptures.Size = new System.Drawing.Size(55, 13);
            this.labelCaptures.TabIndex = 26;
            this.labelCaptures.Text = "Captures: ";
            // 
            // timerCapture
            // 
            this.timerCapture.Tick += new System.EventHandler(this.timerCapture_Tick);
            // 
            // numericUpDownTimeBeforeCapture
            // 
            this.numericUpDownTimeBeforeCapture.Location = new System.Drawing.Point(341, 207);
            this.numericUpDownTimeBeforeCapture.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTimeBeforeCapture.Name = "numericUpDownTimeBeforeCapture";
            this.numericUpDownTimeBeforeCapture.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTimeBeforeCapture.TabIndex = 10;
            this.numericUpDownTimeBeforeCapture.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Before Capture (ms):";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSendkeys);
            this.MinimumSize = new System.Drawing.Size(648, 357);
            this.Name = "FormMain";
            this.Text = "Sendkeys Commands to a Visible Window, Capture Image from Clipboard and Save as P" +
    "NG";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeBeforeCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSendkeys;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.ComboBox cboWindows;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCommands;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.Label labelCaptures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxEnableMouseClick;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeBeforeCapture;
        private System.Windows.Forms.Label label10;
    }
}

