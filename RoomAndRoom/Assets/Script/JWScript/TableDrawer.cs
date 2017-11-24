using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableDrawer : MonoBehaviour {
    int Count = 0;
    public TextMesh tx;
    public GameObject Clue;
    public float TextRemoveTime=1.0f;
    AudioSource audios;
    public AudioClip open;
    void Start()
    {
        audios = GetComponent<AudioSource>();
    }
    public void ClickDrawer(string hint)
    {
        Count += 1;
        if (Count == 3)
        {
            audios.PlayOneShot(open);
            Clue.transform.localPosition = new Vector3(-8.5f, -9.5f, 32.35f);
            tx.text = hint;
            transform.localPosition = new Vector3(0.5270813f, 0.5884488f, 5.3f * Time.deltaTime);
            Collider col = GetComponent<Collider>();
            col.enabled = false;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
    }
    public void hint1(string hint)
    {
        if (Count == 1)
        {
            Clue.transform.localPosition = new Vector3(-11.0f,-9.5f,32.35f);
            tx.text = hint;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
    }
    public void hint2(string hint)
    {
        if (Count == 2)
        {
            Clue.transform.localPosition = new Vector3(-8.8f, -9.5f, 32.35f);
            tx.text = hint;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
