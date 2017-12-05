using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//아이콘형태로 축소시키고 원복시킴.
public class scaleToIcon : MonoBehaviour {
    private Vector3 originScale;
    [Tooltip("스케일할 각각 벡터의 값.")]
    public Vector3 scaleFactor;

    void Start()
    {
        originScale = transform.localScale;
    }
    public void ScaleToIcon()
    {

        transform.localScale = scaleFactor;
    }
    public void ScaleToOrigin()
    {
        transform.localScale =  originScale;
        //print("ScaleToOrigin" + transform.localScale);
    }
}
