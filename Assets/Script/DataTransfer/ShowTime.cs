﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{

    public Text timeTxt;


    // Update is called once per frame
    void Update()
    {
        timeTxt.text = "Time: " + StaticVar.num;
    }
}
