using UnityEngine;

namespace Core.Player.Perks
{
    [CreateAssetMenu(fileName = "BalanceGunslinger", menuName = "ScriptableObject/Settings/Perks/Balance Garlic")]
    public class SaintGarlicBalanceScriptable : AbstractPerkBalanceScriptable, Parameters.IReloadParameter, Parameters.IDamageParameter
    {
        [SerializeField] private int perkReloadTime;
        [SerializeField] private float perkDamage;
        
        public int ReloadTime => perkReloadTime;
        public float Damage => perkDamage;
    }
}