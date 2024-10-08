using System.Threading.Tasks;
using UnityEngine;

public interface IReloadablePerk
{
   [Tooltip("Perk Reload Time in milliseconds")]
   int ReloadTime { get; }
}
