﻿using System.Collections;
using UnityEngine;

public class Bank : Player
{
    public Bank() : base(1) {
    }

    override public bool hasMoney(int amount)
    {
        return true;
    }

    override public bool takeMoney(int amount)
    {
        return true;
    }
}
