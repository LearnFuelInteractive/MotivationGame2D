using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Popup
{
    public class ActionDialog: MonoBehaviour
    {
        // Contains all solutions in one place.
        public GameObject IndividualActionBar;
        public Problem Problem;

        // Only for Individual action: The problem this dialog is called upon
        // Optional: The student to which a solution needs to be applied upon.

        private void Start()
        {
            CloseDialog();
            Debug.Log("Individual dialog ready");
            if (Problem == null)
            {
                Debug.Log("Problem not found");
            }
        }

        // Responsibility
        // Opening en closing dialog.
        // Contain the problem of student.

        // Further action.
        // When player has clicked upon problem, a dialog screen should be spawned and all other elements should be blacked out.
        // Focus should be aimed at player, student and dialog.
        public void SetProblem(Problem problem)
        {
            Problem = problem;
            Debug.Log("Problem found");
        }

        public void UnSetProblem() {
            // Should destroy problem from dialog menu.
            Problem = null;
        }

        public void OpenDialog()
        {
            Debug.Log("Dialog individual action opened.");
            // Should also process problem and student.
            IndividualActionBar.SetActive(true);
        }

        public void CloseDialog() {
            Debug.Log("Dialog individual action closed.");
            IndividualActionBar.SetActive(false);
        }

        public void SelfDestruct()
        {
            // If needed, this dialog should remove itself.
        }
    }
}
