using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Board
{
    public readonly DoubleDice dice = new DoubleDice();
    private Tile[] tiles;

    public Board(Tile[] tiles) {
        this.tiles = tiles;
    }

    public Tile GetTile(Player player) {
        return tiles[player.Location];
    }
}