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

        void Start()
        {
            hasOpened = false;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Clicked on global action popup.");
            var dialog = problemManager.GetGlobalActionDialog();
            dialog.ShowPopup();
            gameObject.SetActive(false);
            parent.HasEntered = hasOpened;
        }
    }
}
