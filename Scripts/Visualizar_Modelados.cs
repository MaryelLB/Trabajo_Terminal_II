using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Visualizar_Modelados : MonoBehaviour
{
    // Controlador de animacion del avatar hombre
    public Animator controladorHombre; 
    // Controlador de animacion del avatar mujer
    public Animator controladorMujer;
    // Audio source del avatar hombre
    public AudioSource audioHombreS; 
    // Audio source del avatar muujer
    public AudioSource audioMujerS; 
    // Clip de audios de las palabras avatar mujer
    public AudioClip clipVacaMujer; 
    public AudioClip clipRatonMujer; 
    public AudioClip clipCerdoMujer; 
    public AudioClip clipConejoMujer; 
    public AudioClip clipOvejaMujer; 
    public AudioClip clipSerpienteMujer; 
    public AudioClip clipPalomaMujer; 
    public AudioClip clipGatoMujer; 
     public AudioClip clipCaballoMujer; 
    public AudioClip clipPerroMujer; 
    // Clip de audios de las palabras avatar hombre
    public AudioClip clipVacaHombre;
    public AudioClip clipCerdoHombre;
    public AudioClip clipPerroHombre;
    public AudioClip clipCaballoHombre;
    public AudioClip clipConejoHombre;
    public AudioClip clipSerpienteHombre;
    public AudioClip clipOvejaHombre;
    public AudioClip clipPalomaHombre;
    public AudioClip clipRatonHombre;
    public AudioClip clipGatoHombre;
    /* Referencia de los objetos 3D que se mandaran 
       a llamar una vez sean detectados
    */
    public GameObject vacaModeladoP3D;
    public GameObject serpienteModelado3D;
    public GameObject ratonModelado3D;
    public GameObject cerdoModelado3D;
    public GameObject caballoModelado3D;
    public GameObject ovejaModelado3D;
    public GameObject palomaModelado3D;
    public GameObject gatoModelado3D;
    public GameObject perroModelado3D;
    public GameObject conejoModelado3D;

    // Referencia de las imagenes del boton de sonido
    [SerializeField] Image sonidoEncendido;
    [SerializeField] Image sonidoApagado;
    // Variable que nos indica el estado del boton de sonido
    private bool mute=false; 

    /* Variables que nos indican que marcadores han sido 
        detectados
    */
    public bool vacaModelado;
    public bool serpienteModelado;
    public bool ratonModelado;
    public bool cerdoModelado;
    public bool caballoModelado;
    public bool ovejaModelado;
    public bool palomaModelado;
    public bool gatoModelado;
    public bool perroModelado;
    public bool conejoModelado;

    void Start()
    {  

        if (!PlayerPrefs.HasKey("Mute")) {
            PlayerPrefs.SetInt("Mute",0);
            Cargar();
        } else {
            Salvar();
        }
        ActualizarBoton();
        AudioListener.pause=mute;
    }

    // Update is called once per frame
    void Update()
    {
            vacaModelado = PlayerPrefs.GetInt("ModeladoVacaDetect") == 1;
            serpienteModelado = PlayerPrefs.GetInt("ModeladoSerpienteDetect") == 1;
            ratonModelado = PlayerPrefs.GetInt("ModeladoRatonDetect") == 1;
            palomaModelado = PlayerPrefs.GetInt("ModeladoPalomaDetect") == 1;
            perroModelado = PlayerPrefs.GetInt("ModeladoPerroDetect") == 1;  
            gatoModelado = PlayerPrefs.GetInt("ModeladoGatoDetect") == 1;
            cerdoModelado = PlayerPrefs.GetInt("ModeladoCerdoDetect") == 1;
            caballoModelado = PlayerPrefs.GetInt("ModeladoCaballoDetect") == 1; 
            ovejaModelado = PlayerPrefs.GetInt("ModeladoOvejaDetect") == 1;
            conejoModelado = PlayerPrefs.GetInt("ModeladoConejoDetect") == 1;

        if (vacaModelado == true) {
        vacaModeladoP3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia de deteccion del modelado de la vaca

        if (serpienteModelado == true) {
        serpienteModelado3D.SetActive(true);
        Destroy(ratonModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia del modelado de la serpiente

        if (ratonModelado == true) {
        ratonModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia del modelado del raton

        if (palomaModelado == true) {
        palomaModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia del modelado de la paloma

        if (perroModelado == true) {
        perroModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia del modelado del perro

        if (gatoModelado == true) {
        gatoModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia del modelado del gato

        if(cerdoModelado == true) {
        cerdoModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);  
        } // Final de la sentencia del modelado Cerdo

        if (caballoModelado == true) {
        caballoModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(ovejaModelado3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia del caballo

        if (ovejaModelado == true) {
        ovejaModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(vacaModeladoP3D);
        Destroy(conejoModelado3D);
        } // Final de la sentencia de la oveja

        if (conejoModelado == true) {
        conejoModelado3D.SetActive(true);
        Destroy(serpienteModelado3D);
        Destroy(ratonModelado3D);
        Destroy(palomaModelado3D);
        Destroy(perroModelado3D);
        Destroy(gatoModelado3D);
        Destroy(cerdoModelado3D);
        Destroy(caballoModelado3D);
        Destroy(ovejaModelado3D);
        Destroy(vacaModeladoP3D);
        } // Final de la sentencia del conejo
    }

    public void AnimarAvatares()
    {

        // Verifica si el avatar hombre esta activado
    if (GetComponent<Cargar_personaje>().avatarHombrePersonaje==isActiveAndEnabled) {
        if (GetComponent<Visualizar_Modelados>().vacaModeladoP3D==isActiveAndEnabled) {
            controladorHombre.Play("Vaca");
            audioHombreS.PlayOneShot(clipVacaHombre);
        } // Final de la animacion/audio del modelado de la vaca
        if (GetComponent<Visualizar_Modelados>().perroModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Perro");
            audioHombreS.PlayOneShot(clipPerroHombre);
        } // Final de la animacion/audio del modelado del perro
        if (GetComponent<Visualizar_Modelados>().gatoModelado3D == isActiveAndEnabled) { 
            controladorHombre.Play("Gato");
            audioHombreS.PlayOneShot(clipGatoHombre);
        } // Final de la animacion/audio del modelado del gato
        if (GetComponent<Visualizar_Modelados>().caballoModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Caballo");
            audioHombreS.PlayOneShot(clipCaballoHombre);
        } // Final de la animacion/audio del modelado del caballo
        if (GetComponent<Visualizar_Modelados>().conejoModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Conejo");
            audioHombreS.PlayOneShot(clipConejoHombre);
        } // Final de la animacion/audio del modelado del conejo
        if (GetComponent<Visualizar_Modelados>().cerdoModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Cerdo");
            audioHombreS.PlayOneShot(clipCerdoHombre);
        } // Final de la animacion/audio del modelado del cerdo
        if (GetComponent<Visualizar_Modelados>().serpienteModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Serpiente");
            audioHombreS.PlayOneShot(clipSerpienteHombre);
        } // Final de la animacion/audio del modelado de la serpiente
        if (GetComponent<Visualizar_Modelados>().ratonModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Raton");
            audioHombreS.PlayOneShot(clipRatonHombre);
        } // Final de la animacion/audio del modelado del raton
        if (GetComponent<Visualizar_Modelados>().ovejaModelado3D == isActiveAndEnabled) {
            controladorHombre.Play("Oveja");
            audioHombreS.PlayOneShot(clipOvejaHombre);
        } // Final de la animacion/audio del modelado de la oveja
        if (GetComponent<Visualizar_Modelados>().palomaModelado3D == isActiveAndEnabled){
            controladorHombre.Play("Paloma");
            audioHombreS.PlayOneShot(clipPalomaHombre);
        } // Final de la animacion/audio del modelado de la paloma
    } // Final de la verificacion si el avatar hombre esta activado

    // Verifica si el avatar mujer esta activado
    if (GetComponent<Cargar_personaje>().avatarMujerPersonaje==isActiveAndEnabled) {
        if (GetComponent<Visualizar_Modelados>().vacaModeladoP3D==isActiveAndEnabled) {
            controladorMujer.Play("Mujer_Vaca");
            audioMujerS.PlayOneShot(clipVacaMujer);
        } // Final de la animacion/audio del modelado de la vaca
        if (GetComponent<Visualizar_Modelados>().perroModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Perro_Mujer");
            audioMujerS.PlayOneShot(clipPerroMujer);
        } // Final de la animacion/audio del modelado del perro
        if (GetComponent<Visualizar_Modelados>().gatoModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Gato_Mujer");
            audioMujerS.PlayOneShot(clipGatoMujer);
        } // Final de la animacion/audio del modelado del gato
        if (GetComponent<Visualizar_Modelados>().caballoModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Caballo_Mujer");
            audioMujerS.PlayOneShot(clipCaballoMujer);
        } // Final de la animacion/audio del modelado del caballo
        if (GetComponent<Visualizar_Modelados>().conejoModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Conejo_Mujer");
            audioMujerS.PlayOneShot(clipConejoMujer);
        } // Final de la animacion/audio del modelado del conejo
        if (GetComponent<Visualizar_Modelados>().cerdoModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Cerdo_Mujer");
            audioMujerS.PlayOneShot(clipCerdoMujer);
        } // Final de la animacion/audio del modelado del cerdo
        if (GetComponent<Visualizar_Modelados>().serpienteModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Serpiente_Mujer");
            audioMujerS.PlayOneShot(clipSerpienteMujer);
        } // Final de la animacion/audio del modelado de la serpiente
        if (GetComponent<Visualizar_Modelados>().ratonModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Raton_Mujer");
            audioMujerS.PlayOneShot(clipRatonMujer);
        } // Final de la animacion/audio del modelado del raton
        if (GetComponent<Visualizar_Modelados>().ovejaModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Oveja_Mujer");
            audioMujerS.PlayOneShot(clipOvejaMujer);
        } // Final de la animacion/audio del modelado de la oveja
        if (GetComponent<Visualizar_Modelados>().palomaModelado3D == isActiveAndEnabled) {
            controladorMujer.Play("Paloma_Mujer");
            audioMujerS.PlayOneShot(clipPalomaMujer);
        } // Final de la animacion/audio del modelado de la paloma
    } // Final de la verificacion si el avatar mujer fue seleccionado 
    }

    public void EncenderApagarAudio()
    {  

        if ( mute == false ) {
            mute = true;
            AudioListener.pause = true;
        } else {
        mute = false;
        AudioListener.pause = false;   
        } // Final de la verificacion del boton del sonido
        Salvar();
        ActualizarBoton();  
    }

    private void ActualizarBoton()
    {
        /* Actualiza el boton dependiendo 
           del estado en que se encuentre
        */
        if (mute == false) {
            sonidoEncendido.enabled = true;
            sonidoApagado.enabled = false;
        } else {
            sonidoEncendido.enabled = false;
            sonidoApagado.enabled = true;
        } // Final de la actualizacion del boton
    }

    private void Cargar()
    {
        mute = PlayerPrefs.GetInt("Mute") == 1;
    }

    private void Salvar()
    {
        PlayerPrefs.SetInt("Mute", mute ? 1:0);
    }

}




    
    



