using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedRoomPickingControl : MonoBehaviour {
    public static BedRoomPickingControl PK;
    public GameObject Thing = null;
    // Use this for initialization
    void Awake()
    {
        BedRoomPickingControl.PK = this;
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
