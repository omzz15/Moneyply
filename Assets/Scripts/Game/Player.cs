using System;

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
    
}

Player p = new Player(1000);
p.takeMoney(10000);
Debug.Log("test");