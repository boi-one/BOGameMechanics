using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform prefab;
    public int speed = 10000;
    private Transform playertransform;
    private Transform cameratransform;
    // Start is called before the first frame update
    void Start()
    {
        playertransform = GameObject.Find("player").transform;
        cameratransform = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Transform bullet = Instantiate(prefab);
            bullet.transform.position = transform.position;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            Vector3 vel = (Quaternion.Euler(cameratransform.eulerAngles.x, playertransform.eulerAngles.y, 0) * Vector3.forward * speed);
            //vel.z = 0;
            rb.AddForce (vel);
        }       
    }
}
