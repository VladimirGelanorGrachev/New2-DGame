using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace TestScene
{
    internal class AssetBundleViewTestBase : MonoBehaviour
    {
        private const string UrlAssetBundleSprites = "https://drive.google.com/uc?export=download&id=1HG0lRnMb1P2EHtmfpW-apusjaLdJT7cN";
        

        [SerializeField] private DataSpriteButtonBundles[] _dataSpriteButtonBundles;
        

        private AssetBundle _spritesButtonAssetBundle;        


        protected IEnumerator DownloadAndSetAssetBundles()
        {
            yield return GetSpritesAssetBundle();            

            if (_spritesButtonAssetBundle != null)
                SetSpriteAssets(_spritesButtonAssetBundle);
            else
                Debug.LogError($"AssetBundle {nameof(_spritesButtonAssetBundle)} failed to load");
            
        }

        private IEnumerator GetSpritesAssetBundle()
        {
            UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(UrlAssetBundleSprites);

            yield return request.SendWebRequest();

            while (!request.isDone)
                yield return null;

            StateRequest(request, out _spritesButtonAssetBundle);
        }
       

        private void StateRequest(UnityWebRequest request, out AssetBundle assetBundle)
        {
            if (request.error == null)
            {
                assetBundle = DownloadHandlerAssetBundle.GetContent(request);
                Debug.Log("Complete");
            }
            else
            {
                assetBundle = null;
                Debug.LogError(request.error);
            }
        }

        private void SetSpriteAssets(AssetBundle assetBundle)
        {
            foreach (DataSpriteButtonBundles data in _dataSpriteButtonBundles)
                data.Image.sprite = assetBundle.LoadAsset<Sprite>(data.NameAssetBundle);          

        }
               
    }
}

