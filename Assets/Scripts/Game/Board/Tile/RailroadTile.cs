using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailroadTile : OwnableTile
{
    public readonly int[] rents;

    public RailroadTile(string name, Player player, int cost, int morgageCost, int unmorgageCost, int[] rents) : base(name, TileType.RAILROAD, player, cost, morgageCost, unmorgageCost)
    {
        this.rents = rents;
    }

    //TODO get railroads for player
    public override int CalculateRent(Game game)
    {
        int railroads = 1;

        return rents[railroads - 1];
    }
}
