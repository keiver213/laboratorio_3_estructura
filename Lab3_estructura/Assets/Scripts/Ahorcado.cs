using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ahorcado : MonoBehaviour
{
    //si Alguien quiere trabajar en esta monda, es libre de borrar toda esta verga    
    private string dato;
   [SerializeField] private UnityEngine.UI.Text componenteTexto = null;
    public InputField palabraInput;
    public Text resultadoText;

    public void Generar()
    {
        string palabra = palabraInput.text;
        string resultado = GenerarLineas(palabra);
        resultadoText.text = resultado;
    }

    private string GenerarLineas(string palabra)
    {
        string lineas = "";

        foreach (char caracter in palabra)
        {
        lineas += "_";
        }

        return lineas;
    }
    void Start()
    {
        
    }
    
    public void Ingresodato(string s){
        dato=s;
        Debug.Log("funciona");

    }
    public void cantidad_caracteres(){
    int cantidad= dato.Length;
    string palabra= "la palabra tiene una cantidad de caracteres" + dato.Length;
    componenteTexto.text=palabra;
    Debug.Log("funciona pero xd");

}
    // Update is called once per frame
    void Update()
    {
        
    }
}
