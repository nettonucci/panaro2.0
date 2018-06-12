using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.Model
{
    public class Venda
    {
        public int id { get; set; }
        public int id_comanda { get; set; }
        public int id_produto { get; set; }
        public string descricao { get; set; }
        public string valor { get; set; }
        public int quantidade { get; set; }

    }
}
