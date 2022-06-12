using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class MainMenuView : View
{
    #region MEMBERS

    [SerializeField] private Button _loadFirstLevelButton;

    #endregion

    #region PROPERTIES

    #endregion

    #region METHODS

    public void AddListenerToLoadFirstLevelButton(UnityAction onClick)
    {
        _loadFirstLevelButton.onClick.AddListener(onClick);
    }

    #endregion

    #region CLASS_ENUMS

    #endregion
}
