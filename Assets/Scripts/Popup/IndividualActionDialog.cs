using Assets.Scripts.Characters;
using TMPro;
using UnityEngine;
using Assets.Scripts.ProblemClass;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Solution.GlobalSolutions;

namespace Assets.Scripts.Popup
{
    public class IndividualActionDialog : IActionDialog
    {
        public TextMeshProUGUI StudentName;
        public TextMeshProUGUI ProblemOfStudent;

        // P.S. Voeg in Unity, handmatig alle problemen toepasbaar voor het level.
        public List<IndividualSolution> solutions;

        public Student Student;
        // Only for Individual action: The problem this dialog is called upon
        // Optional: The student to which a solution needs to be applied upon.

        // Responsibility
        // Opening en closing dialog.
        // Contain the problem of student.
        // Further action.
        // When player has clicked upon problem, a dialog screen should be spawned and all other elements should be blacked out.
        // Focus should be aimed at player, student and dialog.
        private void Start()
        {
            var list = FindObjectsOfType<IndividualSolution>().ToList();
            solutions = list;
            Debug.LogWarning("Start solution Count :" + solutions.Count);
            UpdateSolution();
            ChangeText();
        }

        public override void ShowPopup()
        {
            // Should also process problem and student.
            base.ShowPopup();
        }
        
        public void DestroyPopup()
        {
            HidePopup();
        }

        public override void HidePopup()
        {
            Debug.Log("Destroy popup. Overridden method");
            Destroy(popUp);
            // base.HidePopup();
        }

        public override void UpdateSolution()
        {
            Debug.LogWarning("Count :" + solutions.Count);
            solutions.ForEach(s => { 
                Debug.LogWarning("Updated solution with student: "+ Student.Name);
                s.TargetedStudent = Student; 
            });
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
