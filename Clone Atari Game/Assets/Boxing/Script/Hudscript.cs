using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hudscript : MonoBehaviour {
    public Text tempo, textoPlacar1, textoPlacar2;
    public static int placar1, placar2;
    

    
	
	void Start () {
        placar1 =0;
        placar2 =0;

	}
	
	
	void Update () {
        textoPlacar1.text = placar1.ToString();
        textoPlacar2.text = placar2.ToString();

       
	}
}
