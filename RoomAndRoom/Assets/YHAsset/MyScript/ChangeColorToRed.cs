using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//[Tooltip(" 오브젝트 색을 그냥 빨강으로 바꿔줌")]
public class ChangeColorToRed : MonoBehaviour {
	// Use this for initialization
	public void Change () {
        GetComponent<MeshRenderer>().material.color = Color.red;
	}
}
