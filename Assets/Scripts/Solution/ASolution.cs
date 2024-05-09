using Assets.Scripts.Characters;
using UnityEngine;
using UnityEngine.Events;

public abstract class ASolution : MonoBehaviour
{
    public string Name;
    public UnityEvent confirmChoice;

    // To get character of the problem.
    public Problem RelevantProblem = null;

    // Modifiers solution
    public float competenceGrade = 0.60f;
    public float autonomyGrade = 0.0f;
    public float connectionGrade = 0.0f;


    // Applies effect to
    public virtual void ApplyToProblem(Problem problem)
    {
        // Get Character relevant to problem
        GodCharacter godCharacter = problem.RelevantStudent;
        // Get type of problem information.
        Debug.Log(problem.ProblemType());
        // Solve the problem.
        godCharacter.ApplySolution(this);
    }

    // Apply the effects of the solution to the character
    public abstract bool SolveProblem(GodCharacter character);
    public abstract bool CheckAcceptanceCriteria(float acceptanceCriteria, float value);
    public abstract void ConfirmAction();
}
