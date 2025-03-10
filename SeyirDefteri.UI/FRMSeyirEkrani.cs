using SeyirDefteri.Core.Data;

namespace SeyirDefteri.UI
{
    public partial class FRMSeyirEkrani : Form
    {
        public static List<SeyirKaydi> SeyirKayitlari = new List<SeyirKaydi>();  //Neden static? Bu neyi deðiþtirdi? 

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
                "Ýstanbul Sarýyer Yat Limaný, Türkiye",
                "Ýstanbul Beþiktaþ Limaný, Türkiye",
                "Ýstanbul Haydarpaþa Limaný, Türkiye",
                "Ýstanbul Kadýköy Limaný, Türkiye",
                "Ýstanbul Karaköy Limaný, Türkiye",
                "Ýstanbul Ambarlý Limaný, Türkiye",
                "Ýstanbul Bakýrköy Limaný, Türkiye",
                "Ýzmir Alsancak Limaný, Türkiye",
                "Ýzmir Çeþme Limaný, Türkiye",
                "Ýzmir Karþýyaka Limaný, Türkiye",
                "Ýzmir Aliaða Limaný, Türkiye",
                "Mersin Limaný, Türkiye",
                "Antalya Limaný, Türkiye",
                "Bodrum Limaný, Türkiye",
                "Göcek Limaný, Türkiye",
                "Fethiye Limaný, Türkiye",
                "Kuþadasý Limaný, Türkiye",
                "Trabzon Limaný, Türkiye",
                "Samsun Limaný, Türkiye",
                "Hopa Limaný, Türkiye",
                "Port of Piraeus, Yunanistan",
                "Port of Thessaloniki, Yunanistan",
                "Port of Heraklion, Yunanistan",
                "Port of Patras, Yunanistan",
                "Port of Volos, Yunanistan",
                "Port of Genoa, Ýtalya",
                "Port of Naples, Ýtalya",
                "Port of Livorno, Ýtalya",
                "Port of Civitavecchia, Ýtalya",
                "Port of Venice, Ýtalya",
                "Port of Marseille, Fransa",
                "Port of Le Havre, Fransa"
            };

            foreach (string liman in limanlar)
            {
                //limanlar listesindeki limanlarý comboboxlara ekler.
                cbCikisLimani.Items.Add(liman);
                cbUgradigiLiman.Items.Add(liman);
                cbVarisLimani.Items.Add(liman);
            }
        }

        private void ListViewTabloOlustur()
        {
            lvSeferler.View = View.Details;  //Detaylý görünüm için
            lvSeferler.GridLines = true;    //Çizgiler için

            //Baþlýklar ekleniyor
            lvSeferler.Columns.Add("Id", 40);
            lvSeferler.Columns.Add("Gemi", 200, HorizontalAlignment.Center);  //Ortalý durmasý için 
            lvSeferler.Columns.Add("Çýkýþ Tarihi", 140, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Varýþ Tarihi", 140, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Çýkýþ Limaný", 225, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Uðradýðý Liman", 225, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Varýþ Limaný", 225, HorizontalAlignment.Center);
        }

        private void FRMSeyirEkrani_Load(object sender, EventArgs e)
        {                                   //FORM YÜKLENÝRKEN
            GemileriOlustur(); //Gemileri comboboxda görmek için metodu çaðýrdýk.
            LimanlariOlustur(); //Limanlarý comboboxda görmek için metodu çaðýrdýk.
            ListViewTabloOlustur(); //Tabloyu ve baþlýklarý görmek için metodu çaðýrdýk
            dtpLimandanCikisTarihi.Select();
        }

        int id = 1;
        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            if (dtpLimandanCikisTarihi.Value.Date > dtpLimanaVarisTarihi.Value.Date) //Tarih kontrolü
            {
                MessageBox.Show("Geminin limana varýþ tarihi, limandan çýkýþ tarihinden erken olamaz!");
                return;
            }
            if (cbGemi.SelectedItem == null || cbCikisLimani.SelectedItem == null || cbUgradigiLiman.SelectedItem == null || cbVarisLimani.SelectedItem == null)  //Combobox seçili olma kontrolü
            {
                MessageBox.Show("Gemi alaný, çýkýþ limaný, uðradýðý liman ve varýþ liman alanlarý seçilmelidir!");
                return;
            }
            if (cbCikisLimani.SelectedItem == cbVarisLimani.SelectedItem || cbCikisLimani.SelectedItem == cbUgradigiLiman.SelectedItem || cbUgradigiLiman.SelectedItem == cbVarisLimani.SelectedItem)  //Limanlarýn eþit olma durum kontrolü
            {
                MessageBox.Show("Sefer sýrasýnda girilen duraklar farklý olmak zorundadýr!");
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
            SeyirKayitlari.Add(seyirKaydi); //static listemize seyir kaydýný ekliyoruz.

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = (id++).ToString(); //Her sefer oluþturulduðunda üstüne ekleyerek yazar. (id = 1 baþlangýç)
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
            dtpLimandanCikisTarihi.Value = DateTime.Today; //Varsayýlan olarak bugünü ayarlar.
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
                MessageBox.Show("Lütfen seyirlerinizi listeye ekleyiniz.");
            }
        }
    }
}
