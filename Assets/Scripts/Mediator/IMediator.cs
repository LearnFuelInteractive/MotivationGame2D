using Assets.Scripts.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Mediator
{
    public abstract class IMediator: MonoBehaviour
    {
        public abstract void Notify(ASolution solution, string value);
    }
}
