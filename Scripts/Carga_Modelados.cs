using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Carga_Modelados : MonoBehaviour
{ 
    /*Declaracion de los modelados disponibles
     en terminos de true||false
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

      public void Awake()
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
      }

      public void DetectarModeladoVaca()
      {
            vacaModelado = true;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }
    
      public void DetectarModeladoRaton()
      {
            ratonModelado = true;
            vacaModelado = false;
            perroModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoSerpiente()
      {
            serpienteModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoOveja()
      {
            ovejaModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoConejo()
      {
            conejoModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado= false; 
            GuardarModelado();
      }

      public void DetectarModeladoPaloma()
      {
            palomaModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoPerro()
      {
            perroModelado = true;
            vacaModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoCerdo()
      {
            cerdoModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoCaballo()
      {
            caballoModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            gatoModelado = false;
            conejoModelado = false;
            GuardarModelado();
      }

      public void DetectarModeladoGato()
      {
            gatoModelado = true;
            vacaModelado = false;
            perroModelado = false;
            ratonModelado = false;
            caballoModelado = false;
            palomaModelado = false;
            cerdoModelado = false;
            ovejaModelado = false;
            serpienteModelado = false;
            conejoModelado = false;
            GuardarModelado();
    }

    public void GuardarModelado()
    {
            PlayerPrefs.SetInt("ModeladoVacaDetect", vacaModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoSerpienteDetect", serpienteModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoConejoDetect", conejoModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoRatonDetect", ratonModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoCaballoDetect", caballoModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoPerroDetect", perroModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoGatoDetect", gatoModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoPalomaDetect", palomaModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoOvejaDetect", ovejaModelado ?1:0);
            PlayerPrefs.SetInt("ModeladoCerdoDetect", cerdoModelado ?1:0);
      }
    
}
