﻿using Assets.Scripts.Characters;
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
        public float AcceptanceCriteria;
        public string ProblemName = "Bored student";
        public string ProblemExplanation = "Default value";

        // Minimal and maximum values;
        public float MinimumValue = 10.0f;
        public float MaximumValue = 60.0f;

        public abstract void Affect();
        public abstract void GenerateAcceptanceCriteria();

    }
}
