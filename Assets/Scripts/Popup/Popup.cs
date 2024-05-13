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
    //public Student originStudent;

    //// Temp variable, will be replaced with a service locator to the ProblemManager.
    //// Later variables will ensure that only if the student has been touched, that the popup will be clickable.
    //public ProblemManager problemManager;

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    // This should open individual action dialog
    //    Debug.Log("Individual action: Open dialog.");
    //    ActionDialog dialog = problemManager.GetIndividualDialog();
    //    dialog.student = originStudent;
    //    dialog.ShowPopup();
    //}

    // I simply put this inside the Student class, the student will be clickable, not the popup.
}
