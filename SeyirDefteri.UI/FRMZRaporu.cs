using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2013.Excel;
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
            lvGonderimZRaporu.Columns.Add("Ürün Yükü", 200, HorizontalAlignment.Center);
            lvGonderimZRaporu.Columns.Add("Kalan Tonaj", 200, HorizontalAlignment.Center);
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

            var filtrelenmisSeferler = gonderimler.Where(s => s.SeyirKaydi.LimandanCikisTarihi.Date >= cikisTarihi && s.SeyirKaydi.LimanaVarisTarihi.Date <= varisTarihi).ToList();

            foreach (Gonderim filtrelenmisSefer in filtrelenmisSeferler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = filtrelenmisSefer.SeyirKaydi.Gemi.GemiAdi.ToString();
                listViewItem.SubItems.Add(filtrelenmisSefer.IlgilenenKisi.BagliOlduguFirma.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.Urun.UrunAdi.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.Tonaj.ToString());
                listViewItem.SubItems.Add((filtrelenmisSefer.SeyirKaydi.Gemi.Tonaji - filtrelenmisSefer.Tonaj).ToString());
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

        int excelDosyaNumarasi = 0;
        private void btnExcelDosyasiOlustur_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.AddWorksheet("ZRaporu");

                workSheet.Cell(1, 1).Value = "Gemi Adı";
                workSheet.Cell(1, 2).Value = "Firma Adı";
                workSheet.Cell(1, 3).Value = "Ürün Adı";
                workSheet.Cell(1, 4).Value = "Ürün Yükü";
                workSheet.Cell(1, 5).Value = "Kalan Tonaj";
                workSheet.Cell(1, 6).Value = "İlgilenen Kişi Adı";
                workSheet.Cell(1, 7).Value = "Limandan Çıkış Tarihi";
                workSheet.Cell(1, 8).Value = "Limana Varış Tarihi";

                int satir = 2;
                foreach (ListViewItem item in lvGonderimZRaporu.Items)
                {
                    workSheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                    workSheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                    workSheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                    workSheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                    workSheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                    workSheet.Cell(satir, 6).Value = item.SubItems[5].Text;
                    workSheet.Cell(satir, 7).Value = item.SubItems[6].Text;
                    workSheet.Cell(satir, 8).Value = item.SubItems[7].Text;
                    satir++;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*xlsx";
                    saveFileDialog.Title = "Excel Dosyasını Kaydet";
                    saveFileDialog.FileName = $"ZRaporu{excelDosyaNumarasi++}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Excel başarıyla oluşturuldu.");
                    }
                }
            }
        }
    }
}
