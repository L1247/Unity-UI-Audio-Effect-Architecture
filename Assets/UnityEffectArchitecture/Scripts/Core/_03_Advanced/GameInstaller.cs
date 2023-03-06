#region

using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._03_Advanced
{
    public class GameInstaller : MonoInstaller
    {
    #region Public Methods

        public override void InstallBindings()
        {
            Container.Bind<IBossUIPanel>().FromInstance(FindFirstObjectByType<BossUIPanel>());
            Container.Bind<IAudioSystem>().FromInstance(FindFirstObjectByType<AudioSystem>());
            Container.Bind<IEffectSpawner>().FromInstance(FindFirstObjectByType<EffectSpawner>());
            Container.Bind<BossEffectHandler>().To<BossEffectHandlerForAdvanced>().AsSingle();
        }

    #endregion
    }
}