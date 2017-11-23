using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour {
    public GameObject zoom;
    public GameObject cctv;
    public static ZoomIn instance;
    public GameObject Clue;
    public int count = 0;
    void Start()
    {
        cctv.transform.position = new Vector3(72.3f, 9.8f, 10.1f);
        zoom.transform.localScale = new Vector3(0.2646686f, 0.2832061f, 1.725819f);
    }
    void Awake()
    {
        ZoomIn.instance = this;
    }
    public void ZoomEnter()
    {
        zoom.transform.localScale = new Vector3(0.2646686f, 0.4f, 2.0f);
    }
    public void ClickZoom()
    {
        count += 1;
        if (count == 1)
        {
            cctv.transform.position = new Vector3(79.3f, 9.8f, 10.1f);
        }
        else if (count == 2)
        {
            cctv.transform.position = new Vector3(89.3f, 9.8f, 10.1f);
        }
        else if (count >= 3)
        {
            print("clue");
            Clue.SetActive(true);
            StartCoroutine(clue(3.0f));
            cctv.transform.position = new Vector3(93.3f, 9.8f, 10.1f);
        }
    }
    public void ZoomExit()
    {
        zoom.transform.localScale = new Vector3(0.2646686f, 0.2832061f, 1.725819f);
    }
     void Update()
    {
        count=Mathf.Clamp(count, 0, 3);
    }
    IEnumerator clue(float sec)
    {
        yield return new WaitForSeconds(sec);
        Clue.SetActive(false);
    }
}
