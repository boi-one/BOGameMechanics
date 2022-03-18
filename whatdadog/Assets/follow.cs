using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    Vector3 offset = new Vector3(5,0,0);
    public GameObject following;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = following.transform.position + offset;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = following.transform.position - offset;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position -= offset/1.5f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += offset/1.5f;
        }
    }
}
