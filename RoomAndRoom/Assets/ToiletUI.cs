﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletUI : MonoBehaviour {

    public int Speed = 30;
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward*Speed*Time.deltaTime);
	}
}
