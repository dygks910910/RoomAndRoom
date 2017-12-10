using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PickingAddOn : MonoBehaviour {
	// Use this for initialization
	void Start () {
        //scaleToIcon은 수동으로 추가.
        //eventTrigger는 수동으로 추가.
        GameObject parentGameObj;
        parentGameObj = transform.parent.gameObject;
        //피킹에 필요한 컴포넌트 추가.
        parentGameObj.AddComponent<BoxCollider>();
        parentGameObj.AddComponent<PickingControll>();
        parentGameObj.AddComponent<Rigidbody>();
        

        parentGameObj.AddComponent<EventTrigger>();
        EventTrigger trigger =  parentGameObj.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((eventData) => { parentGameObj.GetComponent<PickingControll>().BindingCamera(); });
        trigger.triggers.Add(entry);
    }
	
}
