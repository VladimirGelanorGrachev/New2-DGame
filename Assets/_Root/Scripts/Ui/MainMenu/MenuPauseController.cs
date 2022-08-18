using Profile;
using Tool;
using UnityEngine;

namespace Ui
{ 
internal class MenuPauseController : BaseController
{
    private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/UI/MenuPauseView");

    private readonly MenuPauseView _view;
    private readonly ProfilePlayer _profilePlayer;



    public MenuPauseController(Transform placeForUi, ProfilePlayer profilePlayer)
    {
        _profilePlayer = profilePlayer;
        _view = LoadView(placeForUi);
        _view.Init(BackToMenu,ReturnToGame);
    }


    private MenuPauseView LoadView(Transform placeForUi)
    {
        GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
        GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
        AddGameObject(objectView);

        return objectView.GetComponent<MenuPauseView>();
    }

    private void BackToMenu() =>
        _profilePlayer.CurrentState.Value = GameState.Start;

    private void ReturnToGame() =>
        _profilePlayer.CurrentState.Value = GameState.Game;
}
}
