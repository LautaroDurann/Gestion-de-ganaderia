using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGranaderia
{
    public class Parto
    {
        //ATRIBUTOS

        public DateTime fechaParto { get; set; }
        public bool terneroVivo { get; set; }  // true si el ternero nació vivo, false si no
        public Animal ternero {  get; set; }

        //METODOS

        //CONSTRUCTOR PARA PARTO VIVO (ademas de los datos del parto, le paso los datos para crear un objeto ternero)
        public Parto(DateTime fechaParto, int codigo, string raza, DateTime fechaNacimiento, double pesoActual, int parcela, string nombre, double pesoDestete, double pesoAlNacer, Vaca Madre, Toro Padre, string sexo)
        {
            this.fechaParto = fechaParto;
            this.terneroVivo = true;

            if(sexo == "HEMBRA")
            {
                Vaca vacaTernera = new Vaca(codigo, raza, pesoActual, parcela);
            }
            else
            {
                Toro toroTernero = new Toro(codigo, raza, pesoActual, parcela);
            }
            
        }

        //CONSTRUCTOR PARA PARTO MUERTO
        public Parto(DateTime fechaParto)
        {
            this.fechaParto = fechaParto;
            this.terneroVivo = false;
        }
    }
}
