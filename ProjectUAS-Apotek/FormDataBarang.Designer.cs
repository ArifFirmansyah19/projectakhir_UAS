
namespace ProjectUAS_Apotek
{
    partial class FormDataBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBarang));
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.labelPerusahaan = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelHargaJual = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelHargaBeli = new System.Windows.Forms.Label();
            this.textBoxHargaBeli = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxPerusahaan = new System.Windows.Forms.TextBox();
            this.dataGridViewDataBarang = new System.Windows.Forms.DataGridView();
            this.labelDataBarang = new System.Windows.Forms.Label();
            this.dateTimePickerExp = new System.Windows.Forms.DateTimePicker();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxIdBarang = new System.Windows.Forms.TextBox();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_beli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSimpan.Location = new System.Drawing.Point(736, 546);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 28);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonHapus.Location = new System.Drawing.Point(952, 546);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(100, 28);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUbah.Location = new System.Drawing.Point(844, 546);
            this.buttonUbah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(100, 28);
            this.buttonUbah.TabIndex = 3;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // labelPerusahaan
            // 
            this.labelPerusahaan.AutoSize = true;
            this.labelPerusahaan.BackColor = System.Drawing.Color.Transparent;
            this.labelPerusahaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerusahaan.Location = new System.Drawing.Point(105, 475);
            this.labelPerusahaan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerusahaan.Name = "labelPerusahaan";
            this.labelPerusahaan.Size = new System.Drawing.Size(95, 17);
            this.labelPerusahaan.TabIndex = 4;
            this.labelPerusahaan.Text = "Perusahaan";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.BackColor = System.Drawing.Color.Transparent;
            this.labelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.Location = new System.Drawing.Point(439, 507);
            this.labelExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(34, 17);
            this.labelExp.TabIndex = 5;
            this.labelExp.Text = "Exp";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(439, 475);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(48, 17);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "Stock";
            // 
            // labelHargaJual
            // 
            this.labelHargaJual.AutoSize = true;
            this.labelHargaJual.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaJual.Location = new System.Drawing.Point(439, 443);
            this.labelHargaJual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHargaJual.Name = "labelHargaJual";
            this.labelHargaJual.Size = new System.Drawing.Size(87, 17);
            this.labelHargaJual.TabIndex = 7;
            this.labelHargaJual.Text = "Harga Jual";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(105, 443);
            this.labelNamaBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(106, 17);
            this.labelNamaBarang.TabIndex = 8;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // labelHargaBeli
            // 
            this.labelHargaBeli.AutoSize = true;
            this.labelHargaBeli.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaBeli.Location = new System.Drawing.Point(105, 507);
            this.labelHargaBeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHargaBeli.Name = "labelHargaBeli";
            this.labelHargaBeli.Size = new System.Drawing.Size(84, 17);
            this.labelHargaBeli.TabIndex = 9;
            this.labelHargaBeli.Text = "Harga Beli";
            // 
            // textBoxHargaBeli
            // 
            this.textBoxHargaBeli.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHargaBeli.Location = new System.Drawing.Point(241, 505);
            this.textBoxHargaBeli.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHargaBeli.Name = "textBoxHargaBeli";
            this.textBoxHargaBeli.Size = new System.Drawing.Size(165, 22);
            this.textBoxHargaBeli.TabIndex = 10;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHargaJual.Location = new System.Drawing.Point(553, 441);
            this.textBoxHargaJual.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(165, 22);
            this.textBoxHargaJual.TabIndex = 11;
            // 
            // textBoxStock
            // 
            this.textBoxStock.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStock.Location = new System.Drawing.Point(553, 473);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(165, 22);
            this.textBoxStock.TabIndex = 12;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamaBarang.Location = new System.Drawing.Point(241, 441);
            this.textBoxNamaBarang.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(165, 22);
            this.textBoxNamaBarang.TabIndex = 14;
            // 
            // textBoxPerusahaan
            // 
            this.textBoxPerusahaan.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPerusahaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPerusahaan.Location = new System.Drawing.Point(241, 473);
            this.textBoxPerusahaan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPerusahaan.Name = "textBoxPerusahaan";
            this.textBoxPerusahaan.Size = new System.Drawing.Size(165, 22);
            this.textBoxPerusahaan.TabIndex = 15;
            // 
            // dataGridViewDataBarang
            // 
            this.dataGridViewDataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.nama_barang,
            this.perusahaan,
            this.harga_beli,
            this.harga_jual,
            this.stock,
            this.exp});
            this.dataGridViewDataBarang.Location = new System.Drawing.Point(109, 108);
            this.dataGridViewDataBarang.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDataBarang.Name = "dataGridViewDataBarang";
            this.dataGridViewDataBarang.RowHeadersWidth = 51;
            this.dataGridViewDataBarang.Size = new System.Drawing.Size(943, 297);
            this.dataGridViewDataBarang.TabIndex = 18;
            this.dataGridViewDataBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataBarang_CellContentClick);
            // 
            // labelDataBarang
            // 
            this.labelDataBarang.AutoSize = true;
            this.labelDataBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelDataBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataBarang.Location = new System.Drawing.Point(472, 9);
            this.labelDataBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataBarang.Name = "labelDataBarang";
            this.labelDataBarang.Size = new System.Drawing.Size(219, 39);
            this.labelDataBarang.TabIndex = 19;
            this.labelDataBarang.Text = "Data Barang";
            // 
            // dateTimePickerExp
            // 
            this.dateTimePickerExp.Location = new System.Drawing.Point(552, 507);
            this.dateTimePickerExp.Name = "dateTimePickerExp";
            this.dateTimePickerExp.Size = new System.Drawing.Size(166, 22);
            this.dateTimePickerExp.TabIndex = 20;
            this.dateTimePickerExp.Value = new System.DateTime(2022, 5, 31, 0, 0, 0, 0);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(111, 76);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(201, 22);
            this.textBoxCari.TabIndex = 21;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(352, 76);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 22;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxIdBarang
            // 
            this.textBoxIdBarang.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIdBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdBarang.Location = new System.Drawing.Point(241, 411);
            this.textBoxIdBarang.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdBarang.Name = "textBoxIdBarang";
            this.textBoxIdBarang.Size = new System.Drawing.Size(165, 22);
            this.textBoxIdBarang.TabIndex = 23;
            this.textBoxIdBarang.Visible = false;
            this.textBoxIdBarang.TextChanged += new System.EventHandler(this.textBoxIdBarang_TextChanged);
            // 
            // id_barang
            // 
            this.id_barang.DataPropertyName = "id_barang";
            this.id_barang.HeaderText = "Kode Barang";
            this.id_barang.MinimumWidth = 6;
            this.id_barang.Name = "id_barang";
            // 
            // nama_barang
            // 
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.MinimumWidth = 6;
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Width = 125;
            // 
            // perusahaan
            // 
            this.perusahaan.DataPropertyName = "perusahaan";
            this.perusahaan.HeaderText = "Perusahaan";
            this.perusahaan.MinimumWidth = 6;
            this.perusahaan.Name = "perusahaan";
            this.perusahaan.Width = 125;
            // 
            // harga_beli
            // 
            this.harga_beli.DataPropertyName = "harga_beli";
            this.harga_beli.HeaderText = "Harga Beli";
            this.harga_beli.MinimumWidth = 6;
            this.harga_beli.Name = "harga_beli";
            // 
            // harga_jual
            // 
            this.harga_jual.DataPropertyName = "harga_jual";
            this.harga_jual.HeaderText = "Harga Jual";
            this.harga_jual.MinimumWidth = 6;
            this.harga_jual.Name = "harga_jual";
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Width = 50;
            // 
            // exp
            // 
            this.exp.DataPropertyName = "exp";
            this.exp.HeaderText = "Exp";
            this.exp.MinimumWidth = 6;
            this.exp.Name = "exp";
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 590);
            this.Controls.Add(this.textBoxIdBarang);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.dateTimePickerExp);
            this.Controls.Add(this.labelDataBarang);
            this.Controls.Add(this.dataGridViewDataBarang);
            this.Controls.Add(this.textBoxPerusahaan);
            this.Controls.Add(this.textBoxNamaBarang);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxHargaJual);
            this.Controls.Add(this.textBoxHargaBeli);
            this.Controls.Add(this.labelHargaBeli);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.labelHargaJual);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelPerusahaan);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Label labelPerusahaan;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelHargaJual;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelHargaBeli;
        private System.Windows.Forms.TextBox textBoxHargaBeli;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxPerusahaan;
        private System.Windows.Forms.DataGridView dataGridViewDataBarang;
        private System.Windows.Forms.Label labelDataBarang;
        private System.Windows.Forms.DateTimePicker dateTimePickerExp;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxIdBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn perusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_beli;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
    }
}