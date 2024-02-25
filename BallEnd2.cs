using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnd2 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        // Check if the triggering object is tagged as "Ball"
        if (col.tag == "Ball")
        {
            // Trigger game over
           Debug.Log("Hello");
        }
    }
}
