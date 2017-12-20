using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    [SerializeField]
    [Tooltip("플레이어 게임오브젝트")]
    private GameObject player;
    [Tooltip("선택된 오브젝트")]
    public bool isPicked = false;
    public GameObject pickedObj;
    public GameObject interactionObj;
    private TextManager txtMgrScr ;
    //주운 총 파트 갯수를 세기위함.3개면 다모인거임.
    public List<bool> gunPartsArr;
    public bool gunPartsReady = false;
    void Start()
    {
        player = GameObject.Find("Player");
        txtMgrScr = GameObject.Find("TextManager").GetComponent<TextManager>();
        //피킹가능 배열 리스트로 넣기.
        //pickObj = GameObject.FindGameObjectsWithTag("PickObject");
    }
    public void unPickObj()
    {
        if (pickedObj != null)
        {
            pickedObj.GetComponent<PickingControll>().UnbindingCamera();
            pickedObj = null;
        }
    }
    public void GetGunParts()
    {
        gunPartsArr.Add(true);
        if(gunPartsArr.Count >= 3)
        {
            gunPartsReady = true;
            GameObject.Find("Main Camera").transform.Find("Gun").gameObject.SetActive(true);
        }
    }
   
    public void CheckInteraction()
    {
        if (pickedObj != null && interactionObj!=null)
        {
            pickedObj.GetComponent<PickingControll>().UnbindingCamera();
            isPicked = false;

            if (interactionObj.name == "SM_Bed_01_S" && pickedObj.name == "Leaver")
            {
                //침대와의 상호작용
                LerpToA tempScript = interactionObj.GetComponent<LerpToA>();
                tempScript.Initialize();
                tempScript.isStarting = true;
            }
            else if (interactionObj.name == "Door1" && pickedObj.name == "Key1")
            {
                interactionObj.GetComponent<RotationDegreeAtoB>().StartRotate();
                interactionObj.GetComponent<AudioSource>().Play();
            }
            else
            {
                interactionObj = null;
            }
            pickedObj = null;
            interactionObj = null; 
        }
        //MovePoint를 찍었을때.
        else if(interactionObj != null && pickedObj == null)
        {
            if(interactionObj.name == "Arrow1")
            {
                Transform movePoint =  interactionObj.transform.Find("MovePoint");
                Vector3 targetVec = movePoint.position;
                LerpToA tempScript = player.GetComponent<LerpToA>();
                tempScript.targetObj = movePoint.gameObject;
                tempScript.Initialize();
                tempScript.isStarting = true;
                player.GetComponent<AudioSource>().Play();
            }
        }
        
        //침대와 지렛대가 맞다면 침대를 들어올린다.

        //지렛대는 다시 바닥에 버린다.
    }
    public void CheckFinalDoor()
    {
            if (gunPartsReady)
            {
                txtMgrScr.ChangeText("게임클리어!!");
                GameObject.Find("FinalDoor").GetComponent<RotationDegreeAtoB>().StartRotate();
                GameObject.Find("FinalDoor").GetComponent<ChangeScene>().ChangeGameScene("SelectUI");
            }
            else
                txtMgrScr.ChangeText("열리지 않는다...내몸을 지킬 무기가 필요하다.");
    }
    // Update is called once per frame
}
