using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class walk : MonoBehaviour
{
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 0)
        {
            Debug.Log("op de grond");
            jump = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-4, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(4, 0, 0) * Time.deltaTime;
        }
        /* if (Input.GetKeyDown(KeyCode.Space) && jump == false)
        {
            jump = true;
            transform.position += new Vector3(0, 10, 0) * Time.deltaTime;
        } */
    }
}
