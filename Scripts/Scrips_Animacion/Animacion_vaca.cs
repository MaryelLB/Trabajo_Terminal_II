using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_vaca : MonoBehaviour
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
            animControlador.SetBool("Agacharse",true);
        } // Inicio de la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Agacharse_Vaca") {
            animControlador.SetBool("Agacharse",false);
        } // Final de la animacion
    }

}
