using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = PlayerMovement.Instance.checkPoint.transform.position;
        }
    }
}
