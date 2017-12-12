using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart : MonoBehaviour {
    public GameObject GvrPointer;
    public static Dart DartIns;
    public GameObject DDart; 
    public void Awake()
    {
        Dart.DartIns = this;
    }
    public void SizeUp()
    {
        transform.localScale = new Vector3(4, 4, 4);
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void ClickBoard()
    {
        DDart.SetActive(false);
        DartBoard.dartinstence.PickCheck = false;
        
    }
    public void GetDart(GameObject obj)
    {
        DDart = obj;
        if (DartBoard.dartinstence.PickCheck == false)
        {
            transform.parent = GvrPointer.transform;
            Collider col = GetComponent<Collider>();
            DartBoard.dartinstence.GetDart = true;
            col.enabled = false;
            DartBoard.dartinstence.PickCheck = true;
        }
    }
}
