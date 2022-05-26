using System.Collections.Generic;

public class Player
{
    private int money;
    private int location;

    public int Location { get => location; set => location = value; }

    public Player(int money) {
        this.money = money;
    }

    public bool canGetTile(OwnableTile tile) {
        return (hasMoney(tile.cost) && !tile.IsOwned());
    }

    public void addTile(OwnableTile tile) {
        //not sure if this is nesseary
        if (tile.IsOwned()) throw new TileOwnedException();

        takeMoney(tile.cost);
        tile.Player = this;
    }

    public void addMoney(int amount)
    {
        //WARNING unprotected input
        money += amount;
    }

    public virtual bool hasMoney(int amount)
    {
        return (money - amount >= 0);
    }

    public virtual void takeMoney(int amount) {
        if (!hasMoney(amount)) throw new NotEnoughMoneyException();
        money -= amount;
    }
}

public class PlayerData{
    public int money;
    public int location;
    public ArrayList<Tile> tiles = new ArrayList();
    
    public PlayerData(int money, int location, ArrayList<> tiles){
        this.money = money;
        this.location = location;
        this.tiles = tiles;
    }
}