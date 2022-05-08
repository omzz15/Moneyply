using System.Collections;
using System.Collections.Generic;

public abstract class OwnableTile : Tile
{
    private Player player;
    public readonly int cost;
    public readonly int morgageCost;
    public readonly int unmorgageCost;

    public OwnableTile(TileType type, Player player, int cost, int morgageCost, int unmorgageCost) : base(type)
    {
        this.player = player;
        this.cost = cost;
        this.morgageCost = morgageCost;
        this.unmorgageCost = unmorgageCost;
    }

    public Player Player { get => player; set => player = value; }

    //TODO add methods to buy property and set player
    public List<PlayAction> getActions(Game game) {
        List<PlayAction> actions = new List<PlayAction>();
        if (player == null) {
            actions.Add(new BuyAction());
            actions.Add(new AuctionAction());
            return actions;
        }
        
        actions.Add()
    }

    public abstract int getRent();
}