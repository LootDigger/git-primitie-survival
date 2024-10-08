using System;
using UnityEngine;
using System.Threading.Tasks;

namespace Core.Player.Perks
{
    public class PerkBalanceManager
    {
        private readonly GunslingerBalanceContainer _levelBalancesContainer;
        public GunslingerBalanceScriptable _currentBalance;
        
        public void UpdateBalanceAsset(int currentLevelIndex) =>_currentBalance = _levelBalancesContainer.GetBalanceByLevel(currentLevelIndex);
        public int GetLevelsCount => _levelBalancesContainer.GetLevelsCount();

        public PerkBalanceManager(GunslingerBalanceContainer levelBalancesContainer) => _levelBalancesContainer = levelBalancesContainer;
    }
    
    public class UpgradablePerkManager
    {
        private PerkBalanceManager _perkBalanceManager;
        private int _currentLevel;
        public int CurrentLevel
        {
            get => _currentLevel;
            set
            {
                _currentLevel = value;
                if (_perkBalanceManager == null) { return; }
                _perkBalanceManager.UpdateBalanceAsset(_currentLevel);
            } 
        }
        public int MaxLevel { get; set; }
        
        public UpgradablePerkManager(PerkBalanceManager perkBalanceManager)
        {
            _perkBalanceManager = perkBalanceManager;
            MaxLevel = _perkBalanceManager.GetLevelsCount;
            CurrentLevel = 0;
        }
        
        public void LevelUp()
        {
            if(_currentLevel + 1 >= MaxLevel) { return; }
            CurrentLevel++;
        }
    }

    public class PerkLoopManager
    {
        private PerkBalanceManager _perkBalanceManager;

        public PerkLoopManager(PerkBalanceManager perkBalanceManager)
        {
            _perkBalanceManager = perkBalanceManager;
        }
        
        public async Task PerkReloadLoop(Action perkActivationDelegate)
        {
            while (true)
            {
                perkActivationDelegate();
                await Task.Delay(_perkBalanceManager._currentBalance.ReloadTime);
            }
        }
    }
    
    
}