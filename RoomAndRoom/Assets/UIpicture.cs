using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIpicture : MonoBehaviour {
    public GameObject Map;
    public GameObject TT;
    public static UIpicture Up;
    public bool PictureCheck = false;
    // Use this for initialization
    void Awake()
    {
        UIpicture.Up = this;
    }
    public void ClickPicture()
    {
        Map.SetActive(true);
    }
    public void SizeUp()
    {
        TT.transform.localScale = new Vector3(0.3f, 0.3f, 1.0f);
    }
    public void SizeDown()
    {
        TT.transform.localScale = new Vector3(0.2f, 0.2f, 1.0f);
    }
    void Update()
    {
        if (PictureCheck == true)
        {
            Map.SetActive(false);
            PictureCheck = false;
        }
    }
}
