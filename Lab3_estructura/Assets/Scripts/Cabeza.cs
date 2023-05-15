using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabeza : MonoBehaviour
{
    public int contador;
    public pala palabras;
    [SerializeField]
    public Animator animacion;
    GameObject cabeza;

    void Start()
    {
        cabeza = GameObject.FindWithTag("Player");
        animacion = cabeza.GetComponent<Animator>();
    }

    void Update()
    {
        if (palabras.errores == 2)
        {
            animacion.SetBool("error", true);
        }
        
        if (palabras.errores == 4)
        {
            animacion.SetBool("error", false);
            animacion.SetBool("error2", true);
        }
        
        if (palabras.errores == 6)
        {
            animacion.SetBool("error2", false);
            animacion.SetBool("error3", true);
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif

        }
    }
}
