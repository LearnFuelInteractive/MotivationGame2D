using Assets.Scripts.Characters;
using Assets.Scripts.ProblemClass;
using System;
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

            // Something to spend energy.
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
            // Apply the effect.
            Problem problem = character.currentProblem;
            problem.Affect();
            // All of the values
            float acceptanceCriteria = problem.AcceptanceCriteria;
            float otherModifiers = 0.0f;
            float personaModifier = character.persona.GetCompetence(CompetenceType);
            // Effectiveness is reduced to 75 percent of its original strength.
            float answer = StandardValue + (1 + otherModifiers / 100.0f) + (1 + (1 - personaModifier)) * 0.75f;

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
    }
}
