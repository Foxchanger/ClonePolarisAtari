using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
    public float velocidade;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Mover(velocidade);
    }
    void Mover(float vel)
    {
        float px = Input.GetAxis("Horizontal2") * velocidade * Time.deltaTime;
        float py = Input.GetAxis("Vertical2") * velocidade * Time.deltaTime;
        transform.Translate(px, py, 0.0f);

    }
}
