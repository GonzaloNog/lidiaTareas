using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Image miImagen;
    public TextMeshProUGUI textoClase;
    public Color miColor;
    public TMP_FontAsset miFont;
    public bool autoSize;
    public Button miBoton;
    public ColorBlock miBotonColor;
    public ColorBlock miBotonColor2;
    
    void Start()
    {
        
        textoClase.text = "hola mundo!!!!!!";
        textoClase.font = miFont;
        textoClase.enableAutoSizing = autoSize;
        miBoton.colors = miBotonColor2;
    }

    public void nuevoColor()
    {
        miImagen.color = miColor;
    }
    public void miNuevoNOmbre()
    {
        textoClase.text = "cambio texto";
    }
}
