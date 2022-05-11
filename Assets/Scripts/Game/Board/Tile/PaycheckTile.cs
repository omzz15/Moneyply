using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaycheckTile : Tile
{
    public readonly int amount;

    public PaycheckTile(string name, int amount) : base(name, TileType.PAYCHECK)
    {
        this.amount = amount;
    }

    override public void OnLand(Game game) {
        game.CurrentPLayer.addMoney(amount);
    }
}

public class GoTile : Tile
{
    public readonly int amount;

    public GoTile(string name, int amount) : base(name, TileType.GO)
    {
        this.amount = amount;
    }

    override public void OnLand(Game game)
    {
        game.CurrentPLayer.addMoney(amount);
    }

    public override void OnPass(Game game)
    {
        game.CurrentPLayer.addMoney(amount);
    }
}