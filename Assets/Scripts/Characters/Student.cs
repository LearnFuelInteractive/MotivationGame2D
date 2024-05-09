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

        public override void ApplySolution(ASolution solution)
        {
            var answer = solution.SolveProblem(this);

            if (answer)
            {
                // Do something
                Debug.Log("Problem has solved");
                Destroy(popup);
            }
        }

        public override void Respond()
        {
            throw new NotImplementedException();
        }

        public override void SpawnPopup()
        {
            throw new NotImplementedException();
        }
    }
}
