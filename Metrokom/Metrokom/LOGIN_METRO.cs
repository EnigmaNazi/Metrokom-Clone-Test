using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Metrokom
{
    public partial class LOGIN_METRO : Form
    {
        //koneksi database
        SqlConnection con = new SqlConnection("Server=REYHANS-PC;Database=METROKOM;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;

        public LOGIN_METRO()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            string strSQL = " select * from tbl_login where username ='" + txt_username.Text
                + "' and password='" + txt_password.Text + "'";

            com.CommandText = strSQL;
            SqlDataReader datareader = com.ExecuteReader();
            if (datareader.Read())
            {
                MessageBox.Show("Login berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MENU_METRO menu = new MENU_METRO();
                menu.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Text = "";
                txt_password.Text = "";
                txt_username.Focus();
            }
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}
