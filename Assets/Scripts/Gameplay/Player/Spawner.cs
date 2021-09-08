using Global;
using Photon.Pun;
using UnityEngine;
using Zenject;

namespace Gameplay.Player
{
    public class Spawner : MonoBehaviour
    {
        [Inject] private GameManager _gameManager;
        private GameObject Player;

        #region Ref

        private List list => _gameManager.Gameplay.PlayerList;

        #endregion

        public void Spawn()
        {
            list.Add(PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity));
        }
    }
}