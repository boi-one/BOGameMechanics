using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.position += new Vector3(-1, 0, 0);

        if (transform.position.x > -10)
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if(transform.position.x > 10)
        {
            transform.position += new Vector3(1, 0, 0);
        }
    }
}
