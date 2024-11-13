using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGranaderia
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            panelSubMenuGanados.Visible = false;
            pnlIndicador1.Visible = false;
            pnlIndicador2.Visible = false;
            mostrarPanel(pnlBienvenida);

            listVacas = new List<Vaca>();
            listToros = new List<Toro>();

            campo = new Campo(listVacas, listToros);
        }

        private List<Vaca> listVacas { get; set; }
        private List<Toro> listToros { get; set; }

        private Campo campo { get; set; }

        //-----------------------------METODOS-----------------------------

        //Este metodo recibe como parametro el panel que se desea mostrar, oculta todos los demas y muestra el que queremos
        private void mostrarPanel(Panel panel)
        {
            pnlBienvenida.Visible = false;
            pnlToros.Visible = false;
            pnlVacas.Visible = false;
            pnlTerneros.Visible = false;
            pnlReproduccion.Visible = false;
            pnlVentas.Visible = false;
            pnlHistVeterinario.Visible = false;

            panel.Visible = true;
        }

        //Este metodo recibe como parametro el panel submenu de ganados y lo visualiza o lo oculta segun queramos
        //(Lo usamos cuando hacemos uso del boton "Ganados" y se despliega los botones de "Vacas", "Toros"
        //y Terneros respectivamente)
        private void verSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
                pnlIndicador2.Visible = false;
            }
            else
            {
                subMenu.Visible = true;
                if (pnlToros.Visible == true || pnlVacas.Visible == true || pnlTerneros.Visible == true)
                {
                    pnlIndicador2.Visible = true;
                }
            }
        }

        //Este metodo es simplemente para controlar la linea vertical (indicador)
        //que figura alado del boton que seleccionamos en el menu izquiero (meramente estetico)
        private void mostrarIndicador(Panel indicador, Button boton)
        {
            indicador.Visible = true;
            indicador.Height = boton.Height;
            indicador.Top = boton.Top;
        }

        //-----------------------------BOTONES-----------------------------

        private void botonToros_Click(object sender, EventArgs e) //Boton de toros
        {
            mostrarIndicador(pnlIndicador2, btnToro);
            pnlIndicador1.Visible = false;
            mostrarPanel(pnlToros);
        }

        private void botonVacas_Click(object sender, EventArgs e) //Boton de vaca
        {
            mostrarIndicador(pnlIndicador2, btnVaca);
            pnlIndicador1.Visible = false;
            mostrarPanel(pnlVacas);
        }

        private void botonTerneros_Click(object sender, EventArgs e) //Boton de ternero
        {
            mostrarIndicador(pnlIndicador2, btnTernero);
            pnlIndicador1.Visible = false;
            mostrarPanel(pnlTerneros);
        }

        private void botonGanado_Click(object sender, EventArgs e) //Boton de ganado
        {
            verSubMenu(panelSubMenuGanados);
            if (pnlReproduccion.Visible == true)
            {
                mostrarIndicador(pnlIndicador1, btnReproduccion);
            }
            if (pnlHistVeterinario.Visible == true)
            {
                mostrarIndicador(pnlIndicador1, btnHistVeterinario);
            }
            if (pnlVentas.Visible == true)
            {
                mostrarIndicador(pnlIndicador1, btnVentas);
            }
        }

        private void botonReproduccion_Click(object sender, EventArgs e) //Boton de reproduccion
        {
            mostrarIndicador(pnlIndicador1, btnReproduccion);
            pnlIndicador2.Visible = false;
            mostrarPanel(pnlReproduccion);
        }

        private void botonHistVeterinario_Click(object sender, EventArgs e) //Boton de reproduccion
        {
            mostrarIndicador(pnlIndicador1, btnHistVeterinario);
            pnlIndicador2.Visible = false;
            mostrarPanel(pnlHistVeterinario);
        }

        private void botonVentas_Click(object sender, EventArgs e) //Boton de ventas
        {
            mostrarIndicador(pnlIndicador1, btnVentas);
            pnlIndicador2.Visible = false;
            mostrarPanel(pnlVentas);
        }

        //-----------------------------PANEL DE VACAS-----------------------------
        public Vaca vaca { get; set; }

        // Metodo para recivir un objeto vaca del formulario exterior "FormNuevaVaca",
        // agregarlo a la lista de vacas y al datagridview
        public void recivirVaca(Vaca vaca)
        {
            this.vaca = vaca;


            campo.listaVacas.Add(vaca);

            dataGridViewVacas.Rows.Add(vaca.codigo, vaca.nombre, vaca.parcela, vaca.raza, vaca.pesoActual);
        }

        private void btnAgregarVaca_Click(object sender, EventArgs e)
        {
            FormNuevaVaca formNuevaVaca = new FormNuevaVaca(this);


            formNuevaVaca.ShowDialog();
        }
    }
}
