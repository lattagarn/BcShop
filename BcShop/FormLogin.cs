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
    public partial class FormLogin : Form
    {
     
        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่ ?", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_employee WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text +"'" ;

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=12345678;database=csharp");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FormMain objFrmMain = new FormMain();
                objFrmMain.Show();
                this.Hide();
            }
        }
    }
    }
