﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB210240
{
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }
        public Semestar Semestar { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
