using Global;
using UnityEngine;
using Zenject;

namespace Gameplay.Manager
{
    public class Aggregator : MonoBehaviour
    {
        [Inject] private GameManager _gameManager;

        private void Start()
        {
            _gameManager.Gameplay.Networking.Connect();
        }

        public void OnJoinedRoom()
        {
            _gameManager.Gameplay.PlayerSpawner.Spawn();
        }
    }
}