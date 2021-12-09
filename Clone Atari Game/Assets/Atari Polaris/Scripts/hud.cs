using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud : MonoBehaviour {
    public Text textoPontos;
    public static int pontos;
    public Text textoVida;
    public static int vida;


    // Use this for initialization
    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        textoPontos.text = pontos.ToString();
        textoVida.text = vida.ToString();

        
        
    }
}
