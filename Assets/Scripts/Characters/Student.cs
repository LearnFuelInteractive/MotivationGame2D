﻿using Assets.Scripts.ProblemClass;
using System;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    public class Student : Character
    {
        public Persona persona;
        public GameObject popup;

        // currentProblem, this can be null or not
        public Problem currentProblem;
        public ProblemManager problemManager;

        public bool isInRange;

        // Temp variabels.
        public float problemMeter = 40;
        public float AcceptanceCriteria = 0;

        private void Start()
        {
            //SpawnPopup();
            this.persona = RandomPersonaGenerator.GenerateRandomPersona();
        }

        public override void ApplySolution(ASolution solution)
        {
            var answer = solution.SolveProblem(this);

            if (answer)
            {
                DestroyImmediate(popup, true);
            }
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
            //// Will be later replaced by a factory pattern.
            //// Spawns in a popup with the correct data to it.

            //// Assigns problem to student.
            //Problem problem = problemManager.GenerateHalfRandomProblem();
            //// Also temporary solution, will need to be integrated in problem manager.
            //AssignProblem(problem);

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
    }
}
