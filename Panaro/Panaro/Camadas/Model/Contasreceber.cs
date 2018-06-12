using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.Model
{
    public class Contasreceber
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string dataabert { get; set; }
        public string datavenc { get; set; }
        public string valor { get; set; }
        public string pago { get; set; }
    }
}
