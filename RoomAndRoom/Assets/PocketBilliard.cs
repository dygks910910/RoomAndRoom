using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketBilliard : MonoBehaviour {
    public static PocketBilliard PB;
    GameObject GvrPointer;
    public Collider col;
    public Rigidbody rigi;
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
    public void PickThings()
    {
        if (BedRoomPickingControl.PK.Thing == null)
        {
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
		
	}
}
