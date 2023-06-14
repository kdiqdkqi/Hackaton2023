using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateforme2 : MonoBehaviour
{
    public float Delais;
    // Start is called before the first frame update
    void Start()
    {
        Delais = -3;
    }

    // Update is called once per frame
    void Update()
    {
        Delais += Time.deltaTime;
        if (Delais > 0f && Delais < 5f)
        {
            gameObject.transform.Translate(-Vector3.up * Time.deltaTime);

        }
        if (Delais > 6f && Delais < 11f)
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);

        }
        if (Delais > 12f)
        {
            Delais = 0;
        }
    }
}
