using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoFinal
{

    public class Productos
    {
        public int IndiceBand { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public string Precio { get; set; }

        public Productos(int indiceBand, int id, string nombre, int cantidad, string precio)
        {
            IndiceBand = indiceBand;
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Cantidad: {Cantidad}";
        }
    }
}
