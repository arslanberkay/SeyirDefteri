namespace SeyirDefteri.UI
{
    partial class FRMZRaporu
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
            dtpCikisTarihi = new DateTimePicker();
            dtpVarisTarihi = new DateTimePicker();
            lvGonderimZRaporu = new ListView();
            btnExcelDosyasiOlustur = new Button();
            btnMailGonder = new Button();
            btnPdfOlustur = new Button();
            SuspendLayout();
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(31, 30);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(333, 32);
            dtpCikisTarihi.TabIndex = 0;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;
            // 
            // dtpVarisTarihi
            // 
            dtpVarisTarihi.Location = new Point(1218, 30);
            dtpVarisTarihi.Name = "dtpVarisTarihi";
            dtpVarisTarihi.Size = new Size(333, 32);
            dtpVarisTarihi.TabIndex = 0;
            dtpVarisTarihi.ValueChanged += dtpVarisTarihi_ValueChanged;
            // 
            // lvGonderimZRaporu
            // 
            lvGonderimZRaporu.Location = new Point(31, 87);
            lvGonderimZRaporu.Name = "lvGonderimZRaporu";
            lvGonderimZRaporu.Size = new Size(1520, 352);
            lvGonderimZRaporu.TabIndex = 1;
            lvGonderimZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // btnExcelDosyasiOlustur
            // 
            btnExcelDosyasiOlustur.BackColor = SystemColors.GradientActiveCaption;
            btnExcelDosyasiOlustur.Location = new Point(753, 458);
            btnExcelDosyasiOlustur.Name = "btnExcelDosyasiOlustur";
            btnExcelDosyasiOlustur.Size = new Size(252, 68);
            btnExcelDosyasiOlustur.TabIndex = 2;
            btnExcelDosyasiOlustur.Text = "Excel Dosyası Oluştur";
            btnExcelDosyasiOlustur.UseVisualStyleBackColor = false;
            btnExcelDosyasiOlustur.Click += btnExcelDosyasiOlustur_Click;
            // 
            // btnMailGonder
            // 
            btnMailGonder.BackColor = SystemColors.GradientActiveCaption;
            btnMailGonder.Location = new Point(1272, 458);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(279, 68);
            btnMailGonder.TabIndex = 2;
            btnMailGonder.Text = "Excel Dosyasını Mail At";
            btnMailGonder.UseVisualStyleBackColor = false;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = SystemColors.GradientActiveCaption;
            btnPdfOlustur.Location = new Point(1026, 458);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(225, 68);
            btnPdfOlustur.TabIndex = 2;
            btnPdfOlustur.Text = "PDF Oluştur";
            btnPdfOlustur.UseVisualStyleBackColor = false;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // FRMZRaporu
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 558);
            Controls.Add(btnMailGonder);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnExcelDosyasiOlustur);
            Controls.Add(lvGonderimZRaporu);
            Controls.Add(dtpVarisTarihi);
            Controls.Add(dtpCikisTarihi);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FRMZRaporu";
            Text = "FRMZRaporu";
            Load += FRMZRaporu_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpCikisTarihi;
        private DateTimePicker dtpVarisTarihi;
        private ListView lvGonderimZRaporu;
        private Button btnExcelDosyasiOlustur;
        private Button btnMailGonder;
        private Button btnPdfOlustur;
    }
}