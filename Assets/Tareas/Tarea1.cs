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

    public int numero1 = 45;
    public int numero2 = 63;
    public int resultado = 108;

    //Debug
    void Start()
    {
        Debug.Log("Edad: " + edad + ", Nombre: " + nombre + ", Apellido: " + apellido + ", Altura: " + altura);
        Debug.Log(numero1 + numero2);
    }
}
