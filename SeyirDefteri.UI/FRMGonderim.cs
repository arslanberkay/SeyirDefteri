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
                if (seyirKaydi.Gemi == null)
                {
                    MessageBox.Show("Sefer kayıtlarındaki gemi bilgisi eksik");
                    return;
                }
                cbSeyirKayitlari.Items.Add(seyirKaydi);
            }
        }

        private void FRMGonderim_Load(object sender, EventArgs e)
        {
            FirmalariOlustur();
            ListViewOlustur();
        }

        int id = 0, urunId = 1, ilgilenenKisiId = 0;
        private Gemi seciliGemi;
        private void btnGonderimOlustur_Click(object sender, EventArgs e)
        {
            Gonderim gonderim = new Gonderim();
            gonderim.Urun.UrunAdi = txtUrunAdi.Text;
            gonderim.IlgilenenKisi.KisininAdi = txtKisiAdi.Text;
            gonderim.IlgilenenKisi.KisininTelefonu = mtxtKisiTelefonNumarasi.Text;
            gonderim.IlgilenenKisi.BagliOlduguFirma = cbFirma.SelectedItem as Firma;
            gonderim.SeyirKaydi = cbSeyirKayitlari.SelectedItem as SeyirKaydi;
            gonderim.Tonaj = nudTonaj.Value;

        }
        private void FirmalariOlustur()
        {
            List<Firma> firmalar = new List<Firma>
        {
            new Firma{FirmaId=1, FirmaAdi="Amazon"},
            new Firma{FirmaId=2, FirmaAdi="Ebay"},
            new Firma{FirmaId=3, FirmaAdi="Wish"},
            new Firma{FirmaId=4, FirmaAdi="Alibaba"},
            new Firma{FirmaId=5, FirmaAdi="Banggood"},
            new Firma{FirmaId=6, FirmaAdi="n11"},
            new Firma{FirmaId=7, FirmaAdi="Trendyol"},
            new Firma{FirmaId=8, FirmaAdi="ÇiçekSepeti"},
            new Firma{FirmaId=9, FirmaAdi="Etsy"},

            };

            foreach (Firma firma in firmalar)
            {
                cbFirma.Items.Add(firma);
            }
        }

        private void Temizle()
        {
            cbFirma.SelectedItem = null;
            cbSeyirKayitlari.SelectedItem = null;
            txtKisiAdi.Text = txtUrunAdi.Text = mtxtKisiTelefonNumarasi.Text = string.Empty;
            nudTonaj.Value = 0;
        }

        private void ListViewOlustur()
        {
            lvGonderim.View = View.Details;
            lvGonderim.GridLines = true;
            lvGonderim.Columns.Add("ID", 50);
            lvGonderim.Columns.Add("Ürün", 150);
            lvGonderim.Columns.Add("Kişi ", 150);
            lvGonderim.Columns.Add("Telefon", 150);
            lvGonderim.Columns.Add("Firma", 150);
            lvGonderim.Columns.Add("Tonaj", 150);
        }



    }
}
