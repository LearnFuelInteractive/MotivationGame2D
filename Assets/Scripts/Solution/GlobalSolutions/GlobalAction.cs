using Assets.Scripts.Characters;
using Assets.Scripts.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Solution.GlobalSolutions
{
    public abstract class GlobalAction : ASolution
    {
        // For now a relation to level manager.
        public IMediator Mediator;
    }
}
