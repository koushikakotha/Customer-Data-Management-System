namespace LoginPage_ContactKeeper
{
    partial class Form2
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
            panel1 = new Panel();
            label9 = new Label();
            txtRemarks = new TextBox();
            txtTallysno = new TextBox();
            label8 = new Label();
            button1 = new Button();
            textsno = new TextBox();
            label6 = new Label();
            btnsave = new Button();
            txtaddress = new TextBox();
            txtemail = new TextBox();
            txtbusiness = new TextBox();
            txtcontact = new TextBox();
            txtcustomername = new TextBox();
            label13 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtRemarks);
            panel1.Controls.Add(txtTallysno);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textsno);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnsave);
            panel1.Controls.Add(txtaddress);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtbusiness);
            panel1.Controls.Add(txtcontact);
            panel1.Controls.Add(txtcustomername);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(72, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 505);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(160, 113, 255);
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(26, 286);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 24;
            label9.Text = "Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(199, 272);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(301, 52);
            txtRemarks.TabIndex = 23;
            // 
            // txtTallysno
            // 
            txtTallysno.Location = new Point(199, 232);
            txtTallysno.Name = "txtTallysno";
            txtTallysno.Size = new Size(301, 23);
            txtTallysno.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(160, 113, 255);
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(26, 237);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 21;
            label8.Text = "Tally S.No";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(160, 113, 255);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(295, 465);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 20;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textsno
            // 
            textsno.Enabled = false;
            textsno.Location = new Point(199, 14);
            textsno.Name = "textsno";
            textsno.Size = new Size(301, 23);
            textsno.TabIndex = 19;
            textsno.TextChanged += textsno_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(160, 113, 255);
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(26, 14);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 18;
            label6.Text = "SNo";
            label6.Click += label6_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(160, 113, 255);
            btnsave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.ForeColor = SystemColors.ControlLightLight;
            btnsave.Location = new Point(118, 465);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 33);
            btnsave.TabIndex = 0;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += button1_Click;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(199, 349);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(301, 102);
            txtaddress.TabIndex = 17;
            txtaddress.TextChanged += textBox6_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(199, 183);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(301, 23);
            txtemail.TabIndex = 16;
            // 
            // txtbusiness
            // 
            txtbusiness.Location = new Point(199, 95);
            txtbusiness.Name = "txtbusiness";
            txtbusiness.Size = new Size(301, 23);
            txtbusiness.TabIndex = 15;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(199, 137);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(301, 23);
            txtcontact.TabIndex = 14;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(199, 54);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(301, 23);
            txtcustomername.TabIndex = 13;
            txtcustomername.TextChanged += txtcustomername_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(389, 237);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(160, 113, 255);
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(26, 349);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 5;
            label7.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(160, 113, 255);
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 186);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(160, 113, 255);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(24, 140);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Contact ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(160, 113, 255);
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(27, 98);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 1;
            label3.Text = "Business";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(160, 113, 255);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Admin Login";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-27, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 603);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 113, 255);
            ClientSize = new Size(629, 594);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtbusiness;
        private TextBox txtcontact;
        private TextBox txtcustomername;
        private Label label13;
        private Label label7;
        private TextBox txtaddress;
        private TextBox txtemail;
        private Panel panel2;
        private Button btnsave;
        private Label label6;
        private TextBox textsno;
        private Button button1;
        private TextBox txtRemarks;
        private TextBox txtTallysno;
        private Label label8;
        private Label label9;
    }
}