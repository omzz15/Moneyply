using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Property Tile Data(DOES NOT HAVE PROTECTED VALUES)
 */
public class PropertyTile : Tile
{
    private Player player;
    public readonly int cost;
    public readonly int houseCost;
    public readonly int hotelCost;
    public readonly int morgageCost;
    public readonly int unmorgageCost;
    private int houses;
    public readonly int[] rents;
    public readonly Color color;
    

    public PropertyTile(int cost, int houseCost, int hotelCost, int morgageCost, int unmorgageCost, int houses, int[] rents, Color color) : base(TileType.PROPERTY)
    {
        this.cost = cost;
        this.houseCost = houseCost;
        this.hotelCost = hotelCost;
        this.morgageCost = morgageCost;
        this.unmorgageCost = unmorgageCost; 
        this.houses = houses;
        this.rents = rents;
        this.color = color;
    }

    public Player Player { get => player; set => player = value; }
    public int Houses { get => houses; }

    public bool canAddHouse() { 
        return houses < rents.Length - 2;
    }

    public bool canAddHotel() { 
        return houses == rents.Length - 2;
    }

    public bool isHotel() {
        return houses == rents.Length - 1;
    }

    public bool AddHouse() {
        if(houses == rents.Length - 1)
            return false;
        houses++;
        return true;
    }

    public int getRent() {
        return rents[houses];
    }
}
