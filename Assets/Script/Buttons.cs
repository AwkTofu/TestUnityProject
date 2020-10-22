using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressRandom()
    {
        Debug.Log("Something");
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = "test";
    }

    public void ClickSummon() {
        Debug.Log("Open up Summons Screen");
    }
}
