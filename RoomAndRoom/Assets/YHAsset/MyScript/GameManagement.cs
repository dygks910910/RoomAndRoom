using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManagement : MonoBehaviour
{
    [Tooltip("피킹 가능 오브젝트 배열")]
    public GameObject[] pickObj;
    // Use this for initialization

    void Start()
    {
        //피킹가능 배열 리스트로 넣기.
        pickObj = GameObject.FindGameObjectsWithTag("PickObject");
    }

    // Update is called once per frame
    public void CheckPickedObj()
    {
        //    PickingControll tempScript;
        //    foreach(GameObject obj in pickObj)
        //    {
        //        tempScript = obj.GetComponent<PickingControll>();
        //        if (tempScript.isPicked)
        //        {
        //            //tempScript.UnbindingCamera();

        //            break;
        //        }
        //    }
        //}
    }



}
