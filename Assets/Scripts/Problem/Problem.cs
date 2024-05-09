using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Problem : MonoBehaviour, IProblem
{
    public GameObject ProblemScreen;
    public GameObject ProblemIcon;
    public string ProblemName = "Default problem";

    public GodCharacter RelevantStudent;

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