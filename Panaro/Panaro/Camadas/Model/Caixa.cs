using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.Model
{
    public class Caixa
    {
        public int id { get; set; }
        public string cliente { get; set; }
        public DateTime data { get; set; }
        public string total { get; set; }

    }
}
