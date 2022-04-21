using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            
            Destroy(other.gameObject);
        }
    }
}
