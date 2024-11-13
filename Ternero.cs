using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGranaderia
{
    public class Ternero : Animal
    {
        public Toro Padre { get; set; }
        public Vaca Madre { get; set; }
        public double PesoDestete { get; set; }
        public double PesoAlNacer { get; set; }

        //METODOS

        //CONSTRUCTOR
        public Ternero() { }

        public Ternero(int codigo, string raza, DateTime fechaNacimiento, double pesoActual, int parcela, string nombre, double pesoDestete, double pesoAlNacer, Vaca Madre, Toro Padre) : base(codigo, raza, fechaNacimiento, pesoActual, parcela, nombre)
        {
            this.Padre = Padre;
            this.Madre = Madre;
        }
    }
}
