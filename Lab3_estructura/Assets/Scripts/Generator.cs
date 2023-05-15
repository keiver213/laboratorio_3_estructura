using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Generator : MonoBehaviour
{
   
    LinkedList<string> palabras = new LinkedList<string>();
    // Start is called before the first frame update
    public void Start()
    {
        palabras.AddLast("buffer");
        palabras.AddLast("campo");
        palabras.AddLast("registro");
        palabras.AddLast("Archivo");
        palabras.AddLast("estructura de datos");
        palabras.AddLast("archivos secuenciales");
        palabras.AddLast("archivos secuenciales indexados");
        palabras.AddLast("listas enlazadas");
        palabras.AddLast("listas doblemente enlazadas");
        palabras.AddLast("listas circulares");
        palabras.AddLast("multilistas");
        palabras.AddLast("nodo");

    }

    public string palabraAleatoria(){
        int controlador = Random.Range(0,palabras.Count);
        string palabra = palabras.ElementAt(controlador);
        palabras.Remove(palabra);
        return palabra;
    }

    public string alEmpezar(string palabra){
        string palabraPorCompletar = "";
        for (int i = 0; i < palabra.Length; i++){
            if(palabra.Substring(i,1).Equals(" ")){
                palabraPorCompletar += " ";
            }else{
                palabraPorCompletar += "_ ";
            }
        }
        return palabraPorCompletar;
    }
    
    public void revelarPalabra(string palabra, string letraDigitada, ref string palabraResult)
    {
    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra.Substring(i, 1).Equals(letraDigitada))
        {
            palabraResult = palabraResult.Substring(0, i) + letraDigitada + palabraResult.Substring(i + 1);
        }
    }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
