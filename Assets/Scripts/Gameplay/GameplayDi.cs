using Gameplay.Manager;
using Gameplay.Player;
using Photon.Voice.PUN;
using Photon.Voice.Unity;
using Zenject;
using Aggregator = Gameplay.Manager.Aggregator;

namespace Gameplay
{
    public class GameplayDi : MonoInstaller
    {
        public override void InstallBindings()
        {
            Manager();
            Player();
            Networking();
            NetworkingVoice();
        }

        private void NetworkingVoice()
        {
            Container.Bind<Recorder>().FromComponentInHierarchy().AsSingle();
            Container.Bind<PhotonVoiceNetwork>().FromInstance(PhotonVoiceNetwork.Instance).AsSingle();
        }

        private void Networking()
        {
            Container.Bind<Networking.Manager>().FromNewComponentOnRoot().AsSingle();
        }

        private void Manager()
        {
            Container.Bind<GameplaySceneManager>().FromNewComponentOnRoot().AsSingle();
            Container.Bind<Aggregator>().FromNewComponentOnRoot().AsSingle();
        }

        private void Player()
        {
            Container.Bind<List>().FromNewComponentOnRoot().AsSingle();
            Container.Bind<Spawner>().FromNewComponentOnRoot().AsSingle();
        }
    }
}