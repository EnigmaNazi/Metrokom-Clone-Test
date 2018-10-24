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
    public partial class BARANG_METRO : Form
    {
        SqlConnection con = new SqlConnection("Server=REYHANS-PC;Database=METROKOM;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_barang", con);
            adapt.Fill(dt);
            dg_barang.DataSource = dt;
            con.Close();

        }
        private void otomatis()
        {
            long hitung;
            string urut;

            con.Open();
            cmd = new SqlCommand("select kode_barang from tbl_barang where kode_barang in(select max(kode_barang) from tbl_barang) order by kode_barang desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_barang"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "BRG" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "BRG0001";
            }
            rd.Close();
            txt_kode_barang.Text = urut;
            con.Close();
        }
        private void cleartext()
        {
            txt_kode_barang.Text = "";
            txt_nama_barang.Text = "";
            cmb_satuan_barang.Text = "pilih";
            txt_harga_barang.Text = "";
            txt_stock_barang.Text = "0";
            txt_kode_barang.Enabled = false;

        }
        public BARANG_METRO()
        {
            InitializeComponent();
            cleartext();
            DisplayData();
        }

        private void btn_new_brg_Click(object sender, EventArgs e)
        {
            otomatis();
        }

        private void btn_save_brg_Click(object sender, EventArgs e)
        {
            if (txt_kode_barang.Text != "" && txt_nama_barang.Text != "" && cmb_satuan_barang.Text != "" && txt_harga_barang.Text != "" && txt_stock_barang.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_barang(kode_barang,nama_barang,satuan,harga,stock) values(@kode_barang,@nama_barang,@satuan,@harga,@stock)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text);
                cmd.Parameters.AddWithValue("@nama_barang", txt_nama_barang.Text);
                cmd.Parameters.AddWithValue("@satuan", cmb_satuan_barang.Text);
                cmd.Parameters.AddWithValue("@harga", txt_harga_barang.Text);
                cmd.Parameters.AddWithValue("@stock", txt_stock_barang.Text);
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

        private void btn_edit_brg_Click(object sender, EventArgs e)
        {
            if (txt_kode_barang.Text != "" && txt_nama_barang.Text != "" && cmb_satuan_barang.Text != "" && txt_harga_barang.Text != "" && txt_stock_barang.Text != "")
            {
                cmd = new SqlCommand("update tbl_barang set nama_barang=@nama_barang,satuan=@satuan,harga=@harga,stock=@stock where kode_barang=@kode_barang", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text);
                cmd.Parameters.AddWithValue("@nama_barang", txt_nama_barang.Text);
                cmd.Parameters.AddWithValue("@satuan", cmb_satuan_barang.Text);
                cmd.Parameters.AddWithValue("@harga", txt_harga_barang.Text);
                cmd.Parameters.AddWithValue("@stock", txt_stock_barang.Text);
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

        private void btn_delete_brg_Click(object sender, EventArgs e)
        {
            if (txt_kode_barang.Text != "")
            {
                cmd = new SqlCommand("delete tbl_barang where kode_barang=@kode_barang", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text);
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

        private void btn_close_brg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dg_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dg_barang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dg_barang.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_satuan_barang.Text = dg_barang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_harga_barang.Text = dg_barang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stock_barang.Text = dg_barang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_kode_barang.Enabled = false;
        }
    }
}
