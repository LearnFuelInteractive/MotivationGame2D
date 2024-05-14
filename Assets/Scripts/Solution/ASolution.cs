using Assets.Scripts.Characters;
using System;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.ProblemClass;
using Assets.Scripts.Other;

public abstract class ASolution : MonoBehaviour
{
    public string Name;
    public UnityEvent confirmChoice;

    // To get character of the problem.
    public Student TargetedStudent = null;

    // Modifiers solution
    public CompetenceType CompetenceType;
    public float StandardValue = 40.0f;

    public float competenceGrade = 0.60f;
    public float autonomyGrade = 0.0f;
    public float connectionGrade = 0.0f;

    // Apply the effects of the solution to the character
    public abstract bool SolveProblem(Student character);
    public abstract bool CheckAcceptanceCriteria(float acceptanceCriteria, float value);
    public abstract void ConfirmAction();
    public abstract void SelectSolution();

}
