using Global;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using Photon.Voice.Unity;
using UnityEngine;
using Zenject;

namespace Gameplay.Networking
{
    public class Manager : MonoBehaviourPunCallbacks
    {
        [Inject] private GameManager _gameManager;
        [Inject] public PhotonVoiceNetwork photonVoiceNetwork { get; }
        [Inject] public Recorder recorder { get; }

        public void Connect()
        {
            PhotonNetwork.ConnectUsingSettings(
                new AppSettings
                {
                    AppIdVoice = "35fae293-12e9-43a2-91ff-439b870a156d",
                    AppIdRealtime = "611b1410-2ebd-46c4-b732-9dc9ff341d78"
                });
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log("connected to server successfully!");
            PhotonNetwork.JoinLobby();
        }

        public override void OnJoinedLobby()
        {
            Debug.Log("joined lobby!");
            PhotonNetwork.JoinOrCreateRoom("TestRoom", new RoomOptions() {MaxPlayers = 20}, TypedLobby.Default);
        }

        public override void OnJoinedRoom()
        {
            _gameManager.Gameplay.Aggregator.OnJoinedRoom();

            /*photonVoiceNetwork.ConnectUsingSettings(new AppSettings
            {
                AppIdVoice = "35fae293-12e9-43a2-91ff-439b870a156d",
                AppIdRealtime = "611b1410-2ebd-46c4-b732-9dc9ff341d78"
            });*/
            // photonVoiceNetwork.ConnectAndJoinRoom();
            Debug.Log("on room joined");
        }
    }
}