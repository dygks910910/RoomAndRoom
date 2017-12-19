using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUI : MonoBehaviour {
    public SpriteRenderer sp;
    public Color cr;
    AudioSource audios;
    public AudioClip buttonSD;
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        audios = GetComponent<AudioSource>();
    }
    public void SizeUp()
    {
        audios.PlayOneShot(buttonSD);
        sp.color = new Color(0.0f,0.0f,0.0f,250.0f);
        transform.localScale = new Vector3(0.4f, 0.4f, 1.0f);
    }
    public void SizeDown()
    {
        sp.color = cr;
        transform.localScale = new Vector3(0.3f, 0.3f, 1.0f);
    }

}
