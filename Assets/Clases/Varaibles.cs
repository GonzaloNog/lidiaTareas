using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Varaibles : MonoBehaviour
{
    public int miInt = 1;// Variable de numero entero
    public int miInt2 = 2;
    public string miString = "miNombre";//Variables de texto
    public bool miBool = true;//Variables de si o no
    public float miFloat = 1.0f; //hasta 8 decimales
    public double miDouble = 1.0; //hasta 16 decimales
    public char miChar = 'c';//unico caracter
    void Start()
    {
        Debug.Log("hola mundo. Arranco el programa");
        //Operaciones
        miInt = 2;//cambio simple
        miInt = 4 + 3; //operacion simple
        miInt = (6 * 5) + 25; //operaciones complejas
        miInt = miInt + 45;
        miInt = miInt + miInt2;

        miFloat = miInt + 3.5f;
        Debug.Log(miInt);

        miString = "hola mundo";
        miString = "hola mundo " + "como estas? " + miInt;
        Debug.Log(miString);

        Debug.Log("hola mundo " + (2 + 10) );
    }

}
