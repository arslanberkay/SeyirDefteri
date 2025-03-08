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
