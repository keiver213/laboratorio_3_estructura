using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    public LinkedList<string> palabras = new LinkedList<string>();
    public LinkedList<string> definiciones = new LinkedList<string>();
    public pala palas;

    public void Start()
    {
        palabras.AddLast("buffer");
        palabras.AddLast("campo");
        palabras.AddLast("registro");
        palabras.AddLast("archivo");
        palabras.AddLast("estructura de datos");
        palabras.AddLast("archivos secuenciales");
        palabras.AddLast("archivos secuenciales indexados");
        palabras.AddLast("listas enlazadas");
        palabras.AddLast("listas doblemente enlazadas");
        palabras.AddLast("listas circulares");
        palabras.AddLast("multilistas");
        palabras.AddLast("nodo");
        definiciones.AddFirst("Un buffer es un espacio de memoria en el cuál se almacena información durante una transferencia de datos. Su principal función es atenuar la diferencia entre dos dispositivos o procesos por lo que está presentes en todo tipo de dispositivos que trabajen con datos de una manera u otra tal cómo discos duros, memoria RAM, procesadores, etc.");
        definiciones.AddLast("Son los componentes que estructuran un registro.");
        definiciones.AddLast("Un registro es un dato estructurado, donde cada uno de sus componentes se denomina campo. Los campos de un registro pueden ser todos de diferentes tipos (inclusive otros registros o arreglos)");
        definiciones.AddLast("Para dar diseño a los archivos se usan los registros: físicamente un archivo se almacena como una sucesión de datos estructurados por el diseño de un registro. La información se guarda con el formato especificado por el registro, y se recupera con ese mismo formato. un conjunto de registros con ciertos aspectos en común, y organizados para algún propósito particular, constituyen un archivo");
        definiciones.AddLast("son un modo de representar información en una computadora, aunque además, cuentan con un comportamiento interno.");
        definiciones.AddLast("En archivo secuencial los registros se insertan en el archivo en orden cronológico de llegada al soporte, es decir, un registro se almacena inmediatamente a continuación del registro anterior.");
        definiciones.AddLast("Se utiliza este tipo de organización de archivo cuando existe la necesidad tanto de accesar los registros secuencialmente, por algún valor de llave, como de accesarlos individualmente.");
        definiciones.AddLast("Una lista enlazada es una colección lineal de elementos llamados nodos. El orden entre ellos se establece mediante punteros; direcciones o referencias a otros nodos. Esta estructura es dinamica, por lo que no debemos necesariamente conocer su numero de elementos");
        definiciones.AddLast("Es una estructura de datos dinámica que se compone de un conjunto de nodos en secuencia enlazados mediante dos apuntadores (uno hacia adelante y otro hacia atrás).");
        definiciones.AddLast("lista lineal en la que el último nodo a punta al primero.");
        definiciones.AddLast("Una multilista es una estructura de datos jerárquica que consta de una lista principal que contiene sub-listas, cada una de las cuales puede contener sus propias sub-listas y así sucesivamente. ");
        definiciones.AddLast("construcción en memoria RAM, donde se pueden tener varios datos de tipos diferentes.");
    }

    public string palabraAleatoria(int indice){
        string palabra = palabras.ElementAt(indice);
        palabras.Remove(palabra);
        return palabra;
    }

    public string alEmpezar(string palabra){
        string palabraPorCompletar = "";
        for (int i = 0; i < palabra.Length; i++)
        {
            if(palabra.Substring(i,1).Equals(" "))
            {
                palabraPorCompletar += " ";
            }
            else
            {
                palabraPorCompletar += "-";
            }
        }
        return palabraPorCompletar;
    }
    
    public void revelarPalabra(string palabra, string letraDigitada,ref string palabraResult)
    {
        bool activacion = false;
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra.Substring(i, 1).Equals(letraDigitada))
            {
                palabraResult = palabraResult.Substring(0, i) + letraDigitada + palabraResult.Substring(i + 1);
                activacion = true;
            }
        }
            if (activacion == false)
            {
                palas.textoerror.enabled = true;
                palas.errores += 1;
                Debug.Log("El numero de errores es: " + palas.errores);
            }
    }
    
    public string ObtenerDefinicion(int indice)
    {
        LinkedListNode<string> nodo = definiciones.First;
        for(int i= 0; i<=indice; i++){
            nodo = nodo.Next;
            string cadenatemp= nodo.Value;
            Debug.Log(cadenatemp);
        }
        string definicion = nodo.Value;
        definiciones.Remove(nodo);
        return definicion;
        /*string definicion = nodo.Value;
        definiciones.Remove(nodo);
        return definicion;*/

    }
    
    void Update()
    {
        
    }
}
