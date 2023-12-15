using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float xRotation;
    [SerializeField]float yRotation;
    [SerializeField]float zRotation;

    void Update()
    {
        transform.Rotate(xRotation * Time.deltaTime ,yRotation * Time.deltaTime ,zRotation * Time.deltaTime);
    }
}
