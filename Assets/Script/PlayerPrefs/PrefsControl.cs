using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsControl : MonoBehaviour
{
    public void SetFloatPlayerPrefs(float value){
        PlayerPrefs.SetFloat("test_float", value);
    }

    public float GetFloatPlayerPrefs(){
        return PlayerPrefs.GetFloat("test_float", 0)); 
    }
}
