using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{

    public float timer;
    public float effectTimer;
    public GameObject effectParticle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(effectTimer > 0)
        {
            effectTimer -= Time.deltaTime;
        }
        else
        {
            GameObject special = Instantiate(effectParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(special,1);
        }
        if(timer > 0)
        {
            timer -= Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
