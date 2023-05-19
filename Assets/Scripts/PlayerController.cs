using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale = 5.0f;

    private Vector3 moveDirection;

    public CharacterController characterController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ystore = moveDirection.y;
        //movimiento
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y = ystore;
        //transform.Translate(moveDirection * Time.deltaTime * moveSpeed);

        //salto
        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
