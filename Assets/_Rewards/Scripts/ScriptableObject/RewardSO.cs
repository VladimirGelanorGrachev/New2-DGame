using System.Collections.Generic;
using UnityEngine;

namespace Rewards
{
    [CreateAssetMenu(fileName = nameof(RewardSO), menuName = "Configs/"+nameof(RewardSO))]
    internal class RewardSO : ScriptableObject
    {
        [SerializeField] private List<Reward> _rewards;
        [SerializeField] private ContainerSlotRewardView _containerSlotRewardPrefab;
                
        internal List<Reward> Rewards => _rewards;

        internal ContainerSlotRewardView ContainerSlotRewardView => _containerSlotRewardPrefab;
    }
}
