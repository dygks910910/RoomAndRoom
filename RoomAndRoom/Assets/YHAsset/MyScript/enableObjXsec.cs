using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableObjXsec : MonoBehaviour {

    private float elapsedTime;
    private bool isEnable=false;
    public float xSec;
    public GameObject targetObj;
	// Update is called once per frame
	void Update () {
		if(isEnable && xSec > elapsedTime)
        {
            targetObj.SetActive(true);
            elapsedTime += Time.deltaTime;
        }
        else
        {
            isEnable = false;
            targetObj.SetActive(false);
            elapsedTime = 0;
        }
	}
    public void EnableObj()
    {
        isEnable = true;
    }
}
