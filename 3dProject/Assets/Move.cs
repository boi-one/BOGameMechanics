using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public bool canJump = false;
    Vector3 startpos;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startpos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-6, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(6, 0, 0) * Time.deltaTime;
        }
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && canJump == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, 8, 0);
        }
        if (transform.position.z > 0)
        {
            transform.position = new Vector3(rb.position.x, rb.position.y, 0);
        }
        if(transform.position.y < -1)
        {
            transform.position = startpos;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        canJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
        Debug.Log("werkt");
    }
}
