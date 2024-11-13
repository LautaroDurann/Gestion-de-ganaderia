using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGranaderia
{
    public abstract class Animal
    {
        //ATRIBUTOS
        public double pesoActual { get; set; } //** 
        public int codigo { get; set; } //**
        public string raza { get; set; } //**
        public string nombre { get; set; } 
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public int parcela { get; set; }
        public string caracteristicas { get; set; }
        public double PesoDestete { get; set; }
        public double PesoAlNacer { get; set; }

        //CONSTRUCTOR CON LO NECESARIO
        public Animal(int codigo, string raza, double pesoActual, int parcela)
        {
            this.codigo = codigo;
            this.raza = raza;
            this.pesoActual = pesoActual;
            this.parcela = parcela;
        }

        public Animal() { }

        //METODOS

        public void AsignarEdadyFechaNac(DateTime fechaNacimiento)
        { 
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
        }


    }
}
