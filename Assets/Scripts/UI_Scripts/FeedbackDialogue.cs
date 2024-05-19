using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FeedbackDialogue : MonoBehaviour
{

    public GameObject feedbackBox;
    public TextMeshProUGUI feedbackText;
    public float timeToDisplayFeedbackBox = 5;
    private float timeLeftToDisplay;

    private void Start()
    {
        timeLeftToDisplay = timeToDisplayFeedbackBox;
    }
    public void ShowDialogueBox(string text)
    {
            timeLeftToDisplay = timeToDisplayFeedbackBox;
            feedbackText.text = text;
            feedbackBox.gameObject.SetActive(true);
    }
        

    public void CloseDialogueBox()
    {
        feedbackBox.gameObject.SetActive(false);
    }

    public void Update()
    {
        if(feedbackBox.gameObject.activeSelf)
        {
            timeLeftToDisplay -= Time.deltaTime;
        }
        if(timeLeftToDisplay < 0)
        {
            feedbackBox.gameObject.SetActive(false);
        }
    }
}
