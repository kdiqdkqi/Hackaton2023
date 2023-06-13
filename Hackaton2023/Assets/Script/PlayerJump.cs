using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public CharacterController character;
    public float jumpForce = 2f;
    public float gravity;

    private Vector3 movementDirection;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (character.isGrounded)
        {
            gravity = 0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
                Debug.Log("Espace");
            }
        }
        else
        {
            gravity -= Time.deltaTime * 9.81f; // Utilise la gravité terrestre
        }

        movementDirection.y = gravity;

        character.Move(movementDirection * Time.deltaTime);
    }

    private void Jump()
    {
        gravity = jumpForce;
    }
}