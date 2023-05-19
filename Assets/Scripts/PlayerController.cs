using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Vector3 moveDirection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //transform.Translate(moveDirection * Time.deltaTime * moveSpeed);
        transform.position = transform.position + (moveDirection * Time.deltaTime * moveSpeed);
    }
}
