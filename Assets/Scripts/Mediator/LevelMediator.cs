using Assets.Scripts.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Mediator
{
    public class LevelMediator : IMediator
    {
        // Mentor

        // Refers to student currently using the mediator.
        public Student currentStudent;
        public LevelManager levelManager;

        private void Start()
        {
            levelManager = FindAnyObjectByType<LevelManager>();
        }

        public override void Notify(ASolution solution, string value)
        {
            Debug.Log($"Mediator notifies to {value}");
            if (value.Equals("All"))
            {
                Debug.Log("Mediator solves single problem.");
                // Notify all students.
                ApplySolutionToStudents(solution);
            }
            else if (value.Equals("Single"))
            {
                ReactToStudent(solution);
            }
            // Spend energy.

            // Notify mentor
            ReactToMentor();
        }

        private void ApplySolutionToStudents(ASolution solution)
        {
            foreach (var student in levelManager.students)
            {
                var studentObject = student.GetComponent<Student>();
                var hasSolved = solution.SolveProblem(studentObject);
                if (hasSolved)
                {
                    Debug.Log("Has solved the issue.");
                }
            }
        }

        private void ReactToStudent(ASolution solution)
        {
            Debug.Log("Mediator solves single problem.");
            currentStudent = solution.TargetedStudent;
            if (solution.SolveProblem(currentStudent))
            {
                Debug.Log("This problem has been solved.");
                currentStudent.DestroyPopup();
            }
            else
            {
                Debug.Log("This problem is not solved.");
            }
        }

        private void ReactToMentor()
        {
            Debug.Log("Mentor has reacted");
        }
    }
}
