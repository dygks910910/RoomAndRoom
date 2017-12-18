using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour {
    public TextMesh tx;
    public GameObject Textbox;
    public GameObject PutTx;
    public bool PutChessCheck = false;
    public GameObject Che;
    public float TextRemoveTime = 1.5f;
    public static Chess Ch;
    public GameObject RealChess;
    public GameObject DummyChess;
    public GameObject Clue;

    void Awake()
    {
        Chess.Ch = this;
    }
    void Start()
    {
        Che = GameObject.Find("chess");
        PutTx = GameObject.Find("ItemText");

    }
    public void ClickChess(string lines)
    {
        if (PutChessCheck==false)
        {
            Textbox.transform.localPosition = new Vector3(-15.8f, -9.5f, 32.35f);
            tx.text = lines;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
        if (BedRoomPickingControl.PK.Thing != null && PutChessCheck == true)
        {
            Textbox.transform.localPosition = new Vector3(-5.7f, -9.5f, 32.35f);
            tx.text = "Cheak Mate";
            StartCoroutine(TextInitialize(TextRemoveTime));
            PutTx.SetActive(true);
            Debug.Log("ChessCheck");
            chessQueen.Cq.ChessCheck = false;
            //PutChessCheck = false;
            RealChess.SetActive(false);
            DummyChess.SetActive(true);
            Clue.SetActive(true);
            BedRoomPickingControl.PK.Thing = null;
        }
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}

