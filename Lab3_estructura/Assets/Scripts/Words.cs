using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Words:MonoBehaviour
{
    public InputField textoesc;
    
    public void gettext()
    {
        string texto = textoesc.text;
        Debug.Log("texto ingresado" + texto)
    }
}
