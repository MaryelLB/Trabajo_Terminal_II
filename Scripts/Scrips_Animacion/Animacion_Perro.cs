using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Perro : MonoBehaviour
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
            animControlador.SetBool("Caminar_P",true);
        } // Inicia animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Caminar_Perro") {
            animControlador.SetBool("Caminar_P",false);
        } // Finaliza animacion
    }

}
