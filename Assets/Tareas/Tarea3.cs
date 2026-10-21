using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea3 : MonoBehaviour
{
   
    public int edad = 45;
    public float dinero = 278.7f;
    public int sueldo = 1500;
    public string nombre = "Blanca";
    public string comando;

    void Start()
    {
        Debug.Log("Hola " + nombre);

        switch (comando)
        {
            case "crearCuenta":
                crearCuenta();
                Debug.Log("Crear cuenta");
                break;
            case "depositarDinero":
                depositarDinero();
                Debug.Log("Depositar dinero");
                break;
            case "retirarDinero":
                retirarDinero();
                Debug.Log("Retirar dinero");
                break;
            case "borrarCuenta":
                borrarCuenta();
                Debug.Log("Borrar cuenta");
                break;
            default:
                Debug.Log("codigo no encontrado");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crearCuenta()
    {
        if(edad >= 18)
        {
            if(sueldo >= 1500)
            {
                if(dinero >= 3000)
                {
                    Debug.Log("Cuenta creada.");
                }
                else
                {
                    Debug.Log("No tienes suficiente dinero.");
                }
            }
            else
            {
                Debug.Log("sueldo insuficiente.");
            }
        }
        else
        {
            Debug.Log("No eres mayor de edad.");
        }
    }

    public void depositarDinero()
    {
        if(dinero >= 100)
        {
            dinero -= 100;
            Debug.Log(dinero);
        }
        else
        {
            Debug.Log("No tienes suficiente dinero.");
        }
    }

    public void retirarDinero()
    {
        dinero += 100;
        Debug.Log(dinero);
    }

    public void borrarCuenta()
    {
        Debug.Log("Cuenta eliminada.");
    }
}
