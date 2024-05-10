using Assets.Scripts.Characters;
using Assets.Scripts.ProblemClass;
using System;
using UnityEngine;

namespace Assets.Scripts.Solution
{
    public class CompetenceSolution : ASolution
    {
        public void OnMouseDown()
        {
            // This will decide if an solution is a global solution or individual action.
            if (this.HasParentProblem())
            {
                Debug.Log($"Individual action: {Name}.");
                // Perform character specific actions.
                ApplyToProblem(RelevantProblem);

                // Close popup.
                confirmChoice.Invoke();
            }
            else
            {
                Debug.Log($"Global action: {Name}.");
                // Notify all users to apply this solution.
                // Perform action with this solution to all users.
            }
        }

        // Applies effect to
        public override void ApplyToProblem(Problem problem)
        {
            // Get Character relevant to problem
            Student godCharacter = problem.RelevantStudent;
            // Get type of problem information.
            Debug.Log("Fill in problem type");
            // Solve the problem.
            // This will require a student, in order for the individual action to work.
            godCharacter.ApplySolution(this);
        }

        // Apply the effects of the solution to the character
        // Works with both individual and global actions.
        public override bool SolveProblem(Student character)
        {
            // Picks the relevant modifier
            float improvedCompetence = character.problemMeter - competenceGrade;
            // Applies 
            character.problemMeter = improvedCompetence;
            // Adds the solution modifiers
            // Calculate chance, replace number with relevant script.
            var randomNumber = 2;
            // Validate acceptance criteria;
            var acceptanceCriteria = character.AcceptanceCriteria;
            // If successfull, destroy popup.
            var validSolution = CheckAcceptanceCriteria(acceptanceCriteria, randomNumber);
            // Apply modifier as new value to persona.
            // Otherwise a negative popup for 2 seconds should show up.
            return validSolution;
        }
        
        public override bool CheckAcceptanceCriteria(float acceptanceCriteria, float value)
        {
            // Misshien moet een extra variabel aangemaakt worden voor het bewaren van modifiers.
            return acceptanceCriteria < value;
        }

        private bool HasParentProblem()
        {
            return (RelevantProblem != null);
        }

        public override void ConfirmAction()
        {
            throw new NotImplementedException();
        }
    }
}
