using Assets.Scripts.Characters;
using Assets.Scripts.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Solution.GlobalSolutions
{
    public abstract class GlobalAction : ASolution
    {
        // For now a relation to level manager.
        public IMediator Mediator;
        public LessonFactory LessonFactory;

        public string SolutionType = "Standard";

        private void Start()
        {
            LessonFactory = new LessonFactory();
            var mediator = FindFirstObjectByType<LevelMediator>();
            if (mediator != null)
            {
                Mediator = mediator;
               // Debug.Log("Mediator found");
            }
            else
            {
                //Debug.Log("Mediator not found");
            }
        }
    }
}
