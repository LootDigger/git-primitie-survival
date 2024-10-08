using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Core.Player.Perks.Parameters;

namespace Core.Player.Perks
{
    public abstract class AbstractPerk : MonoBehaviour
    {
        public virtual void Activate(){}
    }
}