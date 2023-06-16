using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public GameObject chest;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (GameObject.Find("Tree1") == null && GameObject.Find("Tree2") == null &&
                GameObject.Find("Tree3") == null && GameObject.Find("Tree4") == null &&
                GameObject.Find("Tree5") == null && GameObject.Find("Tree6") == null &&
                GameObject.Find("Tree7") == null && GameObject.Find("Tree8") == null &&
                GameObject.Find("Tree9") == null)
            {
                chest.SetActive(true);
                Destroy(gameObject);

            }
                
                

        }

    }
}
