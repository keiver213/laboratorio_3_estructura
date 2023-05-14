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

    void Start()
    {
        textoerror.enabled = false;
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
        }       
    }
}
