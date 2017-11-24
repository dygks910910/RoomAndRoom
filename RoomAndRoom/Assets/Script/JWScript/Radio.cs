using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour {
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public void RadioSizeUp()
    {
        transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
    }
    public void RadioSizeDown()
    {
        transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
    }
    public void ClickRadio(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-12.0f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
