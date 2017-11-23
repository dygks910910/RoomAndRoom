using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDegreeAtoB : MonoBehaviour
{
    //어느 각도까지 회전할건가?
    public float MaxRotationDEGREE;
    //어느 속도로 회전할건가?
    public float rotationSpeed;
    //어느 축으로 회전할건가?
    public string axis;
    //회전의 조건?
    public bool isRotationed = false;
    //조종할 객체
    private Quaternion right = Quaternion.identity;
    void Start()
    {
        if (axis == "y")
        {
            //preAxisValue = transform.rotation.y;
            right.eulerAngles = new Vector3(0, MaxRotationDEGREE, 0);
        }
    }
    void Update()
    {
        //회전축이 y인경우.
        if (isRotationed && axis == "y")
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, right, Time.deltaTime * rotationSpeed);
            if(transform.rotation.eulerAngles.y +1>= right.eulerAngles.y)
            {
                isRotationed = false;
            }
        }
    }
    public void StartRotate()
    {
        isRotationed = true;
    }


}
