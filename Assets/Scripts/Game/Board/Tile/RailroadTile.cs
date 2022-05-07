using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailroadTile : OwnableTile
{
    public readonly int[] rents;

    public RailroadTile(Player player, int cost, int morgageCost, int unmorgageCost, int[] rents) : base(TileType.RAILROAD, player, cost, morgageCost, unmorgageCost)
    {
        this.rents = rents;
    }

    //TODO get railroads for player and get rent
    public void onLand(Player player)
    {

    }
}
