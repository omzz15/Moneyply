using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxTile : Tile
{
    public readonly int amount;

    TaxTile(string name, int amount) : base(name, TileType.TAX) {
        this.amount = amount;
    }

    //TODO add method to take moeny
    override public void OnLand(Game game)
    {
        game.CurrentPLayer.takeMoney(amount);
    }
}
