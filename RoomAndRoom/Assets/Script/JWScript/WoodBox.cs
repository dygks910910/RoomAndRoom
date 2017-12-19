using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBox : MonoBehaviour {
    public GameObject piece;
    public GameObject Pos;
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public void ClickBox(string lines)
    {
        if (Hammer.Hm.HammerCheck == false)
        {
            Textbox.transform.localPosition = new Vector3(-13.86f, -6.5f, 32.35f);
            tx.text = lines;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
        if (Hammer.Hm.HammerCheck==true)
        {
            Handheld.Vibrate();
            Instantiate(piece, Pos.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}