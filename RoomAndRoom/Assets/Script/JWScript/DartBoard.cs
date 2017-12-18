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
}
