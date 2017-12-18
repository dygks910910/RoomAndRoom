using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketBook : MonoBehaviour {
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 2.5f;
    public void SizeUp()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    public void ClickBook(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-22.8f, -6.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
