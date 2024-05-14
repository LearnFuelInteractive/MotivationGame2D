using Assets.Scripts.Characters;
using Assets.Scripts.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts.ProblemClass
{
    public abstract class IProblem: MonoBehaviour
    {
        public GameObject ProblemIcon;
        public string ProblemName = "Bored student";
        public string ProblemExplanation = "Default value";
        public Student RelevantStudent;
        public CompetenceType CompetenceType;
        public float AcceptanceCriteria;

        public abstract void Affect();

        public void GenerateRandomAcceptanceCriteria()
        {
            float underBound = 0.0f;
            float upperBound = 100.0f;
            float range = upperBound - underBound;
            Random random = new();
            var value = (float)random.NextDouble() * range;
            Debug.Log($"AcceptanceCriteria generated is {value}");
            // Generates random value between 0 and 100
            AcceptanceCriteria = value;
        }
    }
}
