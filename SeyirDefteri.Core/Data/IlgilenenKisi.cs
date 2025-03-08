using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core.Data
{
    public class IlgilenenKisi
    {
        public int IlgilenenKisiId { get; set; }
        public string KisininAdi { get; set; }
        public string KisininTelefonu { get; set; }
        public Firma BagliOlduguFirma { get; set; }
    }
}
