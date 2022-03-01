using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(0.4f ,0, 0) * ((Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0.4f, 0, 0) * ((Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0.6f, 0) * ((Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= new Vector3(0, 0, 0.4f) * ((Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, 0.4f) * ((Time.deltaTime) * speed);
        }
    }
}
