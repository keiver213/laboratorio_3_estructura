using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabeza : MonoBehaviour
{
    public int contador;
    public pala palabras;
    public Animator animacion;
    
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    void Update()
    {
        if (palabras.errores == 1)
        {
            Debug.Log("puta vida");
            animacion.SetBool("error", true);
        }
    }
}
