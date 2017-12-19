﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioSource : MonoBehaviour {

    private AudioSource source;
	// Use this for initialization
	void Start () {
        source =  GetComponent<AudioSource>();
	}
	public void PlayAudio()
    {
        source.Play();
    }	
}
