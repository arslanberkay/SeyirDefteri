﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core.Data
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }

        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
