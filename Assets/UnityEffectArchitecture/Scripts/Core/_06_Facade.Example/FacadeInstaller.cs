#region

using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._06_Facade.Example
{
    public class FacadeInstaller : MonoInstaller
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
            Container.Decorate<BossEffectHandler>().With<BossEffectHandlerForKnockBack>();

            // Container.Bind<BossEffectHandler>().To<BossEffectHandlerForKnockBack>().AsSingle();
        }

    #endregion
    }
}