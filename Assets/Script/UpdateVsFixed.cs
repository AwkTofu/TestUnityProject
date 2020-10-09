using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVsFixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate: " + Time.deltaTime);
        Debug.Log("FixedUpdate: " + Time.fixedDeltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update: " + Time.deltaTime);
    }
}
