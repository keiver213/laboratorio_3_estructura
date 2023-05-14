using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class pala : MonoBehaviour
{
    public InputField textito;
    public Text textoerror;
    string pattern = @"^[^\d]+$";
    public int errores;

    void Start()
    {
        errores = 0;
        textoerror.enabled = false;
    }

    void Update()
    {
        //get_text();
    }

    public void get_text()
    {
        if (textito.text.Length == 1 && Regex.IsMatch(textito.text, pattern))
        {
            string texto = textito.text;
            Debug.Log("La palabra ingresada fue: " + texto);
            textoerror.enabled = false;
        }
        else
        {
            textoerror.enabled = true;
            errores += 1;
            Debug.Log("El numero de errores es: " + errores);
        }     
    }
}
