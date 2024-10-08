using System.Collections.Generic;
using UnityEngine;

namespace Core.Player.Perks
{
    public abstract class AbstractBalanceContainer<T> : MonoBehaviour where T : ScriptableObject
    {
        [SerializeField] private List<T> PerkLevelsBalance = new();

        public T GetBalanceByLevel(int levelIndex)
        {
            if (levelIndex >= PerkLevelsBalance.Count)
            {
                return null;
            }
            return PerkLevelsBalance[levelIndex];
        }
        
        public int GetLevelsCount() => PerkLevelsBalance.Count;
    }
}
