using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Serpiente : MonoBehaviour
{
    // Controlador de animacion
    public Animator animControlador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0)) {
            animControlador.SetBool("Arrastrar",true);
        } // Inicio de la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Arrastrarse_Serpiente") {
            animControlador.SetBool("Arrastrar",false);
        } //Final de la animacion
    }

}
