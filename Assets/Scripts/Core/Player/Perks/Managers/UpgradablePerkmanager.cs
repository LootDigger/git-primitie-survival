
namespace Core.Player.Perks.Managers
{
    public class UpgradablePerkManager
    {
        private IUpgradablePerk _upgradablePerk;
        private int _currentLevel;

        public int CurrentLevel
        {
            get => _currentLevel;
            set
            {
                _currentLevel = value;
                if (_upgradablePerk == null)
                {
                    return;
                }
                _upgradablePerk.UpdateBalanceAsset(_currentLevel);
            }
        }

        public int MaxLevel { get; set; }

        public UpgradablePerkManager(IUpgradablePerk upgradablePerk)
        {
            _upgradablePerk = upgradablePerk;
            MaxLevel = _upgradablePerk.LevelsCount;
            CurrentLevel = 0;
        }

        public void LevelUp()
        {
            if (_currentLevel + 1 >= MaxLevel) { return; }
            CurrentLevel++;
        }
    }
}