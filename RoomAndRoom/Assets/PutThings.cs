using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutThings : MonoBehaviour {
    public Collider Putcol;
    public Rigidbody Putrigi;
    public static PutThings Pt;
    public GameObject Rack;
    public GameObject Ham;
    // Use this for initialization
    void Awake()
    {
        PutThings.Pt = this;
    }
    void Start()
    {
        Rack = GameObject.Find("Rack");
        Ham = GameObject.Find("Hammers");

    }
    public void Put()
    {
        if (BedRoomPickingControl.PK.Thing != null || PocketBilliard.PB.BallCheck == true)
        {       
            Debug.Log("Check");
            PocketBilliard.PB.BallCheck = false;
            Putcol.enabled = true;
            Putrigi.useGravity = true;
            BedRoomPickingControl.PK.Thing.transform.parent =Rack.transform ;
            //BedRoomPickingControl.PK.Thing.transform.position
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1, 1, 1);
            BedRoomPickingControl.PK.Thing = null;
        }
        else if (BedRoomPickingControl.PK.Thing != null || Hammer.Hm.HammerCheck == true)
        {
            Debug.Log("Check");
            Hammer.Hm.HammerCheck =false;
            Putcol.enabled = true;
            Putrigi.useGravity = true;
            BedRoomPickingControl.PK.Thing.transform.parent = Ham.transform;
            //BedRoomPickingControl.PK.Thing.transform.position
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1, 1, 1);
            BedRoomPickingControl.PK.Thing = null;
        }
    }
}
