using Managers;
using Zenject;
using UnityEngine;

public class MainInstaller : MonoInstaller
{
    [SerializeField] private GameManager _gameManager;

    public override void InstallBindings()
    {
        Container.Bind<IGameManager>().FromInstance(_gameManager).AsSingle();
        Container.Bind<ISceneManager>().To<SceneManager>().AsSingle();
    }
}