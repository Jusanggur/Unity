using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 0.3f; 
    private bool emX;
    private bool emY;
    private bool emZ;

    // Start is called before the first frame update
    void Start()
    {
        emX = (Random.value > 0.6f);
        emY = (Random.value > 0.6f);
        emZ = (Random.value > 0.6f);
        
    }

    // Update is called once per frame
    void Update()
    {
       if (emX){ 
        gameObject.transform.Translate(Vector3.right * Mathf.Cos(UnityEngine.Time.timeSinceLevelLoad) * velocidade, Space.World);
    }
       if (emY){ 
        gameObject.transform.Translate(Vector3.back * Mathf.Cos(UnityEngine.Time.timeSinceLevelLoad) * velocidade, Space.World);
    }
       if (emZ){
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(UnityEngine.Time.timeSinceLevelLoad) * velocidade, Space.World);
    }
    }
}
