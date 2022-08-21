using System;
using UnityEngine;
using UnityEngine.UI;

namespace TestScene
{
    [Serializable]
    internal class DataSpriteButtonBundles
    {
        [field: SerializeField] public string NameAssetBundle { get; private set; }
        [field: SerializeField] public Image Image { get; private set; }
    }
}
