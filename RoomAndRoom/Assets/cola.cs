using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cola : MonoBehaviour {
    public GameObject GvrPointer;
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public void SizeUp()
    {
        transform.localScale = new Vector3(10, 10, 10);
        transform.position = new Vector3(86.69f, 1.1f, 8.48f);
    }
    public void GetCoke(string lines)
    {
        Textbox.transform.localPosition = new Vector3(-11.0f, -9.5f, 32.35f);
        tx.text = lines;
        StartCoroutine(TextInitialize(TextRemoveTime));
        if (VrHouseStage.instance.PickCheck==false)
        {
            transform.parent = GvrPointer.transform;
            Collider col = GetComponent<Collider>();
            VrHouseStage.instance.GetCokeCan = true;
            col.enabled = false;
            VrHouseStage.instance.PickCheck = true;
        }
    }
    public void SizeDown()
    {
        transform.localScale = new Vector3(7, 7, 7);
        transform.position = new Vector3(86.69f, 0.41f, 8.48f);
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        tx.text = "";
    }
}
