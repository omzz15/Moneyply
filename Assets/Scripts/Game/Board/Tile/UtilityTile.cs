using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityTile : OwnableTile
{
    public readonly int[] rollMultipliers;

    public UtilityTile(Player player, int cost, int morgageCost, int unmorgageCost, int[] rollMultipliers) : base(TileType.UTILITY, player, cost, morgageCost, unmorgageCost)
    {
        this.rollMultipliers = rollMultipliers;
    }

    //TODO refrence player for number of utilities
    public int getCost(int utilities, int roll) {
        return rollMultipliers[utilities - 1] * roll;
    }

    public void onLand(Player player)
    {

    }
}
