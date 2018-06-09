using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.BLL
{
    public class Venda
    {
        public List<Model.Venda> Select()
        {
            DAL.Venda dalVen = new DAL.Venda();
            return dalVen.Select();
        }

        public List<Model.Venda> SelectById(int id_comanda)
        {
            DAL.Venda dalVen = new DAL.Venda();
            return dalVen.SelectById(id_comanda);
        }
    }
}
