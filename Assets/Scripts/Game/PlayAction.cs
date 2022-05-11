using System;
using System.Collections;

public interface PlayAction
{
    public abstract void Act(Game game);
}
//TODO make/fix actions
public class BuyAction : PlayAction
{
    public void Act(Game game)
    {
        Player currentPlayer = game.CurrentPLayer;
        OwnableTile currentTile = new RailroadTile("", null, 0,0,0, new int[]{});// = (OwnableTile)game;
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

public class NoneAction : PlayAction {
    public void Act(Game game) { }
}