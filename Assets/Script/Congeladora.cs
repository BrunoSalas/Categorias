using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    class Congeladora : Refrigeracion
    {
        public int cantidad;

        public Congeladora(string modelo, float precio, string marca) : base(modelo, precio, marca)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.precio = precio;
        }

        public void Congelar(Cant cantidad)
        { }
    }
}
