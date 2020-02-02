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
    public partial class FormSaleReport : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");

        public FormSaleReport()
        {
            InitializeComponent();
        }

        public void load()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Quark", 14F);
                col.DefaultCellStyle.Font = new Font("Quark", 14F);
            }
            dataGridView1.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
            dataGridView1.Columns[1].HeaderText = "จำนวนสั่งซื้อ";
            dataGridView1.Columns[2].HeaderText = "ราคารวม";
            dataGridView1.Columns[3].HeaderText = "วันที่สั่งซื้อ";


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter ada = new MySqlDataAdapter("select * from tbl_sale where sale_date between '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "'", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView1.DataSource = dt;

            label1.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
            load();
        }

        private void FormSaleReport_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            dataGridView1.DataSource = null;
        }
    }
}
    
    
