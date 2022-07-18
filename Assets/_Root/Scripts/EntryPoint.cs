using Profile;
using UnityEngine;

internal class EntryPoint : MonoBehaviour
{
    [Header("Scene Objects")]
    [SerializeField] private Transform _placeForUi;

    [Header("EntryPointSettings")]
    [SerializeField] EntryPointSettings _settings;
        
    private MainController _mainController;

    private void Start()
    {
        var profilePlayer = new ProfilePlayer(_settings.SpeedCar,_settings.JumpHeight,_settings.InitialState);
        _mainController = new MainController(_placeForUi, profilePlayer);
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
    }
}
