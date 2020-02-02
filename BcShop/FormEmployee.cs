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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");

        public void load()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_employee", con);
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
            dataGridView1.Columns[0].HeaderText = "รหัสพนักงาน";
            dataGridView1.Columns[1].HeaderText = "ชื่อ";
            dataGridView1.Columns[2].HeaderText = "นามสกุล";
            dataGridView1.Columns[3].HeaderText = "ที่อยู่";
            dataGridView1.Columns[4].HeaderText = "เบอร์โทร";
            dataGridView1.Columns[5].HeaderText = "Username";
            dataGridView1.Columns[6].HeaderText = "Password";
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into tbl_employee (emp_fname,emp_sname,emp_address,emp_tel,username,password) value (@emp_fname,@emp_sname,@emp_address,@emp_tel,@username,@password)";

                cmd.Parameters.AddWithValue("@emp_fname", textBox2.Text);
                cmd.Parameters.AddWithValue("@emp_sname", textBox3.Text);
                cmd.Parameters.AddWithValue("@emp_address", textBox4.Text);
                cmd.Parameters.AddWithValue("emp_tel", textBox5.Text);
                cmd.Parameters.AddWithValue("@username", textBox7.Text);
                cmd.Parameters.AddWithValue("@password", textBox8.Text);

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

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update tbl_employee set  emp_fname='" + textBox2.Text + "' , " +
                    "emp_sname='" + textBox3.Text + "', emp_address='" + textBox4.Text + "'," +
                    " emp_tel='" + textBox5.Text + "', username='" + textBox7.Text + "'," +
                    " password='" + textBox8.Text + "' where emp_id= '" + textBox1.Text + "' ";

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "แก้ไขข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                load();
                clear();
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
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
                    cmd.CommandText = "delete from tbl_employee where emp_id='" + textBox1.Text + "' ";

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

        private void Button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ID")
            {
                string search = "SELECT * FROM tbl_employee where emp_id LIKE '%" + textBox6.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(search, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else if (comboBox2.Text == "Name")
            {
                string search = "SELECT * FROM tbl_employee where emp_fname LIKE '%" + textBox6.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(search, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }
    }
}
