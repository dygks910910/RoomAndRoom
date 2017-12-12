using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointArea : MonoBehaviour {
    GameObject Player;
    Vector3 LocationPos;
    bool moving=false;
    AudioSource audios;
    public static MovePointArea LocPos;
    void Awake()
    {
       MovePointArea.LocPos=this;
    }
    void Start()
    {
        audios = GetComponent<AudioSource>();
        Player = GameObject.Find("Player");
    }
    public void CilckPoint(Transform move)
    {
        audios.mute = false;
        LocationPos = move.transform.position;
        LocationPos.y = 12.5f;
        moving = true;
    }
    public void Update()
    {
        if (moving==true)
        {
            float moveFloat = Time.deltaTime*1.0f;
            Player.transform.position = Vector3.MoveTowards(Player.transform.position, LocationPos, moveFloat);
            if (Player.transform.position==LocationPos)
            {
                moving = false;
                audios.mute=true;
            }
        }
    }
}
