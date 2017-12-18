using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutThings : MonoBehaviour {
    public Collider Putcol;
    public Rigidbody Putrigi;
    public static PutThings Pt;
    public GameObject Rack;
    public GameObject Ham;
    public bool PutBallCheck = false;
    public bool PutHammerCheck = false;
    public GameObject PutTx;
    // Use this for initialization
    void Awake()
    {
        PutThings.Pt = this;
    }
    void Start()
    {
        Rack = GameObject.Find("Rack");
        Ham = GameObject.Find("Hammers");
        PutTx = GameObject.Find("ItemText");

    }
    public void Put()
    {
        if (BedRoomPickingControl.PK.Thing != null && PutBallCheck==true)
        {
            PutTx.SetActive(true);
            Debug.Log("PoketCheck");
            PocketBilliard.PB.BallCheck = false;
            PutBallCheck = false;
            Putcol.enabled = true;
            Putrigi.useGravity = true;
            BedRoomPickingControl.PK.Thing.transform.parent =Rack.transform ;
            //BedRoomPickingControl.PK.Thing.transform.position
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1, 1, 1);
            BedRoomPickingControl.PK.Thing = null;
        }
        if (BedRoomPickingControl.PK.Thing != null && PutHammerCheck==true)
        {
            PutTx.SetActive(true);
            Debug.Log("HammerCheck");
            Hammer.Hm.HammerCheck =false;
            PutHammerCheck = false;
            Putcol.enabled = true;
            Putrigi.useGravity = true;
            BedRoomPickingControl.PK.Thing.transform.parent = Ham.transform;
            //BedRoomPickingControl.PK.Thing.transform.position
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            BedRoomPickingControl.PK.Thing = null;
        }
    }
}
