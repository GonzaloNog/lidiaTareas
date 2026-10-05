using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Tarea2 : MonoBehaviour
{
    /*A) vamos a crear las siguientes variables, edad, nombre, apellido, sueldo, dinero
B) vamos a crear una aplicación bancaria que va  determinar usando los datos de arriba si la persona puede o no crear una cuenta en caso de no poder tenemos que no tificar el motivo


Condiciones para abrir la cuenta en orden de importancia
a - Ser mayor de 18
b - Tener un sueldo mensual de al menos 1500 euros
c - Tener 3000 euros para depositar en la cuenta 


C) si logra pasar todos los filtros ponemos un mensaje de bienvenida al banco mostrando su nombre y su apellido


Notas, los campos de las variables anda cambiándolos en el inspector para probar los distintos mensajes de error*/

    public string nombre = "Luis";
    public string apellido = "Hola";
    public int edad = 19;
    public int sueldo = 1300;
    public float dinero = 2999.9f;

    void Start()
    {
        if(edad >= 18)
        {
            if(sueldo >= 1500)
            {
                if(dinero >= 3000)
                {
                    Debug.Log("Bienvenido, " + nombre + " " + apellido);
                }
                else
                {
                    Debug.Log("No tienes suficiente dinero.");
                }
            }
            else
            {
                Debug.Log("Tu sueldo no es suficiente");
            }
        }
        else
        {
            Debug.Log("No eres mayor de edad.");
        }
    }

    
}
