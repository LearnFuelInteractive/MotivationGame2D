using Assets.Scripts.Mediator;
using Assets.Scripts.ProblemClass;
using System;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    public class Student : Character
    {
        public Persona persona;
        public GameObject popup;
        public IMediator mediator;

        // currentProblem, this can be null or not
        public Problem currentProblem;
        public ProblemManager problemManager;

        // Temp variabels.
        public float problemMeter = 40;
        public float AcceptanceCriteria = 0;

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
            Debug.Log("Passes through student.");
            var HasSolved = solution.SolveProblem(this);

            if (HasSolved)
            {
                DestroyImmediate(popup, true);
            }
        }

        public void DestroyPopup()
        {
            Debug.Log("Destroy popup");
            Destroy(popup);
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
                GameObject spawnedPopup = Instantiate(popup, spawnPoint.position, Quaternion.identity);
                // Puts game object under spawn point
                spawnedPopup.transform.SetParent(spawnPoint.transform);

                var problemPopUp = spawnedPopup.GetComponent<ProblemPopup>();
                if (problemPopUp != null)
                {
                    problemPopUp.originStudent = this;
                    problemPopUp.problemManager = problemManager;

                    popup = spawnedPopup;
                }
            }
        }
    }
}
