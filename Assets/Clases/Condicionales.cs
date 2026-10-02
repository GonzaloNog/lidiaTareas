using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int num1 = 3;
    public string adminLevel = "empleado";
    public bool entrada = true;

    public int dinero;
    public int edad;
    public int suscripcion;

    void Start()
    {
        //Enteros
        //nivel1
        if(num1 > 0)//mayor que
        {
           
        }
        if(num1 >= 0)
        {

        }
        if(num1 < 0)//menor que
        {

        }
        if(num1 <= 0)
        {

        }
        if(num1 == 0)//igualamos
        {

        }
        //nivel2
        if(num1 != 0)
        {

        }
        if(num1 == 0 && num1 > 90 && num1 < 90)
        {

        }
        if(num1 > 0 || num1 < 80 || num1 == 907)
        {

        }
        //nivel3
        if((edad > 18 || suscripcion > 3) && dinero >= 100)
        {

        }
        //String
        if(adminLevel == "admin")
        {
            
        }
        //Bool
        if(entrada == true)
        {

        }
        if(entrada)// no nesesita comparasion porque ya da true o false
        {

        }

        //Else y ElseIf
        if(num1 > 0)
        {

        }
        else
        {
            
        }

        if(edad > 18)
        {
            Debug.Log("Adulto");
        }
        else if(edad > 10){
            Debug.Log("adolecente");
        }
        else if(edad > 3)
        {
            Debug.Log("ni;o");
        }
        else
        {
            Debug.Log("bebe");
        }

        //If encadenados
        if(edad > 18 && edad < 30)
        {

        }
        else
        {
            Debug.Log("No podes entrar");
        }

        if(edad > 18)
        {
            if(edad < 30)
            {
                Debug.Log("podes entrar");
            }
            else
            {
                Debug.Log("No podes entrar");
            }
        }
        else
        {
            Debug.Log("No podes entrar");
        }
    }
}
