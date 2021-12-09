using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class contagemRegressiva : MonoBehaviour {
    public Text tempo;
    public float contagem;
      	
		void Update () {
        if (contagem > 0.0f)
        {
            contagem -= Time.deltaTime;
            tempo.text = contagem.ToString("f0");
        }
        else
        {
            tempo.text = "Acabou Tempo";
        }
    }
}
