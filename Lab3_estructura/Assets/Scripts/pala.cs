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
    string textitoxd;

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
        textitoxd = textito.text;
    }

    void Update()
    {
        Generator.revelarPalabra(palabral,textitoxd,ref pal);
        palabraslash.text = pal;
        Debug.Log(pal);
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
