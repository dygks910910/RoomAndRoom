using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartBoard : MonoBehaviour {
    public GameObject Light;
    GameObject Ppos;
    GameObject Dpos;
    public static DartBoard dartinstence;
    public bool PickCheck = false;
    public bool GetDart = false;
    void Awake()
    {
        DartBoard.dartinstence = this;
    }
    void Start()
    {
        Ppos = GameObject.Find("Player");
        Dpos = GameObject.Find("DartPos");
    }
    public void DartEnter()
    {
        if (Ppos.transform.position.x == Dpos.transform.position.x)
        {
            Light.SetActive(true);
        }
    }
    public void DartEixt()
    {
        Light.SetActive(false);
    }
    public void Update()
    {
        if (GetDart == true)
        {
            Dart.DartIns.DDart.transform.localPosition = new Vector3(0.0f, 0.07f, 1.3f);
            Dart.DartIns.DDart.transform.localRotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
            Dart.DartIns.DDart.transform.localScale = new Vector3(4, 4, 4);
            if (Dart.DartIns.DDart.transform.localPosition.x == 0.0)
            {
                GetDart = false;
            }
        }
    }
}
