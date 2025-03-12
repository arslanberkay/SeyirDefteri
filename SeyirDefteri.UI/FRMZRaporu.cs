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
    public partial class FRMZRaporu : Form
    {
        private List<Gonderim> gonderimler;

        public FRMZRaporu()
        {
            InitializeComponent();

        }

        public FRMZRaporu(List<Gonderim> gonderimlerT) : this()
        {
            gonderimler = gonderimlerT;
        }

        private void ListViewTabloOlustur()
        {
            lvGonderimZRaporu.View = View.Details;
            lvGonderimZRaporu.GridLines = true;

            lvGonderimZRaporu.Columns.Add("Gemi Adı ", 200);
            lvGonderimZRaporu.Columns.Add("Firma Adı", 200, HorizontalAlignment.Center);
            lvGonderimZRaporu.Columns.Add("Ürün Adı", 200, HorizontalAlignment.Center);
            lvGonderimZRaporu.Columns.Add("Tonaj", 200, HorizontalAlignment.Center);
            lvGonderimZRaporu.Columns.Add("İlgilenen Kişi Adı", 200, HorizontalAlignment.Center);
            lvGonderimZRaporu.Columns.Add("Limandan Çıkış Tarihi", 200, HorizontalAlignment.Center);
            lvGonderimZRaporu.Columns.Add("Limana Varış Tarihi", 200, HorizontalAlignment.Center);
        }

        private void FRMZRaporu_Load(object sender, EventArgs e)
        {
            ListViewTabloOlustur();
            Guncelle(DateTime.Today, DateTime.Today);
        }

        private void Guncelle(DateTime cikisTarihi, DateTime varisTarihi)
        {
            lvGonderimZRaporu.Items.Clear();

            var filtrelenmisSeferler = gonderimler.Where(s => s.SeyirKaydi.LimandanCikisTarihi >= cikisTarihi && s.SeyirKaydi.LimanaVarisTarihi <= varisTarihi).ToList();

            foreach (Gonderim filtrelenmisSefer in filtrelenmisSeferler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = filtrelenmisSefer.SeyirKaydi.Gemi.ToString();
                listViewItem.SubItems.Add(filtrelenmisSefer.IlgilenenKisi.BagliOlduguFirma.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.Urun.UrunAdi.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.Tonaj.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.IlgilenenKisi.KisininAdi.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.SeyirKaydi.LimandanCikisTarihi.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.SeyirKaydi.LimanaVarisTarihi.ToString());

                lvGonderimZRaporu.Items.Add(listViewItem);
            }
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            Guncelle(dtpCikisTarihi.Value.Date, dtpVarisTarihi.Value.Date);
        }

        private void dtpVarisTarihi_ValueChanged(object sender, EventArgs e)
        {
            Guncelle(dtpCikisTarihi.Value.Date, dtpVarisTarihi.Value.Date);
        }
    }
}
