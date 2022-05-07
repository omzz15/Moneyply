using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityTile : Tile
{
    private Player player;
    public readonly int cost;
    public readonly int morgageCost;
    public readonly int unmorgageCost;
    public readonly int[] rollMultipliers;


    public UtilityTile(int cost, int morgageCost, int unmorgageCost, int[] rollMultipliers) : base(TileType.UTILITY)
    {
        this.cost = cost;
        this.morgageCost = morgageCost;
        this.unmorgageCost = unmorgageCost;
        this.rollMultipliers = rollMultipliers;
    }

    public Player Player { get => player; set => player = value; }

    //TODO refrence player for number of utilities
    public int getCost(int utilities, int roll) {
        return rollMultipliers[utilities - 1] * roll;
    }
}
