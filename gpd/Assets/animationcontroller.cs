using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{
    public int down;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(down * Time.deltaTime, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.Rotate(-down * Time.deltaTime, 0, 0);
        }
    }
}
