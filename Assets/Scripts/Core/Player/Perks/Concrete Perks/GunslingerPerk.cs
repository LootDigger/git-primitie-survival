using System.ComponentModel;
using UnityEngine;
using System.Threading.Tasks;
using Zenject;
using Core.Player.Perks.Managers;


namespace Core.Player.Perks
{
    public class GunslingerPerk : AbstractPerk
    {
        private GameObject _projectilePrefab;
        
        private GunslingerPerkBalanceManager _perkBalanceManager;
        private UpgradablePerkManager _upgradablePerkManager;
        private PerkLoopManager _perkLoopManager;
        
        [Inject]
        void Init(GunslingerBalanceContainer balanceContainer)
        {
            GetProjectilePrefab();
            _perkBalanceManager = new GunslingerPerkBalanceManager(balanceContainer);
            _upgradablePerkManager = new UpgradablePerkManager(_perkBalanceManager);
            _perkLoopManager = new PerkLoopManager(_perkBalanceManager,Activate);
        }
        
        // TEMP
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _upgradablePerkManager.LevelUp();
            }
        }
        
        public override void Activate() => ShootAtNearestEnemy();
        
        private void GetProjectilePrefab() => _projectilePrefab = Resources.Load<GameObject>("Player/Projectile");
        
        private async Task ShootAtNearestEnemy()
        {
            Enemy nearestEnemy = FindNearestEnemy();

            if (nearestEnemy != null)
            {
                for (int i = 0; i < _perkBalanceManager._currentBalance.ProjectilesCount; i++)
                {
                    GameObject projectile = Instantiate(_projectilePrefab, transform.position, Quaternion.identity);

                    Vector3 direction = (nearestEnemy.transform.position - transform.position).normalized;

                    Rigidbody rb = projectile.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.velocity = direction * _perkBalanceManager._currentBalance.ProjectileSpeed;
                    }

                    await Task.Delay(100);
                }
            }
        }
        private Enemy FindNearestEnemy()
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            Enemy nearestEnemy = null;
            float shortestDistance = Mathf.Infinity;

            foreach (Enemy enemy in enemies)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

                if (distanceToEnemy < shortestDistance)
                {
                    shortestDistance = distanceToEnemy;
                    nearestEnemy = enemy;
                }
            }
            return nearestEnemy;
        }
    }
}