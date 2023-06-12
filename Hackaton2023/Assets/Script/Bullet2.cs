using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{

    public float timer;
    void Start()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }

    }

    
}
