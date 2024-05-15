using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    public abstract class Character: MonoBehaviour
    {
        // Personage.
        public GameObject character;
        // SpawnPoint
        public Transform spawnPoint;

        public string Name;

        // Students only, a persona.
        private void Start()
        {
            Debug.Log($"Character {Name} loaded in.");
        }

        public abstract void Respond();
        public abstract void SpawnPopup();
    }
}
