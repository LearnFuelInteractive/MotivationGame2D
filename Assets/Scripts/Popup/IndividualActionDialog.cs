using Assets.Scripts.Characters;
using TMPro;
using UnityEngine;
using Assets.Scripts.ProblemClass;
using System.Collections.Generic;

namespace Assets.Scripts.Popup
{
    public class ActionDialog: IActionDialog
    {
        public TextMeshProUGUI StudentName;
        public TextMeshProUGUI ProblemOfStudent;

        public Student student;
        // Only for Individual action: The problem this dialog is called upon
        // Optional: The student to which a solution needs to be applied upon.

        // Responsibility
        // Opening en closing dialog.
        // Contain the problem of student.
        // Further action.
        // When player has clicked upon problem, a dialog screen should be spawned and all other elements should be blacked out.
        // Focus should be aimed at player, student and dialog.

        public void Start()
        {
           // HidePopup();
        }

        public override void ShowPopup()
        {
            // Should also process problem and student.
            base.ShowPopup();
            UpdateSolution();
            ChangeText();
        }
        

        public override void UpdateSolution()
        {
            solutions.ForEach(s => s.TargetedStudent = student);
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
