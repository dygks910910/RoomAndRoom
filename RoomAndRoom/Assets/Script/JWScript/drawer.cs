using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour {
    public GameObject Darw;
    public GameObject scrollss;
    public float scrollsSpeed=1.0f;
    bool scrollsCheck = false;
    public void SizeUp()
    {
        Darw.transform.localScale = new Vector3(110, 110, 110);
        Darw.transform.position = new Vector3(98.0f, 1.02f, 19.24f);
        if (scrollsCheck == false)
        {
            scrollss.SetActive(true);
            scrollss.transform.Translate(Vector3.up*scrollsSpeed*Time.deltaTime);
            scrollss.transform.Translate(Vector3.forward * (scrollsSpeed-100.0f) * Time.deltaTime);
            //scrollss.transform.Translate(Vector3.right * scrollsSpeed * Time.deltaTime);
            Physics.gravity = new Vector3(0, -17.5f, 0);
            //scrollss.transform.Rotate(725.0f,0,0);
            scrollsCheck = true;
        }
    }
    public void SizeDown()
    {
        Darw.transform.localScale = new Vector3(100, 100, 100);
        Darw.transform.position = new Vector3(100.0f, 0.22f, 18.08f);
    }

}
