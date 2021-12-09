using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoSubmarino : MonoBehaviour {
    public float velocidadeX, velocidadeY;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(10.4f, -2.37f, 0.0f);

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadeX * Time.deltaTime, velocidadeY * Time.deltaTime, 0.0f);

        if (transform.position.x < -10.23)
        {
            transform.position = new Vector3(10.4f, -2.37f, 0.0f);
        }
             
		
	}
   
    
}
