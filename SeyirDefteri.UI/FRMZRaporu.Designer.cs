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
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(43, 44);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(333, 32);
            dtpCikisTarihi.TabIndex = 0;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;
            // 
            // dtpVarisTarihi
            // 
            dtpVarisTarihi.Location = new Point(779, 44);
            dtpVarisTarihi.Name = "dtpVarisTarihi";
            dtpVarisTarihi.Size = new Size(333, 32);
            dtpVarisTarihi.TabIndex = 0;
            dtpVarisTarihi.ValueChanged += dtpVarisTarihi_ValueChanged;
            // 
            // lvGonderimZRaporu
            // 
            lvGonderimZRaporu.Location = new Point(43, 101);
            lvGonderimZRaporu.Name = "lvGonderimZRaporu";
            lvGonderimZRaporu.Size = new Size(1069, 352);
            lvGonderimZRaporu.TabIndex = 1;
            lvGonderimZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(641, 476);
            button2.Name = "button2";
            button2.Size = new Size(256, 52);
            button2.TabIndex = 2;
            button2.Text = "Excel Dosyası Oluştur";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(903, 476);
            button3.Name = "button3";
            button3.Size = new Size(209, 52);
            button3.TabIndex = 2;
            button3.Text = "Mail Gönder";
            button3.UseVisualStyleBackColor = false;
            // 
            // FRMZRaporu
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 563);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
    }
}