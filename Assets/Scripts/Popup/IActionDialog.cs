using Assets.Scripts.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Popup
{
    public abstract class IActionDialog: IPopup
    {
        public List<ASolution> solutions;
        // Contains all solutions in one place.
        public abstract void UpdateSolution();
    }
}
