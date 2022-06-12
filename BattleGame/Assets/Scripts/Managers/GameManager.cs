using System;
using UnityEngine;
using Zenject;

namespace Managers
{
    public class GameManager : MonoBehaviour, IGameManager
    {
        #region MEMBERS

        private ISceneManager _sceneManager;

        #endregion

        #region PROPERTIES

        #endregion

        #region UNITY_METHODS

        protected virtual void Awake()
        {
            LoadMenuScene();
        }

        #endregion

        #region METHODS

        [Inject]
        public void InjectDependencies(ISceneManager sceneManager)
        {
            _sceneManager = sceneManager;
        }

        public void LoadFirstLevel()
        {
            _sceneManager.LoadFirstLevel();
        }

        private void LoadMenuScene()
        {
            _sceneManager.LoadMenuScene();
        }

        #endregion
    }
}
