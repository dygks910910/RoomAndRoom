using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//객체를 특정힘만큼 월드Y축으로 AddForce
public class junpObject : MonoBehaviour {

    private Rigidbody rigidbody;
    public float jumpForce;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
	// Use this for initialization
	public void Jump()
    {
        rigidbody.AddForce(new Vector3(0, jumpForce, 0));
    }
}
