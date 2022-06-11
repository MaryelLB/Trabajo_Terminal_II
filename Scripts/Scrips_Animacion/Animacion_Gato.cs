using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Gato : MonoBehaviour
{
    // Controlador de animacion
    public Animator animControlador;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            animControlador.SetBool("Jugar",true);
        } // Inicia la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Salto_Gato")
        {
            animControlador.SetBool("Jugar",false);
        } // Finaliza la animacion
    }
    
}
