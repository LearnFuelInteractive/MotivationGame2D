using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_Text endTimeText;
    public string startTime;
    public string endTime;

    public LevelManager levelManager;
    private readonly string solutionsKey = "SelectedSolutionsList";
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = startTime;
        endTimeText.text = "Class ends: " + endTime;
        
       // InvokeRepeating(nameof(IncreaseTime), 1 ,1); //test to see if the time increases
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    public void IncreaseTime()
    {
        Debug.Log("Ticking the time !");
        string[] time = timeText.text.Split(':');
        int hour = int.Parse(time[0]);
        int minute = int.Parse(time[1]);

        minute += 10;
        if (minute >= 60)
        {
            minute = 0;
            hour++;
        }

        if (hour >= 24)
        {
            hour = 00;
        }
        timeText.text = hour.ToString("00") + ":" + minute.ToString("00");
        EndTimeOnTrigger();
    }
    
    public void EndTimeOnTrigger()
    {
        string[] time = timeText.text.Split(':');
        int hour = int.Parse(time[0]);
        int minute = int.Parse(time[1]);

        string[] endTimes = endTime.Split(':');
        int endHour = int.Parse(endTimes[0]);
        int endMinute = int.Parse(endTimes[1]);

        if (endHour < hour || (endHour <= hour && endMinute <= minute))
        {
            Debug.Log("deflp?");
            // trigger end game screen.
            var solutionsString = "";
            foreach(var solution in levelManager.chosenSolutions)
            {
                solutionsString += $"{solution},";
            }
            PlayerPrefs.SetString(solutionsKey, solutionsString);

            SceneManager.LoadScene("EndScreen");


        }
    }
}
