using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{
    public int down;
    private bool klik;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !klik)
        {
            StartCoroutine(bruh());
            
            
        }

    }
    IEnumerator bruh()
    {
        klik = true;
        for (int i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(0.02f);
            transform.Rotate(down * Time.deltaTime, 0, 0);    
        }
        for (int i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(0.02f);
            transform.Rotate(-down * Time.deltaTime, 0, 0);
        }
        klik = false;
    }
}
