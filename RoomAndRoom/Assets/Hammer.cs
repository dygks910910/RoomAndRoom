using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {
    public static Hammer Hm;
    GameObject GvrPointer;
    public Collider col;
    public Rigidbody rigi;
    bool picksize = false;
    public bool HammerCheck=false;
    public GameObject HmTx;
    // Use this for initialization
    void Awake()
    {
        Hammer.Hm = this;
    }
    void Start () {
        GvrPointer = GameObject.Find("GvrReticlePointer");
        this.col = GetComponent<Collider>();
        this.rigi = GetComponent<Rigidbody>();
        HmTx = GameObject.Find("ItemText");
    }
    public void SizeUp()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    public void PickThings()
    {
        if (BedRoomPickingControl.PK.Thing == null)
        {
            HmTx.SetActive(false);
            HammerCheck = true;
            PutThings.Pt.PutHammerCheck = HammerCheck;
            picksize = true;
            rigi.useGravity = false;
            PutThings.Pt.Putcol = col;
            PutThings.Pt.Putrigi = rigi;
            BedRoomPickingControl.PK.Thing = this.gameObject;
            transform.parent = GvrPointer.transform;
            col.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (picksize == true)
        {
            BedRoomPickingControl.PK.Thing.transform.localPosition = new Vector3(-0.05f, -0.135f, 0.98f);
            BedRoomPickingControl.PK.Thing.transform.localEulerAngles = new Vector3(0.0f, 0.0f, -37.78f);
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(0.4f, 0.4f, 1);
            picksize = false;
        }
    }
}
