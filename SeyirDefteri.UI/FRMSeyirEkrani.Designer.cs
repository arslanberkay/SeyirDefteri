﻿namespace SeyirDefteri.UI
{
    partial class FRMSeyirEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpLimandanCikisTarihi = new DateTimePicker();
            dtpLimanaVarisTarihi = new DateTimePicker();
            cbGemi = new ComboBox();
            cbCikisLimani = new ComboBox();
            cbUgradigiLiman = new ComboBox();
            cbVarisLimani = new ComboBox();
            btnSeferOlustur = new Button();
            lwSeferKaydi = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 38);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 0;
            label1.Text = " Limandan Çıkış Tarihi : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 88);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 1;
            label2.Text = "Limana Varış Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 134);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 0;
            label3.Text = "Gemi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 184);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 1;
            label4.Text = "Çıkış Limanı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 238);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 0;
            label5.Text = "Uğradığı Liman :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 288);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 1;
            label6.Text = "Varış Limanı :";
            // 
            // dtpLimandanCikisTarihi
            // 
            dtpLimandanCikisTarihi.Location = new Point(345, 31);
            dtpLimandanCikisTarihi.Name = "dtpLimandanCikisTarihi";
            dtpLimandanCikisTarihi.Size = new Size(349, 32);
            dtpLimandanCikisTarihi.TabIndex = 2;
            // 
            // dtpLimanaVarisTarihi
            // 
            dtpLimanaVarisTarihi.Location = new Point(345, 81);
            dtpLimanaVarisTarihi.Name = "dtpLimanaVarisTarihi";
            dtpLimanaVarisTarihi.Size = new Size(349, 32);
            dtpLimanaVarisTarihi.TabIndex = 2;
            // 
            // cbGemi
            // 
            cbGemi.FormattingEnabled = true;
            cbGemi.Location = new Point(345, 133);
            cbGemi.Name = "cbGemi";
            cbGemi.Size = new Size(417, 33);
            cbGemi.TabIndex = 3;
            // 
            // cbCikisLimani
            // 
            cbCikisLimani.FormattingEnabled = true;
            cbCikisLimani.Location = new Point(345, 180);
            cbCikisLimani.Name = "cbCikisLimani";
            cbCikisLimani.Size = new Size(417, 33);
            cbCikisLimani.TabIndex = 3;
            // 
            // cbUgradigiLiman
            // 
            cbUgradigiLiman.FormattingEnabled = true;
            cbUgradigiLiman.Location = new Point(345, 234);
            cbUgradigiLiman.Name = "cbUgradigiLiman";
            cbUgradigiLiman.Size = new Size(417, 33);
            cbUgradigiLiman.TabIndex = 3;
            // 
            // cbVarisLimani
            // 
            cbVarisLimani.FormattingEnabled = true;
            cbVarisLimani.Location = new Point(345, 281);
            cbVarisLimani.Name = "cbVarisLimani";
            cbVarisLimani.Size = new Size(417, 33);
            cbVarisLimani.TabIndex = 3;
            // 
            // btnSeferOlustur
            // 
            btnSeferOlustur.BackColor = SystemColors.GradientActiveCaption;
            btnSeferOlustur.Location = new Point(847, 253);
            btnSeferOlustur.Name = "btnSeferOlustur";
            btnSeferOlustur.Size = new Size(230, 60);
            btnSeferOlustur.TabIndex = 4;
            btnSeferOlustur.Text = "Sefer Oluştur";
            btnSeferOlustur.UseVisualStyleBackColor = false;
            // 
            // lwSeferKaydi
            // 
            lwSeferKaydi.Location = new Point(55, 341);
            lwSeferKaydi.Name = "lwSeferKaydi";
            lwSeferKaydi.Size = new Size(1022, 222);
            lwSeferKaydi.TabIndex = 5;
            lwSeferKaydi.UseCompatibleStateImageBehavior = false;
            // 
            // FRMSeyirEkrani
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1136, 601);
            Controls.Add(lwSeferKaydi);
            Controls.Add(btnSeferOlustur);
            Controls.Add(cbVarisLimani);
            Controls.Add(cbCikisLimani);
            Controls.Add(cbUgradigiLiman);
            Controls.Add(cbGemi);
            Controls.Add(dtpLimanaVarisTarihi);
            Controls.Add(dtpLimandanCikisTarihi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FRMSeyirEkrani";
            Text = "Form1";
            Load += FRMSeyirEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpLimandanCikisTarihi;
        private DateTimePicker dtpLimanaVarisTarihi;
        private ComboBox cbGemi;
        private ComboBox cbCikisLimani;
        private ComboBox cbUgradigiLiman;
        private ComboBox cbVarisLimani;
        private Button btnSeferOlustur;
        private ListView lwSeferKaydi;
    }
}
