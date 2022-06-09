using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        #region MEMBERS

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

        private void LoadMenuScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Constants.MAIN_SCENE_MAIN);
        }

        #endregion
    }
}
