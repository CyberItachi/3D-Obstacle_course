using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //using float coz time dot time is float....
    [SerializeField]float timer;
    MeshRenderer rrr;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rrr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rrr.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timer){
            rb.useGravity = true;
            rrr.enabled = true;
        }
    }
}
