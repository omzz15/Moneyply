using System.Collections;
using System.Collections.Generic;

public abstract class OwnableTile : Tile
{
    private Player player;
    private List<Discount> discounts;

    public readonly int cost;
    public readonly int morgageCost;
    public readonly int unmorgageCost;

    private bool isMorgaged = false;

    public OwnableTile(string name, TileType type, Player player, int cost, int morgageCost, int unmorgageCost) : base(name, type)
    {
        this.player = player;
        this.cost = cost;
        this.morgageCost = morgageCost;
        this.unmorgageCost = unmorgageCost;
    }

    public Player Player { get => player; set => player = value; }

    public abstract int CalculateRent(Game game);

    private List<Discount> GetDiscountsForPlayer(Player player) { 
        List<Discount> output = new List<Discount>();

        foreach (Discount discount in discounts)
            if(discount.player  == player) output.Add(discount);
    
        return output;
    }

    private int CalculateRentWithDiscount(Game game) { 
        List<Discount> d = GetDiscountsForPlayer(game.CurrentPLayer);

        int rent = CalculateRent(game);
        int totalD = 0;

        foreach (Discount discount in d) {
            totalD += discount.GetDiscount(rent);
        }

        return totalD >= rent ? 0 : rent - totalD;
    }

    public int GetRent(Game game) { 
        return isMorgaged || player == Player ? 0 : CalculateRentWithDiscount(game);
    }

    public bool IsOwned() { 
        return player != null;
    }

    public bool IsMorgaged()
    {
        return isMorgaged;
    }

    public void Morgage() { 
        if(player == null) throw new TileNotOwnedException();
        if(IsMorgaged()) throw new TileAlreadyMorgagedException();

        player.addMoney(morgageCost);
        isMorgaged = true;
    }

    public void Unmorgage() {
        if (player == null) throw new TileNotOwnedException();
        if (!IsMorgaged()) throw new TileAlreadyUnmorgagedException();

        player.takeMoney(unmorgageCost);
        isMorgaged = false;
    }

    public override void OnLand(Game game)
    {
        if (((OwnableTile)game.CurrentTile).IsOwned()){
            game.AddPlayAction(new PayAction());
            return;
        }
        game.AddPlayAction(new BuyAction());
        game.AddPlayAction(new AuctionAction());
    }
}