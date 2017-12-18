using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAK47Parts : MonoBehaviour {

    private static GameManagement gameMgrScript;
	// Use this for initialization
	void Start () {
        if (gameMgrScript == null)
        {
            gameMgrScript = GameObject.Find("GameManager").GetComponent<GameManagement>();
        }
	}
	public void DeleteGunParts()
    {
        gameMgrScript.GetGunParts();
        Destroy(this.gameObject);
    }
}
