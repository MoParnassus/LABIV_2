﻿using System;
using System.Collections.Generic;

namespace LABIV_2.ZNorthwindModel
{
    public partial class Kategorie
    {
        public Kategorie()
        {
            Produkty = new HashSet<Produkty>();
        }

        public int Idkategorii { get; set; }
        public string NazwaKategorii { get; set; }
        public string Opis { get; set; }
        public byte[] Rysunek { get; set; }

        public virtual ICollection<Produkty> Produkty { get; set; }
    }
}
