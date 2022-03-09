using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Walk : MonoBehaviour
{
    public Rigidbody rb;
    bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float movementSpeed = 5.0f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += movementSpeed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= movementSpeed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= movementSpeed * Time.deltaTime * transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += movementSpeed * Time.deltaTime * transform.right;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * 90 * 4);
        }
        Physics.gravity = new Vector3(0, -10, 0);



    }
}