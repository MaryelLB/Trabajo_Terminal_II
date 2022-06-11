using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GIF_Elemento : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] ImagenAnimada; // Array que contendra el numero de frames
    public Image ObjetoAnimado; // El objeto que contendra la animacion del elemento GIF

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tiempo en que se animara el elemento GIF
        ObjetoAnimado.sprite= ImagenAnimada[(int)(Time.time*10)%ImagenAnimada.Length]; 
    }
 
}
