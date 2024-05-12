using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySvetlizaEtapa2
{
    internal class clsVehiculo
    {   
        public string nombre { get; set; }
        public string tipo { get; set; }
        public Image imagen { get; set; }

        public clsVehiculo(string nom, string tip, Image imag)
        {
            nom = nombre;
            tip = tipo;
            imag = imagen;
        }
        public void crearVehiculo()
        {
            MessageBox.Show($"Vehículo creado: {nombre}, Tipo: {tipo}");
        }
    }

}
