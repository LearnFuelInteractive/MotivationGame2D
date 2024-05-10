using Assets.Scripts.Characters;
using TMPro;
using UnityEngine;
using Assets.Scripts.ProblemClass;

namespace Assets.Scripts.Popup
{
    public class ActionDialog: MonoBehaviour
    {
        public TextMeshProUGUI StudentName;
        public TextMeshProUGUI ProblemOfStudent;

        // Contains all solutions in one place.
        public GameObject IndividualActionBar;

        public Student student;

        // Optional: the class itself instantiates the solution buttons within the dialog.
        // public List<ASolution> solutions;

        // Only for Individual action: The problem this dialog is called upon
        // Optional: The student to which a solution needs to be applied upon.

        // Responsibility
        // Opening en closing dialog.
        // Contain the problem of student.
        // Further action.
        // When player has clicked upon problem, a dialog screen should be spawned and all other elements should be blacked out.
        // Focus should be aimed at player, student and dialog.
        public void SetProblem(Problem problem)
        {
            Debug.Log("Problem found");
        }

        public void OpenDialog()
        {
            Debug.Log("Dialog individual action opened.");
            // Should also process problem and student.
            IndividualActionBar.SetActive(true);
            ChangeText();
        }

        public void CloseDialog()
        {
            Debug.Log("Dialog individual action closed.");
            IndividualActionBar.SetActive(false);
        }

        public void ChangeText()
        {
            if(student != null)
            {
                StudentName.text = student.Name;
                ProblemOfStudent.text = student.currentProblem.ProblemName;
            }
            else
            {
                StudentName.text = "Lorem";
                ProblemOfStudent.text = "Ipsum probleem";
            }
        }
    }
}
