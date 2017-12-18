using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessQueen : MonoBehaviour {
    public static chessQueen Cq;
    GameObject GvrPointer;
    public Collider col;
    public Rigidbody rigi;
    bool picksize = false;
    public bool ChessCheck = false;
    public GameObject CqTx;
    void Awake()
    {
        chessQueen.Cq = this;
    }
    void Start()
    {
        GvrPointer = GameObject.Find("GvrReticlePointer");
        this.col = GetComponent<Collider>();
        this.rigi = GetComponent<Rigidbody>();
        CqTx = GameObject.Find("ItemText");
    }
    public void PickThings()
    {
        if (BedRoomPickingControl.PK.Thing == null)
        {
            CqTx.SetActive(false);
            ChessCheck = true;
            Chess.Ch.PutChessCheck = ChessCheck;
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
            BedRoomPickingControl.PK.Thing.transform.localPosition = new Vector3(0.9579988f, -0.1899f, 1.44f);
            BedRoomPickingControl.PK.Thing.transform.localEulerAngles = new Vector3(-90.0f, 0.0f, 0.0f);
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            picksize = false;
        }
    }
}
