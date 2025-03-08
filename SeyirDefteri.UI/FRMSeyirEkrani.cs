using SeyirDefteri.Core.Data;

namespace SeyirDefteri.UI
{
    public partial class FRMSeyirEkrani : Form
    {
        public FRMSeyirEkrani()
        {
            InitializeComponent();
        }

        private void GemileriOlustur()
        {
            List<Gemi> gemiler = new List<Gemi>()
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

            foreach (var gemi in gemiler)
            {
                cbGemi.Items.Add(gemi);
            }
        }

        private void LimanlariOlustur()
        {
            List<string> limanlar = new List<string>()
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

            foreach (var liman in limanlar)
            {
                cbCikisLimani.Items.Add(liman);
                cbUgradigiLiman.Items.Add(liman);
                cbVarisLimani.Items.Add(liman);
            }

        }


        private void FRMSeyirEkrani_Load(object sender, EventArgs e)
        {
            GemileriOlustur();
            LimanlariOlustur();
        }
    }
}
