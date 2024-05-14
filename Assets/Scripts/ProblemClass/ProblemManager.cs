using Assets.Scripts.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ProblemClass
{
    public class ProblemManager: MonoBehaviour
    {
        public ActionDialog IndividualDialog;
        public IActionDialog GlobalActionDialog;

        public List<Problem> ProblemList;
        

        public ActionDialog GetIndividualDialog()
        {
            return IndividualDialog;
        }

        public IActionDialog GetGlobalActionDialog()
        {
            return GlobalActionDialog;
        }

        public Problem GenerateRandomProblem()
        {
            // Temp solution, will be replaced with random generated problem
            return ProblemList.First();
        }
    }
}
