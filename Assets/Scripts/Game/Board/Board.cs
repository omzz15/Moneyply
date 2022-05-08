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
}

class Dice { 
    private Random random = new Random();
    private short value;

    public void roll() {
        value = (short)random.Next(1, 7);
    }

    public short getRoll() { 
        return value;
    }

    public short getNewRoll() { 
        roll();
        return getRoll();
    }
}

class DoubleDice { 
    private Dice dice1;
    private Dice dice2;

    public void roll() { 
        dice1.roll();
        dice2.roll();
    }

    public short getRoll() { 
        return (short)(dice1.getRoll() + dice2.getRoll());
    }

    public short getNewRoll() {
        roll();
        return getRoll();
    }

    public bool isEqual() { 
        return dice1.getRoll() == dice2.getRoll();
    }
}