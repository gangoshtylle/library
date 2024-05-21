namespace Library
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            txtEmail = new TextBox();
            label7 = new Label();
            txtContact = new TextBox();
            label6 = new Label();
            txtSemester = new TextBox();
            label5 = new Label();
            txtDepartment = new TextBox();
            label4 = new Label();
            txtEnrollment = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            btnRefresh = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 36);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 438);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(268, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 438);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(385, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 37);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(250, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 37);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(265, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(100, 293);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 11;
            label7.Text = "Student Email";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(265, 245);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(254, 23);
            txtContact.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 243);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 9;
            label6.Text = "Student Contact";
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(265, 194);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(254, 23);
            txtSemester.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 192);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 7;
            label5.Text = "Student Semester";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(265, 150);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(254, 23);
            txtDepartment.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 148);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 5;
            label4.Text = "Department";
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(265, 102);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(254, 23);
            txtEnrollment.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 3;
            label3.Text = "Enrollment NO";
            // 
            // txtName
            // 
            txtName.Location = new Point(265, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(254, 23);
            txtName.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(117, 370);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 37);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 53);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 543);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnExit;
        private Button btnSave;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtContact;
        private Label label6;
        private TextBox txtSemester;
        private Label label5;
        private TextBox txtDepartment;
        private Label label4;
        private TextBox txtEnrollment;
        private Label label3;
        private TextBox txtName;
        private Button btnRefresh;
        private Label label2;
    }
}