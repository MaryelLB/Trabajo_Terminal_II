using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void animaciones(){
        if(GetComponent<Visualizar_Modelados>().vacaModelado==true){
            anim.Play("Vaca");
            Debug.Log("Animacion vaca en el avatar hombre");
            
        }
    }

}
