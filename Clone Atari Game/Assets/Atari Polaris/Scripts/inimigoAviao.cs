using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoAviao : MonoBehaviour {
    public float velX, velY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velX * Time.deltaTime, velY * Time.deltaTime, 0.0f);
        if(transform.position.x > 10.85)
        {
            transform.position = new Vector3(-11.37f, 4.52f, 0.0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bala")
        {
            Destroy(gameObject);
            hud.pontos = hud.pontos + 100;
        }
    }

}
