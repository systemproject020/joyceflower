namespace joyceflower
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            panel2 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtStack = new TextBox();
            lblStock = new Label();
            lblCategory = new Label();
            txtFlowerDetails = new TextBox();
            lblFlowerDeatails = new Label();
            panel3 = new Panel();
            label3 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FlowerName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblInventory = new Label();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(txtStack);
            panel2.Controls.Add(lblStock);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(txtFlowerDetails);
            panel2.Controls.Add(lblFlowerDeatails);
            panel2.Location = new Point(12, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 472);
            panel2.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(161, 138, 96);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(159, 393);
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
            btnDelete.Location = new Point(35, 393);
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
            btnUpdate.Location = new Point(159, 336);
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
            btnAdd.Location = new Point(35, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 43);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(232, 240, 229);
            txtPrice.Location = new Point(12, 262);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(270, 31);
            txtPrice.TabIndex = 19;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Baskerville Old Face", 9F);
            lblPrice.ForeColor = Color.FromArgb(82, 107, 82);
            lblPrice.Location = new Point(12, 233);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 21);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // txtStack
            // 
            txtStack.BackColor = Color.FromArgb(232, 240, 229);
            txtStack.Location = new Point(12, 189);
            txtStack.Name = "txtStack";
            txtStack.Size = new Size(270, 31);
            txtStack.TabIndex = 17;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Baskerville Old Face", 9F);
            lblStock.ForeColor = Color.FromArgb(82, 107, 82);
            lblStock.Location = new Point(12, 172);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(49, 21);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Baskerville Old Face", 9F);
            lblCategory.ForeColor = Color.FromArgb(82, 107, 82);
            lblCategory.Location = new Point(12, 110);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 21);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // txtFlowerDetails
            // 
            txtFlowerDetails.BackColor = Color.FromArgb(232, 240, 229);
            txtFlowerDetails.Location = new Point(12, 64);
            txtFlowerDetails.Name = "txtFlowerDetails";
            txtFlowerDetails.Size = new Size(270, 31);
            txtFlowerDetails.TabIndex = 13;
            // 
            // lblFlowerDeatails
            // 
            lblFlowerDeatails.AutoSize = true;
            lblFlowerDeatails.BackColor = Color.Transparent;
            lblFlowerDeatails.Font = new Font("Baskerville Old Face", 9F);
            lblFlowerDeatails.ForeColor = Color.FromArgb(82, 107, 82);
            lblFlowerDeatails.Location = new Point(12, 40);
            lblFlowerDeatails.Name = "lblFlowerDeatails";
            lblFlowerDeatails.Size = new Size(112, 21);
            lblFlowerDeatails.TabIndex = 12;
            lblFlowerDeatails.Text = "Flower Details";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnPrevious);
            panel3.Controls.Add(btnNext);
            panel3.Controls.Add(dataGridView1);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(330, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 461);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.FromArgb(82, 107, 82);
            label3.Location = new Point(15, 423);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 41;
            label3.Text = "Showing 1 of 50";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(232, 240, 229);
            btnPrevious.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.FromArgb(82, 107, 82);
            btnPrevious.Location = new Point(706, 407);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(92, 41);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(232, 240, 229);
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(82, 107, 82);
            btnNext.Location = new Point(813, 407);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(92, 41);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, FlowerName, Category, Stock, Price, Status });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(63, 107, 85);
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(15, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(907, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // FlowerName
            // 
            FlowerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FlowerName.HeaderText = "Flower Name";
            FlowerName.MinimumWidth = 8;
            FlowerName.Name = "FlowerName";
            FlowerName.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.BackColor = Color.Transparent;
            lblInventory.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventory.ForeColor = Color.FromArgb(82, 107, 82);
            lblInventory.Location = new Point(12, 128);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(134, 33);
            lblInventory.TabIndex = 13;
            lblInventory.Text = "Inventory";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-2, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1283, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(232, 240, 229);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 33);
            comboBox1.TabIndex = 42;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 247, 240);
            ClientSize = new Size(1276, 654);
            Controls.Add(pictureBox3);
            Controls.Add(lblInventory);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label lblInventory;
        private Label lblFlowerDeatails;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtStack;
        private Label lblStock;
        private Label lblCategory;
        private TextBox txtFlowerDetails;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FlowerName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Status;
        private Button btnPrevious;
        private Button btnNext;
        private Label label3;
        private ComboBox comboBox1;
    }
}