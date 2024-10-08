using Zenject;

namespace Core.Player.Perks
{
    public class SaintGarlicBalanceContainerInstaller : MonoInstaller
    {
        public SaintGarlicBalanceContainer instance;
        public override void InstallBindings()
        {
            Container.Bind<SaintGarlicBalanceContainer>().FromInstance(instance).AsSingle();
        }
    }
}