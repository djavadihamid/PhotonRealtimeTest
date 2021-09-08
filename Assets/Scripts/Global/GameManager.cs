using Gameplay.Manager;
using UnityEngine;
using Zenject;

namespace Global
{
    public class GameManager : MonoBehaviour
    {
        [Inject] public DiContainer DiContainer { get; }
        public GameplaySceneManager Gameplay;
    }
}