using SeyirDefteri.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyirDefteri.UI
{
    public partial class FRMGonderim : Form
    {
        public FRMGonderim()
        {
            InitializeComponent();
        }

        public FRMGonderim(List<SeyirKaydi> seyirKayitlari) : this()
        {
            foreach (SeyirKaydi seyirKaydi in seyirKayitlari)
            {
                if (seyirKaydi.Gemi == null)  //Bu forma geçme şartı gönderilen verilerdeki listenin eleman sayısının 0 dan büyük olmasıydı. Listeye eklenen seyirkaydınında eklenmesi için geminin seçilmiş olması gerekiyordu. Neden bunu kontrol ediyoruz? 
                {
                    MessageBox.Show("Sefer kayıtlarındaki gemi bilgisi eksik");
                    return;
                }
                cbSeyirKayitlari.Items.Add(seyirKaydi);
            }
        }

        private void FirmalariOlustur()
        {
            List<Firma> firmalar = new List<Firma>
        {
            new Firma{FirmaId=1, FirmaAdi="Amazon"},
            new Firma{FirmaId=2, FirmaAdi="Etsy"},
            new Firma{FirmaId=3, FirmaAdi="Ebay"},
            new Firma{FirmaId=4, FirmaAdi="Wish"},
            new Firma{FirmaId=5, FirmaAdi="Alibaba"},
            new Firma{FirmaId=6, FirmaAdi="Banggood"},
            new Firma{FirmaId=7, FirmaAdi="n11"},
            new Firma{FirmaId=8, FirmaAdi="Trendyol"},
            new Firma{FirmaId=9, FirmaAdi="ÇiçekSepeti"},
            new Firma{FirmaId=10, FirmaAdi="Bonanza"},
            new Firma{FirmaId=11, FirmaAdi="ModCloth"},
            new Firma{FirmaId=12, FirmaAdi="Wayfair"},
            new Firma{FirmaId=13, FirmaAdi="Runway"},
            new Firma{FirmaId=14, FirmaAdi="Shein"},
            new Firma{FirmaId=15, FirmaAdi="Farfetch"},
            new Firma{FirmaId=16, FirmaAdi="Macy's"},
            new Firma{FirmaId=17, FirmaAdi="LightInTheBox"},
            new Firma{FirmaId=18, FirmaAdi="Shein"},
            new Firma{FirmaId=19, FirmaAdi="ASOS"},
            new Firma{FirmaId=20, FirmaAdi="Zalando"},
        };

            foreach (Firma firma in firmalar)
            {
                cbFirma.Items.Add(firma); //firmalar listemin içindeki Firma tipindeki firmalar comboboxa eklendi.
            }
        }

        private void ListViewTabloOlustur()
        {
            lvGonderim.View = View.Details;
            lvGonderim.GridLines = true;

            lvGonderim.Columns.Add("ID", 50);
            lvGonderim.Columns.Add("Ürün", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Kişi ", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Telefon", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Firma", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Tonaj", 150, HorizontalAlignment.Center);
        }

        private void FRMGonderim_Load(object sender, EventArgs e)
        {
            //Form yüklenirken
            FirmalariOlustur();
            ListViewTabloOlustur();
        }

        int id = 0, urunId = 1, ilgilenenKisiId = 0;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cbSeyirKayitlari.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sefer seçiniz!");
                return;
            }
            if (cbFirma.SelectedItem == null)
            {
                MessageBox.Show("Lütfen firma seçiniz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKisiAdi.Text) || string.IsNullOrWhiteSpace(mtxtKisiTelefonNumarasi.Text))
            {
                MessageBox.Show("Kişi adı veya telefon numarası boş olamaz!");
                return;
            }

            SeyirKaydi seyirKaydi = cbSeyirKayitlari.SelectedItem as SeyirKaydi;

            if (nudTonaj.Value > seyirKaydi.Gemi.Tonaji)
            {
                MessageBox.Show("Geminin tonajından büyük bir değer girilemez!");
                return;
            }

            Gonderim gonderim = new Gonderim();
            gonderim.SeyirKaydi = seyirKaydi;

            gonderim.Urun = new Urun();
            gonderim.Urun.UrunId = urunId++;
            gonderim.Urun.UrunAdi = txtUrunAdi.Text;

            gonderim.IlgilenenKisi = new IlgilenenKisi();
            gonderim.IlgilenenKisi.IlgilenenKisiId = ilgilenenKisiId++;
            gonderim.IlgilenenKisi.KisininAdi = txtKisiAdi.Text;
            gonderim.IlgilenenKisi.KisininTelefonu = mtxtKisiTelefonNumarasi.Text;
            gonderim.IlgilenenKisi.BagliOlduguFirma = cbFirma.SelectedItem as Firma;

            gonderim.Tonaj = nudTonaj.Value;



        }

        private void Temizle()
        {
            cbFirma.SelectedItem = null;
            cbSeyirKayitlari.SelectedItem = null;
            txtKisiAdi.Text = txtUrunAdi.Text = mtxtKisiTelefonNumarasi.Text = string.Empty;
            nudTonaj.Value = 0;
        }




    }
}
