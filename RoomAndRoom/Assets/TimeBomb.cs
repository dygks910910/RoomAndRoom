using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBomb : MonoBehaviour
{
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public GameObject RedLight;
    public float Time = 1.0f;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(RotationLightOff(Time));
    }
    IEnumerator RotationLightOff(float sec)
    {
        RedLight.SetActive(false);
        yield return new WaitForSeconds(sec);
        StartCoroutine(RotationLightOn(Time));
    }
    IEnumerator RotationLightOn(float sec)
    {
        RedLight.SetActive(true);
        yield return new WaitForSeconds(sec);
        StartCoroutine(RotationLightOff(Time));
    }
    public void Bomb(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-15.5f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
