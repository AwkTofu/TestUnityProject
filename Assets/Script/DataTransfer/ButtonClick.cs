using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void ClickButton1() {
        Debug.Log("Click Button1");
        SceneManager.LoadScene(1);
    }
    public void ClickButton2() {
        Debug.Log("Click Button2");
        SceneManager.LoadScene(1);
    }

    public void BackButton() {
        Debug.Log("Going Back");
        SceneManager.LoadScene(0);
    }
}
