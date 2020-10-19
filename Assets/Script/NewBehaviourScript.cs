using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tarea_05;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Climitacion[] producto = new Climitacion[4];

        Refrigeracion[] frio = new Refrigeracion[3];

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
        frio[2] = frigo;

        for (int i = 0; i < producto.Length; i++)
        {

            Debug.Log("--------------------");

            Debug.Log("Climitación"+ ":");

            Debug.Log(producto[i].modelo + " - " + producto[i].marca + " - " + producto[i].precio);

        }
        for (int i = 0; i < frio.Length; i++)
        {

            Debug.Log("--------------------");

            Debug.Log("Refrigeración" + ":");

            Debug.Log(frio[i].modelo + " - " + frio[i].marca + " - " + frio[i].precio);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
