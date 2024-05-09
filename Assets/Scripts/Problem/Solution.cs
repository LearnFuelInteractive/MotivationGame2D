using Assets.Scripts.Popup;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LessonSolution : MonoBehaviour
{
    // Represents the button
    public UnityEvent confirmChoice;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnMouseDown()
    {
        confirmChoice.Invoke();
    }

    public void PrintHoeray()
    {
        Debug.Log("Hello world");
    }
}
