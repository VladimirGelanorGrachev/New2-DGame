using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    internal class MainMenuView : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private string _productId;

        [Header("Buttons")]
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSettings;
        [SerializeField] private Button _buttonShed;
        [SerializeField] private Button _buttonReward;
        [SerializeField] private Button _buttonBuy;

        public void Init(UnityAction startGame, UnityAction openSettings, UnityAction openShed,
            UnityAction playRewardedAds, UnityAction<string> buyProduct)
        {
            _buttonStart.onClick.AddListener(startGame);
            _buttonSettings.onClick.AddListener(openSettings);
            _buttonShed.onClick.AddListener(openShed);
            _buttonReward.onClick.AddListener(playRewardedAds);
            _buttonBuy.onClick.AddListener(() => buyProduct(_productId));
        }

        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSettings.onClick.RemoveAllListeners();
            _buttonShed?.onClick.RemoveAllListeners();
            _buttonReward.onClick.RemoveAllListeners();
            _buttonBuy.onClick.RemoveAllListeners();
        }
    }
}
