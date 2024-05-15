using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Popup
{
    public abstract class IPopup: MonoBehaviour
    {
        // Contains popup object
        public GameObject popUp;
        // Static variable to check if popup is already instantiated
        private static GameObject instantiatedPopUp;

        // These methods are virtual in case the implementation needs to differ.
        public virtual void ShowPopup()
        {
            Debug.Log("Arrived in THE showpopup method in IPopup class");
            
            if (popUp == null)
            {
                 Debug.Log("Cant find popup object.");
            }
            
            Debug.Log(popUp.name + " going to be instantiated."); 
            
            // Check if the popup has already been instantiated
            if (instantiatedPopUp == null)
            {

                try
                {
                   // instantiatedPopUp = Instantiate(gameObject); // doesnt work
                    instantiatedPopUp = Instantiate(popUp); // doesnt work
                    Debug.Log("Created: " + instantiatedPopUp, instantiatedPopUp);
                    

                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                    throw;
                }
                // Instantiate the popup if it hasn't been instantiated
              
              
                
            }
            else
            {
                Debug.Log("Popup already instantiated.");
            }
        }

        public virtual void HidePopup()
        {
            // Check if the popup has already been instantiated
            if (instantiatedPopUp != null)
            {
                // Destroy the popup if it has been instantiated
                Destroy(instantiatedPopUp);
                instantiatedPopUp = null;
            }
            
            
        }
    }
}
