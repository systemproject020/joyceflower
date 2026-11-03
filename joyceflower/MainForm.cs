using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
namespace joyceflower
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Bitmap RemoveCheckerboard(Image source)
        {
            var src = new Bitmap(source);
            var result = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);

            for (int x = 0; x < src.Width; x++)
            {
                for (int y = 0; y < src.Height; y++)
                {
                    Color c = src.GetPixel(x, y);
                    int max = Math.Max(c.R, Math.Max(c.G, c.B));
                    int min = Math.Min(c.R, Math.Min(c.G, c.B));

                    bool isBackground = min > 200 && (max - min) < 20;
                    result.SetPixel(x, y, isBackground ? Color.Transparent : c);
                }
            }
            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadSummary()
        {
        }

        private string Scalar(MySqlConnection conn, string sql)
        {
            using (var cmd = new MySqlCommand(sql, conn))
                return cmd.ExecuteScalar().ToString();
        }
        private void LoadFlowers()
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            InventoryForm form = new InventoryForm();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stock_Management form = new Stock_Management();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblStockCount_Click(object sender, EventArgs e)
        {

        }

        private void lbblFlowerStockOverview_Click(object sender, EventArgs e)
        {

        }
    }
}
