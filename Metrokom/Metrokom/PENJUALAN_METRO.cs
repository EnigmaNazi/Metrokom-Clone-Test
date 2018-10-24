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
    public partial class PENJUALAN_METRO : Form
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
            adapt = new SqlDataAdapter("select * from tbl_penjualan", con);
            adapt.Fill(dt);
            dg_penjualan.DataSource = dt;
            con.Close();

        }
        private void DisplayDataBarang()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_barang", con);
            adapt.Fill(dt);
            dg_barang.DataSource = dt;
            con.Close();

        }

        private void DisplayDataPelanggan()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_pelanggan", con);
            adapt.Fill(dt);
            dg_pelanggan.DataSource = dt;
            con.Close();

        }

        //untuk clear text
        private void cleartext()
        {
            txt_no_penjualan.Text = "";
            txt_nama_sales.Text = "";
            txt_kode_pelanggan.Text = "";
            txt_nama_pelanggan.Text = "";
            txt_notelp_pelanggan.Text = "";
            txt_alamat_pelanggan.Text = "";
            txt_kode_barang.Text = "";
            txt_nama_barang.Text = "";
            txt_satuan_barang.Text = "";
            txt_harga_barang.Text = "";
            txt_stock_barang.Text = "0";
            txt_jumlah_penjualan.Text = "";
            txt_sub_total.Text = "";
            txt_jenis_bayar.Text = "KAS";
            txt_terbilang.Text = "";
            txt_diskon.Text = "";
            txt_pembayaran.Text = "";
            txt_memo.Text = "";
            txt_kurang_bayar.Text = "0";
            txt_piutang.Text = "0";
        }

        public PENJUALAN_METRO()
        {
            InitializeComponent();
            cleartext();
            DisplayData();
            DisplayDataBarang();
            DisplayDataPelanggan();
        }

        private void btn_new_penjualan_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker2.Enabled = true;
            txt_no_penjualan.Enabled = true;
            cleartext();
        }

        private void btn_print_penjualan_Click(object sender, EventArgs e)
        {
            LAPORAN_METRO FLAP = new LAPORAN_METRO();
            FLAP.Show();
        }

        private void btn_add_penjualan_Click(object sender, EventArgs e)
        {
            int stock, jumlah_beli, stock_akhir;
            stock = int.Parse(txt_stock_barang.Text);
            jumlah_beli = int.Parse(txt_jumlah_penjualan.Text);
            stock_akhir = stock - jumlah_beli;

            //pembatas pengurangan
            if (int.Parse(txt_stock_barang.Text) >= int.Parse(txt_jumlah_penjualan.Text))
            {
                if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_kode_pelanggan.Text != "" && txt_jumlah_penjualan.Text != ""
                    && txt_sub_total.Text != "" && txt_terbilang.Text != "")
                {
                    try
                    {
                        cmd = new SqlCommand("update tbl_barang set stock=@stock_akhir where kode_barang=@kode_barang", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@stock_akhir", stock_akhir);
                        cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Harus klik tombol 'NEW'!");
                    }
                }
                else
                {
                    MessageBox.Show("gagal simpan");
                }
                if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_kode_pelanggan.Text != "" && txt_jumlah_penjualan.Text != ""
                     && txt_sub_total.Text != "" && txt_terbilang.Text != "")
                {
                    try
                    {
                        cmd = new SqlCommand("insert into tbl_penjualan(no_penjualan,tgl_penjualan,tgl_tempo,nama_sales,kode_barang,nama_barang,satuan,harga,stock,kode_pelanggan,nama_pelanggan,no_telp,alamat,jumlah_beli,subtotal,jenis_bayar,terbilang,diskon,pembayaran,memo,kurang_bayar,piutang) values(@no_penjualan,@tgl_penjualan,@tgl_tempo,@nama_sales,@kode_barang,@nama_barang,@satuan,@harga,@stock,@kode_pelanggan,@nama_pelanggan,@no_telp,@alamat,@jumlah_beli,@subtotal,@jenis_bayar,@terbilang,@diskon,@pembayaran,@memo,@kurang_bayar,@piutang)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@no_penjualan", txt_no_penjualan.Text);
                        cmd.Parameters.Add("@tgl_penjualan", SqlDbType.DateTime).Value = dateTimePicker1.Value.Date;
                        cmd.Parameters.Add("@tgl_tempo", SqlDbType.DateTime).Value = dateTimePicker2.Value.Date;
                        cmd.Parameters.AddWithValue("@nama_sales", txt_nama_sales.Text);
                        cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text);
                        cmd.Parameters.AddWithValue("@nama_barang", txt_nama_barang.Text);
                        cmd.Parameters.AddWithValue("@satuan", txt_satuan_barang.Text);
                        cmd.Parameters.AddWithValue("@harga", txt_harga_barang.Text);
                        cmd.Parameters.AddWithValue("@stock", txt_stock_barang.Text);
                        cmd.Parameters.AddWithValue("@kode_pelanggan", txt_kode_pelanggan.Text);
                        cmd.Parameters.AddWithValue("@nama_pelanggan", txt_nama_pelanggan.Text);
                        cmd.Parameters.AddWithValue("@no_telp", txt_notelp_pelanggan.Text);
                        cmd.Parameters.AddWithValue("@alamat", txt_alamat_pelanggan.Text);
                        cmd.Parameters.AddWithValue("@jumlah_beli", txt_jumlah_penjualan.Text);
                        cmd.Parameters.AddWithValue("@subtotal", txt_sub_total.Text);
                        cmd.Parameters.AddWithValue("@jenis_bayar", txt_jenis_bayar.Text);
                        cmd.Parameters.AddWithValue("@terbilang", txt_terbilang.Text);
                        cmd.Parameters.AddWithValue("@diskon", txt_diskon.Text);
                        cmd.Parameters.AddWithValue("@pembayaran", txt_pembayaran.Text);
                        cmd.Parameters.AddWithValue("@memo", txt_memo.Text);
                        cmd.Parameters.AddWithValue("@kurang_bayar", txt_kurang_bayar.Text);
                        cmd.Parameters.AddWithValue("@piutang", txt_piutang.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data berhasil disimpan");
                        DisplayData();
                        cleartext();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kode barang tidak boleh sama!");
                    }
                }
                else
                {
                    MessageBox.Show("gagal simpan");
                }

            }
            else
            {
                MessageBox.Show("stock kurang");
            }
        }

        private void btn_pilih_pelanggan_Click(object sender, EventArgs e)
        {
            //ini ditombol pilih pelanggan
            group_cari_pelanggan.Visible = true;
        }

        private void btn_pilih_barang_Click(object sender, EventArgs e)
        {
            //ini ditombol pilih barang
            group_cari_barang.Visible = true;
        }

        private void btn_delete_penjualan_Click(object sender, EventArgs e)
        {
            if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_nama_barang.Text != "")
            {
                cmd = new SqlCommand("delete tbl_penjualan where kode_barang=@kode_barang", con);
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

        private void dg_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dg_barang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dg_barang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_satuan_barang.Text = dg_barang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_harga_barang.Text = dg_barang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stock_barang.Text = dg_barang.Rows[e.RowIndex].Cells[4].Value.ToString();
            group_cari_barang.Visible = false;
        }

        private void dg_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_notelp_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
            group_cari_pelanggan.Visible = false;
        }

        private void dg_penjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_no_penjualan.Text = dg_penjualan.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePicker1.Text = dg_penjualan.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker2.Text = dg_penjualan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_nama_sales.Text = dg_penjualan.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_barang.Text = dg_penjualan.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_nama_barang.Text = dg_penjualan.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_satuan_barang.Text = dg_penjualan.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_harga_barang.Text = dg_penjualan.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_stock_barang.Text = dg_penjualan.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_kode_pelanggan.Text = dg_penjualan.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_nama_pelanggan.Text = dg_penjualan.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_notelp_pelanggan.Text = dg_penjualan.Rows[e.RowIndex].Cells[11].Value.ToString();
            txt_alamat_pelanggan.Text = dg_penjualan.Rows[e.RowIndex].Cells[12].Value.ToString();
            txt_jumlah_penjualan.Text = dg_penjualan.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_sub_total.Text = dg_penjualan.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_jenis_bayar.Text = dg_penjualan.Rows[e.RowIndex].Cells[15].Value.ToString();
            txt_terbilang.Text = dg_penjualan.Rows[e.RowIndex].Cells[16].Value.ToString();
            txt_diskon.Text = dg_penjualan.Rows[e.RowIndex].Cells[17].Value.ToString();
            txt_pembayaran.Text = dg_penjualan.Rows[e.RowIndex].Cells[18].Value.ToString();
            txt_memo.Text = dg_penjualan.Rows[e.RowIndex].Cells[19].Value.ToString();
            txt_kurang_bayar.Text = dg_penjualan.Rows[e.RowIndex].Cells[20].Value.ToString();
            txt_piutang.Text = dg_penjualan.Rows[e.RowIndex].Cells[21].Value.ToString();
            dg_pelanggan_CellContentClick(sender, e);
            dg_barang_CellContentClick(sender, e);
            DisplayData();
        }

        private void txt_jumlah_penjualan_TextChanged(object sender, EventArgs e)
        {
            if (txt_jumlah_penjualan.Text != "")
                try
                    {
                        txt_sub_total.Text = (int.Parse(txt_jumlah_penjualan.Text) * int.Parse(txt_harga_barang.Text)).ToString();
                    }
                catch (Exception)
                {
                    MessageBox.Show("Pastikan jumlah beli diisi dengan angka, atau isi dahulu data barang");
                }
        }

        private void txt_sub_total_TextChanged(object sender, EventArgs e)
        {
            if (txt_sub_total.Text != "")
                txt_terbilang.Text = Terbilang(int.Parse(txt_sub_total.Text)) + " Rupiah";
        }

        public static string Terbilang(int x)
        {
            string[] bilangan = { "", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas" };
            string temp = "";
            if (x < 12)
            {
                temp = "" + bilangan[x];
            }
            else if (x < 20)
            {
                temp = Terbilang(x - 10).ToString() + " Belas ";
            }
            else if (x < 100)
            {
                temp = Terbilang(x / 10) + " Puluh " + Terbilang(x % 10);
            }
            else if (x < 200)
            {
                temp = " Seratus " + Terbilang(x - 100);
            }
            else if (x < 1000)
            {
                temp = Terbilang(x / 100) + " Ratus " + Terbilang(x % 100);
            }
            else if (x < 2000)
            {
                temp = " Seribu" + Terbilang(x - 1000);
            }
            else if (x < 1000000)
            {
                temp = Terbilang(x / 1000) + " Ribu " + Terbilang(x % 1000);
            }
            else if (x < 1000000000)
            {
                temp = Terbilang(x / 1000000) + " Juta " + Terbilang(x % 1000000);
            }

            return temp;
        }

        private void btn_save_penjualan_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into tbl_penjualan_detail select * from tbl_penjualan where no_penjualan=@no_penjualan", con);
            con.Open();
            cmd.Parameters.AddWithValue("@no_penjualan", txt_no_penjualan.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Berhasil simpan");
            cmd = new SqlCommand("delete tbl_penjualan", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            cleartext();
        }
    }
}
