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
        
        public Student RelevantStudent;
        public CompetenceType CompetenceType;
        public float AcceptanceCriteria = 55;
        public string ProblemName = "Bored student";
        public string ProblemExplanation = "Default value";

        public abstract void Affect();
    }
}
