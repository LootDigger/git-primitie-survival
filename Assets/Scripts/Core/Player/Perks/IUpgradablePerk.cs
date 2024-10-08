using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUpgradablePerk
{
    [Tooltip("Gets max amount of upgrades")]
    int LevelsCount { get; }

    [Tooltip("Updates current balance asset according to level")]
    void UpdateBalanceAsset(int currentLevelIndex);

}
