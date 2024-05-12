using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySvetlizaEtapa2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //habilita el manejo de eventos de teclado
            this.KeyPreview = true;
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click_1(object sender, EventArgs e)
        {
            //crea la imagen
            Image[] imagenes = { Properties.Resources.auto, Properties.Resources.barco, Properties.Resources.avion };
            // Genera un número aleatorio para seleccionar una imagen y tipo de vehículo
            Random rnd = new Random();
            int index = rnd.Next(0, imagenes.Length);

            // Crea el vehículo con el tipo correspondiente y la imagen seleccionada aleatoriamente
            clsVehiculo vehiculo = new clsVehiculo("Vehículo " + (index + 1), index == 0 ? "Auto" : index == 1 ? "Barco" : "Avión", imagenes[index]);
            vehiculo.crearVehiculo();

            // para que se muestre la imagen en el picturebox
            pctVehiculo.Image = vehiculo.imagen;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C: // Tecla "C" para el auto
                    CambiarImagen(Properties.Resources.auto);
                    break;
                case Keys.B: // Tecla "B" para el barco
                    CambiarImagen(Properties.Resources.barco);
                    break;
                case Keys.P: // Tecla "P" para el avión
                    CambiarImagen(Properties.Resources.avion);
                    break;
                default:
                    // Si se presiona una tecla diferente, no se hace nada
                    break;

            }
        }
        private void CambiarImagen(Image nuevaImagen)
        {
            // Asignar la nueva imagen al PictureBox
            pctVehiculo.Image = nuevaImagen;
        }

    }
}