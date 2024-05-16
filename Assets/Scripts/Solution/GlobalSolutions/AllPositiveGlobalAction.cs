using Assets.Scripts.Characters;
using Assets.Scripts.ProblemClass;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Solution.GlobalSolutions
{
    public class AllPositiveGlobalAction : GlobalAction
    {
        public override void SelectSolution()
        {
            // Calls the mediator.
            var val = "All";
            Mediator.Notify(this, val);
            // Closes dialog.
            ConfirmAction();
        }

        public override bool SolveProblem(Student character)
        {
            Debug.Log("Global solution applied");
            // If character did not have any problem, just return false.
            if(!character.HasProblem())
            {
                // Something with relevant feedback about it.
                return false;
            }

            // Apply groups modifier.
            Problem problem = character.currentProblem;
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

            // Effectiveness is reduced to 75 percent of its original strength.
            float answer = StandardValue * (1 + classRoomModifier + personaDefinitveModifier) * ApplyGlobalModifier();

            return CheckAcceptanceCriteria(acceptanceCriteria, answer);
        }

        public override bool CheckAcceptanceCriteria(float acceptanceCriteria, float value)
        {
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

            float relevantFactor = lesson.modifiers.GetValueOrDefault(CompetenceType, 0.1f);
            return relevantFactor / 2;
        }

        private float ApplyPersonaModifiers(float personaModifier)
        {
            // Factor should not be higher then 50 percent.
            return personaModifier / 2.0f;
        }

        private float ApplyGlobalModifier()
        {
            return 0.75f;
        }
    }
}
