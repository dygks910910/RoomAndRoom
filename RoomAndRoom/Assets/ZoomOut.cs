using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour {
    public GameObject zoom;
    public GameObject cctv;
    // Use this for initialization
    public void ClickZoomEnter()
    {
        ZoomIn.instance.count -= 1;
        zoom.transform.localScale = new Vector3(0.2646686f, 0.4f, 2.0f);
        if (ZoomIn.instance.count == 2)
        {
            cctv.transform.position = new Vector3(89.3f, 9.8f, 10.1f);
        }
        else if (ZoomIn.instance.count == 1)
        {
            cctv.transform.position = new Vector3(79.56f, 9.8f, 10.1f);
        }
        else if (ZoomIn.instance.count == 0)
        {
            cctv.transform.position = new Vector3(60.3f, 9.8f, 10.1f);
        }
    }
    public void ZoomExit()
    {
        zoom.transform.localScale = new Vector3(0.2646686f, 0.2832061f, 1.725819f);
    }
}
