using Zenject;
using Managers;

public class MainMenuModel : Model
{
    #region MEMBERS
        
    private IGameManager _gameManager;

    #endregion

    #region PROPERTIES    

    #endregion

    #region METHODS

    [Inject]
    public void InjectDependencies(IGameManager gameManager)
    {
        _gameManager = gameManager;
    }

    public void LoadFirstLevel()
    {
        _gameManager.LoadFirstLevel();
    }

    #endregion

    #region CLASS_ENUMS

    #endregion
}
