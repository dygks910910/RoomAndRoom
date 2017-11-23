using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoor : MonoBehaviour {
    bool OpenDoor = false;
    public TextMesh tx;
    public GameObject Textbox;
    public GameObject key;
    AudioSource audios;
    public AudioClip open;
    public float TextRemoveTime = 1.5f;
    void Start()
    {
        audios = GetComponent<AudioSource>();
    }
    public void ClickDoor()
    {
        OpenDoor = true;
        StartCoroutine(StopRotation(1.0f));
        if (OpenDoor == true && WornKey.Instancekey.pick == true)
        {
            audios.PlayOneShot(open);
            VrHouseStage.instance.PickCheck = false;
        }
    }
    IEnumerator StopRotation(float sec)
    {
        yield return new WaitForSeconds(sec);
        OpenDoor = false;
    }
    public void Lines(string hint)
    {
        if (WornKey.Instancekey.pick == false)
        {
            Textbox.transform.localPosition = new Vector3(-16.5f, -11.49f, 32.35f);
            tx.text = hint;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
    void Update()
    {
        if (OpenDoor == true&& WornKey.Instancekey.pick == true)
        {
            key.SetActive(false);
                transform.Rotate(0.0f, -140.0f * Time.deltaTime, 0.0f);
                Collider col = GetComponent<Collider>();
                col.enabled = false;           
        }
    }
}


