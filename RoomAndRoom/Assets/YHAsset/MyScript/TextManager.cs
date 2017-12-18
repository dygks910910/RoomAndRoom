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
    public void NotingRandomText()
    {
        int randNum = Random.Range(1,4);
        switch (randNum)
        {
            case 1:
                textString.text = "별거없는거 같다.";
                break;
            case 2:
                textString.text = "자세히 보아도 별거없다.";
                break;
            case 3:
                textString.text = "뭐지?";
                break;
        }
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
