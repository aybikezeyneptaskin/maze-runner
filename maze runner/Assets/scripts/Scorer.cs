using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0; //increases at the beginning of the game
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Plane" && other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log($"You've bumped into something {hits} times");
            //Debug.Log("You've bumped into a wall" + hits);
        }


    }
}
