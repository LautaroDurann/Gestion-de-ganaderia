using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGranaderia
{
    public class Campo
    {
        public List<Vaca> listaVacas {  get; set; }
        public  List<Toro> listaToros { get; set; }

        public Campo(List<Vaca> listvacas, List<Toro> listtoros) 
        {
            listaVacas = listvacas;
            listaToros = listtoros;
        }

    }
}
