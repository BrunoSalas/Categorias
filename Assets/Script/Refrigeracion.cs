using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    public abstract class Refrigeracion : Linea_Blanca
    {
        public Refrigeracion(string modelo, float precio, string marca) : base(modelo, marca, precio)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.precio = precio;
        }

    }
}
