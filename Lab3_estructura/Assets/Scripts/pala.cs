using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

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
    public Button siguiente;
    public Button salir;
    public Text definicionTexto;
    public GameObject definicion;

    void Start()
    {
        int controlador = Random.Range(0,Generator.palabras.Count);
        slashes = GameObject.FindWithTag("EditorOnly");
        palabraslash = slashes.GetComponent<Text>();
        definicionTexto = definicion.GetComponent<Text>();
        errores = 0;
        textoerror.enabled = false;
        Generator.Start();
        definicion.gameObject.SetActive(false);
        palabral = Generator.palabraAleatoria(controlador);
        //string def = Generator.ObtenerDefinicion(controlador);
        definicionTexto.text = Generator.ObtenerDefinicion(controlador); 
        Debug.Log(definicionTexto);
        palabraslash.text = Generator.alEmpezar(palabral);
        pal = Generator.alEmpezar(palabral);
        siguiente.gameObject.SetActive(false);
        salir.gameObject.SetActive(false);
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
                    if(palabral==pal){
                        siguiente.gameObject.SetActive(true);
                        salir.gameObject.SetActive(true);
                        palabraslash.gameObject.SetActive(false);
                        definicion.gameObject.SetActive(true);
                    }
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
