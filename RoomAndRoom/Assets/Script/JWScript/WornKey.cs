using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WornKey : MonoBehaviour {
    public GameObject GvrPointer;
    public bool pick=false;
    public static WornKey Instancekey;
    void Awake()
    {
        WornKey.Instancekey = this;
    }
    public void KeyEnter()
    {
        transform.localPosition = new Vector3(-3.98f,0.5f,0.52f);
        transform.localScale = new Vector3(250,200,200);
    }
    public void KeyExit()
    {
        transform.localPosition = new Vector3(-3.98f, -1.0f, 0.52f);
        transform.localScale = new Vector3(180.337f, 144.2696f, 144.2696f);
    }
    public void Getkey()
    {
        if (VrHouseStage.instance.PickCheck == false)
        {
            pick = true;
            transform.parent = GvrPointer.transform;
            Collider col = GetComponent<Collider>();
            VrHouseStage.instance.GetKey = true;
            col.enabled = false;
            VrHouseStage.instance.PickCheck = true;
        }
    }
}
