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
            btnUrunEkle = new Button();
            lvGonderim = new ListView();
            btnGec = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTonaj).BeginInit();
            SuspendLayout();
            // 
            // cbSeyirKayitlari
            // 
            cbSeyirKayitlari.FormattingEnabled = true;
            cbSeyirKayitlari.Location = new Point(169, 23);
            cbSeyirKayitlari.Margin = new Padding(5, 4, 5, 4);
            cbSeyirKayitlari.Name = "cbSeyirKayitlari";
            cbSeyirKayitlari.Size = new Size(329, 33);
            cbSeyirKayitlari.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 1;
            label1.Text = "Seferler :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 72);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Ürün :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 122);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 1;
            label3.Text = "Tonaj :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 168);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 1;
            label4.Text = "Firma :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 223);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 1;
            label5.Text = "Kişi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 273);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 1;
            label6.Text = "Telefon :";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(169, 68);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(329, 32);
            txtUrunAdi.TabIndex = 2;
            // 
            // nudTonaj
            // 
            nudTonaj.Location = new Point(169, 118);
            nudTonaj.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            nudTonaj.Name = "nudTonaj";
            nudTonaj.Size = new Size(329, 32);
            nudTonaj.TabIndex = 3;
            // 
            // cbFirma
            // 
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(169, 168);
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(329, 33);
            cbFirma.TabIndex = 4;
            // 
            // txtKisiAdi
            // 
            txtKisiAdi.Location = new Point(169, 223);
            txtKisiAdi.Name = "txtKisiAdi";
            txtKisiAdi.Size = new Size(329, 32);
            txtKisiAdi.TabIndex = 5;
            // 
            // mtxtKisiTelefonNumarasi
            // 
            mtxtKisiTelefonNumarasi.Location = new Point(169, 273);
            mtxtKisiTelefonNumarasi.Mask = "(999) 000-0000";
            mtxtKisiTelefonNumarasi.Name = "mtxtKisiTelefonNumarasi";
            mtxtKisiTelefonNumarasi.Size = new Size(329, 32);
            mtxtKisiTelefonNumarasi.TabIndex = 6;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = SystemColors.GradientActiveCaption;
            btnUrunEkle.Location = new Point(52, 327);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(454, 57);
            btnUrunEkle.TabIndex = 8;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // lvGonderim
            // 
            lvGonderim.Location = new Point(37, 400);
            lvGonderim.Name = "lvGonderim";
            lvGonderim.Size = new Size(1345, 229);
            lvGonderim.TabIndex = 9;
            lvGonderim.UseCompatibleStateImageBehavior = false;
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.GradientActiveCaption;
            btnGec.Location = new Point(1097, 635);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(285, 57);
            btnGec.TabIndex = 8;
            btnGec.Text = ">>>";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // FRMGonderim
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 713);
            Controls.Add(lvGonderim);
            Controls.Add(btnGec);
            Controls.Add(btnUrunEkle);
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
        private Button btnUrunEkle;
        private ListView lvGonderim;
        private Button btnGec;
    }
}