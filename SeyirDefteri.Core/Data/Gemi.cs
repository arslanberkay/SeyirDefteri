using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core.Data
{
    public class Gemi
    {
        public int GemiId { get; set; }
        public string GemiAdi { get; set; }
        public decimal Tonaji { get; set; }

        public override string ToString()
        {
            return $"{GemiAdi} (Tonaj : {Tonaji})";
        }
    }
}
