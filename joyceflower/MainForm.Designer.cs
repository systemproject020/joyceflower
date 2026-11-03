namespace joyceflower
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            textBox1 = new TextBox();
            lbblFlowerStockOverview = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            pnlContent = new Panel();
            label3 = new Label();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblWelcomeAdmin = new Label();
            lblDashboard = new Label();
            panel3 = new Panel();
            lblStockCount = new Label();
            lblTotalStock = new Label();
            panel4 = new Panel();
            lblTotalInventoryValue = new Label();
            lblTotalValue = new Label();
            panel6 = new Panel();
            lblLowStockCount = new Label();
            lblLowStock = new Label();
            panel5 = new Panel();
            lblFlowerCount = new Label();
            lblTotalProducts = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            panel1 = new Panel();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            btnLogout = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlContent.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbblFlowerStockOverview);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(277, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 308);
            panel2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(232, 240, 229);
            textBox1.Location = new Point(896, 10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Flower..";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 41;
            // 
            // lbblFlowerStockOverview
            // 
            lbblFlowerStockOverview.AutoSize = true;
            lbblFlowerStockOverview.BackColor = Color.Transparent;
            lbblFlowerStockOverview.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbblFlowerStockOverview.ForeColor = Color.FromArgb(82, 107, 82);
            lbblFlowerStockOverview.Location = new Point(13, 16);
            lbblFlowerStockOverview.Name = "lbblFlowerStockOverview";
            lbblFlowerStockOverview.Size = new Size(216, 25);
            lbblFlowerStockOverview.TabIndex = 10;
            lbblFlowerStockOverview.Text = "Flower Stock Overview";
            lbblFlowerStockOverview.Click += lbblFlowerStockOverview_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(13, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 40;
            dataGridView1.Size = new Size(1136, 231);
            dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Flower Name";
            dataGridViewTextBoxColumn2.HeaderText = "Flower Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Stock";
            dataGridViewTextBoxColumn3.HeaderText = "Stock";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 15;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(label3);
            pnlContent.Controls.Add(button10);
            pnlContent.Controls.Add(button9);
            pnlContent.Controls.Add(button8);
            pnlContent.Controls.Add(button6);
            pnlContent.Controls.Add(button2);
            pnlContent.Controls.Add(button1);
            pnlContent.Controls.Add(lblWelcomeAdmin);
            pnlContent.Controls.Add(lblDashboard);
            pnlContent.Controls.Add(panel3);
            pnlContent.Controls.Add(panel4);
            pnlContent.Controls.Add(panel6);
            pnlContent.Controls.Add(panel5);
            pnlContent.Controls.Add(panel2);
            pnlContent.Controls.Add(label2);
            pnlContent.Controls.Add(pictureBox3);
            pnlContent.Controls.Add(panel8);
            pnlContent.Controls.Add(panel1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1476, 654);
            pnlContent.TabIndex = 6;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(82, 107, 82);
            label3.Location = new Point(280, 603);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 40;
            label3.Text = "Showing 1 of 50 Items";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(217, 226, 211);
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Cursor = Cursors.Hand;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(1259, 605);
            button10.Name = "button10";
            button10.Size = new Size(40, 37);
            button10.TabIndex = 39;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(217, 226, 211);
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(1305, 605);
            button9.Name = "button9";
            button9.Size = new Size(40, 37);
            button9.TabIndex = 38;
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(217, 226, 211);
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(1351, 605);
            button8.Name = "button8";
            button8.Size = new Size(40, 37);
            button8.TabIndex = 37;
            button8.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(217, 226, 211);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(1397, 605);
            button6.Name = "button6";
            button6.Size = new Size(40, 37);
            button6.TabIndex = 36;
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 226, 211);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1167, 603);
            button2.Name = "button2";
            button2.Size = new Size(40, 37);
            button2.TabIndex = 35;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 226, 211);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1213, 605);
            button1.Name = "button1";
            button1.Size = new Size(40, 37);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.BackColor = Color.Transparent;
            lblWelcomeAdmin.Font = new Font("Bell MT", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeAdmin.ForeColor = Color.FromArgb(82, 107, 82);
            lblWelcomeAdmin.Location = new Point(280, 142);
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(93, 15);
            lblWelcomeAdmin.TabIndex = 20;
            lblWelcomeAdmin.Text = "Welcome, Admin!";
            lblWelcomeAdmin.Click += label1_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.BackColor = Color.Transparent;
            lblDashboard.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.FromArgb(82, 107, 82);
            lblDashboard.Location = new Point(272, 114);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(146, 33);
            lblDashboard.TabIndex = 11;
            lblDashboard.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 240, 229);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(lblStockCount);
            panel3.Controls.Add(lblTotalStock);
            panel3.Location = new Point(571, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 108);
            panel3.TabIndex = 19;
            // 
            // lblStockCount
            // 
            lblStockCount.AutoSize = true;
            lblStockCount.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockCount.ForeColor = Color.FromArgb(82, 107, 82);
            lblStockCount.Location = new Point(90, 46);
            lblStockCount.Name = "lblStockCount";
            lblStockCount.Size = new Size(92, 46);
            lblStockCount.TabIndex = 24;
            lblStockCount.Text = "280";
            lblStockCount.Click += lblStockCount_Click;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(3, 15);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(83, 21);
            lblTotalStock.TabIndex = 24;
            lblTotalStock.Text = "Total Stock";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(232, 240, 229);
            panel4.Controls.Add(lblTotalInventoryValue);
            panel4.Controls.Add(lblTotalValue);
            panel4.Location = new Point(1171, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 108);
            panel4.TabIndex = 19;
            // 
            // lblTotalInventoryValue
            // 
            lblTotalInventoryValue.AutoSize = true;
            lblTotalInventoryValue.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalInventoryValue.ForeColor = Color.FromArgb(82, 107, 82);
            lblTotalInventoryValue.Location = new Point(61, 46);
            lblTotalInventoryValue.Name = "lblTotalInventoryValue";
            lblTotalInventoryValue.Size = new Size(180, 46);
            lblTotalInventoryValue.TabIndex = 25;
            lblTotalInventoryValue.Text = "₱250.00";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(3, 15);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(154, 21);
            lblTotalValue.TabIndex = 25;
            lblTotalValue.Text = "Total Inventory Value";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(232, 240, 229);
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(lblLowStockCount);
            panel6.Controls.Add(lblLowStock);
            panel6.Location = new Point(868, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 108);
            panel6.TabIndex = 19;
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockCount.ForeColor = Color.FromArgb(82, 107, 82);
            lblLowStockCount.Location = new Point(113, 46);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(44, 46);
            lblLowStockCount.TabIndex = 26;
            lblLowStockCount.Text = "5";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(17, 12);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(122, 21);
            lblLowStock.TabIndex = 26;
            lblLowStock.Text = "Low Stock Items";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(232, 240, 229);
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(lblFlowerCount);
            panel5.Controls.Add(lblTotalProducts);
            panel5.Location = new Point(277, 160);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 108);
            panel5.TabIndex = 18;
            // 
            // lblFlowerCount
            // 
            lblFlowerCount.AutoSize = true;
            lblFlowerCount.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlowerCount.ForeColor = Color.FromArgb(82, 107, 82);
            lblFlowerCount.Location = new Point(92, 46);
            lblFlowerCount.Name = "lblFlowerCount";
            lblFlowerCount.Size = new Size(68, 46);
            lblFlowerCount.TabIndex = 22;
            lblFlowerCount.Text = "50";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(3, 15);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(93, 21);
            lblTotalProducts.TabIndex = 21;
            lblTotalProducts.Text = "Total Flower";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(251, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1225, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.Location = new Point(-10, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(262, 41);
            panel8.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 232, 213);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 624);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(217, 226, 211);
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(21, 268);
            button7.Name = "button7";
            button7.Size = new Size(213, 45);
            button7.TabIndex = 33;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 226, 211);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(21, 200);
            button4.Name = "button4";
            button4.Size = new Size(213, 45);
            button4.TabIndex = 31;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 226, 211);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(21, 125);
            button3.Name = "button3";
            button3.Size = new Size(213, 45);
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(168, 191, 160);
            button5.ForeColor = Color.White;
            button5.Location = new Point(39, 655);
            button5.Name = "button5";
            button5.Size = new Size(195, 43);
            button5.TabIndex = 8;
            button5.Text = "Log in";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(217, 226, 211);
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(82, 107, 82);
            btnLogout.Location = new Point(21, 569);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(213, 48);
            btnLogout.TabIndex = 34;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 247, 240);
            ClientSize = new Size(1476, 654);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button btnCategories;
        private Button btnInventory;
        private Button btnRepports;
        private Button btnSaveandTransactions;
        private Button btnSupplies;
        private Button btnStockManagement;
        private Button btnSettings;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private Panel pnlRight;
        private Label lblDate;
        private Label lbblFlowerStockOverview;
        private Panel panel2;
        private Label label2;
        private Panel pnlContent;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Label lblDashboard;
        private Label lblWelcomeAdmin;
        private Label lblTotalProducts;
        private Label lblFlowerCount;
        private Label lblStockCount;
        private Label lblTotalStock;
        private Label lblTotalInventoryValue;
        private Label lblTotalValue;
        private Label lblLowStockCount;
        private Label lblLowStock;
        private Button button5;
        private PictureBox pictureBox3;
        private Button button3;
        private Button button4;
        private Button button7;
        private Panel panel8;
        private Button button2;
        private Button button1;
        private Label label3;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button6;
        private TextBox textBox1;
        private Button btnLogout;
    }
}