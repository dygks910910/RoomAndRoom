using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIpicture : MonoBehaviour {
    public GameObject ToiletMap;
    public GameObject BedMap;
    public GameObject CampMap;
    public GameObject TT;
    public static UIpicture Up;
    public bool PictureCheck = false;
    public bool BedPictureCheck = false;
    public bool CampPictureCheck = false;
    // Use this for initialization
    void Awake()
    {
        UIpicture.Up = this;
    }
    public void ClickToiletPicture()
    {
        ToiletMap.SetActive(true);
    }
    public void ClickBedPicture()
    {
       BedMap.SetActive(true);
    }
    public void ClickCampPicture()
    {
        Debug.Log("Camp");
        CampMap.SetActive(true);
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
            ToiletMap.SetActive(false);
            PictureCheck = false;
        }
        if (BedPictureCheck== true)
        {
            BedMap.SetActive(false);
            BedPictureCheck = false;
        }
        if (CampPictureCheck == true)
        {
            CampMap.SetActive(false);
            CampPictureCheck = false;
        }
    }
}
