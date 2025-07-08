using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB210240
{
    public class Nastava
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public Prostorija Prostorija { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public DateTime Vrijeme { get; set; }
        public string DanOdrzavanjaNastave { get; set; }
        public string Oznaka { get; set; }
    }
}
