using Assets.Scripts.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Mediator
{
    public class LevelMediator : IMediator
    {
        // Mentor

        // Refers to student currently using the mediator.
        public Student currentStudent;
        public LevelManager levelManager;

        public UnityEvent SpentTimeAction;
        public UnityEvent SentProblemSolved;
        public UnityEvent SentProblemNotSolved;
        private void Start()
        {
            levelManager = FindAnyObjectByType<LevelManager>();
        }

        public override void Notify(ASolution solution, string value)
        {
            Debug.Log($"Mediator notifies to {value}");
            Debug.Log($"Solution name: {solution.Name}");
            levelManager.chosenSolutions.Add(solution.Name);
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
            SpentTimeAction.Invoke();
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
                    studentObject.DestroyPopup();
                    SentProblemSolved.Invoke();
                }
                else
                {
                    Debug.Log("Global action did not solve problem.");
                    SentProblemNotSolved.Invoke();
                }
            }
        }

        private void ReactToStudent(ASolution solution)
        {
            currentStudent = solution.TargetedStudent;
            if (solution.SolveProblem(currentStudent))
            {
                Debug.Log("This problem has been solved.");
                currentStudent.DestroyPopup();
                SentProblemSolved.Invoke();
            }
            else
            {
                Debug.Log("This problem is not solved.");
                SentProblemNotSolved.Invoke();
            }
        }

        private void ReactToMentor()
        {
            Debug.Log("Mentor has reacted");
        }
    }
}
