using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    internal class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSettings;
        [SerializeField] private Button _shadButton;
        [SerializeField] private Button _bayButton;
        public void Init(UnityAction startGame, UnityAction openSettings, UnityAction openShed)
        {
            _buttonStart.onClick.AddListener(startGame);
            _buttonSettings.onClick.AddListener(openSettings);
            _shadButton.onClick.AddListener(openShed);
        }

        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSettings.onClick.RemoveAllListeners();
            _shadButton?.onClick.RemoveAllListeners();
        }
    }
}
