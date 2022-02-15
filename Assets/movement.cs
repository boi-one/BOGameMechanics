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
            transform.position += transform.right * (Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * (Time.deltaTime * speed);
        }
        if (Input System.GetKey(KeyCode.Space))
    }
}
