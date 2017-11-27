using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour {
    [Tooltip("피킹 가능 오브젝트 배열")]
    public GameObject[] pickObj;
	// Use this for initialization
	void Start () {
        //피킹가능 배열 리스트로 넣기.
        pickObj = GameObject.FindGameObjectsWithTag("PickObject");
       
        foreach(GameObject gameobj in pickObj)
        {
            print("a");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
