using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustbin : MonoBehaviour {
    public GameObject Coke;
    public GameObject Beer;
    public GameObject Champagne;
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public int count = 0;
    AudioSource audios;
    public AudioClip open;
    void Start()
    {
        audios = GetComponent<AudioSource>();
    }
    // Use this for initialization
    public void ClickDust()
    {
        if (VrHouseStage.instance.PickCheck == true&&VrHouseStage.instance.CokeCan.transform.localPosition.x == 0.0f)
        {
            audios.PlayOneShot(open);
            count += 1;
           VrHouseStage.instance.CokeCan.transform.localPosition = new Vector3(1.0f, -0.8f, 11.0f);
            Coke.SetActive(false);
            VrHouseStage.instance.PickCheck = false;
        }
        else if (VrHouseStage.instance.PickCheck == true && VrHouseStage.instance.Beer.transform.localPosition.x == 0.0f)
        {
            audios.PlayOneShot(open);
            count += 1;
            VrHouseStage.instance.Beer.transform.localPosition = new Vector3(1.0f, 0.2f, 12.0f);
            this.Beer.SetActive(false);
            VrHouseStage.instance.PickCheck = false;
        }
        else if (VrHouseStage.instance.PickCheck == true && VrHouseStage.instance.Champagne.transform.localPosition.x == 0.0f)
        {
            audios.PlayOneShot(open);
            count += 1;
            VrHouseStage.instance.Champagne.transform.localPosition = new Vector3(1.0f, 0.2f, 12.0f);
            this.Champagne.SetActive(false);
            VrHouseStage.instance.PickCheck = false;
        }
    }
    public void Hint(string lines)
    {
        if (count == 3)
        {
            Textbox.transform.localPosition = new Vector3(-23.0f, -9.5f, 32.35f);
            tx.text = lines;
            StartCoroutine(TextInitialize(TextRemoveTime));
        }
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
