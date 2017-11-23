using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour {
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public void  DarkBookSizeUp()
    {
        transform.localScale = new Vector3(25, 25, 25);
    }
    public void DarkBookSizeDown()
    {
        transform.localScale = new Vector3(20,20,20);
    }
    public void ClickDark(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-4.5f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    //***********************************************************
    public void InBookSizeUp()
    {
        transform.localScale = new Vector3(25, 25, 25);
    }
    public void InBookSizeDown()
    {
        transform.localScale = new Vector3(20, 20, 20);
    }
    public void ClickInBook(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-4.5f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    //***********************************************************
    public void RightAnswerBookSizeUp()
    {
        transform.localScale = new Vector3(25, 25, 25);
    }
    public void RightAnswerBookSizeDown()
    {
        transform.localScale = new Vector3(20, 20, 20);
    }
    public void ClickRightAnswerBook(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-4.5f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    //***********************************************************
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
