using Profile;
using Tool;
using UnityEngine;

namespace Features.MenuControll
{
    internal class BackToMenuController : BaseController
    {
        private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/MenuController/BackToMenuView");

        private readonly BackToMenuView _view;
        private readonly ProfilePlayer _profilePlayer;
        


        public BackToMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(BackToMenu,MenuPause);
        }


        private BackToMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObject(objectView);

            return objectView.GetComponent<BackToMenuView>();
        }

        private void BackToMenu() =>
            _profilePlayer.CurrentState.Value = GameState.Start;

        private void MenuPause() =>
            _profilePlayer.CurrentState.Value = GameState.Pause;
    }
}
