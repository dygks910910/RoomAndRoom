using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManagement : MonoBehaviour
{
    [Tooltip("선택된 오브젝트")]
    public GameObject pickedObj;
    public GameObject interactionObj;
    void Start()
    {
        //피킹가능 배열 리스트로 넣기.
        //pickObj = GameObject.FindGameObjectsWithTag("PickObject");
    }
    public void unPickObj()
    {
        if(pickedObj != null)
        pickedObj.GetComponent<PickingControll>().UnbindingCamera();
    }
    public void CheckInteraction()
    {
        if (pickedObj != null)
        {
            pickedObj.GetComponent<PickingControll>().UnbindingCamera();

            if (interactionObj.name == "SM_Bed_01_S" && pickedObj.name == "Leaver")
            {
                //침대와의 상호작용
                interactionObj.GetComponent<LerpToA>().isStarting = true;

                interactionObj = null;
                print("침대와의 상호작용");
            }
            if (interactionObj.name == "Door1" && pickedObj.name == "Key1")
            {
                interactionObj.GetComponent<RotationDegreeAtoB>().StartRotate();
            }
            else
            {
                interactionObj = null;
            }
        }
        //침대와 지렛대가 맞다면 침대를 들어올린다.

        //지렛대는 다시 바닥에 버린다.
    }
    // Update is called once per frame
}
