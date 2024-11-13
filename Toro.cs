using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGranaderia
{
    public class Toro : Animal
    {
        //ATRIBUTOS
        public string temperamento { get; set; }
        public int preñasRealizadas { get; set; }

        //METODOS

        //CONSTRUCTOR
        public Toro(int codigo, string raza, double pesoActual, int parcela) : base(codigo, raza, pesoActual, parcela)
        {
        }
    }
}
