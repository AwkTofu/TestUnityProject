using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObj : MonoBehaviour
{
    public static int num = 0;
    void Awake()
    {
        num = 1;
        Debug.Log("Sphere: Test in Awake | Cube Num is " + SqrObj.num);
    }

    // Start is called before the first frame update
    void Start()
    {
        num = 2;
        Debug.Log("Sphere: Test in Start | Cube Num is " + SqrObj.num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
