using Assets.Scripts.Characters;
using Assets.Scripts.ProblemClass;
using UnityEngine;

public class ProblemStudentBored : IProblem
{
    public GameObject ProblemScreen;

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

    public override void Affect()
    {
        throw new System.NotImplementedException();
    }

    public enum ProblemTypeEnum
    {
        Autonomy,
        Competency,
        Connection
    }

}
