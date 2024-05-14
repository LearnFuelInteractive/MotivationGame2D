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
            if (IndividualDialog == null)
            {
                Debug.LogError("Failed to get a valid dialog from IndividualDialog! blaah");
            }
            return IndividualDialog;
        }

        public IActionDialog GetGlobalActionDialog()
        {
            if (GlobalActionDialog == null)
            {
                Debug.LogError("Failed to get a valid dialog from GlobalActionDialog!");
            }
            
            return GlobalActionDialog;
        }
    }
}
