namespace Library
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSearch = new Button();
            btnExit = new Button();
            btnRefresh = new Button();
            txtEnrollement = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label10 = new Label();
            btnIssueBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtContact = new TextBox();
            label6 = new Label();
            txtSem = new TextBox();
            label5 = new Label();
            txtDep = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(390, 31);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEnrollement);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 466);
            panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(69, 216);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 45);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(146, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 38);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(36, 391);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 38);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Location = new Point(36, 167);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(223, 23);
            txtEnrollement.TabIndex = 4;
            txtEnrollement.TextChanged += txtEnrollement_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 123);
            label2.Name = "label2";
            label2.Size = new Size(235, 30);
            label2.TabIndex = 3;
            label2.Text = "Enter Enrollement NO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(102, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtSem);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtDep);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(312, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 466);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(48, 409);
            label10.Name = "label10";
            label10.Size = new Size(196, 63);
            label10.TabIndex = 16;
            label10.Text = "Maximum 3 Books can be\r\nISSUED to 1 Student\r\n\r\n";
            // 
            // btnIssueBook
            // 
            btnIssueBook.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueBook.Location = new Point(303, 402);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(95, 38);
            btnIssueBook.TabIndex = 8;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(240, 338);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 23);
            comboBox1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(62, 338);
            label9.Name = "label9";
            label9.Size = new Size(129, 23);
            label9.TabIndex = 12;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 280);
            label8.Name = "label8";
            label8.Size = new Size(95, 23);
            label8.TabIndex = 10;
            label8.Text = "Book Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(240, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(192, 23);
            txtEmail.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 222);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 8;
            label7.Text = "Student Email";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(240, 178);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(192, 23);
            txtContact.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 178);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 6;
            label6.Text = "Student Contact";
            // 
            // txtSem
            // 
            txtSem.Location = new Point(240, 132);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(192, 23);
            txtSem.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 132);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 4;
            label5.Text = "Student Semester";
            // 
            // txtDep
            // 
            txtDep.Location = new Point(240, 86);
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(192, 23);
            txtDep.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 86);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(240, 42);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(192, 23);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 42);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(796, 596);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnRefresh;
        private TextBox txtEnrollement;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button btnSearch;
        private Button btnExit;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtContact;
        private Label label6;
        private TextBox txtSem;
        private Label label5;
        private TextBox txtDep;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private Label label10;
        private Button btnIssueBook;
    }
}