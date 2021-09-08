using Gameplay.Player;
using Global;
using UnityEngine;
using Zenject;

namespace Gameplay.Manager
{
    public class GameplaySceneManager : MonoBehaviour
    {
        [Inject] private GameManager _gameManager { get; }
        [Inject] public Aggregator Aggregator { get; }
        [Inject] public Networking.Manager Networking { get; }
        [Inject] public List PlayerList { get; }
        [Inject] public Spawner PlayerSpawner { get; }

        private void Awake()
        {
            _gameManager.Gameplay = this;
        }
    }
}