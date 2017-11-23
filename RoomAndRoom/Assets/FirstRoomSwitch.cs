using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FirstRoomSwitch : MonoBehaviour {
    public Material On;
    public Material Off;
    bool ONOFF = true;
    public GameObject lamp;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = On;
        lamp.SetActive(false);
	}
    public void LightSwitch()
    {
        ONOFF = !ONOFF;
        if (ONOFF == true)
        {
            GetComponent<Renderer>().material = On;
            lamp.SetActive(false);
        }
        else if (ONOFF == false)
        {
            GetComponent<Renderer>().material = Off;
            lamp.SetActive(true);
        }
    }
}
