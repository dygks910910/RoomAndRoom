using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockInput : MonoBehaviour {
    public GameObject lockpassword;
    public GameObject InputKey;
    public void ClickInput()
    {
        InputKey.transform.localScale=new Vector3(1.2f, 0.9f, 0.26728f);
        lockpassword.transform.position = new Vector3(93.43f, 10.51f, 29.8f);
        lockpassword.transform.localRotation=new Quaternion (0.0f, 129.0f, 0.0f,60.0f);
        lockpassword.transform.localScale = new Vector3(0.2183667f, 0.7f, 0.7f);
    }
    public void ClickExit()
    {
        InputKey.transform.localScale = new Vector3(1.0f, 0.55f, 0.26728f);
    }
}
