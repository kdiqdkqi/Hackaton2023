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
