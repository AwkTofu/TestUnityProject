using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVar : MonoBehaviour
{
    // Start is called before the first frame update
    public static float num= 2;
    public static string txt = "Hello World";

    void Update()
    {
        num += (Time.deltaTime * 1.5f);   

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(num);
        }
    }
}
