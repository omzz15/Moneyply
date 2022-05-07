using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaycheckTile : Tile
{
    public readonly int amount;

    public PaycheckTile(int amount) : base(TileType.PAYCHECK)
    {
        this.amount = amount;
    }

    //TODO add a method to give player money
    override public void OnLand(Player player) {
        player.addMoney(amount);
    }
}
