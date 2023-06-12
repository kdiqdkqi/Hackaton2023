using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.CompareTag("Ammo"))
        { 
            Debug.Log("Hello");
        }
        else 
        {
            Destroy(this.gameObject);
        }
        
    }
}

