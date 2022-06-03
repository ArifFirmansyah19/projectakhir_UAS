using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_Apotek
{
    public partial class FormTransaksi : Form
    {
        DataTable dtDataBarang;
        DataTable dtTransaksi;
        public FormTransaksi()
        {
            InitializeComponent();
            dataGridViewTransaksi.RowHeadersVisible = false;
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

        }

        //private void textBoxKode_TextChanged(object sender, EventArgs e)
        //{
        //    FormTabelBarang frmTabelBarang = new FormTabelBarang();
        //    frmTabelBarang.Show();
        //}

        private void buttonTransaksiBaru_Click(object sender, EventArgs e)
        {
            textBoxIDTransaksi.Text = DateTime.Now.Ticks.ToString();
            dtTransaksi = new DataTable(); //pembuatan datatabel kosong utk menampung data transaksi
            dtTransaksi.Columns.Add("id_transaksi", typeof(String));
            dtTransaksi.Columns.Add("id_barang", typeof(int));
            dtTransaksi.Columns.Add("nama_barang", typeof(String));
            dtTransaksi.Columns.Add("jumlah_item", typeof(int));
            dtTransaksi.Columns.Add("harga_jual", typeof(int));
            dtTransaksi.Columns.Add("subtotal", typeof(int));
        }

        private void textBoxKode_Leave(object sender, EventArgs e)
        {
            dtDataBarang = new DataTable(); //penyimpanan informasi suatu barang
            dtDataBarang.Columns.Add("id_barang");
            dtDataBarang.Columns.Add("nama_barang");
            dtDataBarang.Columns.Add("jumlah_item");
            dtDataBarang.Columns.Add("harga_jual");

            String nama_barang = textBoxKode.Text; //pencarian data barang sesuai nama barang ug diinputkan
            dtDataBarang = DataBarang.Select(nama_barang);
            if (dtDataBarang.Rows.Count != 0)
            {
                textBoxJumlahItem.Text = "1";
                textBoxHarga.Text = dtDataBarang.Rows[0]["harga_jual"].ToString();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            int subtotal = 0;
            int newqty;
            //cek datagridview, jika id_barang sudah ada, maka tambahkan saja kuantiti
            if (dtTransaksi.Rows.Count > 0)
            {
                foreach (DataRow row in dtTransaksi.Rows)
                {
                    if (textBoxKode.Text == (string)row["nama_barang"])
                    {
                        newqty = Convert.ToInt32(row["jumlah_item"]) + Convert.ToInt32(textBoxJumlahItem.Text);
                        subtotal = newqty * Convert.ToInt32(row["harga_jual"]);
                        row["jumlah_item"] = newqty;
                        row["subtotal"] = subtotal;
                        dataGridViewTransaksi.DataSource = dtTransaksi;
                        dataGridViewTransaksi.Refresh();
                        return;
                    }
                }
            }
            //jika belum ada, baru tambahkan baris baru
            newqty = Convert.ToInt32(textBoxJumlahItem.Text);
            subtotal = newqty * Convert.ToInt32(dtDataBarang.Rows[0]["harga_jual"]);

            DataRow datarow = dtTransaksi.NewRow();
            datarow["id_transaksi"] = textBoxIDTransaksi.Text;
            datarow["id_barang"] = Convert.ToInt32(dtDataBarang.Rows[0]["id_barang"]);
            datarow["nama_barang"] = textBoxKode.Text;
            datarow["jumlah_item"] = Convert.ToInt32(textBoxJumlahItem.Text);
            datarow["harga_jual"] = Convert.ToInt32(dtDataBarang.Rows[0]["harga_jual"]);
            datarow["subtotal"] = subtotal;
            dtTransaksi.Rows.Add(datarow);

            dataGridViewTransaksi.DataSource = dtTransaksi;
            dataGridViewTransaksi.Refresh();
            dataGridViewTransaksi.Columns["id_transaksi"].Visible = false;
            dataGridViewTransaksi.Columns["id_barang"].Visible = false;
            textBoxKode.Text = "";
            textBoxJumlahItem.Text = "";
            textBoxHarga.Text = "";
        }

        private void dataGridViewTransaksi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            //get current time, hitung total belanja
            DateTime now = DateTime.Now;

            //insert into tabel transaksi
            Transaksi transaksi = new Transaksi();
            transaksi.id_transaksi = textBoxIDTransaksi.Text;
            transaksi.waktu_transaksi = now;
            transaksi.total_belanja = Convert.ToInt32(dtTransaksi.Compute("SUM(subtotal)", ""));
            transaksi.insert(); //data id transaksi dimuasukkan ke tabel transaksi di db

            //insert into detail transaksi
            Detail_Transaksi detailTransaksi = new Detail_Transaksi();
            foreach (DataRow row in dtTransaksi.Rows) //perulangan membaca setiap baris data yg dibeli
            {
                detailTransaksi.id_transaksi = row["id_transaksi"].ToString();
                detailTransaksi.id_barang = Convert.ToInt32(row["id_barang"]);
                detailTransaksi.jumlah_item = Convert.ToInt32(row["jumlah_item"]);
                detailTransaksi.harga_jual = Convert.ToInt32(row["harga_jual"]);
                detailTransaksi.subtotal = Convert.ToInt32(row["subtotal"]);
                detailTransaksi.insert();
            }

            //view report
            FormCetakTransaksi formcetak = new FormCetakTransaksi(textBoxIDTransaksi.Text);
            formcetak.Show();
        }

        private void labelKode_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJumlahItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelJmlitem_Click(object sender, EventArgs e)
        {

        }

        private void labelHarga_Click(object sender, EventArgs e)
        {

        }
    }
}
