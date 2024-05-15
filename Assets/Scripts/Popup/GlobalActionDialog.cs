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
            // Will retrieve all global solutions of children.
            Mediator = GameObject.FindFirstObjectByType <LevelMediator>();
        }

        public void ShowPopupDialog()
        {
            // Should also process problem and student.
            Debug.Log("opened the showpopup method in global action dialog");
            ShowPopup(); // dooesnt work
           // Instantiate(gameObject); // works
            
         
        }
        public override void UpdateSolution()
        {
            // Get mediator class and assign it to global solution
            Debug.Log("No updates required");
        }

        public void DestroyPopup()
        {
            HidePopup();
        }
        
        public object GetMediator()
        {
            return Mediator;
        }

       
    }
}
