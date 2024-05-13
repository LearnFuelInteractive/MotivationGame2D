using Assets.Scripts.Characters;
using System;
using UnityEngine;

namespace Assets.Scripts.Solution.GlobalSolutions
{
    public class AllPositiveGlobalAction : GlobalAction
    {
        
        public override bool CheckAcceptanceCriteria(float acceptanceCriteria, float value)
        {
            throw new NotImplementedException();
        }

        public override void ConfirmAction()
        {
            confirmChoice.Invoke();
        }

        public override void SelectSolution()
        {
            Mediator.ApplySolutionToStudents(this);
            // Closes dialog.
            ConfirmAction();
        }

        public override bool SolveProblem(Student character)
        {
            Debug.Log("Global solution applied");
            return true;
        }
    }
}
