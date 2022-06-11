using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Seleccionar_Personaje : MonoBehaviour
{
	// Variables de estado de los avatares
	public bool avatarHombre;
	public bool avatarMujer;
	
	private void Awake()
	{
		// Verifica si estan activados los modelos
		avatarHombre = PlayerPrefs.GetInt("avatarHombreSelect") == 1;
		avatarMujer = PlayerPrefs.GetInt("avatarMujerSelect") == 1;
	}

    public void SeleccionarPersonajeHombre()
    {
    	// Cargar al avatar Hombre
    	avatarHombre = true;
    	avatarMujer = false;
    	GuardarPersonaje();
    }

    public void SeleccionarPersonajeMujer()
    {
    	// Cargar avatar mujer
    	avatarHombre = false;
    	avatarMujer = true;
    	GuardarPersonaje();
    }

    public void GuardarPersonaje()
    {
		
    	// Se encarga de guardar el personaje seleccionado mediante un true||false
		if (avatarHombre == false && avatarMujer == false) {
		// No realiza nada
		} else {
			PlayerPrefs.SetInt("avatarHombreSelect", avatarHombre ? 1 : 0);
    		PlayerPrefs.SetInt("avatarMujerSelect", avatarMujer ? 1 : 0);
			SceneManager.LoadScene("Opciones");
		}
	}	
    	 
}
