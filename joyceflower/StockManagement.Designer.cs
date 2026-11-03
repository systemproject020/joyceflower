namespace joyceflower
{
    partial class Stock_Management
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Management));
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txtRemarks = new TextBox();
            lblRemarks = new Label();
            rdbStockOut = new RadioButton();
            rdbStockIn = new RadioButton();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblDate = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lbltype = new Label();
            lblFlower = new Label();
            lblNewTransaction = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Flower = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblStockManagemnt = new Label();
            pictureBox3 = new PictureBox();
            btnPrevious = new Button();
            btnNext = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtRemarks);
            panel2.Controls.Add(lblRemarks);
            panel2.Controls.Add(rdbStockOut);
            panel2.Controls.Add(rdbStockIn);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(lblQuantity);
            panel2.Controls.Add(lbltype);
            panel2.Controls.Add(lblFlower);
            panel2.Controls.Add(lblNewTransaction);
            panel2.Location = new Point(18, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 472);
            panel2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(16, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 26);
            dateTimePicker1.TabIndex = 28;
            // 
            // txtRemarks
            // 
            txtRemarks.BackColor = Color.FromArgb(232, 240, 229);
            txtRemarks.Location = new Point(16, 305);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(270, 31);
            txtRemarks.TabIndex = 27;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.BackColor = Color.Transparent;
            lblRemarks.Font = new Font("Baskerville Old Face", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.ForeColor = Color.FromArgb(82, 107, 82);
            lblRemarks.Location = new Point(16, 284);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(65, 18);
            lblRemarks.TabIndex = 26;
            lblRemarks.Text = "Remarks";
            // 
            // rdbStockOut
            // 
            rdbStockOut.AutoSize = true;
            rdbStockOut.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbStockOut.Location = new Point(127, 135);
            rdbStockOut.Name = "rdbStockOut";
            rdbStockOut.Size = new Size(82, 20);
            rdbStockOut.TabIndex = 25;
            rdbStockOut.TabStop = true;
            rdbStockOut.Text = "Stock out";
            rdbStockOut.UseVisualStyleBackColor = true;
            // 
            // rdbStockIn
            // 
            rdbStockIn.AutoSize = true;
            rdbStockIn.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbStockIn.Location = new Point(16, 135);
            rdbStockIn.Name = "rdbStockIn";
            rdbStockIn.Size = new Size(74, 20);
            rdbStockIn.TabIndex = 24;
            rdbStockIn.TabStop = true;
            rdbStockIn.Text = "Stock In";
            rdbStockIn.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(161, 138, 96);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(158, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 43);
            btnClear.TabIndex = 23;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(182, 111, 112);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(48, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 43);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(100, 134, 155);
            btnUpdate.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(158, 360);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 43);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(79, 128, 100);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(48, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 43);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Baskerville Old Face", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(82, 107, 82);
            lblDate.Location = new Point(16, 227);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 18);
            lblDate.TabIndex = 18;
            lblDate.Text = "Date";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(232, 240, 229);
            txtQuantity.Location = new Point(16, 184);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(270, 31);
            txtQuantity.TabIndex = 17;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Baskerville Old Face", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.FromArgb(82, 107, 82);
            lblQuantity.Location = new Point(16, 163);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(63, 18);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "Quantity";
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.BackColor = Color.Transparent;
            lbltype.Font = new Font("Baskerville Old Face", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltype.ForeColor = Color.FromArgb(82, 107, 82);
            lbltype.Location = new Point(16, 114);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(41, 18);
            lbltype.TabIndex = 14;
            lbltype.Text = "Type";
            // 
            // lblFlower
            // 
            lblFlower.AutoSize = true;
            lblFlower.BackColor = Color.Transparent;
            lblFlower.Font = new Font("Baskerville Old Face", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlower.ForeColor = Color.FromArgb(82, 107, 82);
            lblFlower.Location = new Point(16, 51);
            lblFlower.Name = "lblFlower";
            lblFlower.Size = new Size(52, 18);
            lblFlower.TabIndex = 12;
            lblFlower.Text = "Flower";
            // 
            // lblNewTransaction
            // 
            lblNewTransaction.AutoSize = true;
            lblNewTransaction.BackColor = Color.Transparent;
            lblNewTransaction.Font = new Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewTransaction.ForeColor = Color.FromArgb(82, 107, 82);
            lblNewTransaction.Location = new Point(16, 19);
            lblNewTransaction.Name = "lblNewTransaction";
            lblNewTransaction.Size = new Size(146, 21);
            lblNewTransaction.TabIndex = 11;
            lblNewTransaction.Text = "New Transaction";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Flower, Type, Qty, Date, Remarks });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(63, 107, 85);
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(14, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(837, 383);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Flower
            // 
            Flower.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Flower.HeaderText = "Flower ";
            Flower.MinimumWidth = 8;
            Flower.Name = "Flower";
            Flower.ReadOnly = true;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Qty.HeaderText = "Quantity";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Remarks
            // 
            Remarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Remarks.HeaderText = "Remarks";
            Remarks.MinimumWidth = 8;
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnNext);
            panel3.Controls.Add(btnPrevious);
            panel3.Controls.Add(dataGridView1);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(356, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(869, 461);
            panel3.TabIndex = 13;
            // 
            // lblStockManagemnt
            // 
            lblStockManagemnt.AutoSize = true;
            lblStockManagemnt.BackColor = Color.Transparent;
            lblStockManagemnt.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockManagemnt.ForeColor = Color.FromArgb(82, 107, 82);
            lblStockManagemnt.Location = new Point(18, 130);
            lblStockManagemnt.Name = "lblStockManagemnt";
            lblStockManagemnt.Size = new Size(249, 33);
            lblStockManagemnt.TabIndex = 14;
            lblStockManagemnt.Text = "Stock Management";
            lblStockManagemnt.Click += lblStockManagemnt_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1263, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(232, 240, 229);
            btnPrevious.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.FromArgb(82, 107, 82);
            btnPrevious.Location = new Point(653, 411);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(92, 41);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(232, 240, 229);
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(82, 107, 82);
            btnNext.Location = new Point(759, 409);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(92, 41);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.FromArgb(82, 107, 82);
            label3.Location = new Point(14, 427);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 42;
            label3.Text = "Showing 1 of 50 ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(232, 240, 229);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 33);
            comboBox1.TabIndex = 29;
            // 
            // Stock_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 247, 240);
            ClientSize = new Size(1230, 645);
            Controls.Add(pictureBox3);
            Controls.Add(lblStockManagemnt);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Stock_Management_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblDate;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lbltype;
        private Label lblFlower;
        private Label lblNewTransaction;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label lblStockManagemnt;
        private RadioButton rdbStockOut;
        private RadioButton rdbStockIn;
        private TextBox txtRemarks;
        private Label lblRemarks;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Flower;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Remarks;
        private Button btnNext;
        private Button btnPrevious;
        private Label label3;
        private ComboBox comboBox1;
    }
}
