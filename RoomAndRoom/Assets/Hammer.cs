using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void SizeUp()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
