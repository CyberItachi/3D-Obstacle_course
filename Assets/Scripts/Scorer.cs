using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void Update() {
    }
    private void OnCollisionEnter(Collision other) {
        hits++;
        if (other.gameObject.tag == "Hit") {
            hits--;
        }
        Debug.Log("You crashed into wall "+ hits +" time");
    }
}
