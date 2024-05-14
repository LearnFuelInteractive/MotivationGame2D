using Assets.Scripts.Popup;
using Assets.Scripts.ProblemClass;
using UnityEngine;

namespace Assets.Scripts.UI_Scripts
{
    public class GlobalActionSpawn: MonoBehaviour
    {
        public bool HasEntered;
        public bool HasClicked;
        public GameObject customPopUp;
        public ProblemManager problemManager;
        public Transform popupSpawn;

        public GameObject instantiatedPopup;

        void Start () { 
            HasEntered = false;
            problemManager = FindAnyObjectByType<ProblemManager>();
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            HasEntered = false;
            Debug.Log("Player left area");
            Destroy(instantiatedPopup);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                Debug.Log("Has touched area");
                // Makes it possible the popup to be clickable
                HasEntered = true;

                // Popup should be shown.
                SpawnPopup();
            }
        }

        public void SpawnPopup()
        {
            instantiatedPopup = Instantiate(customPopUp, popupSpawn.position, Quaternion.identity);
            GlobalActionPopup pop = instantiatedPopup.GetComponent<GlobalActionPopup>();
            pop.problemManager = problemManager;
            pop.parent = this;
        }
    }
}
