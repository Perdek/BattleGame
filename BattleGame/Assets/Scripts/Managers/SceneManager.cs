using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class SceneManager : ISceneManager
    {
        #region PROPERTIES

        #endregion

        #region METHODS

        public void LoadFirstLevel()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Constants.LEVEL_01);
        }

        public void LoadMenuScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Constants.MAIN_SCENE_MAIN);
        }

        #endregion
    }
}
