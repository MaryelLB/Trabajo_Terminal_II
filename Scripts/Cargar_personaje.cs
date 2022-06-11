using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cargar_personaje : MonoBehaviour
{
	// Variables que contiene el modelo 3D de los avatares
	public GameObject avatarHombrePersonaje;
	public GameObject avatarMujerPersonaje;
	// Variables de estado
    public bool avatarHombre;
	public bool avatarMujer;
	/* Variable que contiene el nombre
	   dependiendo del avatar elegido
	*/
	public Text nombrePersonaje;

    // Update is called once per frame
	private void Update()
	{		
			avatarHombre = PlayerPrefs.GetInt("avatarHombreSelect") == 1;
			avatarMujer = PlayerPrefs.GetInt("avatarMujerSelect") == 1;

			if (avatarHombre == true) {
				avatarMujer = false;
				// Si el avatar Hombre esta activado el avatar mujer se destruye
				avatarHombrePersonaje.SetActive(true);
				avatarMujerPersonaje.SetActive(false);
				nombrePersonaje.text = "Hola soy Roberto y sere tu tutor para ayudarte";
		}
		if (avatarMujer==true) {
				// Si el avatar Mujer esta activado el avatar Hombre se destruye
				avatarHombre = false;
				avatarMujerPersonaje.SetActive(true);
				avatarHombrePersonaje.SetActive(false);
				nombrePersonaje.text = "Hola soy Sandra y sere tu tutor para ayudarte";
		}
	}

}
