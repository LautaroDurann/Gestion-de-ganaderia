using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GestionGranaderia
{
    public class Vaca : Animal
    {
        public string valorMadre { get; set; }
        public DateTime fechaEmbarazo { get; set; }
        public DateTime fechaFuturoParto { get; set; }
        public int numeroEmbarazos { get; set; }
        public List <DateTime> listFechasEmbarazos { get; set; }
        public List<Parto> historialPartos { get; set; }
        public int numerosPartosVivos { get; set; }
        public int numerosPartosMuertos { get; set; }
        public bool Preñada { get; set; }

        //METODOS

        //CONSTRUCTOR 
        //Heredar constructor de clase Animal con base
        public Vaca(int codigo, string raza, double pesoActual, int parcela) : base(codigo, raza, pesoActual, parcela)
        {
            this.numerosPartosVivos = 0;
            this.numerosPartosMuertos = 0;
            this.valorMadre = "NO VALOR";
        }

        public Vaca() { }

        public void RegistrarParto(Parto parto)
        {
            if (parto.terneroVivo == true)
            {
                numerosPartosVivos++;
            }
            else
            {
                numerosPartosMuertos++;
            }
            historialPartos.Add(parto);
        }

        public void RegistrarEmbarazo(DateTime fechaEmbarazo, Toro toroPadre)
        {
            this.fechaEmbarazo = fechaEmbarazo;
            this.fechaFuturoParto= fechaEmbarazo.AddMonths(9).AddDays(10); 
            toroPadre.preñasRealizadas++;
            
            numeroEmbarazos++;
            listFechasEmbarazos.Add(fechaEmbarazo);
        }
        
        public void CalcularBuenaMadre()
        {
            int abortos;
            if (Preñada == true)
            {
                abortos = (numeroEmbarazos - (numerosPartosVivos + numerosPartosMuertos)) - 1;
            }

            else
            { 
                abortos = numeroEmbarazos - (numerosPartosVivos + numerosPartosMuertos);
            }
            //int totalListas = numerosPartosMuertos + numerosPartosVivos;
            int diasdesdesdeultimoparto = (int)(DateTime.Today - listFechasEmbarazos.Last()).TotalDays;
            if (diasdesdesdeultimoparto >= 730 || numerosPartosMuertos >= (numerosPartosVivos + numerosPartosMuertos) / 2 || abortos > (numerosPartosVivos + numerosPartosMuertos) / 4)
            {
                valorMadre = "Mala Madre";
            }
            else
            {
                valorMadre = "Buena Madre";
            }



            /*
            if (totalListas > 0)
            
                double porcentajeValor=(double)totalListas/NumeroEmbarazos;
                if (porcentajeValor > 0.75)
                {
                    valorMadre = "Buena Madre";
                }
                else
                {
                    valorMadre = "Mala Madre";
                }
            }
            */
            
        }


    }
}
