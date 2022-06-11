using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Raton : MonoBehaviour
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
            animControlador.SetBool("Saltar_R",true);
        } // Inicio de la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Salto_Raton") {
            animControlador.SetBool("Saltar_R",false);
        } // Final de la animacion
    }

}
