using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart : MonoBehaviour {
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public float zNum = 0;
    public void SizeUp()
    {
        transform.localScale = new Vector3(4, 4, 4);
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void ClickDart(string lines)
    {
        Textbox.transform.localPosition = new Vector3(zNum, -6.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));

    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
