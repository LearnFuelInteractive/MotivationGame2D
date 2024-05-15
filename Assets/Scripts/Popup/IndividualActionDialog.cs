using Assets.Scripts.Characters;
using TMPro;
using UnityEngine;
using Assets.Scripts.ProblemClass;
using System.Collections.Generic;

namespace Assets.Scripts.Popup
{
    public class IndividualActionDialog : IActionDialog
    {
        public TextMeshProUGUI StudentName;
        public TextMeshProUGUI ProblemOfStudent;

        public Student Student;
        // Only for Individual action: The problem this dialog is called upon
        // Optional: The student to which a solution needs to be applied upon.

        // Responsibility
        // Opening en closing dialog.
        // Contain the problem of student.
        // Further action.
        // When player has clicked upon problem, a dialog screen should be spawned and all other elements should be blacked out.
        // Focus should be aimed at player, student and dialog.

        public override void ShowPopup()
        {
            // Should also process problem and student.
            base.ShowPopup();
            // UpdateSolution();
            // ChangeText();
        }
        
        public void DestroyPopup()
        {
            HidePopup();
        }
        

        public override void UpdateSolution()
        {
            solutions.ForEach(s => s.TargetedStudent = Student);
        }

        public void ChangeText()
        {
            if(Student != null)
            {
                StudentName.text = Student.Name;
                ProblemOfStudent.text = Student.currentProblem.ProblemName;
            }
            else
            {
                StudentName.text = "Lorem";
                ProblemOfStudent.text = "Ipsum probleem";
            }
        }
    }
}
