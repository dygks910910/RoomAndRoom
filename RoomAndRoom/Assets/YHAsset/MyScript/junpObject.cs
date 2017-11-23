using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
