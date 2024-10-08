using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Player.Perks
{
    [Tooltip("Abstract Manager class implementing base logic for the balance managers")]
    public abstract class AbstractPerkBalanceManager<TBalanceContainer, TBalanceScriptable>
        where TBalanceContainer : AbstractBalanceContainer<TBalanceScriptable>
        where TBalanceScriptable : AbstractPerkBalanceScriptable
    {
        protected TBalanceContainer _levelBalancesContainer;
        public TBalanceScriptable _currentBalance;

        public AbstractPerkBalanceManager(TBalanceContainer levelBalancesContainer) =>
            _levelBalancesContainer = levelBalancesContainer;

        protected void UpdateBalanceAsset(int currentLevelIndex) =>
            _currentBalance = _levelBalancesContainer.GetBalanceByLevel(currentLevelIndex);
        protected int GetLevelsCount() => _levelBalancesContainer.GetLevelsCount();
    }
}