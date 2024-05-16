using Assets.Scripts.Characters;
using Assets.Scripts.Solution.GlobalSolutions;
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
        // P.S. Voeg in Unity, handmatig alle problemen toepasbaar voor het level.
        public List<GlobalAction> solutions;
        // Contains all solutions in one place.
        public abstract void UpdateSolution();

        public override void ShowPopup()
        {
            base.ShowPopup();
        }

        public override void HidePopup()
        {
            base.HidePopup();
        }
    }
}
