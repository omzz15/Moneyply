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
        Player player = game.CurrentPLayer;
        OwnableTile tile = (OwnableTile)game.CurrentTile;

        int cost = tile.cost;
        
        player.takeMoney(cost);
        tile.Player = player;
    }
}

public class AuctionAction : PlayAction
{
    private OwnableTile tile;

    public AuctionAction() { }
    public AuctionAction(OwnableTile tile) { this.tile = tile; }
    
    public void Act(Game game)
    {
        if (tile == null) tile = (OwnableTile)game.CurrentTile;
        //TODO add auction stuff
    }
}

public class PayAction : PlayAction
{
    private int amount;
    private Player to;

    public PayAction() { }
    public PayAction(int amount, Player to) {
        this.amount = amount;
        this.to = to;
    }

    public void Act(Game game)
    {
        if (to == null) {
            OwnableTile tile = (OwnableTile)game.CurrentTile;
            to = tile.Player;
            amount = tile.GetRent(game);
        }

        game.CurrentPLayer.takeMoney(amount);
        to.addMoney(amount);
    }
}

public abstract class Give {
    private Player from;
    private Player to;

    public Player FromPlayer { get => from; }
    public Player ToPlayer { get => to; }

    public GiveAction(Player from, Player to) {
        this.from = from;
        this.to = to;
    }

    public abstract void Act(Game game);
}

public class GiveMoney : Give
{
    private int amount;
    public GiveMoney(Player from, Player to, int amount) : base(from, to){
        this.amount = amount;
    }
    public override void Act(Game game)
    {
        FromPlayer.takeMoney(amount);
        ToPlayer.addMoney(amount);
    }
}

public class TradeAction : PlayAction
{
    private Give to;
    private Give from;

    public TradeAction(Give)

    public void Act(Game game)
    {
        
    }
}

public class NoneAction : PlayAction {
    public void Act(Game game) { }
}