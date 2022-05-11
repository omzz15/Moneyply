using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityTile : OwnableTile
{
    public readonly int[] rollMultipliers;

    public UtilityTile(string name, Player player, int cost, int morgageCost, int unmorgageCost, int[] rollMultipliers) : base(name, TileType.UTILITY, player, cost, morgageCost, unmorgageCost)
    {
        this.rollMultipliers = rollMultipliers;
    }

    //TODO get utilities for player
    public override int CalculateRent(Game game)
    {
        int utilities = 1;

        return rollMultipliers[utilities - 1] * game.board.dice.getRoll();
    }
}
