using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTeoria : MonoBehaviour
{
    public string comando;
    void Start()
    {
        switch (comando)
        {
            case "play":
                Debug.Log("arranca el juego"); 
                break;
            case "ajustes":
                Debug.Log("menu de ajustes");
                break;
            default:
                Debug.Log("comando incorrecto");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
