using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cambio_escena : MonoBehaviour
{
    //Variable que maneja el cambio y scripts de las escenas
    public GameObject funcionesManager;

    public void Cambiar_Menu_Opciones()
    {
        SceneManager.LoadScene("Opciones");
        //Carga el personaje seleccionado por el usuario en la escena 
        funcionesManager.GetComponent<Seleccionar_Personaje>().GuardarPersonaje(); 
    }

    public void Seleccionar_avatar()
    {
        SceneManager.LoadScene("Seleccionar_Personaje");
    }

    public void Regresar_Menu_Inicial()
    {
    	SceneManager.LoadScene("Inicio");
    }
    public void Escena_Instrucciones()
    {
    	SceneManager.LoadScene("Instrucciones");
        //Carga el personaje seleccionado por el usuario en la escena 
    	funcionesManager.GetComponent<Seleccionar_Personaje>().GuardarPersonaje();
    }

    public void Reconocer_imagenes()
    {
    	SceneManager.LoadScene("ReconocerIM");
         //Carga el personaje seleccionado por el usuario en la escena 
        funcionesManager.GetComponent<Seleccionar_Personaje>().GuardarPersonaje();
    }

    public void Realizar_Test()
    {
        SceneManager.LoadScene("Test");
         //Carga el personaje seleccionado por el usuario en la escena 
        funcionesManager.GetComponent<Seleccionar_Personaje>().GuardarPersonaje(); 
    }

    public void Traducir()
    {
        SceneManager.LoadScene("Traducir");
         //Carga el personaje seleccionado por el usuario en la escena 
        funcionesManager.GetComponent<Seleccionar_Personaje>().GuardarPersonaje();
         //Carga el modelado detectado 
        funcionesManager.GetComponent<Carga_Modelados>().GuardarModelado();
    }

}
