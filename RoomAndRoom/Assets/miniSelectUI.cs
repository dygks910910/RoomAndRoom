using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniSelectUI : MonoBehaviour {
    public SpriteRenderer sp;
    public Color cr;
    AudioSource audios;
    public AudioClip buttonSD;
    public GameObject Lig;
    public bool miniCheck = false;
    public static miniSelectUI Mu;
    void Awake()
    {
        miniSelectUI.Mu = this;
    }
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        audios = GetComponent<AudioSource>();
    }
    public void SizeUp()
    {
        audios.PlayOneShot(buttonSD);
        sp.color = new Color(0.0f, 0.0f, 0.0f, 250.0f);
        transform.localScale = new Vector3(0.2f, 0.2f, 1.0f);
    }
    public void SizeDown()
    {
        sp.color = cr;
        transform.localScale = new Vector3(0.1f, 0.1f, 1.0f);
        Lig.SetActive(false);

    }
    public void ClickSelect()
    {
        Lig.SetActive(true);
    }
    public void Exit()
    {
        Debug.Log("check");
        miniCheck = true;
        UIpicture.Up.PictureCheck = miniCheck;
        Lig.SetActive(false);
    }
}
