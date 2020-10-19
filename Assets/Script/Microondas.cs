using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    class Microondas : Climitacion
    {
        public Microondas(string modelo, float precio, string marca) : base(modelo, precio, marca)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.precio = precio;
        }
    }
}
