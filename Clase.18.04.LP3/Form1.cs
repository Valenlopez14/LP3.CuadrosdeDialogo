using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase._18._04.LP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            //cuadro d dialogo para cambiar el color del formulario 
            CDcolor.ShowDialog();
            //comando para que se guarde el color en el formulario 
            this.BackColor = CDcolor.Color;

        }

        private void btnCambioFuente_Click(object sender, EventArgs e)
        {   
            //Cuadro d dialogo para cambiar la fuente de una lbl
            FDfuente.ShowDialog();
            //comando para guardar el cambio de fuente
            label1.Font = FDfuente.Font;
        }

        private void btnElegirCarpeta_Click(object sender, EventArgs e)
        {
            FBcarpeta.ShowDialog();
            MessageBox.Show(FBcarpeta.SelectedPath);
        }

        private void btnElegirarchivo_Click(object sender, EventArgs e)
        {
            //Para q la ruta de la carpeta este vacia al inicializar
            OFarchivo.FileName = "";
            //Filtrar para que busque solo los archivos txt o pdf o lo q filtremos
            OFarchivo.Filter = "Archivos.cmj |*.txt | Archivos.Acrpbat | *.pdf";
            OFarchivo.ShowDialog();
            MessageBox.Show(OFarchivo.FileName);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SFGuardar.ShowDialog();
            MessageBox.Show(SFGuardar.FileName);
        }
    }
}
