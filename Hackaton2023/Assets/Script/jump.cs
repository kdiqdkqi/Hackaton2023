using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce = 2f; 

    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {


        if (Input.GetKeyDown("v"))

        {

            Jump();
            Debug.Log("lama");

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Jump()

    {

        gravity = jumpForce;

    }
}
