using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace TestScene
{
    internal class LoadButtonSpriteView : AssetBundleViewTestBase
    {
        [Header("ButtonReload")]
        [SerializeField] private Button _reloadButton;

        [Header("Addressables")]
        [SerializeField] private AssetReference _backgroundImage;
        [SerializeField] private RectTransform _image;
        [SerializeField] private Button _loadBackgroundImageButton;
        [SerializeField] private Button _unloadBackgroundImageButton;

        private readonly List<AsyncOperationHandle<GameObject>> _addressablePrefabs =
            new List<AsyncOperationHandle<GameObject>>();


        private void Start()
        {
            _reloadButton.onClick.AddListener(LoadAssets);
            _loadBackgroundImageButton.onClick.AddListener(SpawnPrefab);
            _unloadBackgroundImageButton.onClick.AddListener(DespawnPrefabs);
        }

        private void OnDestroy()
        {
            _reloadButton.onClick.RemoveAllListeners();
            _loadBackgroundImageButton.onClick.RemoveAllListeners();
            _unloadBackgroundImageButton.onClick.RemoveAllListeners();

            DespawnPrefabs();
        }


        private void SpawnPrefab()
        {
            AsyncOperationHandle<GameObject> addressablePrefab =
                Addressables.InstantiateAsync(_backgroundImage, _image);

            _addressablePrefabs.Add(addressablePrefab);
        }

        private void DespawnPrefabs()
        {
            foreach (AsyncOperationHandle<GameObject> addressablePrefab in _addressablePrefabs)
                Addressables.ReleaseInstance(addressablePrefab);

            _addressablePrefabs.Clear();
        }
        private void LoadAssets()
        {
            _reloadButton.interactable = false;
            StartCoroutine(DownloadAndSetAssetBundles());
        }
    }
}
