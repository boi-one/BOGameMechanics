using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class planeet : MonoBehaviour
{
    List<GameObject> planeten = new List<GameObject>(); 
    public bool isStatic = false;
    float massa = 1;
    Vector3 a = new Vector3(0,0,0); // acceleratie
    public Vector3 v = new Vector3(0,0,0); //velocity (snelheid)

    // Start is called before the first frame update
    void Start()
    {
        planeten = GameObject.FindGameObjectsWithTag("planeet").ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStatic)
        {
            return;
        }
        a = Vector3.zero; //combinatie van elke a van elke planeet in de list
        foreach (GameObject target in planeten)
        {
            if (target == gameObject)
                continue;
            //r is afstand
            Vector3 r = target.transform.position - transform.position; 
            a += (1 / (Mathf.Pow(r.magnitude, 2))) * r.normalized; //formule zwaartekracht
        }
        Debug.Log(gameObject.name + " " + a);
        v += a;
        transform.position += v / 50;
        
    }


}
