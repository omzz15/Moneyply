using System;

public class Value
{
    public readonly int value;
    public readonly Type type;

    public Value(int value, Type type)
    {
        this.value = value;
        this.type = type;
    }

    public enum Type
    {
        PERCENT,
        DOLLAR
    }
}

public class Discount : Value
{
    public readonly Player player;

    public Discount(Value amount, Player player) : base(amount.value, amount.type)
    {
        this.player = player;
    }

    public Discount(int value, Type type, Player player) : base(value, type)
    {
        this.player = player;
    }

    public int GetDiscount(int cost)
    {
        return type == Value.Type.PERCENT ? (int)(value / 100.0 * cost) : value;
    }
}

public class Dice
{
    private Random random = new Random();
    private short value;

    public void roll()
    {
        value = (short)random.Next(1, 7);
    }

    public short getRoll()
    {
        return value;
    }

    public short getNewRoll()
    {
        roll();
        return getRoll();
    }
}

public class DoubleDice
{
    private Dice dice1;
    private Dice dice2;

    public void roll()
    {
        dice1.roll();
        dice2.roll();
    }

    public short getRoll()
    {
        return (short)(dice1.getRoll() + dice2.getRoll());
    }

    public short getNewRoll()
    {
        roll();
        return getRoll();
    }

    public bool isEqual()
    {
        return dice1.getRoll() == dice2.getRoll();
    }
}

//not sure if all the exceptions are needed

//this one is pretty important
public class NotEnoughMoneyException : Exception
{
    //TODO add stuff??
}
//these not so much
public class TileOwnedException : Exception
{
    //TODO add stuff??
}

public class TileNotOwnedException : Exception
{
    //TODO add stuff??
}

public class TileAlreadyMorgagedException : Exception
{
    //TODO add stuff??
}
public class TileAlreadyUnmorgagedException : Exception
{
    //TODO add stuff??
}
public class NoHouseOnTileException : Exception
{
    //TODO add stuff??
}