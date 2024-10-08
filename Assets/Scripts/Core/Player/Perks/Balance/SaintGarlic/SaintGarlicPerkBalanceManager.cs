using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Player.Perks
{
    [Tooltip("Concrete Manager class handling the balance for 'Saint Garlic' perk")]
    public class SaintGarlicPerkBalanceManager :  AbstractPerkBalanceManager<SaintGarlicBalanceContainer, SaintGarlicBalanceScriptable>,
        IReloadablePerk, IUpgradablePerk, IDistanceDependentPerk
    {
        public int ReloadTime => _currentBalance.ReloadTime;
        public float PerkMaxReachRadius => _currentBalance.Radius;
        public int LevelsCount => GetLevelsCount();
        
        public SaintGarlicPerkBalanceManager(SaintGarlicBalanceContainer levelBalancesContainer) : base(levelBalancesContainer)
        {
        }
        
        public new void UpdateBalanceAsset(int currentLevelIndex) => base.UpdateBalanceAsset(currentLevelIndex);
    }
}
