using SeyirDefteri.Core.Data;

namespace SeyirDefteri.UI
{
    public partial class FRMSeyirEkrani : Form
    {
        public static List<SeyirKaydi> SeyirKayitlari = new List<SeyirKaydi>();  //Neden static? Bu neyi de�i�tirdi? 

        public FRMSeyirEkrani()
        {
            InitializeComponent();
        }

        private void GemileriOlustur()
        {
            List<Gemi> gemiler = new List<Gemi>
            {
                new Gemi { GemiId = 1, GemiAdi = "Titanic", Tonaji = 46000m },
                new Gemi { GemiId = 2, GemiAdi = "Queen Mary 2", Tonaji = 148528m },
                new Gemi { GemiId = 3, GemiAdi = "Oasis of the Seas", Tonaji = 226838m },
                new Gemi { GemiId = 4, GemiAdi = "Harmony of the Seas", Tonaji = 226963m },
                new Gemi { GemiId = 5, GemiAdi = "Symphony of the Seas", Tonaji = 228081m },
                new Gemi { GemiId = 6, GemiAdi = "MSC Meraviglia", Tonaji = 171598m },
                new Gemi { GemiId = 7, GemiAdi = "Norwegian Escape", Tonaji = 165300m },
                new Gemi { GemiId = 8, GemiAdi = "Costa Smeralda", Tonaji = 185010m },
                new Gemi { GemiId = 9, GemiAdi = "AIDAnova", Tonaji = 183900m },
                new Gemi { GemiId = 10, GemiAdi = "Mardi Gras", Tonaji = 180000m },
                new Gemi { GemiId = 11, GemiAdi = "Regal Princess", Tonaji = 142714m },
                new Gemi { GemiId = 12, GemiAdi = "Majestic Princess", Tonaji = 143700m },
                new Gemi { GemiId = 13, GemiAdi = "Celebrity Edge", Tonaji = 130818m },
                new Gemi { GemiId = 14, GemiAdi = "MSC Seaview", Tonaji = 154000m },
                new Gemi { GemiId = 15, GemiAdi = "Carnival Vista", Tonaji = 133500m }
            };

            foreach (Gemi gemi in gemiler)
            {
                cbGemi.Items.Add(gemi);   //Gemiler listesindeki gemileri comboboxa ekler.
            }
        }

        private void LimanlariOlustur()
        {
            List<string> limanlar = new List<string>
            {
                "�stanbul Sar�yer Yat Liman�, T�rkiye",
                "�stanbul Be�ikta� Liman�, T�rkiye",
                "�stanbul Haydarpa�a Liman�, T�rkiye",
                "�stanbul Kad�k�y Liman�, T�rkiye",
                "�stanbul Karak�y Liman�, T�rkiye",
                "�stanbul Ambarl� Liman�, T�rkiye",
                "�stanbul Bak�rk�y Liman�, T�rkiye",
                "�zmir Alsancak Liman�, T�rkiye",
                "�zmir �e�me Liman�, T�rkiye",
                "�zmir Kar��yaka Liman�, T�rkiye",
                "�zmir Alia�a Liman�, T�rkiye",
                "Mersin Liman�, T�rkiye",
                "Antalya Liman�, T�rkiye",
                "Bodrum Liman�, T�rkiye",
                "G�cek Liman�, T�rkiye",
                "Fethiye Liman�, T�rkiye",
                "Ku�adas� Liman�, T�rkiye",
                "Trabzon Liman�, T�rkiye",
                "Samsun Liman�, T�rkiye",
                "Hopa Liman�, T�rkiye",
                "Port of Piraeus, Yunanistan",
                "Port of Thessaloniki, Yunanistan",
                "Port of Heraklion, Yunanistan",
                "Port of Patras, Yunanistan",
                "Port of Volos, Yunanistan",
                "Port of Genoa, �talya",
                "Port of Naples, �talya",
                "Port of Livorno, �talya",
                "Port of Civitavecchia, �talya",
                "Port of Venice, �talya",
                "Port of Marseille, Fransa",
                "Port of Le Havre, Fransa"
            };

            foreach (string liman in limanlar)
            {
                //limanlar listesindeki limanlar� comboboxlara ekler.
                cbCikisLimani.Items.Add(liman);
                cbUgradigiLiman.Items.Add(liman);
                cbVarisLimani.Items.Add(liman);
            }
        }

