using UnityEngine;
using System.Collections.Generic;

public class GameManagerMantener : MonoBehaviour
{
    private static GameManagerMantener instance;
    public static GameManagerMantener Instance { get { return instance; } }

    public LinkedList<string> palabras;
    public LinkedList<string> definiciones;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            if (palabras == null)
            {
                palabras = new LinkedList<string>();
                // Agrega las palabras iniciales aquí si es necesario
            }

            if (definiciones == null)
            {
                definiciones = new LinkedList<string>();
                // Agrega las definiciones iniciales aquí si es necesario
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}



