using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemPopup : MonoBehaviour
{
    // Contains popup object
    public GameObject popUp;
    public Problem problemAction;

    // Will have some relation back to the student.

    public void ShowPopup()
    {
        popUp.SetActive(true);
    }

    public void HidePopup()
    {
        popUp.SetActive(false);
    }

    // Shows message screen with button
    public void OnMouseDown()
    {
        problemAction.ShowProblem();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Other people triggered popup.");
        problemAction.ShowProblem();
    }
}
