using Zenject;

namespace Global
{
    public class GlobalDi : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameManager>().FromNewComponentOnNewGameObject().WithGameObjectName("GameManager").AsSingle();
        }
    }
}