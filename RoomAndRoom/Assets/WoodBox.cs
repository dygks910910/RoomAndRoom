using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBox : MonoBehaviour {
    public GameObject piece;
    public GameObject Pos;
    public void ClickBox()
    {
        if (Hammer.Hm.HammerCheck==true)
        {
            Handheld.Vibrate();
            Instantiate(piece, Pos.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
