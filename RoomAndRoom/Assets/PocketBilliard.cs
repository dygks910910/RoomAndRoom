using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketBilliard : MonoBehaviour {
    public static PocketBilliard PB;
    GameObject GvrPointer;
    public Collider col;
    public Rigidbody rigi;
    bool picksize=false;
    public bool BallCheck=false;
    // Use this for initialization
    void Awake()
    {
        PocketBilliard.PB = this;
    }
    void Start () {
        GvrPointer = GameObject.Find("GvrReticlePointer");
        this.col = GetComponent<Collider>();
        this.rigi = GetComponent<Rigidbody>();
    }
    public void ClickEnter()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void ClickExit()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    public void PickThings()
    {
        if (BedRoomPickingControl.PK.Thing == null)
        {
            BallCheck = true;
            picksize = true;
            rigi.useGravity = false;
            PutThings.Pt.Putcol=col;
            PutThings.Pt.Putrigi = rigi;
            BedRoomPickingControl.PK.Thing =this.gameObject;
            transform.parent = GvrPointer.transform;
            col.enabled = false;
        }
    }
	// Update is called once per frame
	void Update () {
        if (picksize == true)
        {
            BedRoomPickingControl.PK.Thing.transform.localPosition = new Vector3(0.0f, 0.033f, 0.7f);
            BedRoomPickingControl.PK.Thing.transform.localEulerAngles = new Vector3(40.92f, 0.0f, 37.75f);
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1, 1, 1);
            picksize = false;
        }		
	}
}
