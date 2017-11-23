using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorToRed : MonoBehaviour {

	// Use this for initialization
	public void Change () {
        GetComponent<MeshRenderer>().material.color = Color.red;
	}
}
