using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animacion_Cerdo : MonoBehaviour
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
            animControlador.SetBool("Caminar",true);
        } // Cuando se de un touch se realiza la animacion
        if (animControlador.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Caminar_Puerco") {
            animControlador.SetBool("Caminar",false);
        } // Cuando la animacion finalize
    }

}
