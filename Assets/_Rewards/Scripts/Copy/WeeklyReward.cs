using System;
using UnityEngine;

namespace Rewards
{
    [Serializable]
    internal class WeeklyReward
    {
        [field: SerializeField] public RewardType RewardType { get; private set; }
        [field: SerializeField] public Sprite IconCurrency { get; private set; }
        [field: SerializeField] public int CountCurrency { get; private set; }
    }
}
