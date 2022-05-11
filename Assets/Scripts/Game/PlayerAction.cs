using System;
//TODO make actions
public interface PlayerAction
{
    public abstract void Act(Player from, Player to, Value value);
}

//public class 