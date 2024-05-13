using UnityEngine;

namespace Assets.Scripts.Popup
{
    public class GlobalActionDialog : IActionDialog
    {
        // Relation to mediator class
        // For now a relation to level manager.

        private void Start()
        {
            // Default setting
            // HidePopup();
            // Will retrieve all global solutions of children.
            solutions.Clear();

        }

        public override void UpdateSolution()
        {
            Debug.Log("No updates required");
        }
    }
}
