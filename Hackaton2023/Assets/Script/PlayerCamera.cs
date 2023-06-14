using System.Collections;

using System.Collections.Generic;

using UnityEngine;




public class PlayerCamera : MonoBehaviour

{

    public Transform body;

    public float sensitivity = 500f;

    float xClamp;

    

    public GameObject weaponFire;
    public GameObject weaponWater;
    public GameObject weaponNature;
    public int powerStage = 0;
    public float arme = 1f;

    // Start is called before the first frame update

    void Start()

    {

        Cursor.lockState = CursorLockMode.Locked;

    }




    // Update is called once per frame

    void Update()

    {

        float mouseXaxis = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        float mouseYaxis = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xClamp -= mouseYaxis;

        xClamp = Mathf.Clamp(xClamp, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xClamp, 0f, 0f);

        body.Rotate(Vector3.up * mouseXaxis);

        if (powerStage >= 1 && Input.GetKeyDown("1") && arme != 1f)
        {
            Debug.Log("Eau");
                weaponWater.SetActive(true);
                weaponFire.SetActive(false);
                weaponNature.SetActive(false);
                arme = 1f;
            
        }
        if (powerStage >= 2 && Input.GetKeyDown("2") && arme != 2f)
            {
            Debug.Log("Feu");
                weaponFire.SetActive(true);
                weaponWater.SetActive(false);
                weaponNature.SetActive(false);
                arme = 2f;

            }
            
        
        if (powerStage >= 3 && Input.GetKeyDown("3") && arme != 3f) 
            {

                weaponFire.SetActive(false);
                weaponWater.SetActive(false);
                weaponNature.SetActive(true);
                arme = 3f;

            }


    }



}



