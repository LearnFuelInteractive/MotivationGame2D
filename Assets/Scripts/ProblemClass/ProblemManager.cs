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
        

        public ActionDialog GetIndividualDialog()
        {
            return IndividualDialog;
        }
    }
}
