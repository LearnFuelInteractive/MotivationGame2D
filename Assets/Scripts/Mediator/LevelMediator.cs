using Assets.Scripts.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Mediator
{
    public class LevelMediator : MonoBehaviour, IMediator
    {

        // Temp value. Will need to be connected with level manager.
        public List<Student> students;

        public void ApplySolutionToStudents(ASolution solution)
        {
            foreach (var student in students)
            {
                var hasSolved = solution.SolveProblem(student);
                if (hasSolved)
                {

                }
            }
        }
    }
}
