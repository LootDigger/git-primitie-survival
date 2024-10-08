using System;
using UnityEngine;
using System.Threading.Tasks;

namespace Core.Player.Perks.Managers
{
    public class PerkLoopManager
    {
        private IReloadablePerk _reloadablePerk;
        private Action _perkActionDelegate;

        public PerkLoopManager(IReloadablePerk reloadablePerk, Action perkActivationDelegate)
        {
            _reloadablePerk = reloadablePerk;
            _perkActionDelegate = perkActivationDelegate;

            ActivatePerkLoop();
        }

        private async Task ActivatePerkLoop( )
        {
            while (true)
            {
                _perkActionDelegate();
                await Task.Delay(_reloadablePerk.ReloadTime);
            }
        }
    }
}