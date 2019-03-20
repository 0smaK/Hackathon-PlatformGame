using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntuacionController : MonoBehaviour{

    public int puntuacion_val;
    Text txt_puntos;
    // Start is called before the first frame update
    void Start(){
        txt_puntos = gameObject.GetComponent<Text>(); 
        txt_puntos.text = ""+puntuacion_val;
        InvokeRepeating("sumarPuntos", 0f, 1f);
    }

    void sumarPuntos(){
        puntuacion_val++;
        txt_puntos.text=""+puntuacion_val;
    }

    void Update(){
    }
}
