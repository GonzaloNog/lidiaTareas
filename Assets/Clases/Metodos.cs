using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    public int num = 1;
    public int num2 = 1;
    public int resultado;
    public int resultado2;
    public int resultado3;
    public int edad = 19;
    public int dinero = 100;
    void Start()
    {
        int resultado22 = num + num2;//variable temporal
                                   // miMetodo2(2, 8);
                                   // miMetodo2(22, 8);
                                   // miMetodo2(12, 15);
                                   // miMetodo2(18, 19);
                                   //miMetodo2(9, 15);
       resultado = miMetodo3();
       resultado2 = miMetodo3();
       resultado3 = miMetodo3();
       if (Acto(edad,dinero))
       {

       } 
    }
    void Update()
    {
        num = 3;
    }

    public void miMetodo() //Metodo unicamente void
    {

    }
    public void miMetodo2(int num, int num2)//Metodo con parametros
    {
        if (num >= 10 && num <= 20 && num2 >= 10 && num2 <= 20)
        {
            Debug.Log(num + num2);
        }
        else
        {
            Debug.Log("fuera de rango");
        }
    }

    public int miMetodo3()
    {
        return 10 + 20;
    }
    public bool Acto(int edad,int dinero)
    {
        if(edad >= 19)
        {
            if(dinero > 100)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        else
        { 
            return false; 
        }
    }


}
