
namespace ProjectUAS_Apotek
{
    partial class FormCetakTransaksi
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
            this.crystalReportViewerCetakTransaksi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CetakBuktiTransaksi1 = new ProjectUAS_Apotek.CetakBuktiTransaksi();
            this.SuspendLayout();
            // 
            // crystalReportViewerCetakTransaksi
            // 
            this.crystalReportViewerCetakTransaksi.ActiveViewIndex = 0;
            this.crystalReportViewerCetakTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerCetakTransaksi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerCetakTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerCetakTransaksi.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerCetakTransaksi.Name = "crystalReportViewerCetakTransaksi";
            this.crystalReportViewerCetakTransaksi.ReportSource = this.CetakBuktiTransaksi1;
            this.crystalReportViewerCetakTransaksi.Size = new System.Drawing.Size(1082, 453);
            this.crystalReportViewerCetakTransaksi.TabIndex = 0;
            this.crystalReportViewerCetakTransaksi.Load += new System.EventHandler(this.crystalReportViewerCetakTransaksi_Load);
            // 
            // CetakBuktiTransaksi1
            // 
            this.CetakBuktiTransaksi1.InitReport += new System.EventHandler(this.CetakBuktiTransaksi1_InitReport);
            // 
            // FormCetakTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.crystalReportViewerCetakTransaksi);
            this.Name = "FormCetakTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCetakTransaksi";
            this.Load += new System.EventHandler(this.FormCetakTransaksi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerCetakTransaksi;
        private CetakBuktiTransaksi CetakBuktiTransaksi1;
    }
}