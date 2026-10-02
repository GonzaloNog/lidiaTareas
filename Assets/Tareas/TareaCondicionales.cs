using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCondicionales : MonoBehaviour
{   /*a) creamos una variable edad y una variable nombre, comprobamos si la edad es mayor o igual a 18 de ser el caso ponemos "bienvenido + nombre" de no cumplir la condición ponemos "no se le permite la entrada"
    b) Creamos una variable bool permiso, si permiso esta en true mostramos el mensaje, “PERMISO”*/

    public int edad = 30;
    public string nombre = "Luis";

    public bool permiso = true;
    void Start()
    {
        if (edad >= 18)
        {
            Debug.Log("Bienvenido," + nombre);
        }
        else
        {
            Debug.Log("No se le permite la entrada.");
        }

        if(permiso)
        {
            Debug.Log("PERMISO");
        }
    }

}
