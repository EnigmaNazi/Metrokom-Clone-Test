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
    public partial class PELANGGAN_METRO : Form
    {
        //koneksi database
        SqlConnection con = new SqlConnection("Server=REYHANS-PC;Database=METROKOM;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_pelanggan", con);
            adapt.Fill(dt);
            dg_pelanggan.DataSource = dt;
            con.Close();

        }
        private void otomatis()
        {
            long hitung;
            string urut;

            con.Open();
            cmd = new SqlCommand("select kode_pelanggan from tbl_pelanggan where kode_pelanggan in(select max(kode_pelanggan) from tbl_pelanggan) order by kode_pelanggan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_pelanggan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "PLG" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "PLG0001";
            }
            rd.Close();
            txt_kode_plg.Text = urut;
            con.Close();
        }

        //untuk clear text
        private void cleartext()
        {
            txt_kode_plg.Enabled = false;
            txt_nama_plg.Text = "";
            txt_notelp_plg.Text = "";
            txt_alamat_plg.Text = "";


        }

        public PELANGGAN_METRO()
        {
            InitializeComponent();
            cleartext();
            DisplayData();
        }

        private void btn_new_plg_Click(object sender, EventArgs e)
        {
            otomatis();
        }

        private void btn_save_plg_Click(object sender, EventArgs e)
        {
            if (txt_kode_plg.Text != "" && txt_nama_plg.Text != "" && txt_notelp_plg.Text != "" && txt_alamat_plg.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_pelanggan(kode_pelanggan,nama_pelanggan,no_telp,alamat) values(@kode_pelanggan,@nama_pelanggan,@no_telp,@alamat)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kode_pelanggan", txt_kode_plg.Text);
                cmd.Parameters.AddWithValue("@nama_pelanggan", txt_nama_plg.Text);
                cmd.Parameters.AddWithValue("@no_telp", txt_notelp_plg.Text);
                cmd.Parameters.AddWithValue("@alamat", txt_alamat_plg.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan");
                DisplayData();
                cleartext();
            }
            else
            {
                MessageBox.Show("gagal simpan");
            }
        }

        private void btn_edit_plg_Click(object sender, EventArgs e)
        {
            if (txt_kode_plg.Text != "" && txt_nama_plg.Text != "" && txt_notelp_plg.Text != "" && txt_alamat_plg.Text != "")
            {
                cmd = new SqlCommand("update tbl_pelanggan set nama_pelanggan=@nama_pelanggan,no_telp=@no_telp,alamat=@alamat where kode_pelanggan=@kode_pelanggan", con);

                con.Open();
                cmd.Parameters.AddWithValue("@kode_pelanggan", txt_kode_plg.Text);
                cmd.Parameters.AddWithValue("@nama_pelanggan", txt_nama_plg.Text);
                cmd.Parameters.AddWithValue("@no_telp", txt_notelp_plg.Text);
                cmd.Parameters.AddWithValue("@alamat", txt_alamat_plg.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Berhasil");
                con.Close();
                DisplayData();
                cleartext();
            }
            else
            {
                MessageBox.Show("gagal edit");
            }
        }

        private void btn_delete_plg_Click(object sender, EventArgs e)
        {
            if (txt_kode_plg.Text != "" && txt_nama_plg.Text != "" && txt_notelp_plg.Text != "" && txt_alamat_plg.Text != "")
            {
                cmd = new SqlCommand("delete tbl_pelanggan where kode_pelanggan=@kode_pelanggan", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kode_pelanggan", txt_kode_plg.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("berhasil hapus");
                DisplayData();
                cleartext();
            }
            else
            {
                MessageBox.Show("gagal hapus");
            }
        }

        private void btn_close_plg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dg_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_notelp_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_plg.Enabled = false;
        }
    }
}
