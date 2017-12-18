using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memo : MonoBehaviour {
    public GameObject Clue;
    // Use this for initialization
    public void ClickMemo()
    {
        Clue.SetActive(true);
    }
}
