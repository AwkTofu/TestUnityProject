using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPress : MonoBehaviour
{
    GameObject gameController;
    public void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }
    public void getFloat()
    {
        PrefsControl pc = gameController.GetComponent<PrefsControl>();
        float theFloatValue = pc.GetFloatPlayerPrefs();
        Debug.Log("Float Value: " + theFloatValue);
    }

    public void addOne()
    {
        PrefsControl pc = gameController.GetComponent<PrefsControl>();
        float theFloatValue = pc.GetFloatPlayerPrefs();
        Debug.Log(theFloatValue);
        pc.SetFloatPlayerPrefs(theFloatValue + 1);
    } 
}
