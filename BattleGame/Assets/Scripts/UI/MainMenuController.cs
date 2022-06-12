using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MainMenuModel), typeof(MainMenuView))]
public class MainMenuController : Controller
{
    #region MEMBERS

    #endregion

    #region PROPERTIES

    private MainMenuModel Model => GetModel<MainMenuModel>();
    private MainMenuView View => GetView<MainMenuView>();

    #endregion

    #region METHODS

    public override void Initialize()
    {
        base.Initialize();
        View.AddListenerToLoadFirstLevelButton(Model.LoadFirstLevel);
    }

    #endregion

    #region CLASS_ENUMS

    #endregion
}
