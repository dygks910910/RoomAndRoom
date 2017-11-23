using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Clock : MonoBehaviour {
    //-- set start time 00:00
    public TextMesh tx;
    public GameObject Textbox;
    public float TextRemoveTime = 1.5f;
    public int minutes = 0;
    public int hour = 0;
    public float clockSpeed = 1.0f;     // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster
    int seconds;
    float msecs;
    GameObject pointerSeconds;
    GameObject pointerMinutes;
    GameObject pointerHours;
    string Timeminutes;
    string Timeseconds;
    bool clockcheck = false;
    string Pr;
    string Ht;
    string Mt;
    string St;

    void Start() 
{
    pointerSeconds = transform.Find("rotation_axis_pointer_seconds").gameObject;
    pointerMinutes = transform.Find("rotation_axis_pointer_minutes").gameObject;
    pointerHours   = transform.Find("rotation_axis_pointer_hour").gameObject;

    msecs = 0.0f;
    seconds = 0;
}
    public void pretime(string pre)
    {
        Pr = pre;
    }
    public void HourTime(string ht)
    {
        Ht = ht;
    }
    public void minTime(string mt)
    {
        Mt = mt;
    }
    public void secTime(string st)
    {
        St = st;
    }
    public void ClickTheClock()
    {
        clockcheck = true;
        StartCoroutine(TextInitialize(TextRemoveTime));
    }
    IEnumerator TextInitialize(float sec)
    {
        yield return new WaitForSeconds(sec);
        clockcheck = false;
        tx.text = "";
    }
    void Update() 
{
        if (clockcheck==true)
        {
            Textbox.transform.localPosition = new Vector3(-12.0f, -9.5f, 32.35f);
            tx.text =Pr +hour + Ht + minutes + Mt + seconds+St;
        }
    //-- calculate time
    msecs += Time.deltaTime * clockSpeed;
    if(msecs >= 1.0f)
    {
        msecs -= 1.0f;
        seconds++;
        if(seconds >= 60)
        {
            seconds = 0;
            minutes++;
            if(minutes > 60)
            {
                minutes = 0;
                hour++;
                if(hour >= 24)
                    hour = 0;
            }
        }
    }
        //-- calculate pointer angles
        float rotationSeconds = (360.0f / 60.0f)  * seconds;
        float rotationMinutes = (360.0f / 60.0f)  * minutes;
        float rotationHours = ((360.0f / 12.0f) * hour) + ((360.0f / (60.0f * 12.0f)) * minutes);
        //-- draw pointers
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
    pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
    pointerHours.transform.localEulerAngles   = new Vector3(0.0f, 0.0f, rotationHours);
}
}
