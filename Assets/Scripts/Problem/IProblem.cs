using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Popup
{
    public interface IProblem
    {
        void Click();
        void ShowProblem();
        void HideProblem();
        void Affect();
    }
}
