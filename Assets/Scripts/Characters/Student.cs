﻿using Assets.Scripts.Popup;
using Assets.Scripts.ProblemClass;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Characters
{
    public class Student : Character, IPointerClickHandler
    {
        // Will be handled later by a manager.
        public GameObject popup;

        // currentProblem, this can be null or not
        public Problem currentProblem;
        public ProblemManager problemManager;

        // Temp variabels.
        public float problemMeter = 40;
        public float AcceptanceCriteria = 0;

        public Student originStudent;
        public ActionDialog dialog;

        private void Start()
        {
            SpawnPopup();
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
            // Will be later replaced by a factory pattern.
            // Spawns in a popup with the correct data to it.

            // Assigns problem to student.
            Problem problem = problemManager.GenerateRandomProblem();
            // Also temporary solution, will need to be integrated in problem manager.
            AssignProblem(problem);
            
            if(problem != null)
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
        public bool isInRange = false;

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
                dialog.HidePopup();
            }
        }


       

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("clickingg.");
            // This should open individual action dialog
            if (isInRange)
            {
                Debug.Log("Individual action: Open dialog.");
                dialog = problemManager.GetIndividualDialog();
                dialog.student = this;
                dialog.ShowPopup();
            }
          
        }



    }
}
