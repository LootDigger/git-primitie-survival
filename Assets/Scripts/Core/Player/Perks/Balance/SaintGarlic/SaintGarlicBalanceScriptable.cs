using UnityEngine;

namespace Core.Player.Perks
{
    [CreateAssetMenu(fileName = "BalanceGunslinger", menuName = "ScriptableObject/Settings/Perks/Balance Garlic")]
    public class SaintGarlicBalanceScriptable : AbstractPerkBalanceScriptable, Parameters.IReloadParameter, Parameters.IDamageParameter, Parameters.IRadiusParameter
    {
        [SerializeField] private int perkReloadTime;
        [SerializeField] private float perkDamage;
        [SerializeField] private float perkMaxWorkRadius;
        
        public int ReloadTime => perkReloadTime;
        public float Damage => perkDamage;
        public float Radius => perkMaxWorkRadius;
    }
}