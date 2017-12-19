using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmRoof : MonoBehaviour {

    [SerializeField]
    private AudioClip snd;
    private AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!source.isPlaying)
        {
            source.clip = snd;
            source.Play();
        }
	}
}
