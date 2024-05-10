using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Popup
{
    public class ActionDialog
    {
        // Contains all solutions in one place.

        // Only for Individual action: The problem this dialog is called upon
        // Optional: The student to which a solution needs to be applied upon.

        // Responsibility
        // Opening en closing dialog.
        // Contain the problem of student.

        // Further action.
        // When player has clicked upon problem, a dialog screen should be spawned and all other elements should be blacked out.
        // Focus should be aimed at player, student and dialog.
        public void SetProblem(Problem problem)
        {

        }

        public void UnSetProblem() { 
            // Should destroy problem from dialog menu.
        }

        public void OpenDialog()
        {

        }

        public void CloseDialog() { 
        
        }

        public void SelfDestruct()
        {
            // If needed, this dialog should remove itself.
        }
    }
}
