using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {
    public Light UIlight;
    bool LightCheck=false;
    public void ChangeGameScene(string sceneName)
    {
        LightCheck = true;
        if (UIlight.intensity <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    void Update()
    {
        if (LightCheck == true)
        {
            UIlight.intensity -=0.15f* Time.deltaTime;           
            //LightCheck = false;
        }
    }
}
