using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetect : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public int number = 0;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        //Initialise Ray
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Print out the current number value to the console window
         Debug.Log("Number is currently: " + number); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
          Debug.Log ("MouseDown");
          // Reset ray with new mouse position
          ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
          RaycastHit[] hits = Physics.RaycastAll (ray);
          foreach (RaycastHit hit in hits) {
              if (hit.collider.gameObject.tag == "Target") {
                  Target = hit.collider.gameObject;
                  Debug.Log ("Hit");
              }
          }
      }
    }
}
