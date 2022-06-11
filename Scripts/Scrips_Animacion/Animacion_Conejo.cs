using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Conejo : MonoBehaviour
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
            animControlador.SetBool("Saltar",true);
        } // Empieza la animacion al dar un touch
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Saltar_Conejo"){
            animControlador.SetBool("Saltar",false);
        } // Finaliza la animacion
    }

}
