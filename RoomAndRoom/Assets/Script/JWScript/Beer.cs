using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour {
    public GameObject GvrPointer;
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public void SizeUp()
    {
        transform.localScale = new Vector3(15, 15, 15);
    }
    public void GetBeer(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-11.0f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
        if (VrHouseStage.instance.PickCheck == false)
        {
            transform.parent = GvrPointer.transform;
            Collider col = GetComponent<Collider>();
            VrHouseStage.instance.GetBeer = true;
            col.enabled = false;
            VrHouseStage.instance.PickCheck = true;
        }
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(10, 10, 10);
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
