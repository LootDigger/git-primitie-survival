using System;
using UnityEngine;
using System.Threading.Tasks;

namespace Core.Player.Perks
{
    [Tooltip("Concrete Manager class handling the balance for 'Gunslinger' perk")]
    public class GunslingerPerkBalanceManager : AbstractPerkBalanceManager<GunslingerBalanceContainer, GunslingerBalanceScriptable>, 
        IReloadablePerk, IUpgradablePerk
    {
        public int ReloadTime => _currentBalance.ReloadTime;
        public int LevelsCount => GetLevelsCount();

        public GunslingerPerkBalanceManager(GunslingerBalanceContainer levelBalancesContainer) : base(levelBalancesContainer)
        {
        }

        public new void UpdateBalanceAsset(int currentLevelIndex) => base.UpdateBalanceAsset(currentLevelIndex);
    }
}