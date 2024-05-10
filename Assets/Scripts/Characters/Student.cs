using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    public class Student : Character
    {
        public GameObject popup;
        public Problem currentProblem;
        public float problemMeter = 40;
        public float AcceptanceCriteria = 0;

        private void Start()
        {
            SpawnPopup();
        }

        public override void ApplySolution(ASolution solution)
        {
            var answer = solution.SolveProblem(this);

            if (answer)
            {
                // Do something

                Debug.Log("Problem has solved");
                DestroyImmediate(popup, true);
            }
        }

        public override void Respond()
        {
            throw new NotImplementedException();
        }

        public override void SpawnPopup()
        {
            // Spawns in a popup with the correct data to it.
            GameObject copy = Instantiate(popup, ProblemPopup.position, Quaternion.identity);
            var problemPopUp = copy.GetComponent<ProblemPopup>();
            if (problemPopUp != null)
            {
                Debug.Log("Creation of popup suceeded");
                problemPopUp.problemAction.RelevantStudent = this;
                Debug.Log("Assigned of popup to gameObject");
                copy.transform.SetParent(ProblemPopup.transform);
                popup = copy;
            }
        }
    }
}