        private void ListViewTabloOlustur()
        {
            lvSeferler.View = View.Details;  //Detayl� g�r�n�m i�in
            lvSeferler.GridLines = true;    //�izgiler i�in

            //Ba�l�klar ekleniyor
            lvSeferler.Columns.Add("Id", 40);
            lvSeferler.Columns.Add("Gemi", 200, HorizontalAlignment.Center);  //Ortal� durmas� i�in 
            lvSeferler.Columns.Add("��k�� Tarihi", 140, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Var�� Tarihi", 140, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("��k�� Liman�", 225, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("U�rad��� Liman", 225, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Var�� Liman�", 225, HorizontalAlignment.Center);
        }

        private void FRMSeyirEkrani_Load(object sender, EventArgs e)
        {                                   //FORM Y�KLEN�RKEN
            GemileriOlustur(); //Gemileri comboboxda g�rmek i�in metodu �a��rd�k.
            LimanlariOlustur(); //Limanlar� comboboxda g�rmek i�in metodu �a��rd�k.
            ListViewTabloOlustur(); //Tabloyu ve ba�l�klar� g�rmek i�in metodu �a��rd�k
            dtpLimandanCikisTarihi.Select();
        }

        int id = 1;
        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            if (dtpLimandanCikisTarihi.Value.Date > dtpLimanaVarisTarihi.Value.Date) //Tarih kontrol�
            {
                MessageBox.Show("Geminin limana var�� tarihi, limandan ��k�� tarihinden erken olamaz!");
                return;
            }
            if (cbGemi.SelectedItem == null || cbCikisLimani.SelectedItem == null || cbUgradigiLiman.SelectedItem == null || cbVarisLimani.SelectedItem == null)  //Combobox se�ili olma kontrol�
            {
                MessageBox.Show("Gemi alan�, ��k�� liman�, u�rad��� liman ve var�� liman alanlar� se�ilmelidir!");
                return;
            }
            if (cbCikisLimani.SelectedItem == cbVarisLimani.SelectedItem || cbCikisLimani.SelectedItem == cbUgradigiLiman.SelectedItem || cbUgradigiLiman.SelectedItem == cbVarisLimani.SelectedItem)  //Limanlar�n e�it olma durum kontrol�
            {
                MessageBox.Show("Sefer s�ras�nda girilen duraklar farkl� olmak zorundad�r!");
                return;
            }

            SeyirKaydi seyirKaydi = new SeyirKaydi()
            {
                Gemi = cbGemi.SelectedItem as Gemi,
                LimandanCikisTarihi = dtpLimandanCikisTarihi.Value,
                LimanaVarisTarihi = dtpLimanaVarisTarihi.Value,
                CikisLimani = cbCikisLimani.SelectedItem.ToString(),
                UgrayacagiLiman = cbUgradigiLiman.SelectedItem.ToString(),
                VarisLimani = cbVarisLimani.SelectedItem.ToString()
            };
            SeyirKayitlari.Add(seyirKaydi); //static listemize seyir kayd�n� ekliyoruz.

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = (id++).ToString(); //Her sefer olu�turuldu�unda �st�ne ekleyerek yazar. (id = 1 ba�lang��)
            listViewItem.SubItems.Add(seyirKaydi.Gemi.ToString());
            listViewItem.SubItems.Add(seyirKaydi.LimandanCikisTarihi.ToShortDateString());
            listViewItem.SubItems.Add(seyirKaydi.LimanaVarisTarihi.ToShortDateString());
            listViewItem.SubItems.Add(seyirKaydi.CikisLimani);
            listViewItem.SubItems.Add(seyirKaydi.UgrayacagiLiman);
            listViewItem.SubItems.Add(seyirKaydi.VarisLimani);

            lvSeferler.Items.Add(listViewItem);

            Temizle();
        }

        private void Temizle()
        {
            //dtpLimandanCikisTarihi.Value = DateTime.Now; 
            dtpLimandanCikisTarihi.Value = DateTime.Today; //Varsay�lan olarak bug�n� ayarlar.
            dtpLimanaVarisTarihi.Value = DateTime.Today;
            cbGemi.SelectedIndex = -1; //(cbGemi.SelectedItem = null;)
            cbCikisLimani.SelectedIndex = -1;
            cbUgradigiLiman.SelectedIndex = -1;
            cbVarisLimani.SelectedIndex = -1;
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (SeyirKayitlari.Count > 0)
            {
                FRMGonderim fRMGonderim = new FRMGonderim(SeyirKayitlari);
                fRMGonderim.ShowDialog();
            }
            else
            {
                MessageBox.Show("L�tfen seyirlerinizi listeye ekleyiniz.");
            }
        }
    }
}
