#region

using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._05_Master
{
    public class MasterInstaller : MonoInstaller
    {
    #region Public Methods

        public override void InstallBindings()
        {
            Container.Bind<IBossUIPanel>().FromInstance(FindFirstObjectByType<BossUIPanel>());
            Container.Bind<IAudioSystem>().FromInstance(FindFirstObjectByType<AudioSystem>());
            Container.Bind<IEffectSpawner>().FromInstance(FindFirstObjectByType<EffectSpawner>());

            Container.Bind<BossEffectHandler>().To<BossEffectHandler_Audio>().AsSingle();
            Container.Decorate<BossEffectHandler>().With<BossEffectHandler_UI>();
            Container.Decorate<BossEffectHandler>().With<BossEffectHandler_Effect>();
            Container.Decorate<BossEffectHandler>().With<BossEffectHandler_Log>();
        }

    #endregion
    }
}