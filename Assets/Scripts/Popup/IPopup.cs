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

        // These methods are virtual in case the implementation needs to differ.
        public virtual void ShowPopup()
        {
            popUp.SetActive(true);

        }

        public virtual void HidePopup()
        {
            // These methods are virtual in case the implementation needs to differ.
            popUp.SetActive(false);

        }
    }
}
