namespace Library
{
    partial class ViewStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformation));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollement = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSemester = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtSSName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(20, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 147);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 80);
            label2.Name = "label2";
            label2.Size = new Size(143, 47);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 47);
            label1.TabIndex = 1;
            label1.Text = "Add";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 177);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 1;
            label3.Text = "Enrollment NO:";
            // 
            // txtSearchEnrollement
            // 
            txtSearchEnrollement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchEnrollement.Location = new Point(375, 177);
            txtSearchEnrollement.Name = "txtSearchEnrollement";
            txtSearchEnrollement.Size = new Size(198, 29);
            txtSearchEnrollement.TabIndex = 2;
            txtSearchEnrollement.TextChanged += txtSearchEnrollement_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(601, 174);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 32);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1201, 241);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtSSName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(25, 492);
            panel2.Name = "panel2";
            panel2.Size = new Size(1196, 353);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(746, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button4_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(634, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 35);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(523, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 35);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(731, 47);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(198, 23);
            txtSemester.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(731, 130);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(198, 23);
            txtContact.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(731, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(246, 207);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(198, 23);
            txtDepartment.TabIndex = 14;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(246, 125);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(198, 23);
            txtEnrollment.TabIndex = 13;
            // 
            // txtSSName
            // 
            txtSSName.Location = new Point(246, 52);
            txtSSName.Name = "txtSSName";
            txtSSName.Size = new Size(198, 23);
            txtSSName.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(541, 207);
            label9.Name = "label9";
            label9.Size = new Size(127, 25);
            label9.TabIndex = 11;
            label9.Text = "Student Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(541, 120);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 10;
            label8.Text = "Student Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(541, 47);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 9;
            label7.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 207);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 8;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 125);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 7;
            label5.Text = "Enrollment NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 47);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 6;
            label4.Text = "Student Name\r\n";
            // 
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1233, 857);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollement);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudentInformation";
            Text = "ViewStudentInformation";
            Load += ViewStudentInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtSearchEnrollement;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSemester;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtSSName;
        protected Label label9;
        protected Label label8;
        protected Label label7;
        protected Label label6;
        protected Label label5;
        protected Label label4;
    }
}