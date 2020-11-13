using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqrObj : MonoBehaviour
{
    public static int num = 0;
    void Awake()
    {
        num = 1;
        Debug.Log("Cube: Test in Awake | Sphere Num is " + SphereObj.num);
    }

    // Start is called before the first frame update
    void Start()
    {
        num = 2;
        Debug.Log("Cube: Test in Start | Sphere Num is " + SphereObj.num);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
