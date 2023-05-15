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
    public Generator Generator;
    public Text palabraslash;
    string palabral;
    GameObject slashes;
    string pal;
    string[] palabras = new string[29];
    int contadorcito = 0;

    void Start()
    {
        slashes = GameObject.FindWithTag("EditorOnly");
        palabraslash = slashes.GetComponent<Text>();
        errores = 0;
        textoerror.enabled = false;
        Generator.Start();
        palabral = Generator.palabraAleatoria();
        palabraslash.text = Generator.alEmpezar(palabral);
        pal = Generator.alEmpezar(palabral);
    }

    public void revelar(string palabral, string texto,ref string pal)
    {
        Debug.Log("Palabral: " + palabral + ",Textito: " + texto + ",pal: " + pal);
        Generator.revelarPalabra(palabral,texto,ref pal);
        palabraslash.text = pal;
        Debug.Log(pal);
    }

    public void get_text()
    {
        if (textito.text.Length == 1 && Regex.IsMatch(textito.text, pattern))
        {
            string texto = textito.text;
            Debug.Log("La letra ingresada fue: " + texto);
            if (contadorcito == 0)
            {
                revelar(palabral, texto, ref pal);
                palabras[contadorcito] = texto;
                contadorcito += 1;
            }
            else
            {
                bool palabraRepetida = false;
                for (int i = 0; i < contadorcito; i++)
                {
                    if (palabras[i] == texto)
                    {
                        palabraRepetida = true;
                        break;
                    }
                }
                if (palabraRepetida == true) 
                {
                    textoerror.enabled = true;
                    errores += 1;
                    Debug.Log("El numero de errores es: " + errores);
                }
                else
                {
                    revelar(palabral, texto, ref pal);
                    palabras[contadorcito] = texto;
                    contadorcito += 1;
                }
            }
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
