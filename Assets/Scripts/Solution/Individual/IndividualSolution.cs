using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Characters;
using Assets.Scripts.ProblemClass;
using Assets.Scripts.Mediator;

public class IndividualSolution : ASolution
{
    // For now a relation to level manager.
    public IMediator Mediator;
    public LessonFactory LessonFactory;

    private void Start()
    {
        LessonFactory = new LessonFactory();
        var mediator = FindFirstObjectByType<LevelMediator>();
        if (mediator != null)
        {
            Mediator = mediator;
            Debug.Log("Mediator found");
        }
        else
        {
            Debug.Log("Mediator not found");
        }
    }

    public override void SelectSolution()
    {
        // This will decide if an solution is a global solution or individual action.
        Debug.Log($"Individual action: {Name}.");
        // Perform character specific actions.
        var value = "Single";
        Mediator.Notify(this, value);
        // Close popup.
        ConfirmAction();
    }

    // Apply the effects of the solution to the character
    public override bool SolveProblem(Student character)
    {
        // Validate if characters problem exists.
        if(!character.HasProblem())
        {
            return false;
        }
        Problem problem = character.currentProblem;
        // Apply the effect.
        problem.Affect();
        // All of the values
        float acceptanceCriteria = problem.AcceptanceCriteria;

        float personaModifier = character.persona.GetCompetence(CompetenceType);
        // Example 0.3
        float classRoomModifier = ApplyClassroomModifiers();
        // Example 0.4
        float personaDefinitveModifier = ApplyPersonaModifiers(personaModifier);

        // If percentage 0 - 100, it will divide it to single 
        // If personal skill value is high, the modifier should be minimal
        float answer = StandardValue * (1 + classRoomModifier + personaDefinitveModifier);
        // If solution competence and problem competence match,
        if (problem.CompetenceType.Equals(CompetenceType))
        {
            // A 25 percent boost should be applied.
            answer *= 1.25f;
        }
        // If successfull, destroy popup.
        var validSolution = CheckAcceptanceCriteria(acceptanceCriteria, answer);

        // Return if solution passes;
        return validSolution;
    }

    public override bool CheckAcceptanceCriteria(float acceptanceCriteria, float value)
    {
        Debug.Log($"Acceptance criteria is {acceptanceCriteria} and answer is {value}");
        // Misshien moet een extra variabel aangemaakt worden voor het bewaren van modifiers.
        return acceptanceCriteria < value;
    }

    public override void ConfirmAction()
    {
        confirmChoice.Invoke();
    }

    private float ApplyClassroomModifiers()
    {
        // Here comes the modifier.
        var lesson = LessonFactory.CreateLessonWithPlayerPrefs();

        float relevantFactor = lesson.modifiers.GetValueOrDefault(CompetenceType, 0.0f);;
        return relevantFactor / 2;
    }

    private float ApplyPersonaModifiers(float personaModifier)
    {
        // Factor should not be higher then 50 percent.
        return personaModifier / 2.0f;
    }
}
