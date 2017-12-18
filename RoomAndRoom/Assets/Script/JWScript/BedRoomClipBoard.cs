using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedRoomClipBoard : MonoBehaviour {
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public void ClickBoard(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-17.88f, -6.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
