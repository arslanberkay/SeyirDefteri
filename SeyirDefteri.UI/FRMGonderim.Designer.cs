namespace SeyirDefteri.UI
{
    partial class FRMGonderim
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
            cbSeyirKayitlari = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUrunAdi = new TextBox();
            nudTonaj = new NumericUpDown();
            cbFirma = new ComboBox();
            txtKisiAdi = new TextBox();
            mtxtKisiTelefonNumarasi = new MaskedTextBox();
            btnGonderimOlustur = new Button();
            lvGonderim = new ListView();
            ((System.ComponentModel.ISupportInitialize)nudTonaj).BeginInit();
            SuspendLayout();
            // 
            // cbSeyirKayitlari
            // 
            cbSeyirKayitlari.FormattingEnabled = true;
            cbSeyirKayitlari.Location = new Point(238, 20);
            cbSeyirKayitlari.Margin = new Padding(5, 4, 5, 4);
            cbSeyirKayitlari.Name = "cbSeyirKayitlari";
            cbSeyirKayitlari.Size = new Size(653, 33);
            cbSeyirKayitlari.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 28);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 1;
            label1.Text = "Seferler :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Ürün :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 132);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 1;
            label3.Text = "Tonaj :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 184);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 1;
            label4.Text = "Firma :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 236);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 1;
            label5.Text = "Kişi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 282);
            label6.Name = "label6";
            label6.Size = new Size(156, 25);
            label6.TabIndex = 1;
            label6.Text = "Kişi Telefonu :";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(238, 72);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(653, 32);
            txtUrunAdi.TabIndex = 2;
            // 
            // nudTonaj
            // 
            nudTonaj.Location = new Point(238, 123);
            nudTonaj.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            nudTonaj.Name = "nudTonaj";
            nudTonaj.Size = new Size(653, 32);
            nudTonaj.TabIndex = 3;
            // 
            // cbFirma
            // 
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(238, 174);
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(653, 33);
            cbFirma.TabIndex = 4;
            // 
            // txtKisiAdi
            // 
            txtKisiAdi.Location = new Point(238, 229);
            txtKisiAdi.Name = "txtKisiAdi";
            txtKisiAdi.Size = new Size(653, 32);
            txtKisiAdi.TabIndex = 5;
            // 
            // mtxtKisiTelefonNumarasi
            // 
            mtxtKisiTelefonNumarasi.Location = new Point(238, 279);
            mtxtKisiTelefonNumarasi.Mask = "(999) 000-0000";
            mtxtKisiTelefonNumarasi.Name = "mtxtKisiTelefonNumarasi";
            mtxtKisiTelefonNumarasi.Size = new Size(653, 32);
            mtxtKisiTelefonNumarasi.TabIndex = 6;
            // 
            // btnGonderimOlustur
            // 
            btnGonderimOlustur.BackColor = SystemColors.ActiveCaption;
            btnGonderimOlustur.Location = new Point(952, 254);
            btnGonderimOlustur.Name = "btnGonderimOlustur";
            btnGonderimOlustur.Size = new Size(203, 57);
            btnGonderimOlustur.TabIndex = 8;
            btnGonderimOlustur.Text = "Oluştur";
            btnGonderimOlustur.UseVisualStyleBackColor = false;
            btnGonderimOlustur.Click += btnGonderimOlustur_Click;
            // 
            // lvGonderim
            // 
            lvGonderim.Location = new Point(25, 350);
            lvGonderim.Name = "lvGonderim";
            lvGonderim.Size = new Size(1130, 211);
            lvGonderim.TabIndex = 9;
            lvGonderim.UseCompatibleStateImageBehavior = false;
            // 
            // FRMGonderim
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 603);
            Controls.Add(lvGonderim);
            Controls.Add(btnGonderimOlustur);
            Controls.Add(mtxtKisiTelefonNumarasi);
            Controls.Add(txtKisiAdi);
            Controls.Add(cbFirma);
            Controls.Add(nudTonaj);
            Controls.Add(txtUrunAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSeyirKayitlari);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FRMGonderim";
            Text = "FRMGonderim";
            Load += FRMGonderim_Load;
            ((System.ComponentModel.ISupportInitialize)nudTonaj).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSeyirKayitlari;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUrunAdi;
        private NumericUpDown nudTonaj;
        private ComboBox cbFirma;
        private TextBox txtKisiAdi;
        private MaskedTextBox mtxtKisiTelefonNumarasi;
        private Button btnGonderimOlustur;
        private ListView lvGonderim;
    }
}