using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Player
{
    public class List : MonoBehaviour
    {
        private List<GameObject> PlayerList;

        private void Awake()
        {
            PlayerList = new List<GameObject>();
        }

        public void Add(GameObject Player)
        {
            PlayerList.Add(Player);
        }
    }
}