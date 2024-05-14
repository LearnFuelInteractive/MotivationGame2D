using System;
using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using Assets.Scripts.ProblemClass;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProblemPopup : IPopup, IPointerClickHandler
{
    //// Will have some relation back to the student.
    public Student originStudent;
    
    private ActionDialog dialog;

    //// Temp variable, will be replaced with a service locator to the ProblemManager.
    //// Later variables will ensure that only if the student has been touched, that the popup will be clickable.
    public ProblemManager problemManager;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (originStudent == null)
        {
            Debug.LogError("originStudent is not initialized!");
            return;
        }

        if (!originStudent.isInRange)
        {
            Debug.Log("Student not in range");
            return;
        }

        if (problemManager == null)
        {
            Debug.LogError("ProblemManager is not initialized!");
            return;
        }


        dialog = problemManager.GetIndividualDialog();

        if (dialog == null)
        {
            Debug.LogError("Failed to get a valid dialog from ProblemManager!");
            return;
        }

        dialog.student = originStudent;
        dialog.ShowPopup();
        Debug.Log("Individual action: Open dialog.");
    }

    public void RemovePopup()
    {
        HidePopup();
    }


    private void Start()
    {
        this.problemManager = FindObjectOfType<ProblemManager>();
    }
}
