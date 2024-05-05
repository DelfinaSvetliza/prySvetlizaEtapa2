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

        public clsVehiculo(string nombre, string tipo, Image imagen)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.imagen = imagen;
        }
        public void crearVehiculo()
        {
            
            Console.WriteLine($"Vehículo creado: {nombre}, Tipo: {tipo}");
        }
    }

}
