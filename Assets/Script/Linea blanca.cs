using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    public abstract class Linea_Blanca
    {
        public float temperatura;

        public string modelo;

        public string marca;

        public float precio;

        public Linea_Blanca(string modelo, string marca, float precio)
        {

        }

        public void Enchufar() { }

        public void EncenderApagar() { }
    }
}