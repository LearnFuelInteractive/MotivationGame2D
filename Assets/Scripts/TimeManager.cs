using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_Text endTimeText;
    public string startTime;
    public string endTime;
    // Start is called before the first frame update
    void Start()
    {
        this.timeText.text = this.startTime;
        this.endTimeText.text = "Class ends: " + this.endTime;
        
       // InvokeRepeating(nameof(IncreaseTime), 1 ,1); //test to see if the time increases
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    public void IncreaseTime()
    {
        Debug.Log("Ticking the time !");
        string[] time = this.timeText.text.Split(':');
        int hour = int.Parse(time[0]);
        int minute = int.Parse(time[1]);

        minute = minute + 10;
        if (minute >= 60)
        {
            minute = 0;
            hour++;
        }

        if (hour >= 24)
        {
            hour = 00;
        }
        this.timeText.text = hour.ToString("00") + ":" + minute.ToString("00");
        EndTimeOnTrigger();
    }
    
    public void EndTimeOnTrigger()
    {
        if (this.timeText.text.Equals(endTime))
        {
            Debug.Log("deflp?");
            // trigger end game screen.


        }
    }
}
