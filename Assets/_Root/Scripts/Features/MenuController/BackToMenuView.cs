using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Features.MenuControll
{
    internal class BackToMenuView : MonoBehaviour
    {
        [SerializeField] private Button _backToMenu;
        [SerializeField] private Button _menuPause;

        public void Init(UnityAction backToMenu, UnityAction menuPause)
        {
            _backToMenu.onClick.AddListener(backToMenu);
            _menuPause.onClick.AddListener(menuPause);
        }
        private void OnDestroy()
        {
            _backToMenu.onClick.RemoveAllListeners();
            _menuPause.onClick.RemoveAllListeners();
        }
    }
}
