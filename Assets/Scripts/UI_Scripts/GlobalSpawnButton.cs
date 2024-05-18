using Assets.Scripts.Popup;
using Assets.Scripts.ProblemClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.UI_Scripts
{
    public class GlobalSpawnButton: MonoBehaviour
    {
        // Needs a reference to the problem manager for the global action dialog.
        public ProblemManager problemManager;
        private GlobalActionDialog dialog;
        public bool HasOpened; 

        private void Start()
        {
            HasOpened = false;
        }

        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.Q))
            {
                if(!HasOpened)
                {
                    SpawnPopup();
                }
                else
                {
                    CloseDialog();
                }
                
            }
        }

        public void SpawnPopup()
        {
            var spawnedDialog = problemManager.GetGlobalActionDialog();

            dialog = spawnedDialog;
            dialog.ShowPopupDialog();
            // Hide the button, when dialog is opened
            HasOpened = true;
        }


        public void CloseDialog()
        {
            dialog.HidePopup();
            HasOpened = false;
        }
    }
}
