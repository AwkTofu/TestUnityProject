using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDown : MonoBehaviour
{
    public int test = 0;
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Debug.Log("Clicked on the item");
        if (test == 0)
        {
            Debug.Log("Starting with 0");
            test++;
        }
        else if (test == 1)
        {
            Debug.Log("Now at 1");
            test++;
        }
        else if (test == 2)
        {
            Debug.Log("Time to reset to 0");
            test = 0;
        }
    }
}
