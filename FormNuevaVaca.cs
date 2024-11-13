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
    public partial class FormNuevaVaca : Form
    {
        private PantallaPrincipal frmMain;
        public FormNuevaVaca(PantallaPrincipal frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vaca vaca = new Vaca(int.Parse(txbCodigo.Text), txbRaza.Text, double.Parse(txbPeso.Text), int.Parse(txbParcela.Text));

            //Le mando el objeto vaca que cree al formulario principal
            frmMain.recivirVaca(vaca);
            //MessageBox.Show(vaca.codigo + " " + vaca.raza + " " + vaca.pesoActual + " " + vaca.parcela);

            this.Close();
        }
    }
}
