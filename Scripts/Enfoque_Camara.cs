using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Enfoque_Camara : MonoBehaviour
{
    void Start(){

        VuforiaApplication.Instance.OnVuforiaStarted+= InciarVuforiaAutoFocus;
    }

    public void InciarVuforiaAutoFocus(){
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

}
