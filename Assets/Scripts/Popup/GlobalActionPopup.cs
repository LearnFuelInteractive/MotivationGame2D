using Assets.Scripts.ProblemClass;
using Assets.Scripts.UI_Scripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Popup
{
    public class GlobalActionPopup : IPopup, IPointerClickHandler
    {
        public bool hasOpened;

        public GlobalActionSpawn parent;
        private GlobalActionDialog dialog;

        public ProblemManager problemManager;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Clicked on global action popup.");
            
            
            if (problemManager == null)
            {
                Debug.LogError("ProblemManager is not initialized!");
                return;
            }
            dialog = problemManager.GetGlobalActionDialog();
            //Instantiate(dialog);
          
            if (dialog == null)
            {
                Debug.LogError("Failed to get a valid dialog from ProblemManager!");
                return;
            }
            
            dialog.ShowPopupDialog();
            
            gameObject.SetActive(false);
            parent.HasEntered = hasOpened;
            
        }
        
        private void Start()
        {
            this.problemManager = FindObjectOfType<ProblemManager>();
            hasOpened = false;
        }
    }
}
