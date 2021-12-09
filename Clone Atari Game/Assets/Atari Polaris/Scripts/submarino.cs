using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class submarino : MonoBehaviour {
    public float velocidade;
    SpriteRenderer sr;
    public static int vida;
    

	
	void Start () {
        transform.position = new Vector3(-7.49f, -1.56f, 0.0f);
        hud.pontos = 0;
        hud.vida = 3;

        
		
	}
	
	
	void Update () {
        if(hud.vida < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
        if(hud.pontos == 100)
        {
            SceneManager.LoadScene("pre2");
        }

        Movimentar(velocidade);
       
        
        

    }
    void Movimentar(float vel)
    {
        
        float px = Input.GetAxisRaw("Horizontal") * vel * Time.deltaTime;
        float py = Input.GetAxisRaw("Vertical") * vel * Time.deltaTime;
        transform.Translate(px, py, 0.0f);
        
       
        if (Input.GetAxisRaw("Horizontal") < 0.0f)
        {
            sr = GetComponent<SpriteRenderer>();
            sr.flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0.0f)
        {
            sr = GetComponent<SpriteRenderer>();
            sr.flipX = false;
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "inimigo")
        {
            transform.position = new Vector3(-7.49f, -1.56f, 0.0f);
            hud.vida--;
            
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "morre")
        {
            transform.position = new Vector3(-7.49f, -1.56f, 0.0f);
            hud.vida--;
            

        }
        if (collision.collider.tag == "inimigo")
        {
            transform.position = new Vector3(-7.49f, -1.56f, 0.0f);
            hud.vida--;
            
        }
    }
    
   
   
}
