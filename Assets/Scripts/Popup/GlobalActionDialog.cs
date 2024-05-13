using Assets.Scripts.Mediator;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Popup
{
    public class GlobalActionDialog : IActionDialog
    {
        // Relation to mediator class
        // For now a relation to level manager.
        public IMediator Mediator;

        private void Start()
        {
            // Default setting
            // HidePopup();
            // Will retrieve all global solutions of children.
            Mediator = GameObject.FindFirstObjectByType <LevelMediator>();
            if(Mediator != null )
            {
                Debug.Log("Mediator found");
            }
            else
            {
                Debug.Log("Mediator not found");
            }
        }

        public override void UpdateSolution()
        {
            // Get mediator class and assign it to global solution
            Debug.Log("No updates required");
        }

        public object GetMediator()
        {
            return Mediator;
        }
    }
}
