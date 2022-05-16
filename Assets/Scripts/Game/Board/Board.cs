using System;

public class Board
{
    public readonly DoubleDice dice = new DoubleDice();
    private Tile[] tiles;

    public Board(Tile[] tiles) {
        this.tiles = tiles;
    }

    public Tile GetTile(Player player) {
        return GetTile(player.Location);
    }

    public Tile GetTile(int location) {
        return tiles[location];
    }

    public int GetTileLength() {
        return tiles.Length;
    }
}