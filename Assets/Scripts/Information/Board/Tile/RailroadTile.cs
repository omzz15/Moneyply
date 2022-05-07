using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailroadTile : Tile
{
    private Player player;
    public readonly int cost;
    public readonly int morgageCost;
    public readonly int unmorgageCost;
    public readonly int[] rents;


    public RailroadTile(int cost, int morgageCost, int unmorgageCost, int[] rents) : base(TileType.RAILROAD)
    {
        this.cost = cost;
        this.morgageCost = morgageCost;
        this.unmorgageCost = unmorgageCost;
        this.rents = rents;
    }

    public Player Player { get => player; set => player = value; }

    //TODO get railroads for player
    public int getRent(int railroads) {
        return rents[railroads];
    }
}
