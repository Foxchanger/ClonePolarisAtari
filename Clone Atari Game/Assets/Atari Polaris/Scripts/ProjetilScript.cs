using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

    public float forca;
    public static int fogo;
    


    void Start()
    {
        // Marca para detruir o projetil em 3 segundos
        Destroy(gameObject, 3.0f);
        // Impulso no projetil
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * forca);
    }
    // Update is called once per frame
    void Update () {
       
        if(fogo > 3)
        {
            Destroy(gameObject, 0.0f);

        }
		
	}
    /*void OnCollisionEnter2D(Collision2D collision)
   {
      if(collision.collider.tag == "aviao")
       {
           Destroy(gameObject);
       }
   }*/
    
}
