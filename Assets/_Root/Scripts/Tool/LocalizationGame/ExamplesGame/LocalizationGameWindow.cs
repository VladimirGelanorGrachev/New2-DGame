using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace Tool.LocalizationGame
{
    internal abstract class LocalizationGameWindow : MonoBehaviour
    {
        [Header("Scene Components")]
        [SerializeField] private Button _englishButton;       
        [SerializeField] private Button _russianButton;
  
        void Start()
        {
            _englishButton.onClick.AddListener(() => ChangeLanguage(0));            
            _russianButton.onClick.AddListener(() => ChangeLanguage(2));
            OnStarted();

        }
        private void OnDestroy()
        {
            _englishButton.onClick.RemoveAllListeners();            
            _russianButton.onClick.RemoveAllListeners();
            OnDestroyed();
        }

        protected virtual void OnStarted() { }
        protected virtual void OnDestroyed() { }

        private void ChangeLanguage(int index) =>
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
}
