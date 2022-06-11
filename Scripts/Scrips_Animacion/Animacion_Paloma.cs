using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Paloma : MonoBehaviour
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
            animControlador.SetBool("Volar",true);
        } // Inicia la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Paloma_Volando") {
            animControlador.SetBool("Volar",false);
        } // Finaliza de la animacion
    }

}
