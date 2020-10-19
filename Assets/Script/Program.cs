using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Climitacion[] producto = new Climitacion[5];

            Refrigeracion[] frio = new Refrigeracion[5];
            int[] stock = new int[5];

            Estufas estufa = new Estufas("Estufa" + ":" + "ETM - 32", 139.00f, "Miray");


            Microondas Micro = new Microondas("Horno microondas" + ":" + "LG MH8296DIR", 649.00f, "LG");


            Termas_y_calentadores Terma = new Termas_y_calentadores("Terma a gas" + ":" + " SOLEGASN05V2C", 649.00f, "Sole");


            Termas_y_calentadores calent = new Termas_y_calentadores("Calentador a gas" + ":" + "Compact 2 14Lt GLP Bat + Kit", 1789.00f, "Bosch");


            Refrigeradora refri = new Refrigeradora("Refrigeradora" + ":" + "RM-168H Eurofrío 168L", 799.00f, "Miray");


            Congeladora conge = new Congeladora("Congeladora" + ":" + "OS-PCF11002SE 316L", 1549.00f, "Oster");

            Frigobar frigo = new Frigobar("Frigobar" + ":" + "OSPMB91WF 91L", 549.00f, "Oster");

            producto[0] = estufa;
            producto[1] = Micro;
            producto[2] = Terma;
            producto[3] = calent;
            frio[0] = refri;
            frio[1] = conge;
            frio[2] =frigo;
            stock[0] = 7;

            System.Console.WriteLine("stock: ");

            for (int i = 0; i < producto.Length; i++)
            {

                System.Console.WriteLine("--------------------");

                System.Console.WriteLine("Climitación");

                System.Console.WriteLine(producto[i].modelo + " - " + producto[i].marca + " - " + producto[i].precio);

                System.Console.WriteLine("--------------------");

                System.Console.WriteLine("Refrigeración");

                System.Console.WriteLine(frio[i].modelo + " - " + frio[i].marca + " - " + frio[i].precio);
            }
        }
    }
}
