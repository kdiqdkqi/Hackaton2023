using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMouvement : MonoBehaviour
{
    public float rotationSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        float newYRotation = currentRotation.y + rotationSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(currentRotation.x, newYRotation, currentRotation.z);
    }
}
