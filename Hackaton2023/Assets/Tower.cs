using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bullet;
    public float speed = 10f;
    public float delay;
    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if(timer> delay)
        {
            Rigidbody bulletInstance = Instantiate(bullet, shootPoint.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            bulletInstance.AddForce(transform.forward * 30f, ForceMode.Impulse);
            timer = 0;
        }
        
        
        



    }

   

}
