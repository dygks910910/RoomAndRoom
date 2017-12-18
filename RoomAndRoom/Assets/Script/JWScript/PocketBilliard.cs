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
    public GameObject PkTx;
    //************TEXT*****************
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 2.5f;
    //*********************************
    // Use this for initialization
    void Awake()
    {
        PocketBilliard.PB = this;
    }
    void Start () {
        GvrPointer = GameObject.Find("GvrReticlePointer");
        this.col = GetComponent<Collider>();
        this.rigi = GetComponent<Rigidbody>();
        PkTx = GameObject.Find("ItemText");
    }
    public void ClickEnter()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void ClickExit()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    public void PickThings(string lines)
    {
        if (BedRoomPickingControl.PK.Thing == null)
        {
            Textbox.transform.localPosition = new Vector3(-0.68f, -6.5f, 32.35f);
            tx.text = lines;
            StartCoroutine(TextInitialize(TextRemoveTime));
            PkTx.SetActive(false);
            BallCheck = true;
            PutThings.Pt.PutBallCheck = BallCheck;
            picksize = true;
            rigi.useGravity = false;
            PutThings.Pt.Putcol=col;
            PutThings.Pt.Putrigi = rigi;
            BedRoomPickingControl.PK.Thing =this.gameObject;
            transform.parent = GvrPointer.transform;
            col.enabled = false;
        }
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
    // Update is called once per frame
    void Update () {
        if (picksize == true)
        {
            BedRoomPickingControl.PK.Thing.transform.localPosition = new Vector3(0.0f, -0.087f, 0.99f);
            BedRoomPickingControl.PK.Thing.transform.localEulerAngles = new Vector3(40.92f, 0.0f, 37.75f);
            BedRoomPickingControl.PK.Thing.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            picksize = false;
        }		
	}
}
