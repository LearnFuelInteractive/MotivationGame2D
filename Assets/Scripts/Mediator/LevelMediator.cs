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
        public UnityEvent<string> SentProblemSolved;
        public UnityEvent<string> SentProblemNotSolved;
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
            int hasSolvedCounter = 0;
            int hasNotSolvedCounter = 0;
            foreach (var student in levelManager.students)
            {
                var studentObject = student.GetComponent<Student>();
                var hasSolved = solution.SolveProblem(studentObject);
                if (hasSolved)
                {
                    Debug.Log("Has solved the issue.");
                    studentObject.DestroyPopup();
                    hasSolvedCounter++;
                }
                else
                {
                    Debug.Log("Global action did not solve problem.");
                    hasNotSolvedCounter++;
                }
            }

            if (hasSolvedCounter > 0 && hasNotSolvedCounter > 0) {
                if(hasSolvedCounter >= hasNotSolvedCounter)
                {
                    SentProblemSolved.Invoke("Goed gedaan, je actie heeft de meeste student problemen opgelost");

                } else
                {
                    SentProblemNotSolved.Invoke("Goed gedaan, je actie heeft sommige problemen opgelost, maar je moet nog even naar de rest kijken");
                }
            } else
            {
                if(hasNotSolvedCounter > 0)
                {
                    SentProblemSolved.Invoke("Goed gedaan, je hebt je les zo ingericht dat je alle problemen hebt opgelost");
                } else
                {
                    SentProblemNotSolved.Invoke("Dit lesonderdeel blijkt niet helemaal te werken, misschien moet je iets anders proberen?");
                }
            }
        }

        private void ReactToStudent(ASolution solution)
        {
            currentStudent = solution.TargetedStudent;
            var problem = solution.TargetedStudent.currentProblem;
            if (solution.SolveProblem(currentStudent))
            {
                Debug.Log("This problem has been solved.");
                currentStudent.DestroyPopup();
                SentProblemSolved.Invoke(problem.ProblemResolvedText);
            }
            else
            {
                Debug.Log("This problem is not solved.");
                SentProblemNotSolved.Invoke(problem.ProblemNotResolvedText);
            }
        }

        private void ReactToMentor()
        {
            Debug.Log("Mentor has reacted");
        }
    }
}
