using Assets.Scripts.Characters;
using Assets.Scripts.Other;
using Assets.Scripts.Popup;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.ProblemClass {
    
    public class Problem : IProblem
    {

        // Start is called before the first frame update
        void Start()
        {
            // Apply standard acceptancecriteria, before influence of student.
            GenerateAcceptanceCriteria();
        }

        public string ProblemType()
        {
            return "There is a problem";
        }

        // Only detected when problem is assigned to student.
        public override void Affect()
        {
            float valueOfType = RelevantStudent.persona.GetCompetence(CompetenceType);
            // If skill is above 70 percent, acceptence criteria should be lowered.
            if (valueOfType > 0.7)
            {
                AcceptanceCriteria *= (1 - valueOfType);
            }
            // If skill percentage is lower then 40 percent, it should be higher
            else if (valueOfType < 0.4)
            {
                AcceptanceCriteria *= (valueOfType + 1);
            }
        }

        public override void GenerateAcceptanceCriteria()
        {
            float acceptanceCriteria = Random.Range(MinimumValue, MaximumValue);
            Debug.Log("Acceptance criteria is " + acceptanceCriteria);
            AcceptanceCriteria = acceptanceCriteria;
        }

        public void AssignStudent(Student student)
        {
            this.RelevantStudent = student;
        }
    }
}



