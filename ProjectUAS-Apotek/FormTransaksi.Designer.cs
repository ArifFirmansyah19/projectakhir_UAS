
namespace ProjectUAS_Apotek
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            this.labelTransaksi = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.labelKode = new System.Windows.Forms.Label();
            this.labelIDTransaksi = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelJmlitem = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.textBoxIDTransaksi = new System.Windows.Forms.TextBox();
            this.buttonTransaksiBaru = new System.Windows.Forms.Button();
            this.textBoxJumlahItem = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTransaksi
            // 
            this.labelTransaksi.AutoSize = true;
            this.labelTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.labelTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksi.Location = new System.Drawing.Point(501, 9);
            this.labelTransaksi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransaksi.Name = "labelTransaksi";
            this.labelTransaksi.Size = new System.Drawing.Size(174, 39);
            this.labelTransaksi.TabIndex = 20;
            this.labelTransaksi.Text = "Transaksi";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSimpan.Location = new System.Drawing.Point(768, 534);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 28);
            this.buttonSimpan.TabIndex = 21;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Visible = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCetak.Location = new System.Drawing.Point(939, 534);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(116, 28);
            this.buttonCetak.TabIndex = 22;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_barang,
            this.jumlah_item,
            this.harga_jual,
            this.subtotal});
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(128, 181);
            this.dataGridViewTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.RowHeadersWidth = 51;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(943, 328);
            this.dataGridViewTransaksi.TabIndex = 29;
            this.dataGridViewTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaksi_CellContentClick_1);
            // 
            // labelKode
            // 
            this.labelKode.AutoSize = true;
            this.labelKode.BackColor = System.Drawing.Color.Transparent;
            this.labelKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKode.Location = new System.Drawing.Point(142, 138);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(106, 17);
            this.labelKode.TabIndex = 30;
            this.labelKode.Text = "Nama Barang";
            this.labelKode.Click += new System.EventHandler(this.labelKode_Click);
            // 
            // labelIDTransaksi
            // 
            this.labelIDTransaksi.AutoSize = true;
            this.labelIDTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.labelIDTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDTransaksi.Location = new System.Drawing.Point(329, 83);
            this.labelIDTransaksi.Name = "labelIDTransaksi";
            this.labelIDTransaksi.Size = new System.Drawing.Size(99, 17);
            this.labelIDTransaksi.TabIndex = 32;
            this.labelIDTransaksi.Text = "ID Transaksi";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(753, 134);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(52, 17);
            this.labelHarga.TabIndex = 33;
            this.labelHarga.Text = "Harga";
            this.labelHarga.Click += new System.EventHandler(this.labelHarga_Click);
            // 
            // labelJmlitem
            // 
            this.labelJmlitem.AutoSize = true;
            this.labelJmlitem.BackColor = System.Drawing.Color.Transparent;
            this.labelJmlitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlitem.Location = new System.Drawing.Point(578, 136);
            this.labelJmlitem.Name = "labelJmlitem";
            this.labelJmlitem.Size = new System.Drawing.Size(94, 17);
            this.labelJmlitem.TabIndex = 34;
            this.labelJmlitem.Text = "Jumlah Item";
            this.labelJmlitem.Click += new System.EventHandler(this.labelJmlitem_Click);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(811, 131);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(112, 22);
            this.textBoxHarga.TabIndex = 38;
            this.textBoxHarga.TextChanged += new System.EventHandler(this.textBoxHarga_TextChanged);
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(254, 131);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(291, 22);
            this.textBoxKode.TabIndex = 39;
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            this.textBoxKode.Leave += new System.EventHandler(this.textBoxKode_Leave);
            // 
            // textBoxIDTransaksi
            // 
            this.textBoxIDTransaksi.Location = new System.Drawing.Point(435, 80);
            this.textBoxIDTransaksi.Name = "textBoxIDTransaksi";
            this.textBoxIDTransaksi.Size = new System.Drawing.Size(207, 22);
            this.textBoxIDTransaksi.TabIndex = 40;
            // 
            // buttonTransaksiBaru
            // 
            this.buttonTransaksiBaru.Location = new System.Drawing.Point(146, 80);
            this.buttonTransaksiBaru.Name = "buttonTransaksiBaru";
            this.buttonTransaksiBaru.Size = new System.Drawing.Size(142, 23);
            this.buttonTransaksiBaru.TabIndex = 41;
            this.buttonTransaksiBaru.Text = "Transaksi Baru";
            this.buttonTransaksiBaru.UseVisualStyleBackColor = true;
            this.buttonTransaksiBaru.Click += new System.EventHandler(this.buttonTransaksiBaru_Click);
            // 
            // textBoxJumlahItem
            // 
            this.textBoxJumlahItem.Location = new System.Drawing.Point(678, 131);
            this.textBoxJumlahItem.Name = "textBoxJumlahItem";
            this.textBoxJumlahItem.Size = new System.Drawing.Size(47, 22);
            this.textBoxJumlahItem.TabIndex = 42;
            this.textBoxJumlahItem.TextChanged += new System.EventHandler(this.textBoxJumlahItem_TextChanged);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Yellow;
            this.buttonTambah.Location = new System.Drawing.Point(955, 126);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(100, 28);
            this.buttonTambah.TabIndex = 43;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // nama_barang
            // 
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.MinimumWidth = 6;
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Width = 250;
            // 
            // jumlah_item
            // 
            this.jumlah_item.DataPropertyName = "jumlah_item";
            this.jumlah_item.HeaderText = "Jumlah Item";
            this.jumlah_item.MinimumWidth = 6;
            this.jumlah_item.Name = "jumlah_item";
            this.jumlah_item.Width = 150;
            // 
            // harga_jual
            // 
            this.harga_jual.DataPropertyName = "harga_jual";
            this.harga_jual.HeaderText = "Harga Jual";
            this.harga_jual.MinimumWidth = 6;
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.Width = 150;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 150;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 590);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxJumlahItem);
            this.Controls.Add(this.buttonTransaksiBaru);
            this.Controls.Add(this.textBoxIDTransaksi);
            this.Controls.Add(this.textBoxKode);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.labelJmlitem);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelIDTransaksi);
            this.Controls.Add(this.labelKode);
            this.Controls.Add(this.dataGridViewTransaksi);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransaksi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label labelIDTransaksi;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelJmlitem;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxIDTransaksi;
        private System.Windows.Forms.Button buttonTransaksiBaru;
        private System.Windows.Forms.TextBox textBoxJumlahItem;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}