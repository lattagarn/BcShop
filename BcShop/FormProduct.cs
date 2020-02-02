using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;


namespace BcShop
{
    public partial class FormProduct : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");
        public FormProduct()
        {
            InitializeComponent();
            
        }
        public void load()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_product", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
       
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Quark", 14F);
                col.DefaultCellStyle.Font = new Font("Quark", 14F);
            }
            dataGridView1.Columns[0].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns[1].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns[2].HeaderText = "หมวดหมู่";
            dataGridView1.Columns[3].HeaderText = "ราคา";
            dataGridView1.Columns[4].HeaderText = "จำนวน";
            dataGridView1.Columns[5].HeaderText = "ราคารวม";
            dataGridView1.Columns[6].HeaderText = "ภาพ";

        }

        public void cat()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_category", con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "cat_name";
            comboBox1.ValueMember = "cat_id";
            

            con.Close();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            //comboBox1.Items.Clear();
            pictureBox1.Image = null;
        }
       


            private void FormProduct_Load(object sender, EventArgs e)
        {
            
            load();
            cat();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into tbl_product(pro_name,cat_id,pro_price,pro_qty,pro_total,img) VALUES (@pro_name,@cat_id,@pro_price,@pro_qty,@pro_total,@img)";

                cmd.Parameters.AddWithValue("@pro_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@cat_id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@pro_price", textBox3.Text);
                cmd.Parameters.AddWithValue("@pro_qty", textBox4.Text);
                cmd.Parameters.AddWithValue("@pro_total", textBox5.Text);
                cmd.Parameters.AddWithValue("@img", img);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "เพิ่มข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

                con.Close();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void DataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update tbl_product set pro_name=@pro_name,cat_id=@cat_id,pro_price=@pro_price,pro_qty=@pro_qty,pro_total=@pro_total,img=@img where pro_id = '"+textBox1.Text+"' ";

                cmd.Parameters.AddWithValue("@pro_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@cat_id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@pro_price", textBox3.Text);
                cmd.Parameters.AddWithValue("@pro_qty", textBox4.Text);
                cmd.Parameters.AddWithValue("@pro_total", textBox5.Text);
                cmd.Parameters.AddWithValue("@img", img);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "แก้ไขข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
               
                
                con.Close();
                load();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from tbl_product where pro_id='" + textBox1.Text + "' ";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อย", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    clear();
                    load();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            try { 
            double price = double.Parse(textBox3.Text);
            double qty = double.Parse(textBox4.Text);
            double total = price * qty;
            textBox5.Text = total.ToString();
        }   catch   {
                
            }
}

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ID")
            {
                string search = "SELECT * FROM tbl_product where pro_id LIKE '%" + textBox6.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(search, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else if (comboBox2.Text == "Name")
            {
                string search = "SELECT * FROM tbl_product where pro_name LIKE '%" + textBox6.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(search, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
