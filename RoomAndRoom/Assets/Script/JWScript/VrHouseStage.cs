using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrHouseStage : MonoBehaviour {
    public static VrHouseStage instance;
    public GameObject CokeCan;
    public GameObject Beer;
    public GameObject Champagne;
    public GameObject Key;
    public bool GetCokeCan = false;
    public bool GetBeer=false;
    public bool GetChampagne = false;
    public bool GetKey = false;
    public int Count = 0;
    public bool PickCheck=false;
    // Use this for initialization  
    public void Awake()
    {
        VrHouseStage.instance = this;
    }
    public void Update()
    {
        if (GetCokeCan == true)
        {
            CokeCan.transform.localPosition = new Vector3(0.0f, -0.8f, 11.0f);
            CokeCan.transform.localRotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
            CokeCan.transform.localScale = new Vector3(10, 10, 10);
            if (CokeCan.transform.localPosition.x == 0.0)
            {
                GetCokeCan = false;
            }
        }
        else if (GetBeer == true)
        {
            Beer.transform.localPosition = new Vector3(0.0f, 0.2f, 12.0f);
            Beer.transform.localRotation = new Quaternion(0.0f,45.0f, 0.0f,45.0f);
            Beer.transform.localScale = new Vector3(10, 10, 10);
            if (Beer.transform.localPosition.x == 0.0)
            {
                GetBeer= false;
            }
        }
        else if (GetChampagne == true)
        {
            Champagne.transform.localPosition = new Vector3(0.0f, 0.2f, 12.0f);
            Champagne.transform.localRotation = new Quaternion(0.0f, 45.0f, 0.0f, 45.0f);
            Champagne.transform.localScale = new Vector3(12, 12, 12);
            if (Champagne.transform.localPosition.x == 0.0)
            {
                GetChampagne = false;
            }
        }
        else if (GetKey == true)
        {
            Key.transform.localPosition = new Vector3(0.0f, -0.12f, 11.0f);
            Key.transform.localRotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
            Key.transform.localScale = new Vector3(30, 30, 20);
            if (Key.transform.localPosition.x == 0.0)
            {
                GetKey = false;
            }
        }
    }
    
}
