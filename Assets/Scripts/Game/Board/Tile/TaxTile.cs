using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxTile : Tile
{
    public readonly int amount;

    TaxTile(int amount) : base(TileType.TAX) {
        this.amount = amount;
    }

    //TODO add method to take moeny
    override public void OnLand(Player player)
    {
        player.takeMoney(amount);
    }
}
