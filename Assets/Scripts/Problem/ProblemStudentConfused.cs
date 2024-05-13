using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Assets.Scripts.ProblemClass;

public class ProblemStudentConfused : MonoBehaviour, IProblem
{
    public GameObject ProblemScreen;
    public GameObject ProblemIcon;
    public string ProblemName = "Student Confused";
    public string ProblemExplanation = "This student does not understand the teacher, and makes a confused face expression.. What would you do?";


    public Student RelevantStudent;

    // Start is called before the first frame update
    void Start()
    {
        // At start it will hide the problem screen.
        HideProblem();
    }
    // Logic related to box collider.
    private void OnMouseEnter()
    {
        ShowProblem();
    }

    private void OnMouseExit()
    {
        // HideProblem();
    }

    public string ProblemType()
    {
        return "There is a problem";
    }

    public void Affect()
    {
    }

    public void Click()
    {
        // Other logic like spending time/energy in-game.
        HideProblem();
    }

    public void HideProblem()
    {
        ProblemScreen.SetActive(false);
    }

    public void ShowProblem()
    {
        ProblemScreen.SetActive(true);
    }

}
