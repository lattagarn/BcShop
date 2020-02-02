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

namespace BcShop
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");

        public void load() { 

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_category", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Quark", 14F);
                col.DefaultCellStyle.Font = new Font("Quark", 14F);
            }
            dataGridView1.Columns[0].HeaderText = "รหัสหมวดหมู่";
            dataGridView1.Columns[1].HeaderText = "ชื่อหมวดหมู่";
            dataGridView1.Columns[2].HeaderText = "รายละเอียด";
         }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into tbl_category(cat_name,cat_description) value (@cat_name,@cat_description)";

                cmd.Parameters.AddWithValue("@cat_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@cat_description", textBox3.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "เพิ่มข้อมูล",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox2.Clear();
                textBox3.Clear();
                con.Close();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update tbl_category set cat_name='"+textBox2.Text+"' , cat_description='"+textBox3.Text+"' where cat_id= '"+textBox1.Text+"' ";

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "แก้ไขข้อมูล",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            load(); 
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
                    cmd.CommandText = "delete from tbl_category where cat_id='" + textBox1.Text + "' ";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อย", "ลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    load();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ID")
            {
                string search = "SELECT * FROM tbl_category where cat_id LIKE '%" + textBox6.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(search, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else if (comboBox2.Text == "Name")
            {
                string search = "SELECT * FROM tbl_category where cat_name LIKE '%" + textBox6.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(search,con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
    }
  
