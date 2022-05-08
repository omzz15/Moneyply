using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * data class that stores information for tiles
 */
public abstract class Tile
{
    public readonly string name;
    public readonly TileType type;

    public Tile(string name, TileType type) {
        this.name = name;
        this.type = type;
    }

    public abstract void OnLand(Game game);

    public virtual void OnPass(Game game) { }
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