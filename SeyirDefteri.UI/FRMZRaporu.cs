using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2013.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
        private List<Gonderim> gonderimler; //2. formdan veri aktarımı yaptığım gönderim listesini bu listeye aktardım.

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
            lvGonderimZRaporu.View = View.Details; //Listview görünümünü detaylı hale getirmek için
            lvGonderimZRaporu.GridLines = true; //Hücrelere böldü.

            lvGonderimZRaporu.Columns.Add("Gemi Adı ", 200);  //ListView başlıklarını ekliyoruz.
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

            //gonderimler listemde dönüyorum ve istediğim şartları sağlayan gonderimleri filtrelenmisSeferler listesinin içine atıyorum.
            var filtrelenmisSeferler = gonderimler.Where(s => s.SeyirKaydi.LimandanCikisTarihi.Date >= cikisTarihi && s.SeyirKaydi.LimanaVarisTarihi.Date <= varisTarihi).ToList();

            foreach (Gonderim filtrelenmisSefer in filtrelenmisSeferler)
            {
                ListViewItem listViewItem = new ListViewItem(); //Listviewin içine itemlarını yerleştirmek için
                listViewItem.Text = filtrelenmisSefer.SeyirKaydi.Gemi.GemiAdi.ToString();
                listViewItem.SubItems.Add(filtrelenmisSefer.IlgilenenKisi.BagliOlduguFirma.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.Urun.UrunAdi.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.Tonaj.ToString());
                listViewItem.SubItems.Add((filtrelenmisSefer.SeyirKaydi.Gemi.Tonaji - filtrelenmisSefer.Tonaj).ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.IlgilenenKisi.KisininAdi.ToString());
                listViewItem.SubItems.Add(filtrelenmisSefer.SeyirKaydi.LimandanCikisTarihi.ToString("dd/MM/yyyy")); //MMM olsa Mart yazıyor.
                listViewItem.SubItems.Add(filtrelenmisSefer.SeyirKaydi.LimanaVarisTarihi.ToString());

                if (filtrelenmisSefer.SeyirKaydi.Gemi.Tonaji < filtrelenmisSefer.Tonaj)
                {
                    MessageBox.Show("Gemi tonajından fazla yük yüklenemez");
                    return;
                }

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
        private void ExcelDosyasiOlustur() //ClosedXML kütüphanesini kullanarak ListView kontrolündeki verileri bir Excel dosyasına aktardım.
        {
            using (var workbook = new XLWorkbook())//Yeni bir Excel çalışma kitabı oluşturuluyor.
            {
                var workSheet = workbook.AddWorksheet("ZRaporu"); //Workbook içine ZRaporu adında yeni bir çalışma sayfası ekledim.

                //Başlık satırlarını ekledim.
                workSheet.Cell(1, 1).Value = "Gemi Adı";
                workSheet.Cell(1, 2).Value = "Firma Adı";
                workSheet.Cell(1, 3).Value = "Ürün Adı";
                workSheet.Cell(1, 4).Value = "Ürün Yükü";
                workSheet.Cell(1, 5).Value = "Kalan Tonaj";
                workSheet.Cell(1, 6).Value = "İlgilenen Kişi Adı";
                workSheet.Cell(1, 7).Value = "Limandan Çıkış Tarihi";
                workSheet.Cell(1, 8).Value = "Limana Varış Tarihi";

                int satir = 2; //lvgonderim adlı ListView kontrolünde bulunan veriler döngü ile Excel'e yazılıyor.
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

                //Excel Dosyasının Kaydedilmesi
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) //Kullanıcıdan Excel dosyasını kaydetmek istediği yeri seçmesi için bir SaveFileDiolog penceresi açılıyor.
                {
                    saveFileDialog.Filter = "Excel Files|*xlsx"; //Sadece .xlsx uzantılı dosyaların kaydedilmesine izin veriliyor.
                    saveFileDialog.Title = "Excel Dosyasını Kaydet"; //Pencere başlığı 
                    saveFileDialog.FileName = $"ZRaporu{excelDosyaNumarasi++}.xlsx"; //Varsayılan dosa adı ayarlanıyor.

                    //Kullanıcının seçtiği konuma kaydetme
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) //Kullanıcı dosya kaydetme işlemini onaylarsa
                    {
                        string filePath = saveFileDialog.FileName; //Dosyanın kaydedileceği yolu alır.
                        workbook.SaveAs(filePath); //Excel dosyası belirtilen konuma kaydedilir.
                        MessageBox.Show("Excel başarıyla oluşturuldu.");
                    }
                }
            }
        }

        private void btnExcelDosyasiOlustur_Click(object sender, EventArgs e)
        {
            ExcelDosyasiOlustur();
        }

        private void PDFOlustur()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog(); //Kullanıcının dosya kaydetmek için bir konum seçmesini sağlayan bir pencere açar.
                saveFileDialog.Filter = "PDF Dosyası|*.pdf"; //Sadece .pdf uzantılı dosyalar kaydedilebilir.
                saveFileDialog.Title = "PDF Dosyası Kaydet"; //Pencerenin başlığı

                if (saveFileDialog.ShowDialog() == DialogResult.OK) //Kullanıcı bir konum seçerse işlemi başlat
                {
                    Document document = new Document(); //PDF belgesi oluşturulur.
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create)); //Belirlenen dosya yoluna PDF dosyası oluşturulur.
                    document.Open(); //PDF dosyası açılır ve içerisine veri yazmaya hazır hale gelir.

                    //PDF içinde tablo oluşturmak için
                    PdfPTable table = new PdfPTable(lvGonderimZRaporu.Columns.Count); //ListView'deki sütun sayısı kadar sütun içeren bir tablo oluşturur.
                    table.WidthPercentage = 100; //Tabloyu sayfa genişliğine tam olarak yayar.

                    //ListView başlıklarını PDF'e eklemek
                    foreach (ColumnHeader column in lvGonderimZRaporu.Columns) //ListView'deki tüm sütun başlıklarını döner.
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text)); //Sütun başlıklarını içeren hücreler oluşturur.
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY; // Başlıkları gri renkle vurgular.
                        table.AddCell(cell); //Hücreyi tabloya ekler.
                    }

                    //ListView içeriğini PDF'e eklemek
                    foreach (ListViewItem listViewItem in lvGonderimZRaporu.Items) //ListView içindeki her bir satırı döner.
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in listViewItem.SubItems) //Satırın tüm hücrelerini döner
                        {
                            table.AddCell(subItem.Text); //Hücre içeriğini tabloya ekler.
                        }
                    }

                    document.Add(table); //Tabloyu PDF'e ekler.
                    document.Close(); //PDF belgesini kapatır ve kaydeder.

                    MessageBox.Show("PDF başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata : {ex.Message}");
            }
        }

        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            PDFOlustur();
        }
    }
}
