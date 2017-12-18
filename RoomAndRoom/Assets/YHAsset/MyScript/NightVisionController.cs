using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightVisionController : MonoBehaviour {
    //3초켜졌다가 2초꺼짐
    private float MAX_TIME = 3;
    private float MIN_TIME = 2;
    [SerializeField]
    private float elapsedTime = 0;

    bool isSwitch = true;
    DeferredNightVisionEffect nightVision;
    // Use this for initialization
    void Start () {
        nightVision = gameObject.GetComponent<DeferredNightVisionEffect>();
	}
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime;
        //3초 켜짐 switch ture
        if(elapsedTime >= MAX_TIME && isSwitch)
        {
            nightVisionOn();
            isSwitch = false;
            elapsedTime = 0;
        }
        //2초 꺼짐 switch false;
        else if(elapsedTime >= MIN_TIME && isSwitch == false)
        {
            nightVisionOff();
            isSwitch = true;
            elapsedTime = 0;
        }
    }
    void nightVisionOff()
    {
        nightVision.enabled = false;
    }
    void nightVisionOn()
    {
        nightVision.enabled = true;
    }
}
