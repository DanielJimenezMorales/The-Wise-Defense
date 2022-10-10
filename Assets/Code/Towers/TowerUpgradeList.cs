using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TowerUpgradeList
{
    [SerializeField] private List<TowerUpgrade> _upgrades;

    public TowerUpgradeList() { }

    public TowerUpgrade GetUpgrade(int currentUpgrade)
    {
        if(currentUpgrade > _upgrades.Count)
        {
            return new TowerUpgrade();
        }

        return _upgrades[currentUpgrade];
    }
}
