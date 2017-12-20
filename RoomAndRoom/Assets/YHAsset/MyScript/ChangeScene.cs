﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {
    public Light UIlight;
    [SerializeField]
    bool LightCheck=false;
    string Name;
    public float LightValue=0.25f; 
    public void ChangeGameScene(string sceneName)
    {
        Name = sceneName;
        LightCheck = true;
    }
    void Update()
    {
        if (LightCheck == true)
        {
            UIlight.intensity -=LightValue* Time.deltaTime;
            if (UIlight.intensity <= 0)
            {
                print("씬전환");
                LightCheck = false;
                SceneManager.LoadScene(Name);
            }
        }
    }
}
