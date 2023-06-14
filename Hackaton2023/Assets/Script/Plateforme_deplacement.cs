using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateformedeplacement : MonoBehaviour
{
    public float Delais;

    void Start()
    {
        Delais = 0;
    }

    
    void Update()
    {
        Delais += Time.deltaTime;
        if (Delais > 0f && Delais < 5f) 
        { 
            gameObject.transform.Translate(-Vector3.right * Time.deltaTime);

        }
        if (Delais > 6f && Delais < 11f)
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime);

        }
        if (Delais > 12f)
        {
            Delais = 0;
        }
    }
}
