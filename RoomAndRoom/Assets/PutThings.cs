using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutThings : MonoBehaviour {
    public Collider Putcol;
    public Rigidbody Putrigi;
    public static PutThings Pt;
    // Use this for initialization
    void Awake()
    {
        PutThings.Pt = this;
    }
    public void Put()
    {
        if (BedRoomPickingControl.PK.Thing != null)
        {
            Debug.Log("Check");
            Putcol.enabled = true;
            Putrigi.useGravity = true;
            BedRoomPickingControl.PK.Thing.transform.parent = null;
            BedRoomPickingControl.PK.Thing = null;
        }
    }
}
