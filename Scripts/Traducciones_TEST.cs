using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Traducciones_TEST : MonoBehaviour
{
    /* Controladores de animacion de los avatares
       dependiendo de sus opciones
    */
    public Animator controladorHombre1; 
    public Animator controladorMujer1; 
    public Animator controladorHombre2; 
    public Animator controladorMujer2;
    public Animator controladorHombre3;
    public Animator controladorMujer3;
    public Animator avatarPuntajeHombre;
    public Animator avatarPuntajeMujer;
    // Array que contiene las variables de los animales
    private string[] animales = new string[]{"Vaca", "Perro", 
                                            "Caballo","Conejo",
                                            "Cerdo", "Serpiente",
                                            "Gato", "Raton",
                                            "Oveja", "Paloma"};

    /* Variable que almacena los modelados de las opciones de los
       avatares
    */
    public GameObject[] opciones;

    // Variables que mandaran las opciones
    public string opcion1;
    public string opcion2;
    public string opcion3;

    // String de la opcion elegida
    public string datoSeleccionado;

    // GameObject del panel de pantalla Puntaje
    public GameObject pantallaP;

    // GameObject del panel de pantalla del test
    public GameObject pantallaI;

     // GameObject del panel de pantalla principal
    public GameObject pantallaRI;

    // GameObject de la opcion de modelados

    public GameObject modelados;
    // Texto del puntaje obtenido
    public Text pantallaPuntaje;

    // Imagenes de los iconos de verificacion
    [SerializeField] Image respuestaCorrecta;
    [SerializeField] Image respuestaIncorrecta;

    // Variable de posicion de las opciones
    int n = 0;

    /* Variable que almacena la posicion 
       una vez seleccionado
    */
    int contador = 0;  

    // Variable de puntaje
    public int score = 0;

    // Variable de los marcadores detectado
    public int contadorM = 0;
    string puntaje = "Puntaje";

    void Start()
    {
        ApagarPersonajes();
        n = PlayerPrefs.GetInt(datoSeleccionado,0);
        opciones[n].SetActive(true);
        score=PlayerPrefs.GetInt(puntaje,contador); 
    }

    public void SiguienteEstado()
    {
        desactivarIconosdeVerificacion();
        opciones[n].SetActive(false);
        n++;  
        n = ( n + 1 ) % opciones.Length;
        Enviaropcion1(opcion1);

        if (n == 0) {
            EnviarOpcion3(opcion3);
            Debug.Log("Estado siguiente cuando sea n=0"+n);
        }
        if (n == 2) {
            EnviarOpcion2(opcion2);
            Debug.Log("Estado siguiente en opcion 2 n=2"+n);
         }      
     }

    public void AnteriorOpcion()
    {
        desactivarIconosdeVerificacion();
        opciones[n].SetActive(false);
        n--;

        if (n < 0) {
            n += opciones.Length;
         }
        if (n == 0) {
            EnviarOpcion3(opcion3);
            Debug.Log("Estado anterior cuando en n=0"+n);
        }
        if (n == 1) {
            Enviaropcion1(opcion1);
            Debug.Log("Estado anterior en opcion 1 es decir n=1"+n);
         }
        EnviarOpcion2(opcion2);
        Debug.Log("Estado opcion2 anterior"+n);       
    }

    public void realizarOpcionesDistintas()
    {
        bool error =false;
  
        do{
                int i = Random.Range(0, animales.Length);
                int j = Random.Range(0, animales.Length);
                opcion1 = animales[i];
                opcion2 = animales[j];
            if (opcion1 == opcion3 || opcion2 == opcion3 || opcion1 == opcion2) {
                error = true;
                } else {
                error = false;
                }
        } while (error);
    }

    public void Enviaropcion1(string v)
    {
        opciones[n].SetActive(true); 

        if (GetComponent<Cargar_Personajes_Test>().avatarHombrePersonaje2 == isActiveAndEnabled) {
                controladorHombre2.SetBool(v, true);
       }
        if (GetComponent<Cargar_Personajes_Test>().avatarMujerPersonaje2 == isActiveAndEnabled) {
                controladorMujer2.SetBool(v, true);
        } 
    }

    public void EnviarOpcion2(string v)
    {
        opciones[n].SetActive(true); 

        if (GetComponent<Cargar_Personajes_Test>().avatarHombrePersonaje3 == isActiveAndEnabled) {
                controladorHombre3.SetBool(v, true);
        }
        if (GetComponent<Cargar_Personajes_Test>().avatarMujerPersonaje3 == isActiveAndEnabled) {
                controladorMujer3.SetBool(v, true);  
        }
    }

    public void EnviarOpcion3(string g)
    {
        opciones[n].SetActive(true);

        if (GetComponent<Cargar_Personajes_Test>().avatarHombrePersonaje1 == isActiveAndEnabled) {
                controladorHombre1.SetBool(g, true); 
        }
        if (GetComponent<Cargar_Personajes_Test>().avatarMujerPersonaje1 == isActiveAndEnabled) {
                controladorMujer1.SetBool(g, true);
        }     
    } 
    public void Guardar()
    {
        // Posicion en la que se encuentra la respuesta correcta
        if ( n == 0) {
                score++;
                GuardarPuntos();
                respuestaCorrecta.enabled = true;
                respuestaIncorrecta.enabled = false;
        } else {
        // Activacion de los iconos de verificacion         
                respuestaCorrecta.enabled = false;
                respuestaIncorrecta.enabled = true;
        }
    }

    public void GuardarPuntos()
    {  
        PlayerPrefs.SetInt(puntaje, contador);
    }

    public void Finalizar()
    {
        ApagarPersonajes();
        pantallaI.SetActive(false);
        pantallaRI.SetActive(false);
        modelados.SetActive(false);
        pantallaP.SetActive(true);
        pantallaPuntaje.text = "Obtuviste: " + score.ToString() + " - " + contadorM;

         // Mandara a llamar la animacion de tristeza
        if (score == 0) {
                // Verifica si el avatar hombre es el que esta activado
                if (GetComponent<Cargar_personaje>().avatarHombrePersonaje == isActiveAndEnabled) {
                    avatarPuntajeHombre.SetBool("Triste_H", true);              
                }
                 // Verifica si el avatar mujer es el que esta activado
                if (GetComponent<Cargar_personaje>().avatarMujerPersonaje == isActiveAndEnabled) {       
                    avatarPuntajeMujer.SetBool("Triste_M" , true);
                }
          // Mandara a llamar la animacion de tristeza
        } else if (score == contadorM) {
                // Verifica si el avatar hombre es el que esta activado
                if (GetComponent<Cargar_personaje>().avatarHombrePersonaje == isActiveAndEnabled) {
                    avatarPuntajeHombre.SetBool("Festejar", true);
                }
                // Verifica si el avatar mujer es el que esta activado
                if (GetComponent<Cargar_personaje>().avatarMujerPersonaje == isActiveAndEnabled){
                    avatarPuntajeMujer.SetBool("Festejar_M", true);
                }
        // Mandara a llamar la animacion de aplaudir
        } else {
                // Verifica si el avatar hombre es el que esta activado
                if (GetComponent<Cargar_personaje>().avatarHombrePersonaje == isActiveAndEnabled) {
                    avatarPuntajeHombre.SetBool("Aplaudir", true);
                }
                // Verifica si el avatar mujer es el que esta activado
                if (GetComponent<Cargar_personaje>().avatarMujerPersonaje == isActiveAndEnabled) {
                avatarPuntajeMujer.SetBool("Aplaudir_M", true);
                }
        }
    }
    
    public void EnviarModeladoVaca()
    {  
        contadorM++;
        desactivarIconosdeVerificacion();  
        opcion3 = "Vaca";
        EnviarOpcion3(opcion3); 
        realizarOpcionesDistintas();
    }

    public void EnviarModeladoPerro()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Perro";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas(); 
    }

    public void EnviarModeloCerdo()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Cerdo";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void EnviarModeloCaballo()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Caballo";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void EnviarModeloConejo()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Conejo";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void EnviarModeloGato()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3="Gato";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void EnviarModeloPaloma()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Paloma";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void EnviarModeladoSerpiente()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Serpiente";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void EnviarModeloRaton()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Raton";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();  
    }
    public void EnviarModeloOveja()
    {
        contadorM++;
        desactivarIconosdeVerificacion();
        opcion3 = "Oveja";
        EnviarOpcion3(opcion3);
        realizarOpcionesDistintas();
    }

    public void ApagarPersonajes()
    {
        foreach (GameObject g in opciones) {
            g.SetActive(false);
        }
    }

    public void desactivarIconosdeVerificacion()
    {
        respuestaCorrecta.enabled = false;
        respuestaIncorrecta.enabled = false;
    }
    
}
