using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform body;
    public float sensitivity = 500f;
    public float xClamp;
    public GameObject weaponType1;
    public GameObject weaponType2;
    public GameObject weaponType3;
    public GameObject weaponType4;
    public float arme = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseXaxis = Input.GetAxis("Mouse X") * sensitivity*Time.deltaTime;
        float mouseYaxis = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xClamp -= mouseYaxis;
        xClamp = Mathf.Clamp(xClamp, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xClamp, 0f, 0f);
        body.Rotate(Vector3.up * mouseXaxis);

        if (Input.GetKeyDown("1") && arme != 1f)
        {
            weaponType1.SetActive(true);
            weaponType2.SetActive(false);
            weaponType3.SetActive(false);
            weaponType4.SetActive(false);
            arme = 1f;

        }
        if (Input.GetKeyDown("2") && arme != 2f)
        {
            weaponType1.SetActive(false);
            weaponType2.SetActive(true);
            weaponType3.SetActive(false);
            weaponType4.SetActive(false);
            arme = 2f;

        }
        if (Input.GetKeyDown("3") && arme != 3f)
        {
            weaponType1.SetActive(false);
            weaponType2.SetActive(false);
            weaponType3.SetActive(true);
            weaponType4.SetActive(false);
            arme = 3f;

        }
        if (Input.GetKeyDown("4")&& arme != 4f)
        {
            weaponType1.SetActive(false);
            weaponType2.SetActive(false);
            weaponType3.SetActive(false);
            weaponType4.SetActive(true);
            arme = 4f;
        }


    }
}
