using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Zenject;
using Core.Player.Perks.Managers;

namespace Core.Player.Perks
{
    public class SaintGarlicPerk : AbstractPerk
    {
        private SaintGarlicPerkBalanceManager _perkBalanceManager;
        private UpgradablePerkManager _upgradablePerkManager;
        private PerkLoopManager _perkLoopManager;

        [Inject]
        void Init(SaintGarlicBalanceContainer saintGarlicBalanceContainer)
        {
            _perkBalanceManager = new SaintGarlicPerkBalanceManager(saintGarlicBalanceContainer);
            _upgradablePerkManager = new UpgradablePerkManager(_perkBalanceManager);
            _perkLoopManager = new PerkLoopManager(_perkBalanceManager,Activate);
        }
        
        public override void Activate() => SearchForEnemies();
        
        public void SearchForEnemies()
        {
            Collider[] collidersInRadius = Physics.OverlapSphere(transform.position, _perkBalanceManager._currentBalance.Radius);

            foreach (Collider collider in collidersInRadius)
            {
                Enemy enemy = collider.GetComponent<Enemy>();
                if (enemy != null)
                {
                    Debug.Log($"Enemy found: {enemy.name} at position {enemy.transform.position}");
                    enemy.ApplyDamage();
                }
            }
        }
    }
}