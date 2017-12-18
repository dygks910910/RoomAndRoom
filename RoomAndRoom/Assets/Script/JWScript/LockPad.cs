using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Text;

public class LockPad : MonoBehaviour {
    public string Password=null;
    public GameObject[] Number;
    public string PS = null;
    public void NumberEnter(GameObject Num)
    {
        Num.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    public void NumberExit(GameObject Num)
    {
        Num.transform.localScale = new Vector3(1, 1, 1);
    }
    public void NumberClick(GameObject Num)
    {
        Num.GetComponent<Renderer>().material.color=Color.red;
        Num.GetComponent<Collider>().enabled = false;
    }
    public void GetNumber(string NumberName)
    {
        PasswordRepository(NumberName);
    }
    public void Reset()
    {
        Password = null;
        print(Password);
        for (int i=0; i<10; i++)
        {
            Number[i].GetComponent<Renderer>().material.color = Color.white;
            Number[i].GetComponent<Collider>().enabled = true;
        }
    }
    public void PasswordRepository(string InputNum)
    {
        Password += string.Concat(InputNum);
        print(Password);
    }
    public void Ok()
    {
        if (Password == PS)
        {
            print("Clear");
        }
        else
        {
            print("Is not collect");
        }
    }
}
