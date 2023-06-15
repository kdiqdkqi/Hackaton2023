using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController character;
    public float characterSpeed = 20f;
    public float gravity;
    public bool canJump = false;
    public GameObject weaponFire;
    public GameObject weaponWater;
    public GameObject weaponNature;
    public int powerStage = 0;
    public float arme = 1f;
    public GameObject tpFinal;
    
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");


        Vector3 movement = transform.right * xMovement + transform.forward * zMovement;
        
        
        if (!character.isGrounded)
        {
            movement.y = gravity;
            gravity -= 2 * Time.deltaTime;
            

        }

        if (gravity <-2)

        {
            gravity = -0.9f;
        }




        if (Input.GetKeyDown(KeyCode.Space) && canJump && gravity <-0.9  )
        {
            
            ///Vector3 jump = transform.forward + transform.up * 3;
            ///character.Move(jump);
            gravity = 1;

            
        }

        character.Move(movement * characterSpeed * Time.deltaTime);


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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bottes"))
        {
            canJump = true;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Power1"))
        {
            powerStage = 1;
            weaponWater.SetActive(true);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Power2"))
        {
            powerStage = 2;
            Destroy(other.gameObject);

        }
        if (other.CompareTag("Power3"))
        {
            powerStage = 3;
            Destroy(other.gameObject);
            tpFinal.SetActive(true);

        }
        
        

    }
   

}