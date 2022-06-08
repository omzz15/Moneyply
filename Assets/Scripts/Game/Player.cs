using System.Collections;
using System.Collections.Generic;

public class Player
{
    private PlayerData data;

    public int Location { get => data.location; set => data.location = value; }

    public Player(int money) {
        data.money = money;
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
        data.money += amount;
    }

    public virtual bool hasMoney(int amount)
    {
        return (data.money - amount >= 0);
    }

    public virtual void takeMoney(int amount) {
        if (!hasMoney(amount)) throw new NotEnoughMoneyException();
        data.money -= amount;
    }
}

public interface Clone<T> {
    T CreateDeepCopy();
}

public class PlayerData : Clone<PlayerData>
{
    public int money;
    public int location;
    public ArrayList tiles = new ArrayList();

    public PlayerData(int money, int location, ArrayList tiles){
        this.money = money;
        this.location = location;
        this.tiles = tiles;
    }

    public PlayerData CreateDeepCopy()
    {
        PlayerData copy = (PlayerData)MemberwiseClone();
        copy.tiles = (ArrayList)tiles.Clone();
        return copy;
    }
}