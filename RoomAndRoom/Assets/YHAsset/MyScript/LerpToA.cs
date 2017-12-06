using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpToA : MonoBehaviour {
    public GameObject targetObj;

    private Transform startMarker;
    private Transform endMarker;

    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public bool isStarting = false;
    void Start()
    {
        startMarker = transform;
        endMarker = targetObj.transform;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update()
    {
        if (isStarting)
        {
            float distCovered = (Time.time - startTime) * speed * Time.deltaTime;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
        }
    }
}
