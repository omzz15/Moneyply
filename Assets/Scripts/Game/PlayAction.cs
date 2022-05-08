using System;
using System.Collections;
using UnityEngine;


public interface PlayAction
{
    public abstract void Act(Game game);
}

public interface PLayerAction { 
    public abstract void Act(Game game, Player from, Player to, )
}

public class TradeAction : PlayAction {
    public void Act(Game game) { 
        
    }
}

public class BuyAction : PlayAction
{
    public void Act(Game game)
    {
        Player currentPlayer = game.CurrentPlayer;
        OwnableTile currentTile = (OwnableTile)game.CurrentTile;
        int cost = currentTile.cost;

        if (!currentPlayer.hasMoney(cost)) return;
            
        currentPlayer.takeMoney(cost);
        currentTile.Player = currentPlayer;
    }
}

public class AuctionAction : PlayAction
{
    public void Act(Game game)
    {

    }
}

public class PayAction : PlayAction
{
    public void Act(Game game)
    {
    }
}

public class Value
{
    public readonly int value;
    public readonly Type type;

    public Value(int value, Type type) { 
        this.value = value;
        this.type = type;
    }

    public enum Type { 
        PERCENT,
        DOLLAR
    }
}

public class NotEnoughMoneyException : Exception {
    //TODO add stuff??
}