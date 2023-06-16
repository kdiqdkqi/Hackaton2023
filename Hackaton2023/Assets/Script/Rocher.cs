using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocher : MonoBehaviour
{
    // Start is called before the first frame update
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement.Instance.pv -= 1f;
            Destroy(gameObject);
        }
    }


}