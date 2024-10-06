using Core.Settings.Difficulty;
using UnityEngine;
using Zenject;

public class DifficultyManagerInstaller : MonoInstaller
{
    [SerializeField]
    private DifficultyManager instance;
    
    public override void InstallBindings()
    { 
        Container.Bind<DifficultyManager>().FromInstance(instance).AsSingle().NonLazy();
    }
}