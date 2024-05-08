using Assets.Scripts.Popup;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LessonSolution : MonoBehaviour
{
    // Represents the button
    private Rigidbody2D body;
    public UnityEvent confirmChoice;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void PrintHoeray()
    {
        Debug.Log("Hello world");
    }

    public void OnMouseDown()
    {
        confirmChoice.Invoke();
    }

}
