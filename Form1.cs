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
            
          }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVehiculo_Click_1(object sender, EventArgs e)
        {
            
            // cargar imagen
            Image[] imagenes = { Properties.Resources.auto, Properties.Resources.barco, Properties.Resources.avion };

            // Generamos un número aleatorio para seleccionar una imagen y tipo de vehículo
            Random rnd = new Random();
            int index = rnd.Next(0, imagenes.Length);

            // Creamos el vehículo con el tipo correspondiente y la imagen seleccionada aleatoriamente
            clsVehiculo vehiculo = new clsVehiculo("Vehículo " + (index + 1), index == 0 ? "Auto" : index == 1 ? "Barco" : "Avión", imagenes[index]);
            vehiculo.crearVehiculo();

            // para que se muestre la imagen en el picturebox
            pctVehiculo.Image = vehiculo.imagen;
        }
    }
    
}
