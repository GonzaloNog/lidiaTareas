using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea1 : MonoBehaviour
{
    public int edad = 21;
    public string nombre = "lydia";
    public string apellido = "hola";
    public float altura = 1.55f;

    public bool entrarEdificioGubernamental = true;

    public int efectivo = 46;
    public int cuenta = 63;
    public int dineroTodal;

    //Debug
    void Start()
    {
        Debug.Log("Edad: " + edad + ", Nombre: " + nombre + ", Apellido: " + apellido + ", Altura: " + altura);
        dineroTodal = efectivo + cuenta;
        Debug.Log(dineroTodal);
    }
}
