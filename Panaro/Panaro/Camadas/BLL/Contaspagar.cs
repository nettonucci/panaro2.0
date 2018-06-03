using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.BLL
{
    public class Contaspagar
    {
        public List<Model.Contaspagar> Select()
        {
            DAL.Contaspagar dalCont = new DAL.Contaspagar();
            return dalCont.Select();
        }

        public List<Model.Contaspagar> SelectById(int id)
        {
            DAL.Contaspagar dalCont = new DAL.Contaspagar();
            return dalCont.SelectById(id);
        }

        public List<Model.Contaspagar> SelectByDesc(string descricao)
        {
            DAL.Contaspagar dalCont = new DAL.Contaspagar();
            return dalCont.SelectByDesc(descricao);
        }
    }
}