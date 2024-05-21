namespace Library
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            panel1 = new Panel();
            btnSearchStudent = new Button();
            btnExit = new Button();
            btnRefresh = new Button();
            txtEnterEnroll = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnCancel = new Button();
            label4 = new Label();
            btnReturn = new Button();
            label3 = new Label();
            txtBookIssueDate = new TextBox();
            label1 = new Label();
            txtBookName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 466);
            panel1.TabIndex = 2;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStudent.Location = new Point(69, 216);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(136, 45);
            btnSearchStudent.TabIndex = 7;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
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
            // txtEnterEnroll
            // 
            txtEnterEnroll.Location = new Point(36, 167);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(223, 23);
            txtEnterEnroll.TabIndex = 4;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(864, 463);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtBookName);
            panel2.Location = new Point(312, 484);
            panel2.Name = "panel2";
            panel2.Size = new Size(864, 202);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(381, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(603, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 38);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(232, 130);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 5;
            label4.Text = "Book Return Date";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(603, 74);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(95, 38);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 89);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 3;
            label3.Text = "Book Issue Date";
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(383, 89);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(182, 23);
            txtBookIssueDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 1;
            label1.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(383, 48);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(182, 23);
            txtBookName.TabIndex = 0;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1188, 686);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ReturnBooks";
            Text = "ReturnBooks";
            Load += ReturnBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearchStudent;
        private Button btnExit;
        private Button btnRefresh;
        private TextBox txtEnterEnroll;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private TextBox txtBookIssueDate;
        private Label label1;
        private TextBox txtBookName;
        private Button btnCancel;
        private Label label4;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
    }
}