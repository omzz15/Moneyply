using System.Collections;
using UnityEngine;


public interface PlayAction
{
    public abstract void Act(Game game);
}

public class TradeAction : PlayAction {
    public void Act(Game game) { 
        
    }
}

public class BuyAction : PlayAction
{
    public void Act(Game game)
    {

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
        Player currPlayer = game.CurrentPlayer;
        OwnableTile currTile = (OwnableTile)game.CurrentTile;

        if(currPlayer.hasMoney(currTile.ge))
        currTile.Player.addMoney()
    }
}