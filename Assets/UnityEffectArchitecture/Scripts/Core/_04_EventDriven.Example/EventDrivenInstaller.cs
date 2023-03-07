#region

using rStarUtility.Generic.Installer;
using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._04_EventDriven
{
    public class EventDrivenInstaller : MonoInstaller
    {
    #region Public Methods

        public override void InstallBindings()
        {
            EventBusInstaller.Install(Container);
            Container.Bind<BossEventHandler>().AsSingle().NonLazy();
            Container.Bind<IBossUIPanel>().FromInstance(FindFirstObjectByType<BossUIPanel>());
            Container.Bind<IAudioSystem>().FromInstance(FindFirstObjectByType<AudioSystem>());
            Container.Bind<IEffectSpawner>().FromInstance(FindFirstObjectByType<EffectSpawner>());
            Container.Bind<BossEffectHandler>().To<BossEffectHandlerForAdvanced>().AsSingle();
        }

    #endregion
    }
}