using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _KitapDukkani
{
    class Kitap
    {
        public string kitapadi { get; set; }
        public string kitaptürü { get; set; }
        public int sayfasayısı { get; set; }
        public decimal kitapfiyati { get; set; }
        public yazar yazari { get; set; }
    }
}
