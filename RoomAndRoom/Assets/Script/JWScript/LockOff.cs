using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOff : MonoBehaviour {
    public GameObject lockpassword;
    public GameObject OffKey;
    public void ClickOff()
    {
        OffKey.transform.localScale = new Vector3(1.2f, 0.9f, 0.26728f);
        lockpassword.transform.position = new Vector3(93.43f, 10.51f, 32.7f);
        lockpassword.transform.localRotation = new Quaternion(0.0f, 90.0f, 0.0f, 90.0f);
        lockpassword.transform.localScale = new Vector3(0.2183667f, 0.55f, 0.52f);
    }
    public void ClickExit()
    {
        OffKey.transform.localScale = new Vector3(1.0f, 0.55f, 0.26728f);
    }
}
