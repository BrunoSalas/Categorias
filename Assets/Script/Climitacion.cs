using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    public abstract class Climitacion : Linea_Blanca
    {
        public Climitacion(string modelo, float precio, string marca) : base(modelo, marca, precio)
        {
        }
    }
}
