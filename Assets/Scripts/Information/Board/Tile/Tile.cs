using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * data class that stores information for tiles
 */
public class Tile
{
    public readonly TileType type;

    public Tile(TileType type) {
        this.type = type;
    }
}

public enum TileType { 
    PROPERTY,
    RAILROAD,
    UTILITY,
    TAX,
    PAYCHECK,
    COMMUNITY_CHEST,
    CHANCE,
    START
}