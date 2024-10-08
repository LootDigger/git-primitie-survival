using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Zenject;

namespace Core.Player.Perks
{
    public class SaintGarlicPerk : AbstractPerk
    {
        private PerkBalanceManager _perkBalanceManager;
        private UpgradablePerkManager _upgradablePerkManager;
        private PerkLoopManager _perkLoopManager;
        

        [Inject]
        void Init(GunslingerBalanceContainer balanceContainer)
        {
            _perkBalanceManager = new PerkBalanceManager(balanceContainer);
            _upgradablePerkManager = new UpgradablePerkManager(_perkBalanceManager);
            _perkLoopManager = new PerkLoopManager(_perkBalanceManager);
        }
        
        private void Start() => _perkLoopManager.PerkReloadLoop(Activate);
        public override void Activate() {}
        
        
        
        public void SearchForEnemies()
        {
            Collider[] collidersInRadius = Physics.OverlapSphere(transform.position, 10f);

            foreach (Collider collider in collidersInRadius)
            {
                Enemy enemy = collider.GetComponent<Enemy>();
                if (enemy != null)
                {
                    Debug.Log($"Enemy found: {enemy.name} at position {enemy.transform.position}");
                    // Можно добавить логику взаимодействия с найденным врагом
                }
            }
        }
    }
}