using Global;
using Photon.Pun;
using Photon.Voice.PUN;
using UnityEngine;
using Zenject;

namespace Gameplay.Player
{
    public class Player : MonoBehaviour
    {
        [Inject] private GameManager _gameManager;
        public Controller CurrentController { get; private set; }
        public PhotonView PhotonView { get; private set; }
        public PhotonVoiceView PhotonVoiceView { get; private set; }

        private void Start()
        {
            PhotonView = GetComponent<PhotonView>();
            PhotonVoiceView = GetComponent<PhotonVoiceView>();
            if (PhotonVoiceView.IsRecorder) PhotonVoiceView.RecorderInUse = _gameManager.Gameplay.Networking.recorder;
            if (PhotonView.IsMine) CurrentController = _gameManager.DiContainer.InstantiateComponent<Controller>(gameObject);
        }
    }
}