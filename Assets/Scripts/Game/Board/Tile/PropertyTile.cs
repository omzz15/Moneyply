using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Property Tile Data(DOES NOT HAVE PROTECTED VALUES)
 */
public class PropertyTile : OwnableTile
{
    public readonly int houseCost;
    public readonly int hotelCost;
    private int houses;
    public readonly int[] rents;
    public readonly Color color;
    

    public PropertyTile(Player player, int cost, int houseCost, int hotelCost, int morgageCost, int unmorgageCost, int houses, int[] rents, Color color) : base(TileType.PROPERTY, player, cost, morgageCost, unmorgageCost)
    {
        this.houseCost = houseCost;
        this.hotelCost = hotelCost;
        this.houses = houses;
        this.rents = rents;
        this.color = color;
    }

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

    //TODO fix add house and get rent to refrence player 
    public bool AddHouse() {
        if(houses == rents.Length - 1)
            return false;
        houses++;
        return true;
    }

    public int getRent() {
        return rents[houses];
    }

    public void onLand(Player player)
    {

    }
}
