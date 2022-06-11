using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Caballo : MonoBehaviour
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
            animControlador.SetBool("Camina",true);
        } // Fin de la sentencia cuando se de un touch
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Caminar_Caballo") {
            animControlador.SetBool("Camina",false);
        } // Fin de la sentencia cuando la animacion se complete
    }

}
