using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using TMPro;
using UnityEditor;

public class TimerBarScript : MonoBehaviour
{

    public GameObject timerBar;
    public int timeForBar = 10;
    public TMP_Text failMessage;


    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
        failMessage.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AnimateBar()
    {
        // the animation that will create the timer bar.
        LeanTween.scaleX(timerBar, 1, timeForBar).setOnComplete(ShowMessage);
    }

    public void ShowMessage()
    {
        // {
        failMessage.gameObject.SetActive(true);
        // make it dissapear after 3 seconds

        LeanTween.delayedCall(3, HideMessage);

    }
       
    public void HideMessage()
    {
        
        failMessage.gameObject.SetActive(false);



    }

}
