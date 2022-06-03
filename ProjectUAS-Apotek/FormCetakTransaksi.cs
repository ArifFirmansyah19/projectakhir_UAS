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
    public partial class FormCetakTransaksi : Form
    {
        String id_transaksi;
        public FormCetakTransaksi(String id_transaksi)
        {
            InitializeComponent();
            this.id_transaksi = id_transaksi;
        }

        private void FormCetakTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewerCetakTransaksi_Load(object sender, EventArgs e)
        {
            DataTable dtTransaksi = new DataTable(); //data transaksi
            dtTransaksi.Columns.Add("id_transaksi", typeof(String));
            dtTransaksi.Columns.Add("waktu_transaksi", typeof(DateTime));
            dtTransaksi.Columns.Add("total_belanja", typeof(int));

            dtTransaksi = Transaksi.Select(this.id_transaksi);//select berdasarkan id_transaksi

            DataTable dtDetail_Transaksi = new DataTable(); //data barang yg dibeli
            dtDetail_Transaksi.Columns.Add("nama_barang", typeof(String));
            dtDetail_Transaksi.Columns.Add("jumlah_item", typeof(int));
            dtDetail_Transaksi.Columns.Add("harga_jual", typeof(int));
            dtDetail_Transaksi.Columns.Add("subtotal", typeof(int));
            dtDetail_Transaksi.Columns.Add("id_transaksi", typeof(String));

            dtDetail_Transaksi = Detail_Transaksi.SelectDetail(this.id_transaksi);

            CetakTransaksi cetakTransaksi = new CetakTransaksi(); //
            cetakTransaksi.Database.Tables["transaksi"].SetDataSource(dtTransaksi); //sumber dataset transaksi dari dtTransaksi
            cetakTransaksi.Database.Tables["detail_transaksi"].SetDataSource(dtDetail_Transaksi); //nilainya dari dtDetailTransaksi
            crystalReportViewerCetakTransaksi.ReportSource = null;
            crystalReportViewerCetakTransaksi.ReportSource = cetakTransaksi;
        }

        private void CetakBuktiTransaksi1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
