namespace Library
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBName = new TextBox();
            txtAuthor = new TextBox();
            txtPublication = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            button4 = new Button();
            button2 = new Button();
            btnUpdate = new Button();
            txtPDate = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 155);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(591, 66);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 1;
            label2.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(446, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(448, 163);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(200, 23);
            txtBookName.TabIndex = 1;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(654, 163);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 165);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "Book Name";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(1118, 350);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightSkyBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 574);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1118, 329);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Location = new Point(166, 641);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Book Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Location = new Point(166, 717);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 7;
            label4.Text = "Book Author Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSkyBlue;
            label5.Location = new Point(166, 796);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 8;
            label5.Text = "Book Publication";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSkyBlue;
            label6.Location = new Point(617, 641);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 9;
            label6.Text = "Book Purchase Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSkyBlue;
            label7.Location = new Point(617, 717);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 10;
            label7.Text = "Book Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSkyBlue;
            label8.Location = new Point(617, 796);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 11;
            label8.Text = "Book Quantity";
            // 
            // txtBName
            // 
            txtBName.Location = new Point(305, 641);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(176, 23);
            txtBName.TabIndex = 12;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(305, 709);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(176, 23);
            txtAuthor.TabIndex = 13;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(305, 788);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(176, 23);
            txtPublication.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(762, 709);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(762, 788);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 17;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(654, 861);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 21;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(536, 861);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(420, 861);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(762, 633);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(200, 23);
            txtPDate.TabIndex = 24;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 900);
            Controls.Add(txtPDate);
            Controls.Add(btnUpdate);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtPublication);
            Controls.Add(txtAuthor);
            Controls.Add(txtBName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(panel1);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtBookName;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtBName;
        private TextBox txtAuthor;
        private TextBox txtPublication;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button button4;
        private Button button2;
        private Button btnUpdate;
        private TextBox txtPDate;
    }
}