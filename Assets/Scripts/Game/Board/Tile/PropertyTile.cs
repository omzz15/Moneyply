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
    

    public PropertyTile(string name, Player player, int cost, int houseCost, int hotelCost, int morgageCost, int unmorgageCost, int houses, int[] rents, Color color) : base(name, TileType.PROPERTY, player, cost, morgageCost, unmorgageCost)
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
 
    public void AddStructure() {
        if(Player == null) throw new TileNotOwnedException();
        
        if (canAddHouse()) { 
            Player.takeMoney(houseCost);
            houses++;
            return;
        }
        if (canAddHotel()) {
            Player.takeMoney(hotelCost);
            houses++;
        }
    }

    public void RemoveStructure() { 
        if(Player == null) throw new TileNotOwnedException();

        if (isHotel()){
            Player.addMoney(hotelCost);
            houses--;
            return;
        }
        if (houses > 0) {
            Player.addMoney(houseCost);
            houses--;
            return;
        }
        throw new NoHouseOnTileException();
    }

    override public int CalculateRent(Game game) {
        return rents[houses];
    }
}
