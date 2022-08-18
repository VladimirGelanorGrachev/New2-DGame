using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    internal class MenuPauseView : MonoBehaviour
    {
        [SerializeField] private Button _backGame;
        [SerializeField] private Button _backToMenu;        

        public void Init(UnityAction backToMenu, UnityAction backGame)
        {
            _backToMenu.onClick.AddListener(backToMenu);
            _backGame.onClick.AddListener(backGame);
        }

        private void OnDestroy()
        {
            _backGame.onClick.RemoveAllListeners();
            _backToMenu.onClick.RemoveAllListeners();
        }
    }
}
