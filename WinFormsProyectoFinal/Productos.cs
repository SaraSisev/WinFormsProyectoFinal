using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoFinal
{

    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Productos(int id, string nombre, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Cantidad: {Cantidad}";
        }
    }
}
