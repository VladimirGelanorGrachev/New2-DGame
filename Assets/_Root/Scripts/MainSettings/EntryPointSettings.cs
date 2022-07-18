using Profile;
using UnityEngine;

[CreateAssetMenu(
        fileName = nameof(EntryPointSettings),
        menuName = "Configs/" + nameof(EntryPointSettings))]
public class EntryPointSettings : ScriptableObject
{
    [Header("Initial Settings")]
    [SerializeField] private float _speedCar;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private GameState _initialState;   


    public float SpeedCar  => _speedCar;
    public float JumpHeight => _jumpHeight;     
    internal GameState InitialState => _initialState;
}
