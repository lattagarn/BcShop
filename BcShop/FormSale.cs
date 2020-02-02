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
    public partial class FormSale : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");
        int totalPrice = 0;
     
        public FormSale()
        {
            InitializeComponent();
   
            

        }

        public void load()
        {
            label10.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             foreach (DataGridViewColumn col in dataGridView1.Columns)
             {
                 col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                 col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                 col.HeaderCell.Style.Font = new Font("Quark", 14F);
                 col.DefaultCellStyle.Font = new Font("Quark", 14F);
             }
            con.Open();
            string query = "SELECT max(sale_id) from tbl_sale";
            MySqlCommand cmd1 = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    label5.Text = "1";
                }
                else
                {
                    int a;
                    a = int.Parse(dr[0].ToString());
                    a = a + 1;
                    label5.Text = a.ToString();
                }
                con.Close();
            }

        }
       
        

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                textBox2.Enabled = true;
                textBox2.Focus();
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_product where pro_id='"+textBox1.Text+"' ", con);
                    con.Open();
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        int price = int.Parse(textBox2.Text.ToString()) * int.Parse(r[3].ToString());
                        totalPrice = totalPrice + price;

                        dataGridView1.Rows.Add(dataGridView1.RowCount, r[0], r[1], textBox2.Text.Trim(), r[3], price);
                    }
                    label7.Text = " " + (dataGridView1.RowCount - 1) + " ";
                    label8.Text = " " + totalPrice + " ";

                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error From Database");
                }
                textBox1.Focus();
                textBox1.Clear();

                textBox2.Enabled = false;
                textBox2.Clear();
            }
        }



        private void FormSale_Load(object sender, EventArgs e)
        {
            
            load();
            }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd1.Connection = con;
                    cmd1.CommandText = "insert into tbl_saledetail(saledetail_id,sale_id,pro_id,saledetail_persale,saledetail_qty,saledetail_total) values (@saledetail_id,@sale_id,@pro_id,@saledetail_persale,@saledetail_qty,@saledetail_total)";

                    cmd1.Parameters.AddWithValue("@saledetail_id", dataGridView1.Rows[i].Cells[0].Value);
                    cmd1.Parameters.AddWithValue("@sale_id", label5.Text);
                    cmd1.Parameters.AddWithValue("@pro_id", dataGridView1.Rows[i].Cells[1].Value);
                    cmd1.Parameters.AddWithValue("@saledetail_persale", dataGridView1.Rows[i].Cells[4].Value);
                    cmd1.Parameters.AddWithValue("@saledetail_qty", dataGridView1.Rows[i].Cells[3].Value);
                    cmd1.Parameters.AddWithValue("@saledetail_total", dataGridView1.Rows[i].Cells[5].Value);

                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "insert into tbl_sale(sale_id,sale_qty,sale_total,sale_date) value (@sale_id,@sale_qty,@sale_total,@sale_date)";

                    cmd2.Parameters.AddWithValue("@sale_id", label5.Text);
                    cmd2.Parameters.AddWithValue("@sale_qty", label7.Text);
                    cmd2.Parameters.AddWithValue("@sale_total", label8.Text);
                    cmd2.Parameters.AddWithValue("@sale_date", label10.Text);

                    

                    con.Open();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "เพิ่มข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                }
            }
            catch 
            {
               
            }
            finally
            {
                con.Close();
            }
                        
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = double.Parse(label8.Text);
                double money = double.Parse(textBox3.Text);
                double change = money - total;
                label13.Text = change.ToString();
            }catch{
                label13.Text = "0";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label7.Text = "0";
            label8.Text = "0";
            textBox3.Clear();
            textBox1.Focus();
            dataGridView1.Rows.Clear();
        }
    }
}
