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
    public partial class FormMain : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");

        public FormMain()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void รายงานการขายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct objFrmProduct = new FormProduct();
            objFrmProduct.Show();
            objFrmProduct.MdiParent = this;
        }

        private void รายงานคลงสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory objFrmCategory = new FormCategory();
            objFrmCategory.Show();
            
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            FormSale objFrmSale = new FormSale();
            objFrmSale.Show();
            objFrmSale.MdiParent = this;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_employee", con);
        
        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            FormEmployee objFrmEmployee = new FormEmployee();
            objFrmEmployee.Show();
            objFrmEmployee.MdiParent = this;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormSaleReport objFrmSaleReport = new FormSaleReport();
            objFrmSaleReport.Show();
            objFrmSaleReport.MdiParent = this;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PReport objFrmSaleReport = new PReport();
            objFrmSaleReport.Show();
            objFrmSaleReport.MdiParent = this;
        }
    }
}
