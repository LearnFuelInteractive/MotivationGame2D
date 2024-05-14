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
            // Check if the popup has already been instantiated
            if (instantiatedPopUp == null)
            {
                // Instantiate the popup if it hasn't been instantiated
                instantiatedPopUp = Instantiate(popUp);
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
