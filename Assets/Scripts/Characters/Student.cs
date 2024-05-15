using Assets.Scripts.Mediator;
using Assets.Scripts.ProblemClass;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Characters
{
    public class Student : Character
    {
        public Persona persona;
        public GameObject prefabpopup;
        public IMediator mediator;

        // currentProblem, this can be null or not
        public Problem? currentProblem;
        public ProblemManager problemManager;

        public GameObject concretePopup;

        public bool isInRange;

        private void Start()
        {
            //SpawnPopup();
            mediator = FindAnyObjectByType<IMediator>();
            this.persona = RandomPersonaGenerator.GenerateRandomPersona();
            problemManager = FindAnyObjectByType<ProblemManager>();
            if (problemManager == null ) {
                Debug.Log("Problem manager not found in scene");
            }
        }

        public override void ApplySolution(ASolution solution)
        {            
            var HasSolved = solution.SolveProblem(this);
            if (HasSolved)
            {
                Debug.Log("Problem successfully solved");
                DestroyImmediate(concretePopup, true);
                DestroyImmediate(currentProblem, true);
                UnAssignProblem();
            } else
            {
                Debug.Log("Failed to solve problem");

            }
        }

        public void DestroyPopup()
        {
            Destroy(concretePopup);
            Destroy(currentProblem.gameObject);
            UnAssignProblem();
        }

        public override void Respond()
        {
            throw new NotImplementedException();
        }

        public bool HasProblem()
        {
            return currentProblem != null;
        }

        public void AssignProblem(Problem problem)
        {
            problem.RelevantStudent = this;
            currentProblem = problem;
        }

        public void UnAssignProblem()
        {
            currentProblem = null;
        }

        public override void SpawnPopup()
        {
            if (currentProblem != null)
            {
                concretePopup = Instantiate(prefabpopup, spawnPoint.position, Quaternion.identity);
                // Puts game object under spawn point
                concretePopup.transform.SetParent(spawnPoint.transform);

                var problemPopUp = concretePopup.GetComponent<IndividualActionPopup>();
                if (problemPopUp != null)
                {
                    problemPopUp.originStudent = this;
                    problemPopUp.problemManager = problemManager;
                }
            }
        }
        
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                isInRange = true;

            }
        }

        public void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                isInRange = false;
            }
        }

        public bool IsInRange
        {
            get => isInRange;
        }
        
        
        public void DestroyProblemPopup()
        {
            Destroy(concretePopup);
        }
    }
}
