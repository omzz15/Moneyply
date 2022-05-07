using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private Dictionary<TileType, LinkedList<Tile>> tiles = new Dictionary<TileType, LinkedList<Tile>>();
    private int money;
    private int location;

    public int Location { get => location; set => location = value; }

    public Player(int money) {
        this.money = money;
    }

    public bool canGetTile(OwnableTile tile) {
        return (hasMoney(tile.cost) && tile.Player == null);
    }

    public void addTile(OwnableTile tile) {
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
        return (money - amount < 0);
    }

    public virtual bool takeMoney(int amount) {
        if (hasMoney(amount)) {
            //TODO add logic
            return false;
        }

        money -= amount;
        return true;
    }
}
