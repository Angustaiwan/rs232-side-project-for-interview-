namespace rs232_side_project_for_interview_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Record = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Setting = new System.Windows.Forms.TabPage();
            this.plcsidelight = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radnone = new System.Windows.Forms.RadioButton();
            this.radcrlf = new System.Windows.Forms.RadioButton();
            this.radcr = new System.Windows.Forms.RadioButton();
            this.plcsideclosebtn = new System.Windows.Forms.Button();
            this.btnreaderplcside = new System.Windows.Forms.Button();
            this.readerstatus = new System.Windows.Forms.PictureBox();
            this.cmstopbits2 = new System.Windows.Forms.ComboBox();
            this.cmdatabits2 = new System.Windows.Forms.ComboBox();
            this.cmparity2 = new System.Windows.Forms.ComboBox();
            this.cmbaudrate2 = new System.Windows.Forms.ComboBox();
            this.plcportname = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmstopbits1 = new System.Windows.Forms.ComboBox();
            this.cmdatabits1 = new System.Windows.Forms.ComboBox();
            this.cmparity1 = new System.Windows.Forms.ComboBox();
            this.cmbaudrate1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmportname2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Record.SuspendLayout();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plcsidelight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 750);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Record);
            this.tabControl1.Controls.Add(this.Setting);
            this.tabControl1.Location = new System.Drawing.Point(3, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // Record
            // 
            this.Record.Controls.Add(this.listView1);
            this.Record.Location = new System.Drawing.Point(8, 44);
            this.Record.Name = "Record";
            this.Record.Padding = new System.Windows.Forms.Padding(3);
            this.Record.Size = new System.Drawing.Size(1232, 681);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(3, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1226, 628);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.plcsidelight);
            this.Setting.Controls.Add(this.button1);
            this.Setting.Controls.Add(this.panel2);
            this.Setting.Controls.Add(this.plcsideclosebtn);
            this.Setting.Controls.Add(this.btnreaderplcside);
            this.Setting.Controls.Add(this.readerstatus);
            this.Setting.Controls.Add(this.cmstopbits2);
            this.Setting.Controls.Add(this.cmdatabits2);
            this.Setting.Controls.Add(this.cmparity2);
            this.Setting.Controls.Add(this.cmbaudrate2);
            this.Setting.Controls.Add(this.plcportname);
            this.Setting.Controls.Add(this.label10);
            this.Setting.Controls.Add(this.label9);
            this.Setting.Controls.Add(this.label8);
            this.Setting.Controls.Add(this.label7);
            this.Setting.Controls.Add(this.label6);
            this.Setting.Controls.Add(this.cmstopbits1);
            this.Setting.Controls.Add(this.cmdatabits1);
            this.Setting.Controls.Add(this.cmparity1);
            this.Setting.Controls.Add(this.cmbaudrate1);
            this.Setting.Controls.Add(this.label5);
            this.Setting.Controls.Add(this.label4);
            this.Setting.Controls.Add(this.label3);
            this.Setting.Controls.Add(this.label2);
            this.Setting.Controls.Add(this.textBox2);
            this.Setting.Controls.Add(this.cmportname2);
            this.Setting.Controls.Add(this.label1);
            this.Setting.Controls.Add(this.textBox1);
            this.Setting.Location = new System.Drawing.Point(8, 44);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(1232, 681);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // plcsidelight
            // 
            this.plcsidelight.Location = new System.Drawing.Point(1147, 35);
            this.plcsidelight.Name = "plcsidelight";
            this.plcsidelight.Size = new System.Drawing.Size(29, 25);
            this.plcsidelight.TabIndex = 28;
            this.plcsidelight.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radnone);
            this.panel2.Controls.Add(this.radcrlf);
            this.panel2.Controls.Add(this.radcr);
            this.panel2.Location = new System.Drawing.Point(611, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 63);
            this.panel2.TabIndex = 26;
            // 
            // radnone
            // 
            this.radnone.AutoSize = true;
            this.radnone.Location = new System.Drawing.Point(405, 16);
            this.radnone.Name = "radnone";
            this.radnone.Size = new System.Drawing.Size(115, 34);
            this.radnone.TabIndex = 2;
            this.radnone.TabStop = true;
            this.radnone.Text = "NONE";
            this.radnone.UseVisualStyleBackColor = true;
            // 
            // radcrlf
            // 
            this.radcrlf.AutoSize = true;
            this.radcrlf.Location = new System.Drawing.Point(214, 16);
            this.radcrlf.Name = "radcrlf";
            this.radcrlf.Size = new System.Drawing.Size(110, 34);
            this.radcrlf.TabIndex = 1;
            this.radcrlf.TabStop = true;
            this.radcrlf.Text = "CR/LF";
            this.radcrlf.UseVisualStyleBackColor = true;
            // 
            // radcr
            // 
            this.radcr.AutoSize = true;
            this.radcr.Location = new System.Drawing.Point(14, 16);
            this.radcr.Name = "radcr";
            this.radcr.Size = new System.Drawing.Size(75, 34);
            this.radcr.TabIndex = 0;
            this.radcr.TabStop = true;
            this.radcr.Text = "CR";
            this.radcr.UseVisualStyleBackColor = true;
            // 
            // plcsideclosebtn
            // 
            this.plcsideclosebtn.Location = new System.Drawing.Point(791, 528);
            this.plcsideclosebtn.Name = "plcsideclosebtn";
            this.plcsideclosebtn.Size = new System.Drawing.Size(150, 46);
            this.plcsideclosebtn.TabIndex = 25;
            this.plcsideclosebtn.Text = "Close";
            this.plcsideclosebtn.UseVisualStyleBackColor = true;
            this.plcsideclosebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnreaderplcside
            // 
            this.btnreaderplcside.Location = new System.Drawing.Point(325, 528);
            this.btnreaderplcside.Name = "btnreaderplcside";
            this.btnreaderplcside.Size = new System.Drawing.Size(150, 46);
            this.btnreaderplcside.TabIndex = 24;
            this.btnreaderplcside.Text = "Connect";
            this.btnreaderplcside.UseVisualStyleBackColor = true;
            this.btnreaderplcside.Click += new System.EventHandler(this.btnreaderplcside_Click);
            // 
            // readerstatus
            // 
            this.readerstatus.Location = new System.Drawing.Point(20, 35);
            this.readerstatus.Name = "readerstatus";
            this.readerstatus.Size = new System.Drawing.Size(29, 25);
            this.readerstatus.TabIndex = 23;
            this.readerstatus.TabStop = false;
            // 
            // cmstopbits2
            // 
            this.cmstopbits2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmstopbits2.FormattingEnabled = true;
            this.cmstopbits2.Location = new System.Drawing.Point(903, 390);
            this.cmstopbits2.Name = "cmstopbits2";
            this.cmstopbits2.Size = new System.Drawing.Size(307, 38);
            this.cmstopbits2.TabIndex = 22;
            // 
            // cmdatabits2
            // 
            this.cmdatabits2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdatabits2.FormattingEnabled = true;
            this.cmdatabits2.Location = new System.Drawing.Point(903, 318);
            this.cmdatabits2.Name = "cmdatabits2";
            this.cmdatabits2.Size = new System.Drawing.Size(307, 38);
            this.cmdatabits2.TabIndex = 21;
            // 
            // cmparity2
            // 
            this.cmparity2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmparity2.FormattingEnabled = true;
            this.cmparity2.Location = new System.Drawing.Point(903, 245);
            this.cmparity2.Name = "cmparity2";
            this.cmparity2.Size = new System.Drawing.Size(307, 38);
            this.cmparity2.TabIndex = 20;
            // 
            // cmbaudrate2
            // 
            this.cmbaudrate2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbaudrate2.FormattingEnabled = true;
            this.cmbaudrate2.Location = new System.Drawing.Point(903, 177);
            this.cmbaudrate2.Name = "cmbaudrate2";
            this.cmbaudrate2.Size = new System.Drawing.Size(307, 38);
            this.cmbaudrate2.TabIndex = 19;
            // 
            // plcportname
            // 
            this.plcportname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plcportname.FormattingEnabled = true;
            this.plcportname.Location = new System.Drawing.Point(903, 109);
            this.plcportname.Name = "plcportname";
            this.plcportname.Size = new System.Drawing.Size(307, 38);
            this.plcportname.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(611, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 38);
            this.label10.TabIndex = 17;
            this.label10.Text = "StopBits";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(611, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 38);
            this.label9.TabIndex = 16;
            this.label9.Text = "DataBits";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(611, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 38);
            this.label8.TabIndex = 15;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(611, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Baud";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(611, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Port";
            // 
            // cmstopbits1
            // 
            this.cmstopbits1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmstopbits1.FormattingEnabled = true;
            this.cmstopbits1.Location = new System.Drawing.Point(298, 393);
            this.cmstopbits1.Name = "cmstopbits1";
            this.cmstopbits1.Size = new System.Drawing.Size(307, 38);
            this.cmstopbits1.TabIndex = 12;
            // 
            // cmdatabits1
            // 
            this.cmdatabits1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdatabits1.FormattingEnabled = true;
            this.cmdatabits1.Location = new System.Drawing.Point(298, 318);
            this.cmdatabits1.Name = "cmdatabits1";
            this.cmdatabits1.Size = new System.Drawing.Size(307, 38);
            this.cmdatabits1.TabIndex = 11;
            // 
            // cmparity1
            // 
            this.cmparity1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmparity1.FormattingEnabled = true;
            this.cmparity1.Location = new System.Drawing.Point(298, 245);
            this.cmparity1.Name = "cmparity1";
            this.cmparity1.Size = new System.Drawing.Size(307, 38);
            this.cmparity1.TabIndex = 10;
            // 
            // cmbaudrate1
            // 
            this.cmbaudrate1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbaudrate1.FormattingEnabled = true;
            this.cmbaudrate1.Location = new System.Drawing.Point(298, 174);
            this.cmbaudrate1.Name = "cmbaudrate1";
            this.cmbaudrate1.Size = new System.Drawing.Size(307, 38);
            this.cmbaudrate1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(6, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "StopBits";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(6, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "DataBits";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(6, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(611, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(599, 91);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "PLC接收端";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmportname2
            // 
            this.cmportname2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmportname2.FormattingEnabled = true;
            this.cmportname2.Location = new System.Drawing.Point(298, 109);
            this.cmportname2.Name = "cmportname2";
            this.cmportname2.Size = new System.Drawing.Size(307, 38);
            this.cmportname2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 91);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "讀碼器接收端";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 757);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Record.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plcsidelight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerstatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage Record;
        private TabPage Setting;
        private TextBox textBox2;
        private ComboBox cmportname2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox cmstopbits2;
        private ComboBox cmdatabits2;
        private ComboBox cmparity2;
        private ComboBox cmbaudrate2;
        private ComboBox plcportname;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cmstopbits1;
        private ComboBox cmdatabits1;
        private ComboBox cmparity1;
        private ComboBox cmbaudrate1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private PictureBox readerstatus;
        private Button btnreaderplcside;
        private Button plcsideclosebtn;
        private Panel panel2;
        private RadioButton radnone;
        private RadioButton radcrlf;
        private RadioButton radcr;
        private Button button1;
        private PictureBox plcsidelight;
    }
}