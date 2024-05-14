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
        public ProblemManager problemManager;
        public GlobalActionSpawn parent;
        public UnityEvent updateSpawner;
        private IActionDialog dialog;
        
        
        void Start()
        {
            this.problemManager = FindObjectOfType<ProblemManager>();
            hasOpened = false;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Clicked on global action popup.");
            dialog = problemManager.GetGlobalActionDialog();
            if (dialog == null)
            {
                Debug.LogError("Failed to get a valid dialog from ProblemManager!");
                return;
            }
            dialog.ShowPopup();
            
            
            
            gameObject.SetActive(false);
            parent.HasEntered = hasOpened;
            
        }
    }
}
