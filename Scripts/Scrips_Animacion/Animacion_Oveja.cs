using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Oveja : MonoBehaviour
{
    // Contolador de animacion
    public Animator animControlador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0)) {
            animControlador.SetBool("Caminar",true);
        } // Inicia la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Caminar_Oveja") {
            animControlador.SetBool("Caminar",false);
        } // Finaliza la animacion
    }

}
