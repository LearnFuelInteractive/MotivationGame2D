using Assets.Scripts.Characters;
using Assets.Scripts.Other;
using Assets.Scripts.Popup;
using System;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts.ProblemClass {
    
    public class Problem : MonoBehaviour, IProblem
    {
        public GameObject ProblemIcon;
        public Student RelevantStudent;
        public string ProblemName = "Default problem";

        // Waarden
        // Competentie
        public CompetenceType competenceType;
        public float AcceptanceCriteria;

        // Start is called before the first frame update
        void Start()
        {
            // Apply standard acceptancecriteria, before influence of student.
            AcceptanceCriteria = GenerateRandomAcceptanceCriteria();
            // Apply effects of student persona to the problem.
            Affect();
        }

        public string ProblemType()
        {
            return "There is a problem";
        }

        private float GenerateRandomAcceptanceCriteria()
        {
            float underBound = 0.0f;
            float upperBound = 100.0f;
            float range = upperBound - underBound;
            Random random = new();

            // Generates random value between 0 and 100
            return (float)random.NextDouble() * range;
        }

        // Only detected when problem is assigned to student.
        public void Affect()
        {
            CompetenceType strongestType = CompetenceType.COMPETENCE;
            float valueOfType = 0.11f;
            if (strongestType.Equals(competenceType))
            {
                // Weaken the acceptance criteria.
                AcceptanceCriteria = valueOfType * AcceptanceCriteria;
            }
            else
            {
                // Reinforce the acceptance criteria
                AcceptanceCriteria = (1.0f + valueOfType) * AcceptanceCriteria;
            }
        }
    }

}



