using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    public GameObject eixtscreen;
    public void ClickPicture()
    {
        eixtscreen.SetActive(true);
        StartCoroutine(Off(5.0f));

    }
    IEnumerator Off(float sec)
    {
        yield return new WaitForSeconds(sec);
        eixtscreen.SetActive(false);
    }
}
