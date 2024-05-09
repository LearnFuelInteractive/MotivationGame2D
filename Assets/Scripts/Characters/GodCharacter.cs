using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    public class GodCharacter: MonoBehaviour
    {
        public GameObject popup;
        public Problem currentProblem;
        public float problemMeter = 40;
        public float acceptanceCriteria = 0;

        public void ApplySolution(ASolution solution)
        {
            var answer = solution.SolveProblem(this);

            if (answer)
            {
                // Do something
                Debug.Log("Problem has solved");
                Destroy(popup);
            }
        }
    }
}
