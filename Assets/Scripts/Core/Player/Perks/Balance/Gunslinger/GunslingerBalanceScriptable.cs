using UnityEngine;

namespace Core.Player.Perks
{
    [CreateAssetMenu(fileName = "BalanceGunslinger", menuName = "ScriptableObject/Settings/Perks/Balance Gunslinger")]
    public class GunslingerBalanceScriptable : AbstractPerkBalanceScriptable, Parameters.IShooterParameter, Parameters.IReloadParameter, Parameters.IDamageParameter
    {
        [SerializeField] private  float projectileSpeed;
        [SerializeField] private float projectilesCount;
        [SerializeField] private int perkReloadTime;
        [SerializeField] private float perkDamage;
        
        public float ProjectileSpeed => projectileSpeed;
        public float ProjectilesCount => projectilesCount;
        public int ReloadTime => perkReloadTime;
        public float Damage => perkDamage;
    }
}