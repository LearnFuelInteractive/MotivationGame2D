using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using Assets.Scripts.ProblemClass;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProblemPopup : MonoBehaviour, IPointerClickHandler
{
    // Contains popup object
    public GameObject popUp;

    // public Problem problemAction;
    public Student originStudent;

    // Later variables will ensure that only if the student has been touched, that the popup will be clickable.
    public ProblemManager problemManager;

    // Will have some relation back to the student.

    public void ShowPopup()
    {
        popUp.SetActive(true);
    }

    public void HidePopup()
    {
        popUp.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // This should open individual action dialog
        Debug.Log("Individual action: Open dialog.");
        ActionDialog dialog = problemManager.GetIndividualDialog();
        dialog.student = originStudent;
        dialog.OpenDialog();
    }
}
