using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController character;
    public float characterSpeed = 20f;
    public float gravity;
    public bool canJump = false;

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
        if (character.isGrounded)
        {
            gravity = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true && gravity <=0.01)
        {
            ///Vector3 jump = transform.forward + transform.up * 3;
            ///character.Move(jump);
            gravity = 1;
        }
        character.Move(movement * characterSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bottes"))
        {
            canJump = true;
        }
    }
}