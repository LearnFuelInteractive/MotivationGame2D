using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using TMPro;
using UnityEditor;
using UnityEngine.Events;

public class TimerBarScript : MonoBehaviour
{

    public GameObject timerBar;
    public int timeForBar = 3;
    public GameObject failMessagePopup;
    public GameObject locationOfPopup;
    public GameObject canvas;



    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
       
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
        failMessagePopup = Instantiate(failMessagePopup, locationOfPopup.transform.position, Quaternion.identity, canvas.transform);

        // make it dissapear after 3 seconds
        LeanTween.delayedCall(3, HideMessage);

    }
       
    public void HideMessage()
    {
        Destroy(canvas);

    }

}
