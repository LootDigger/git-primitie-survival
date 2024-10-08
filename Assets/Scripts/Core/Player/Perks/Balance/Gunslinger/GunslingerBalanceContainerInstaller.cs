using Zenject;

namespace Core.Player.Perks
{
    public class GunslingerBalanceContainerInstaller : MonoInstaller
    {
        public GunslingerBalanceContainer instance;
        public override void InstallBindings()
        {
            Container.Bind(typeof(GunslingerBalanceContainer)).FromInstance(instance).AsSingle();
        }
    }
}