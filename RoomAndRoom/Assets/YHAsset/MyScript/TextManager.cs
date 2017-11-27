using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//어떤 문자열을 몇초뒤 사라지게 할것인가?
public class TextManager : MonoBehaviour {


    private Text textString;
    public GameObject textObj;
    //몇초뒤 사라지게 할건지?
    [SerializeField]
    private float countDownSec;
    //텍스트가 바뀐시간.
    private bool timeStart;
    //흐른시간
    private float elapsedTime;
    void Start()
    {
        textString = textObj.GetComponent<Text>();
    }
    public void ChangeText(string text)
    {
        textString.text = text;
        timeStart = true;

    }
    void Update()
    {
        if (timeStart && elapsedTime < countDownSec)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            timeStart = false;
            elapsedTime = 0;
            textString.text = "";

        }
    }
}
