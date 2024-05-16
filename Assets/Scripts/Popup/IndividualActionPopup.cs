using System;
using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using Assets.Scripts.ProblemClass;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Other;
using UnityEngine;
using UnityEngine.EventSystems;

public class IndividualActionPopup : IPopup, IPointerClickHandler
{
    //// Will have some relation back to the student.
    public Student originStudent;
    
    private IndividualActionDialog dialog;

    //// Temp variable, will be replaced with a service locator to the ProblemManager.
    //// Later variables will ensure that only if the student has been touched, that the popup will be clickable.
    public ProblemManager problemManager;
    public GameObject[] emotionTypes;

    private void Start()
    {
        this.problemManager = FindObjectOfType<ProblemManager>();
        // get parent of parent of this object
        this.originStudent = transform.parent.parent.GetComponent<Student>();
        Debug.Log("student name: " + originStudent.Name + " competency problem type " + originStudent.currentProblem.CompetenceType);
        setEmotionBasedOnProblemType();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicking on individual action popup.");
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
        // Dialog needs to be instantiated before student can be assigned.
        //dialog.ShowPopup();
        // This should be fixed!
        var instantiatedPopup = Instantiate(dialog);

        instantiatedPopup.Student = originStudent;
        Debug.Log($"Name of dialog student {originStudent.Name}");
        instantiatedPopup.UpdateSolution();
        instantiatedPopup.ChangeText();
        Debug.Log("Individual action: Open dialog.");
    }

    public void RemovePopup()
    {
        HidePopup();
    }

    public void setEmotionBasedOnProblemType()
    {
        var currentproblem = originStudent.currentProblem.CompetenceType;
        if (currentproblem == CompetenceType.AUTONOMY)
        {
            emotionTypes[0].SetActive(true);
        }
        else if (currentproblem == CompetenceType.COMPETENCE)
        {
            emotionTypes[1].SetActive(true);
        }
        else if (currentproblem == CompetenceType.CONNECTION)
        {
            emotionTypes[2].SetActive(true);
        }
        
    }
}
