using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour {
    public float Speed=1.0f;
	void Update () {
        transform.Rotate(0,Speed*Time.deltaTime,0);
	}
}
