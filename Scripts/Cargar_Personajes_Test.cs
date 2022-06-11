using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cargar_Personajes_Test : MonoBehaviour
{
	/* Variable que contiene el modelo 3D 
	   de los avatares
	*/
    public GameObject avatarHombrePersonaje1;
	public GameObject avatarMujerPersonaje1;
    public GameObject avatarHombrePersonaje2;
	public GameObject avatarMujerPersonaje2;
    public GameObject avatarHombrePersonaje3;
	public GameObject avatarMujerPersonaje3;
	// Variables de estado del avatar seleccionado
    public bool avatarHombre;
	public bool avatarMujer;

    // Update is called once per frame

   	private void Update()
   	{	
		avatarHombre = PlayerPrefs.GetInt("avatarHombreSelect") == 1;
		avatarMujer = PlayerPrefs.GetInt("avatarMujerSelect") == 1;

		if (avatarHombre == true) {
			// Si el avatar Hombre esta activado el avatar mujer se destruye
			avatarHombrePersonaje1.SetActive(true);
            avatarHombrePersonaje2.SetActive(true);
            avatarHombrePersonaje3.SetActive(true);
			// Los avatares mujeres se destruyen
			avatarMujerPersonaje1.SetActive(false);
            avatarMujerPersonaje2.SetActive(false);
            avatarMujerPersonaje3.SetActive(false);
		}
		if (avatarMujer == true) {
			// Si el avatar Mujer esta activado el avatar Hombre se destruye
			avatarMujerPersonaje1.SetActive(true);
            avatarMujerPersonaje2.SetActive(true);
            avatarMujerPersonaje3.SetActive(true);
			// Los avatares mujeres se destruyen
			avatarHombrePersonaje1.SetActive(false);
            avatarHombrePersonaje2.SetActive(false);
            avatarHombrePersonaje3.SetActive(false);
		}
	}
}
